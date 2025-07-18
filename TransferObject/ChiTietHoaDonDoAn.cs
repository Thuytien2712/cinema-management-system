using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class ChiTietHoaDonDoAn
    {
        public int MaHD { get; set; }
        public string IdDoAn { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string TenMon { get; set; }
        public ChiTietHoaDonDoAn() { }

        public ChiTietHoaDonDoAn(int maHD, string idDoAn, int soLuong, decimal donGia)
        {
            MaHD = maHD;
            IdDoAn = idDoAn;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        public ChiTietHoaDonDoAn(int maHD, string idDoAn, int soLuong, decimal donGia, string tenMon)
        {
            MaHD = maHD;
            IdDoAn = idDoAn;
            SoLuong = soLuong;
            DonGia = donGia;
            TenMon = TenMon;
        }
    }

}
