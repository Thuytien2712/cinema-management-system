using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Windows.Forms;

namespace DataLayer
{
    public class DAL_Phim : DataProvider
    {
        public DataTable GetAllPhim()
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhim, TenPhim FROM PHIM", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect();
            return dt;
        }


        public bool KiemTraMaPhim(string maPhim)
        {
            string sql = "SELECT COUNT(*) FROM PHIM WHERE MaPhim = @maPhim";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maPhim", maPhim);

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


        public bool ThemPhim(PhimDTO phim)
        {
            try
            {
                Connect();

                string query = @"INSERT INTO PHIM (
                    MaPhim, TenPhim, NgayKhoiChieu, ThoiLuong, DaoDien, DienVien, NgonNgu, MoTaNoiDung, id_dinh_dang, id_the_loai, Rated, HinhAnh)
                    VALUES (
                    @MaPhim, @TenPhim, @NgayKhoiChieu, @ThoiLuong, @DaoDien, @DienVien, @NgonNgu, @MoTaNoiDung, @IdDinhDang, @IdTheLoai, @Rated, @HinhAnh)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@MaPhim", phim.MaPhim);
                cmd.Parameters.AddWithValue("@TenPhim", phim.TenPhim);
                cmd.Parameters.AddWithValue("@NgayKhoiChieu", phim.NgayKhoiChieu);
                cmd.Parameters.AddWithValue("@ThoiLuong", phim.ThoiLuong);
                cmd.Parameters.AddWithValue("@DaoDien", phim.DaoDien);
                cmd.Parameters.AddWithValue("@DienVien", phim.DienVien);
                cmd.Parameters.AddWithValue("@NgonNgu", phim.NgonNgu);
                cmd.Parameters.AddWithValue("@MoTaNoiDung", phim.MoTaNoiDung);
                cmd.Parameters.AddWithValue("@IdDinhDang", phim.IdDinhDang);
                cmd.Parameters.AddWithValue("@IdTheLoai", phim.IdTheLoai);
                cmd.Parameters.AddWithValue("@Rated", phim.Rated);
                cmd.Parameters.AddWithValue("@HinhAnh", phim.HinhAnh);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public List<PhimDTO> TimKiemPhim(string maPhim, string tenPhim, string theLoai)
        {
            List<PhimDTO> danhSachPhim = new List<PhimDTO>();
            Connect();

            string sql = @"SELECT 
                               PH.MaPhim, 
                               PH.TenPhim, 
                               PH.NgayKhoiChieu, 
                               PH.ThoiLuong, 
                               PH.DaoDien, 
                               PH.DienVien, 
                               PH.NgonNgu, 
                               PH.MoTaNoiDung,
                               PH.id_dinh_dang, 
                               PH.id_the_loai,
                               PH.Rated,
                               PH.HinhAnh,
                               TL.ten AS TheLoai
                           FROM PHIM PH
                           JOIN THELOAIPHIM TL ON PH.id_the_loai = TL.id_the_loai
                           WHERE (@MaPhim IS NULL OR PH.MaPhim LIKE '%' + @MaPhim + '%')
                             AND (@TenPhim IS NULL OR PH.TenPhim LIKE '%' + @TenPhim + '%')
                             AND (@TheLoai IS NULL OR TL.id_the_loai LIKE '%' + @TheLoai + '%')";

            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaPhim", string.IsNullOrEmpty(maPhim) ? DBNull.Value : (object)maPhim);
            cmd.Parameters.AddWithValue("@TenPhim", string.IsNullOrEmpty(tenPhim) ? DBNull.Value : (object)tenPhim);
            cmd.Parameters.AddWithValue("@TheLoai", string.IsNullOrEmpty(theLoai) ? DBNull.Value : (object)theLoai);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                danhSachPhim.Add(new PhimDTO
                {
                    MaPhim = reader["MaPhim"].ToString(),
                    TenPhim = reader["TenPhim"].ToString(),
                    NgayKhoiChieu = Convert.ToDateTime(reader["NgayKhoiChieu"]),
                    ThoiLuong = reader["ThoiLuong"].ToString(),
                    DaoDien = reader["DaoDien"].ToString(),
                    DienVien = reader["DienVien"].ToString(),
                    NgonNgu = reader["NgonNgu"].ToString(),
                    MoTaNoiDung = reader["MoTaNoiDung"].ToString(),
                    IdDinhDang = reader["id_dinh_dang"].ToString(),
                    IdTheLoai = reader["id_the_loai"].ToString(),
                    HinhAnh = reader["HinhAnh"].ToString(),
                    Rated = reader["Rated"].ToString()
                });
            }
            reader.Close();
            Disconnect();

            return danhSachPhim;
        }


        public bool XoaPhim(string maPhim)
        {
            try
            {
                string query = "DELETE FROM PHIM WHERE MaPhim = @MaPhim";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@MaPhim", maPhim);

                Connect();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Lỗi vi phạm khóa ngoại (Foreign Key violation)
                {
                    MessageBox.Show("Không thể xóa phim vì đang được sử dụng ở bảng khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa phim: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                Disconnect();
            }
        }


        public List<PhimDTO> LayPhim24hToi()
        {
            List<PhimDTO> list = new List<PhimDTO>();

            try
            {
                Connect();

                string query = @"
                    SELECT DISTINCT p.MaPhim, p.TenPhim, p.NgayKhoiChieu, p.HinhAnh, p.MoTaNoiDung
                    FROM PHIM p
                    JOIN SUATCHIEU sc ON p.MaPhim = sc.MaPhim
                    WHERE (sc.ngay_chieu = CAST(GETDATE() AS DATE) AND sc.tg_bat_dau >= CAST(GETDATE() AS TIME))
                        OR (sc.ngay_chieu = DATEADD(DAY, 1, CAST(GETDATE() AS DATE)) AND sc.tg_bat_dau <= CAST(GETDATE() AS TIME))

                ";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PhimDTO phim = new PhimDTO
                    {
                        MaPhim = reader["MaPhim"].ToString(),
                        TenPhim = reader["TenPhim"].ToString(),
                        NgayKhoiChieu = Convert.ToDateTime(reader["NgayKhoiChieu"]),
                        HinhAnh = reader["HinhAnh"].ToString(),
                        MoTaNoiDung = reader["MoTaNoiDung"].ToString()

                    };
                    list.Add(phim);
                }

                reader.Close();
            }
            finally
            {
                Disconnect();
            }

            return list;
        }
        public DataTable LayDanhSachPhim()
        {
            Connect(); // Kết nối trước khi truy vấn

            string query = @"
        SELECT 
            ma_phim, 
            ten_phim, 
            ngay_khoi_chieu, 
            thoi_luong, 
            dao_dien, 
            dien_vien, 
            ngon_ngu, 
            mo_ta_noi_dung, 
            id_dinh_dang, 
            id_the_loai, 
            rated, 
            hinh_anh
        FROM PHIM";

            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Disconnect(); // Ngắt kết nối
            return dt;
        }

    }

}
