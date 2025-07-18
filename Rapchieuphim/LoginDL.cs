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
            string sql = "SELECT chuc_vu FROM TAIKHOAN WHERE Email = @Email AND MatKhau = @MatKhau";

            try
            {
                Connect(); // Mở kết nối từ DataProvider

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Email", account.Email);
                cmd.Parameters.AddWithValue("@MatKhau", account.MatKhau);

                object result = cmd.ExecuteScalar(); // Trả về chức vụ nếu đúng tài khoản

                if (result != null)
                {
                    account.Chucvu = result.ToString();
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

            //public bool Login(Account account)
            //{
            //    string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE Email = '" + account.Email + "' AND MatKhau = '" + account.MatKhau + "'";

            //    try
            //    {
            //        return ((int)(MyExcuteScaler(sql, CommandType.Text)) > 0);
            //    }
            //    catch (SqlException ex)
            //    {
            //        throw ex;
            //    }
            //}
        }
    }
}
