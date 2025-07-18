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
    public class NhanVienDL : DataProvider
    {
        public List<NhanVienDTO> GetNhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";
            string id_nv, ho_ten, gioi_tinh, dia_chi, sdt, chuc_vu;
            DateTime ngay_sinh;
            List<NhanVienDTO> nhanvien = new List<NhanVienDTO>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id_nv = reader[0].ToString();
                    ho_ten = reader[1].ToString();
                    ngay_sinh = Convert.ToDateTime(reader["ngay_sinh"]);
                    gioi_tinh = reader[3].ToString();
                    dia_chi = reader[4].ToString();
                    sdt = reader[5].ToString();
                    chuc_vu = reader[6].ToString();

                    NhanVienDTO nv = new NhanVienDTO(id_nv, ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, chuc_vu);
                    nhanvien.Add(nv);
                }
                reader.Close();
                return nhanvien;
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

        public int ThemNhanVien(NhanVienDTO nv)
        {
            string sql = "sp_ThemNhanVien";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ho_ten", nv.Ho_ten));
            parameters.Add(new SqlParameter("@ngay_sinh", nv.Ngay_sinh));
            parameters.Add(new SqlParameter("@gioi_tinh", nv.Gioi_tinh));
            parameters.Add(new SqlParameter("@dia_chi", nv.Dia_chi));
            parameters.Add(new SqlParameter("@sdt", nv.Sdt));
            parameters.Add(new SqlParameter("@chuc_vu", nv.Chuc_vu));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhatNhanVien(NhanVienDTO nv)
        {
            string sql = "sp_CapNhatNhanVien";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_nv", nv.Id_nv));
            parameters.Add(new SqlParameter("@ho_ten", nv.Ho_ten));
            parameters.Add(new SqlParameter("@ngay_sinh", nv.Ngay_sinh));
            parameters.Add(new SqlParameter("@gioi_tinh", nv.Gioi_tinh));
            parameters.Add(new SqlParameter("@dia_chi", nv.Dia_chi));
            parameters.Add(new SqlParameter("@sdt", nv.Sdt));
            parameters.Add(new SqlParameter("@chuc_vu", nv.Chuc_vu));

            try
            {
                object result = MyExecuteScalar_1(sql, CommandType.StoredProcedure, parameters);
                return Convert.ToInt32(result); // Trả về 1 nếu thành công hoặc 0 thật bại
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int XoaNhanVien(NhanVienDTO nv)
        {
            string sql = "sp_XoaNhanVien";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_nv", nv.Id_nv));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        


    }
}
