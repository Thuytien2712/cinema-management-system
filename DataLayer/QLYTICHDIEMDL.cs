using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class QLYTICHDIEMDL : DataProvider
    {
        public List<TichDiem> LayDanhSach()
        {
            List<TichDiem> ds = new List<TichDiem>();
            try
            {
                Connect();
                string sql = "SELECT * FROM LICHSUTICHDIEM";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TichDiem diem = new TichDiem
                    {
                        id_tich_diem = reader["id_tich_diem"].ToString(),
                        noi_dung = reader["noi_dung"].ToString(),
                        diem = Convert.ToInt32(reader["diem"]),
                        id_kh = reader["id_kh"].ToString(),
                        Mahoadon = Convert.ToInt32(reader["Mahoadon"]),
                        ngay_tich_diem = Convert.ToDateTime(reader["ngay_tich_diem"])


                    };
                    ds.Add(diem);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }

            return ds;
        }
        public int Them(TichDiem tichdiem)
        {

            string sql = "sp_ThemLichSuTichDiem";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlCommand cmd = new SqlCommand(sql, cn);

            parameters.Add(new SqlParameter("@noi_dung", tichdiem.noi_dung));
            parameters.Add(new SqlParameter("@diem", tichdiem.diem));
            parameters.Add(new SqlParameter("@id_kh", tichdiem.id_kh));
            parameters.Add(new SqlParameter("@Mahoadon", tichdiem.Mahoadon));
            parameters.Add(new SqlParameter("@ngay_tich_diem", tichdiem.ngay_tich_diem));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public int Sua(TichDiem tichdiem)
        {

            string sql = "uspUpdateLichSuTichDiem";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlCommand cmd = new SqlCommand(sql, cn);
            parameters.Add(new SqlParameter("@noi_dung", tichdiem.noi_dung));
            parameters.Add(new SqlParameter("@diem", tichdiem.diem));
            parameters.Add(new SqlParameter("@id_kh", tichdiem.id_kh));
            parameters.Add(new SqlParameter("@Mahoadon", tichdiem.Mahoadon));
            parameters.Add(new SqlParameter("@ngay_tich_diem", tichdiem.ngay_tich_diem));


            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public int Xoa(TichDiem tichdiem)
        {

            string sql = "uspDeleteLichSuTichDiem";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlCommand cmd = new SqlCommand(sql, cn);
            parameters.Add(new SqlParameter("@id_tich_diem", tichdiem.id_tich_diem));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public bool KiemTraMaKhachHang(string maKH)
        {
            string sql = "SELECT COUNT(*) FROM KHACHHANG WHERE id_kh = @id_kh";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_kh", maKH));

            object result = MyExecuteScalar_1(sql, CommandType.Text, parameters);

            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }

            return false;
        }


        public List<TichDiem> LayDanhSachTichDiemTheoKH(string idKH)
        {
            List<TichDiem> ds = new List<TichDiem>();

            try
            {
                Connect();
                string sql = "SELECT * FROM LICHSUTICHDIEM WHERE id_kh = @id_kh";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id_kh", idKH);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TichDiem diem = new TichDiem
                    {
                        id_tich_diem = reader["id_tich_diem"].ToString(),
                        id_kh = reader["id_kh"].ToString(),
                        Mahoadon = Convert.ToInt32(reader["Mahoadon"]),
                        diem = Convert.ToInt32(reader["diem"]),
                        ngay_tich_diem = Convert.ToDateTime(reader["ngay_tich_diem"]),
                        noi_dung = reader["noi_dung"].ToString()
                    };
                    ds.Add(diem);
                }
            }
            finally
            {
                Disconnect();
            }

            return ds;
        }
    }

}

