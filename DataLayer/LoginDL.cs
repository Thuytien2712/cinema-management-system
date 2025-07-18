using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using TransferObject;

namespace DataLayer
{
    public class LoginDL : DataProvider
    {
        public Account Login(Account account)
        {
            //string sql = "SELECT chuc_vu FROM TAIKHOAN WHERE Email = @Email AND MatKhau = @MatKhau";
            string sql = "SELECT Email, MatKhau, Id_nv, chuc_vu FROM TAIKHOAN WHERE Email = @Email AND MatKhau = @MatKhau";
            try
            {
                Connect(); // Mở kết nối từ DataProvider

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Email", account.Email);
                cmd.Parameters.AddWithValue("@MatKhau", account.MatKhau);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    account.Email = reader["Email"].ToString();
                    account.MatKhau = reader["MatKhau"].ToString();
                    account.Id_nv = reader["Id_nv"].ToString();
                    account.Chucvu = reader["chuc_vu"].ToString();
                    return account;
                }

                return null; // Đăng nhập sai
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra tài khoản: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
