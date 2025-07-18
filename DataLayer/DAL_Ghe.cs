using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class DAL_Ghe : DataProvider
    {
        public List<GheDTO> LayDanhSachGheTheoPhong(string idPhong)
        {
            List<GheDTO> ds = new List<GheDTO>();
            Connect();

            string sql = @"SELECT G.id_ghe, G.vi_tri, L.ten AS TenLoaiGhe, L.phu_thu, G.id_phong
                           FROM GHE G
                           JOIN LOAIGHE L ON G.id_loai_ghe = L.id_loai_ghe
                           WHERE G.id_phong = @IdPhong";

            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@IdPhong", idPhong);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GheDTO ghe = new GheDTO
                {
                    IdGhe = reader["id_ghe"].ToString(),
                    ViTri = reader["vi_tri"].ToString(),
                    TenLoaiGhe = reader["TenLoaiGhe"].ToString(),
                    PhuThu = Convert.ToInt32(reader["phu_thu"]),
                    IdPhong = reader["id_phong"].ToString()
                };
                ds.Add(ghe);
            }

            reader.Close();
            Disconnect();
            return ds;
        }
    }
}
