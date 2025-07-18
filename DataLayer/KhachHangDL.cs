using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class KhachHangDL : DataProvider
    {
        public List<KhachHangDTO> GetKhachHang()
        {
            string sql = "SELECT * FROM KHACHHANG";
            string id_kh, ho_ten, gioi_tinh, dia_chi, sdt, email;
            DateTime ngay_sinh;
            List<KhachHangDTO> khachhang = new List<KhachHangDTO>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id_kh = reader[0].ToString();
                    ho_ten = reader[1].ToString();
                    ngay_sinh = Convert.ToDateTime(reader["ngay_sinh"]);
                    gioi_tinh = reader[3].ToString();
                    dia_chi = reader[4].ToString();
                    sdt = reader[5].ToString();
                    email = reader[6].ToString();

                    KhachHangDTO kh = new KhachHangDTO(id_kh, ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, email);
                    khachhang.Add(kh);
                }
                reader.Close();
                return khachhang;
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

        public int ThemKhachHang(KhachHangDTO kh)
        {
            string sql = "sp_ThemKhachHang";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ho_ten", kh.Ho_ten));
            parameters.Add(new SqlParameter("@ngay_sinh", kh.Ngay_sinh));
            parameters.Add(new SqlParameter("@gioi_tinh", kh.Gioi_tinh));
            parameters.Add(new SqlParameter("@dia_chi", kh.Dia_chi));
            parameters.Add(new SqlParameter("@sdt", kh.Sdt));
            parameters.Add(new SqlParameter("@email", kh.Email));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhatKhachHang(KhachHangDTO kh)
        {
            string sql = "sp_CapNhatKhachHang";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_kh", kh.Id_kh));
            parameters.Add(new SqlParameter("@ho_ten", kh.Ho_ten));
            parameters.Add(new SqlParameter("@ngay_sinh", kh.Ngay_sinh));
            parameters.Add(new SqlParameter("@gioi_tinh", kh.Gioi_tinh));
            parameters.Add(new SqlParameter("@dia_chi", kh.Dia_chi));
            parameters.Add(new SqlParameter("@sdt", kh.Sdt));
            parameters.Add(new SqlParameter("@email", kh.Email));

            try
            {
                object result = MyExecuteScalar_1(sql, CommandType.StoredProcedure, parameters);
                return Convert.ToInt32(result); // Trả về 1 hoặc 0
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int XoaKhachHang(KhachHangDTO kh)
        {
            string sql = "sp_XoaKhachHang";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_kh", kh.Id_kh));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public KhachHangDTO TimKhachHangTheoMa(string maKH)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE id_kh = @maKH";
            Connect();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@maKH", maKH);
            SqlDataReader reader = cmd.ExecuteReader();

            KhachHangDTO kh = null;
            if (reader.Read())
            {
                string id_kh = reader[0].ToString();
                string ho_ten = reader[1].ToString();
                DateTime ngay_sinh = Convert.ToDateTime(reader["ngay_sinh"]);
                string gioi_tinh = reader[3].ToString();
                string dia_chi = reader[4].ToString();
                string sdt = reader[5].ToString();
                string email = reader[6].ToString();

                kh = new KhachHangDTO(id_kh, ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, email);
            }

            reader.Close();
            Disconnect();
            return kh;
        }
    }
}
