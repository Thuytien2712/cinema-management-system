using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TransferObject;

namespace DataLayer
{
    public class SuatChieuDAL : DataProvider
    {
        public bool ThemSuatChieu(SuatChieuDTO sc)
        {
            try
            {
                Connect(); // mở kết nối từ lớp cha DataProvider

                string query = @"INSERT INTO SUATCHIEU (id_suat_chieu, tg_bat_dau, tg_ket_thuc, ngay_chieu, MaPhim, id_phong) 
                                 VALUES (@MaSC, @TgBatDau, @TgKetThuc, @NgayChieu, @MaPhim, @IdPhong)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@MaSC", sc.MaSC);
                cmd.Parameters.AddWithValue("@TgBatDau", sc.TgBatDau);
                cmd.Parameters.AddWithValue("@TgKetThuc", sc.TgKetThuc);
                cmd.Parameters.AddWithValue("@NgayChieu", sc.NgayChieu);
                cmd.Parameters.AddWithValue("@MaPhim", sc.MaPhim);
                cmd.Parameters.AddWithValue("@IdPhong", sc.IdPhong);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect(); // đóng kết nối từ lớp cha
            }
        }

        public List<SuatChieuDTO> LaySuatChieuTheoPhongVaNgay(string maPhong, DateTime ngay)
        {
            List<SuatChieuDTO> list = new List<SuatChieuDTO>();

            string query = "SELECT * FROM SUATCHIEU WHERE id_phong = @maPhong AND ngay_chieu = @ngayChieu";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            cmd.Parameters.AddWithValue("@ngayChieu", ngay);

            Connect();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SuatChieuDTO sc = new SuatChieuDTO
                {
                    TgBatDau = (TimeSpan)reader["tg_bat_dau"],
                    TgKetThuc = (TimeSpan)reader["tg_ket_thuc"],
                    NgayChieu = (DateTime)reader["ngay_chieu"]
                };
                list.Add(sc);
            }
            Disconnect();
            return list;
        }

        public bool KiemTraMaSC(string maSC)
        {
            string sql = "SELECT COUNT(*) FROM SUATCHIEU WHERE id_suat_chieu = @maSC";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maSC", maSC);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public List<SuatChieuDTO> TimKiemSuatChieu(string maSC, string maPhim, string maPhong)
        {
            Connect();
            List<SuatChieuDTO> ds = new List<SuatChieuDTO>();


            string sql = @"SELECT SC.MaPhim, SC.id_suat_chieu, P.TenPhim, SC.id_phong, SC.ngay_chieu, SC.tg_bat_dau, SC.tg_ket_thuc
                           FROM SUATCHIEU SC
                           JOIN PHIM P ON SC.MaPhim = P.MaPhim
                           WHERE (@MaSC IS NULL OR SC.id_suat_chieu LIKE '%' + @MaSC + '%')
                             AND (@MaPhim IS NULL OR SC.MaPhim LIKE '%' + @MaPhim + '%')
                             AND (@MaPhong IS NULL OR SC.id_phong LIKE '%' + @MaPhong + '%')";

            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaSC", string.IsNullOrEmpty(maSC) ? DBNull.Value : (object)maSC);
            cmd.Parameters.AddWithValue("@MaPhim", string.IsNullOrEmpty(maPhim) ? DBNull.Value : (object)maPhim);
            cmd.Parameters.AddWithValue("@MaPhong", string.IsNullOrEmpty(maPhong) ? DBNull.Value : (object)maPhong);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ds.Add(new SuatChieuDTO
                {
                    MaSC = rd["id_suat_chieu"].ToString(),
                    TgBatDau = (TimeSpan)rd["tg_bat_dau"],
                    TgKetThuc = (TimeSpan)rd["tg_ket_thuc"],
                    NgayChieu = (DateTime)rd["ngay_chieu"],
                    MaPhim = rd["MaPhim"].ToString(),
                    IdPhong = rd["id_phong"].ToString()
                });
            }

            Disconnect();
            return ds;
        }

        public bool XoaSuatChieu(string maSC)
        {
            try
            {
                string query = "DELETE FROM SuatChieu WHERE id_suat_chieu = @MaSC";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@MaSC", maSC);

                Connect();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Lỗi vi phạm khóa ngoại (Foreign Key violation)
                {
                    MessageBox.Show("Không thể xóa suất chiếu vì đang được sử dụng ở bảng khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa suất chiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                Disconnect();
            }
        }
        //Dùng hiển thị trên hóa đơn
        public (string TenPhim, TimeSpan GioBatDau, DateTime NgayChieu, string MaPhong) LayThongTinPhimTheoSuatChieu(string idSuatChieu)
        {
            try
            {
                Connect();
                string sql = "sp_LayThongTinPhimTheoSuatChieu";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_suat_chieu", idSuatChieu);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string tenPhim = reader["TenPhim"].ToString();
                    string maPhong = reader["id_phong"].ToString();
                    TimeSpan gioBatDau = (TimeSpan)reader["tg_bat_dau"];
                    DateTime ngayChieu = Convert.ToDateTime(reader["ngay_chieu"]);

                    reader.Close();
                    return (tenPhim, gioBatDau, ngayChieu, maPhong);
                }

                reader.Close();
                return ("Không rõ", TimeSpan.Zero, DateTime.MinValue, " ");
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
