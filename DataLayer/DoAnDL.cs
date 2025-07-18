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
    public class DoAnDL : DataProvider
    {
        public List<DoAnDTO> GetDoAn()
        {
            string sql = @"SELECT d.id_do_an, d.ten, l.ten AS ten_loai, d.gia, d.so_luong, d.sl_con_lai
                            FROM DOAN d 
                            JOIN LOAIDOAN l ON d.id_loai = l.id_loai";
            string id_do_an, ten, ten_loai, so_luong, sl_con_lai;
            decimal gia;

            List<DoAnDTO> doan = new List<DoAnDTO>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id_do_an = reader[0].ToString();
                    ten = reader[1].ToString();
                    ten_loai = reader[2].ToString();
                    gia = reader[3] != DBNull.Value ? Convert.ToDecimal(reader[3]) : 0;
                    so_luong = reader[4].ToString();
                    sl_con_lai = reader[5].ToString();

                    DoAnDTO da = new DoAnDTO(id_do_an, ten, ten_loai, gia, so_luong, sl_con_lai);
                    doan.Add(da);
                }
                reader.Close();
                return doan;
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

        public int ThemDoAn(DoAnDTO da)
        {

            string sql = "sp_ThemDoAn";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ten", da.Ten));
            parameters.Add(new SqlParameter("@id_loai", da.Id_loai));
            parameters.Add(new SqlParameter("@gia", da.Gia));
            parameters.Add(new SqlParameter("@so_luong", da.So_luong));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhatDoAn(DoAnDTO da)
        {
            string sql = "sp_CapNhatDoAn";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_do_an", da.Id_do_an));
            parameters.Add(new SqlParameter("@ten", da.Ten));
            parameters.Add(new SqlParameter("@id_loai", da.Id_loai));
            parameters.Add(new SqlParameter("@gia", da.Gia));
            parameters.Add(new SqlParameter("@so_luong", da.So_luong));

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

        public int XoaDoAn(DoAnDTO da)
        {
            string sql = "sp_XoaDoAn";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_do_an", da.Id_do_an));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<DoAnDTO> LayMonTheoLoai(string ten_loai)
        {
            string id_do_an, ten;
            decimal gia;
            List<DoAnDTO> doan = new List<DoAnDTO>();

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("sp_LocMonTheoLoai", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenLoai", ten_loai);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_do_an = reader[0].ToString();
                    ten = reader[1].ToString();
                    gia = reader[2] != DBNull.Value ? Convert.ToDecimal(reader[2]) : 0;

                    //các thông tin còn lại không có trong procedure
                    DoAnDTO da = new DoAnDTO(id_do_an, ten, ten_loai, gia, "", "");
                    doan.Add(da);
                }
                reader.Close();
                return doan;
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

        public DataTable LayDanhSachMonConHang()
        {
            Connect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DsMonConHang", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }

            return dt;
        }

        public void CapNhatTonKhoSauKhiBan(string idDoAn, int soLuong)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@id_do_an", idDoAn));
                parameters.Add(new SqlParameter("@so_luong", soLuong));

                DataProvider dp = new DataProvider();
                dp.MyExecuteNonQuery("sp_TinhSoLuongTon", CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


    }
}
