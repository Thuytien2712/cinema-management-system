using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DataLayer
{
    public class QLyTaiKhoanDL : DataProvider
    {
        public List<Account> LayDanhSach()
        {
            List<Account> ds = new List<Account>();
            try
            {
                Connect();
                string sql = "SELECT * FROM TAIKHOAN";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Account account = new Account
                    {
                        Id_nv = reader["id_nv"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        Chucvu = reader["chuc_vu"].ToString(),
                    };
                    ds.Add(account);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }

            return ds;
        }
        public int ThemTaiKhoan(Account account)
        {
            string sql = "sp_ThemTaiKhoan";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_nv", account.Id_nv));
            parameters.Add(new SqlParameter("@Email", account.Email));
            parameters.Add(new SqlParameter("@MatKhau", account.MatKhau));
            parameters.Add(new SqlParameter("@chuc_vu", account.Chucvu));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int SuaTaiKhoan(Account account)
        {
            string sql = "sp_SuaTaiKhoan";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_nv", account.Id_nv));
            parameters.Add(new SqlParameter("@Email", account.Email));
            parameters.Add(new SqlParameter("@MatKhau", account.MatKhau));
            parameters.Add(new SqlParameter("@chuc_vu", account.Chucvu));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int XoaTaiKhoan(Account account)
        {
            string sql = "sp_XoaTaiKhoan";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_nv", account.Id_nv));
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
