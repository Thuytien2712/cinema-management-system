using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class KhachHangDTO
    {
        public string Id_kh { get; set; }
        public string Ho_ten { get; set; }
        public DateTime Ngay_sinh { get; set; }
        public string Gioi_tinh { get; set; }
        public string Dia_chi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }

        public KhachHangDTO(string id_kh, string ho_ten, DateTime ngay_sinh, string gioi_tinh, string dia_chi, string sdt, string email)
        {
            Id_kh = id_kh;
            Ho_ten = ho_ten;
            Ngay_sinh = ngay_sinh;
            Gioi_tinh = gioi_tinh;
            Dia_chi = dia_chi;
            Sdt = sdt;
            Email = email;
        }

        public KhachHangDTO( string ho_ten, DateTime ngay_sinh, string gioi_tinh, string dia_chi, string sdt, string email)
        {
            Ho_ten = ho_ten;
            Ngay_sinh = ngay_sinh;
            Gioi_tinh = gioi_tinh;
            Dia_chi = dia_chi;
            Sdt = sdt;
            Email = email;
        }

        public KhachHangDTO(string id_kh)
        {
            Id_kh = id_kh;
        }
    }
}
