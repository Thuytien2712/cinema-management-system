using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class QLHOADONBL
    {
        private QLYHOADONDL qlhddl = new QLYHOADONDL();
        private ChiTietHoaDonDoAnDL cthddadl = new ChiTietHoaDonDoAnDL();
        private ChiTietHoaDonVeDL cthdvedl = new ChiTietHoaDonVeDL();
        public List<HoaDon> LayTatCa()
        {
            return qlhddl.LayDanhSach();
        }
        public List<HoaDon> TimKiemHD(string maHD, string maNV, string maKH, DateTime tuNgay, DateTime denNgay)
        {
            return qlhddl.TimKiem(maHD, maNV, maKH, tuNgay, denNgay);
        }
        public int ThemHoaDonVaChiTiet(HoaDon hd, List<ChiTietHoaDonDoAn> dsDoAn, List<ChiTietHoaDonVe> dsVe)
        {
            return qlhddl.ThemHoaDonVaChiTiet(hd, dsDoAn, dsVe);
        }
        public List<ChiTietHoaDonDoAn> LayChiTietHoaDonDoAn(int maHD)
        {
            return cthddadl.LayTheoMaHD(maHD);
        }
        public List<ChiTietHoaDonVe> LayChiTietHoaDonVe(int maHD)
        {
            return cthdvedl.LayTheoMaHD(maHD);
        }

    }
}


