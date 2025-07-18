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
    public class DAL_Phong : DataProvider
    {
        public DataTable GetAllPhong()
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT id_phong FROM PHONG", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect();
            return dt;
        }

        public bool ThemPhong(PhongDTO phong)
        {
            try
            {
                string sql = "INSERT INTO PHONG (id_phong, ten_phong, sl_ghe) VALUES (@id, @ten, @soghe)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", phong.IdPhong);
                cmd.Parameters.AddWithValue("@ten", phong.TenPhong);
                cmd.Parameters.AddWithValue("@soghe", phong.SoLuongGhe);

                Connect();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
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

        public bool KiemTraTenPhong(string tenPhong)
        {
            string sql = "SELECT COUNT(*) FROM PHONG WHERE ten_phong = @tenPhong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@tenPhong", tenPhong);
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

        public bool KiemTraMaPhong(string maPhong)
        {
            string sql = "SELECT COUNT(*) FROM PHONG WHERE id_phong = @maPhong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maPhong", maPhong);
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

        public DataTable TimKiemPhong(string maPhong, string tenPhong)
        {
            Connect();

            string sql = @"SELECT id_phong, ten_phong, sl_ghe
                   FROM PHONG
                   WHERE (@MaPhong IS NULL OR id_phong LIKE '%' + @MaPhong + '%')
                     AND (@TenPhong IS NULL OR ten_phong LIKE '%' + @TenPhong + '%')";

            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaPhong", string.IsNullOrEmpty(maPhong) ? DBNull.Value : (object)maPhong);
            cmd.Parameters.AddWithValue("@TenPhong", string.IsNullOrEmpty(tenPhong) ? DBNull.Value : (object)tenPhong);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Disconnect();

            return dt;
        }

        public bool XoaPhong(string maPhong)
        {
            try
            {
                string query = "DELETE FROM PHONG WHERE id_phong = @MaPhong";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                Connect();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Vi phạm ràng buộc khóa ngoại
                {
                    MessageBox.Show("Không thể xóa phòng vì đang được sử dụng trong bảng khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable GetTatCaPhong()
        {
            Connect(); // Kết nối trước khi truy vấn
            string query = "SELECT id_phong, ten_phong, sl_ghe FROM PHONG";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cn); // Sử dụng biến cn
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Disconnect(); // Ngắt kết nối sau khi truy vấn
            return dt;
        }


    }
}
