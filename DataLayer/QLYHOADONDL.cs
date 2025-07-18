using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;



namespace DataLayer
{
    public class QLYHOADONDL : DataProvider
    {
        public List<HoaDon> LayDanhSach()
        {
            List<HoaDon> ds = new List<HoaDon>();
            try
            {
                Connect();
                string sql = @"SELECT MaHoaDon, NgayLap, id_nv, id_kh, TongTien, MaGG, DiemDaDung, TienGiam, TienThanhToan, GhiChu FROM HOADON";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HoaDon hd = new HoaDon
                    {
                        MaHoaDon = reader.GetInt32(0),
                        NgayLap = reader.GetDateTime(1),
                        IdNV = reader.GetString(2),
                        IdKH = reader.IsDBNull(3) ? null : reader.GetString(3),
                        TongTien = reader.GetDecimal(4),
                        MaGG = reader.IsDBNull(5) ? null : reader.GetString(5),
                        DiemDaDung = reader.GetInt32(6),
                        TienGiam = reader.GetDecimal(7),
                        TienThanhToan = reader.GetDecimal(8),
                        GhiChu = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };
                    ds.Add(hd);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }

            return ds;
        }
        public List<HoaDon> TimKiem(string maHD, string maNV, string maKH, DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDon> ds = new List<HoaDon>();
            try
            {
                Connect();
                StringBuilder sqlBuilder = new StringBuilder("SELECT MaHoaDon, NgayLap, id_nv, id_kh, TongTien, MaGG, DiemDaDung, TienGiam, TienThanhToan, GhiChu FROM HOADON WHERE 1=1");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                if (!string.IsNullOrEmpty(maHD))
                {
                    sqlBuilder.Append(" AND CAST(MaHoaDon AS NVARCHAR) LIKE @maHD");
                    cmd.Parameters.AddWithValue("@maHD", "%" + maHD + "%");
                }
                if (!string.IsNullOrEmpty(maNV))
                {
                    sqlBuilder.Append(" AND id_nv LIKE @maNV");
                    cmd.Parameters.AddWithValue("@maNV", "%" + maNV + "%");
                }
                if (!string.IsNullOrEmpty(maKH))
                {
                    sqlBuilder.Append(" AND id_kh LIKE @maKH");
                    cmd.Parameters.AddWithValue("@maKH", "%" + maKH + "%");
                }
                sqlBuilder.Append(" AND NgayLap >= @tuNgay AND NgayLap < DATEADD(DAY, 1, @denNgay)");
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay.Date);
                cmd.Parameters.AddWithValue("@denNgay", denNgay.Date);

                cmd.CommandText = sqlBuilder.ToString();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HoaDon hd = new HoaDon
                    {
                        MaHoaDon = reader.GetInt32(0),
                        NgayLap = reader.GetDateTime(1),
                        IdNV = reader.GetString(2),
                        IdKH = reader.IsDBNull(3) ? null : reader.GetString(3),
                        TongTien = reader.GetDecimal(4),
                        MaGG = reader.IsDBNull(5) ? null : reader.GetString(5),
                        DiemDaDung = reader.GetInt32(6),
                        TienGiam = reader.GetDecimal(7),
                        TienThanhToan = reader.GetDecimal(8),
                        GhiChu = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };
                    ds.Add(hd);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }
            return ds;
        }

        // thêm mới 1 hóa đơn và chi tiết hóa đơn sau khi thanh toán
        public int ThemHoaDonVaChiTiet(HoaDon hoaDon, List<ChiTietHoaDonDoAn> chiTietDoAnList, List<ChiTietHoaDonVe> chiTietVeList)
        {
            string sql = "sp_ThemHoaDonVaChiTiet";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@id_kh", string.IsNullOrEmpty(hoaDon.IdKH) ? (object)DBNull.Value : hoaDon.IdKH));
            parameters.Add(new SqlParameter("@id_nv", hoaDon.IdNV));
            parameters.Add(new SqlParameter("@MaGG", string.IsNullOrEmpty(hoaDon.MaGG) ? (object)DBNull.Value : hoaDon.MaGG));
            parameters.Add(new SqlParameter("@NgayLap", hoaDon.NgayLap));
            parameters.Add(new SqlParameter("@DiemDaDung", hoaDon.DiemDaDung));
            parameters.Add(new SqlParameter("@TongTien", hoaDon.TongTien));
            parameters.Add(new SqlParameter("@TienGiam", hoaDon.TienGiam));
            parameters.Add(new SqlParameter("@TienThanhToan", hoaDon.TienThanhToan));
            parameters.Add(new SqlParameter("@GhiChu", hoaDon.GhiChu ?? ""));

            // Tạo bảng chi tiết đò ăn
            DataTable dtChiTiet = new DataTable();
            dtChiTiet.Columns.Add("id_do_an", typeof(string));
            dtChiTiet.Columns.Add("so_luong", typeof(int));
            dtChiTiet.Columns.Add("don_gia", typeof(decimal));

            foreach (var item in chiTietDoAnList)
            {
                dtChiTiet.Rows.Add(item.IdDoAn, item.SoLuong, item.DonGia);
            }

            SqlParameter tvp = new SqlParameter("@ChiTietDoAn", dtChiTiet)
            {
                SqlDbType = SqlDbType.Structured,
                TypeName = "TVP_CHITIET_DOAN"
            };
            parameters.Add(tvp);

            // Tạo bảng TVP cho ChiTiet Ve
            DataTable dtChiTietVe = new DataTable();
            dtChiTietVe.Columns.Add("id_suat_chieu", typeof(string));
            dtChiTietVe.Columns.Add("id_ghe", typeof(string));
            dtChiTietVe.Columns.Add("gia_ve", typeof(decimal));
            dtChiTietVe.Columns.Add("id_loai_ve", typeof(string)); // Thêm cột này
            foreach (var item in chiTietVeList)
                dtChiTietVe.Rows.Add(item.IdSuatChieu, item.IdGhe, item.GiaVe, item.IdLoaiVe);

            SqlParameter tvpVe = new SqlParameter("@ChiTietVe", dtChiTietVe)
            {
                SqlDbType = SqlDbType.Structured,
                TypeName = "TVP_CHITIET_VE"
            };
            parameters.Add(tvpVe);

            SqlParameter output = new SqlParameter("@MaHoaDonMoi", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            parameters.Add(output);

            try
            {
                MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
                return Convert.ToInt32(output.Value);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }


    public class ChiTietHoaDonVeDL : DataProvider
    {
        public List<ChiTietHoaDonVe> LayTheoMaHD(int maHD)
        {
            List<ChiTietHoaDonVe> ds = new List<ChiTietHoaDonVe>();
            try
            {
                Connect();
                string sql = @"SELECT id_suat_chieu, id_ghe, gia_ve, id_loai_ve FROM CHITIETHOADONVE WHERE MaHoaDon = @MaHD";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietHoaDonVe ct = new ChiTietHoaDonVe
                    {
                        MaHD = maHD,
                        IdSuatChieu = reader.GetString(0),
                        IdGhe = reader.GetString(1),
                        GiaVe = reader.GetDecimal(2),
                        IdLoaiVe = reader.GetString(3)
                    };
                    ds.Add(ct);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }
            return ds;
        }
    }

    public class ChiTietHoaDonDoAnDL : DataProvider
    {
        public List<ChiTietHoaDonDoAn> LayTheoMaHD(int maHD)
        {
            List<ChiTietHoaDonDoAn> ds = new List<ChiTietHoaDonDoAn>();
            try
            {
                Connect();
                string sql = @"SELECT id_do_an, so_luong, don_gia FROM CHITIETHOADONDOAN WHERE MaHoaDon = @MaHD";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietHoaDonDoAn ct = new ChiTietHoaDonDoAn
                    {
                        MaHD = maHD,
                        IdDoAn = reader.GetString(0),
                        SoLuong = reader.GetInt32(1),
                        DonGia = reader.GetDecimal(2)
                    };
                    ds.Add(ct);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }
            return ds;
        }
    }


}

