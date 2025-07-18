using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;


namespace DataLayer
{
    namespace DataLayer
    {
        public class QLMaGGDL : DataProvider
        {
            public List<MaGiamGia> LayDanhSach()
            {
                List<MaGiamGia> ds = new List<MaGiamGia>();
                try
                {
                    Connect();
                    string sql = "SELECT * FROM MAGIAMGIA";  
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MaGiamGia ma = new MaGiamGia
                        {
                            MaGG = reader["MaGG"].ToString(),
                            PhanTramGiam = Convert.ToInt32(reader["PhanTramGiam"]),
                            GiamToiDa = Convert.ToInt32(reader["GiamToiDa"]),
                            DieuKien = reader["DieuKien"].ToString(),
                            NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                            NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                            DonToiThieu = Convert.ToInt32(reader["DonToiThieu"]),
                            
                        };
                        ds.Add(ma);
                    }
                    reader.Close();
                }
                finally
                {
                    Disconnect();
                }

                return ds;
            }

            public bool Them(MaGiamGia ma)
            {
                try
                {
                    Connect();
                    string sql = @"INSERT INTO MaGiamGia (MaGG, PhanTramGiam, GiamToiDa, DieuKien, NgayBatDau, NgayKetThuc, DonToiThieu, SoLuong, DaSuDung, MoTa)
                               VALUES (@MaGG, @PhanTramGiam, @DieuKien, @NgayBatDau, @NgayKetThuc, @DonToiThieu, @SoLuong, @DaSuDung, @MoTa)";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@MaGG", ma.MaGG);
                    cmd.Parameters.AddWithValue("@PhanTramGiam", ma.PhanTramGiam);
                    cmd.Parameters.AddWithValue("@GiamToiDa",ma.GiamToiDa);
                    cmd.Parameters.AddWithValue("@DieuKien", ma.DieuKien);
                    cmd.Parameters.AddWithValue("@NgayBatDau", ma.NgayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ma.NgayKetThuc);
                    cmd.Parameters.AddWithValue("@DonToiThieu", ma.DonToiThieu);
                    

                    return cmd.ExecuteNonQuery() > 0;
                }
                finally
                {
                    Disconnect();
                }
            }

            public bool Sua(MaGiamGia ma)
            {
                try
                {
                    Connect();
                    string sql = @"UPDATE MaGiamGia
                               SET PhanTramGiam = @PhanTramGiam,
                                    GiamToiDa=@GiamToiDa,
                                   DieuKien = @DieuKien,
                                   NgayBatDau = @NgayBatDau,
                                   NgayKetThuc = @NgayKetThuc,
                                   DonToiThieu=@DonToiThieu
                              
                               WHERE MaGG = @MaGG";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@MaGG", ma.MaGG);
                    cmd.Parameters.AddWithValue("@PhanTramGiam", ma.PhanTramGiam);
                    cmd.Parameters.AddWithValue("@GiamToiDa", ma.GiamToiDa);
                    cmd.Parameters.AddWithValue("@DieuKien", ma.DieuKien);
                    cmd.Parameters.AddWithValue("@NgayBatDau", ma.NgayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ma.NgayKetThuc);
                    cmd.Parameters.AddWithValue("@DonToiThieu", ma.DonToiThieu);
                    //cmd.Parameters.AddWithValue("@SoLuong", ma.SoLuong);
                    //cmd.Parameters.AddWithValue("@DaSuDung", ma.DaSuDung);
                    //cmd.Parameters.AddWithValue("@MoTa", ma.MoTa);

                    return cmd.ExecuteNonQuery() > 0;
                }
                finally
                {
                    Disconnect();
                }
            }

            public bool Xoa(string maGG)
            {
                try
                {
                    Connect();
                    string sql = "DELETE FROM MaGiamGia WHERE MaGG = @MaGG";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@MaGG", maGG);

                    return cmd.ExecuteNonQuery() > 0;
                }
                finally
                {
                    Disconnect();
                }
            }
        }


    }
}


