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

        public int ThemMaGiamGia(MaGiamGia magiamgia)
        {
            string sql = "uspThemMaGiamGia";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaGG", magiamgia.MaGG));
            parameters.Add(new SqlParameter("@PhanTramGiam", magiamgia.PhanTramGiam));
            parameters.Add(new SqlParameter("@GiamToiDa", magiamgia.GiamToiDa));
            parameters.Add(new SqlParameter("@DieuKien", magiamgia.DieuKien));
            parameters.Add(new SqlParameter("@DonToiThieu", magiamgia.DonToiThieu));
            parameters.Add(new SqlParameter("@NgayBatDau", magiamgia.NgayBatDau));
            parameters.Add(new SqlParameter("@NgayKetThuc", magiamgia.NgayKetThuc));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int SuaMaGiamGia(MaGiamGia magiamgia)
        {
            string sql = "uspSuaMaGiamGia";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaGG", magiamgia.MaGG));
            parameters.Add(new SqlParameter("@PhanTramGiam", magiamgia.PhanTramGiam));
            parameters.Add(new SqlParameter("@GiamToiDa", magiamgia.GiamToiDa));
            parameters.Add(new SqlParameter("@DieuKien", magiamgia.DieuKien));
            parameters.Add(new SqlParameter("@DonToiThieu", magiamgia.DonToiThieu));
            parameters.Add(new SqlParameter("@NgayBatDau", magiamgia.NgayBatDau));
            parameters.Add(new SqlParameter("@NgayKetThuc", magiamgia.NgayKetThuc));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int XoaMaGiamGia(MaGiamGia magiamgia)
        {
            string sql = "uspXoaMaGiamGia";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaGG", magiamgia.MaGG));
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



