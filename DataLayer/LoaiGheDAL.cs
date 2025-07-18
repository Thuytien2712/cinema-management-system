using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class LoaiGheDAL : DataProvider
    {
        public List<LoaiGheDTO> LayDanhSachLoaiGhe()
        {
            List<LoaiGheDTO> ds = new List<LoaiGheDTO>();
            string sql = "SELECT id_loai_ghe, ten, phu_thu FROM LoaiGhe";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ds.Add(new LoaiGheDTO
                    {
                        IdLoaiGhe = reader["id_loai_ghe"].ToString(),
                        Ten = reader["ten"].ToString(),
                        PhuThu = Convert.ToInt32(reader["phu_thu"])
                    });
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại ghế", ex);
            }
            finally
            {
                Disconnect();
            }

            return ds;
        }
    }
}
