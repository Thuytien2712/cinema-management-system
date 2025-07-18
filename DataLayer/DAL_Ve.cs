using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class DAL_Ve : DataProvider
    {
        public bool ThemVe(VeDTO ve)
        {
            string query = @"INSERT INTO VE 
                        (id_ve, ngay_ban, tong_tien, suat_chieu_id, id_loai_ve, id_ghe, id_kh, id_nv)
                         VALUES 
                        (@id_ve, @ngay_ban, @tong_tien, @suat_chieu_id, @id_loai_ve, @id_ghe, @id_kh, @id_nv)";

            try
            {
                Connect(); // mở kết nối từ DataProvider

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id_ve", ve.IdVe);
                    cmd.Parameters.AddWithValue("@ngay_ban", ve.NgayBan);
                    cmd.Parameters.AddWithValue("@tong_tien", (object)ve.TongTien ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@suat_chieu_id", ve.SuatChieuId);
                    cmd.Parameters.AddWithValue("@id_loai_ve", ve.IdLoaiVe);
                    cmd.Parameters.AddWithValue("@id_ghe", ve.IdGhe);
                    cmd.Parameters.AddWithValue("@id_kh", (object)ve.IdKh ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_nv", (object)ve.IdNv ?? DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm vé: " + ex.Message);
            }
            finally
            {
                Disconnect(); // đóng kết nối từ DataProvider
            }
        }
    }

}
