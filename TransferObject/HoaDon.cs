using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class HoaDon
    {

        public int MaHoaDon { get; set; }
        public string IdKH { get; set; }
        public string IdNV { get; set; }
        public string MaGG { get; set; }
        public DateTime NgayLap { get; set; }
        public int DiemDaDung { get; set; }
        public decimal TongTien { get; set; }
        public decimal TienGiam { get; set; }
        public decimal TienThanhToan { get; set; }
        public string GhiChu { get; set; }

        // Constructor không tham số (nếu cần)
        public HoaDon() { }

        // Constructor đầy đủ 
        public HoaDon(int maHD, string idKH, string idNV, string maGG, DateTime ngayLap, int diemDaDung,
                 decimal tongTien, decimal tienGiam, decimal tienThanhToan, string ghiChu)
        {
            MaHoaDon = maHD;
            IdKH = idKH;
            IdNV = idNV;
            MaGG = maGG;
            NgayLap = ngayLap;
            DiemDaDung = diemDaDung;
            TongTien = tongTien;
            TienGiam = tienGiam;
            TienThanhToan = tienThanhToan;
            GhiChu = ghiChu;
        }



    }
}
