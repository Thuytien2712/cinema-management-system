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
    public class LoaiVeDAL : DataProvider
    {
        public List<LoaiVeDTO> LayDanhSachLoaiVe()
        {
            List<LoaiVeDTO> ds = new List<LoaiVeDTO>();

            try
            {
                Connect();
                string query = "SELECT id_loai_ve, ten, gia_ve FROM LoaiVe";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LoaiVeDTO loai = new LoaiVeDTO
                    {
                        IdLoaiVe = reader["id_loai_ve"].ToString(),
                        Ten = reader["ten"].ToString(),
                        GiaVe = Convert.ToInt32(reader["gia_ve"])
                    };
                    ds.Add(loai);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }

            return ds;
        }
    }
}
