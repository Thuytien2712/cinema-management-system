using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class NhanVienDTO
    {
        public string Id_nv { get; set; }
        public string Ho_ten { get; set; }
        public DateTime Ngay_sinh { get; set; }
        public string Gioi_tinh { get; set; }
        public string Dia_chi { get; set; }
        public string Sdt { get; set; }
        public string Chuc_vu { get; set; }

        public NhanVienDTO(string ho_ten, DateTime ngay_sinh, string gioi_tinh, string dia_chi, string sdt, string chuc_vu)
        {
            Ho_ten = ho_ten;
            Ngay_sinh = ngay_sinh;
            Gioi_tinh = gioi_tinh;
            Dia_chi = dia_chi;
            Sdt = sdt;
            Chuc_vu = chuc_vu;
        }

        public NhanVienDTO(string id_nv, string ho_ten, DateTime ngay_sinh, string gioi_tinh, string dia_chi, string sdt, string chuc_vu)
        {
            Id_nv = id_nv;
            Ho_ten = ho_ten;
            Ngay_sinh = ngay_sinh;
            Gioi_tinh = gioi_tinh;
            Dia_chi = dia_chi;
            Sdt = sdt;
            Chuc_vu = chuc_vu;
        }

        public NhanVienDTO(string id_nv)
        {
            Id_nv = id_nv;
        }

    }
}
