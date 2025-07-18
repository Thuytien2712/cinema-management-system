using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class QLYDOANHTHUBL
    {
        private QLYHOADONDL hoaDonDL = new QLYHOADONDL();
        private ChiTietHoaDonVeDL chiTietVeDL = new ChiTietHoaDonVeDL();
        private ChiTietHoaDonDoAnDL chiTietDoAnDL = new ChiTietHoaDonDoAnDL();
        public decimal TinhTongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDon> danhSachHoaDon = hoaDonDL.TimKiem("", "", "", tuNgay, denNgay);
            return danhSachHoaDon.Sum(hd => hd.TienThanhToan);
        }

        public Dictionary<DateTime, decimal> LayDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDon> danhSachHoaDon = hoaDonDL.TimKiem("", "", "", tuNgay, denNgay);
            return danhSachHoaDon.GroupBy(hd => hd.NgayLap.Date)
                                 .ToDictionary(g => g.Key, g => g.Sum(hd => hd.TienThanhToan));
        }
        public Dictionary<DateTime, decimal> LayDoanhThuVeTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDon> danhSachHoaDon = hoaDonDL.TimKiem("", "", "", tuNgay, denNgay);
            Dictionary<DateTime, decimal> doanhThuVeTheoNgay = new Dictionary<DateTime, decimal>();

            foreach (var hoaDon in danhSachHoaDon)
            {
                List<ChiTietHoaDonVe> chiTietVes = chiTietVeDL.LayTheoMaHD(hoaDon.MaHoaDon);
                decimal tongTienVe = chiTietVes.Sum(ct => ct.GiaVe);
                DateTime ngayLap = hoaDon.NgayLap.Date;

                if (doanhThuVeTheoNgay.ContainsKey(ngayLap))
                {
                    doanhThuVeTheoNgay[ngayLap] += tongTienVe;
                }
                else
                {
                    doanhThuVeTheoNgay[ngayLap] = tongTienVe;
                }
            }
            return doanhThuVeTheoNgay;
        }

        public Dictionary<DateTime, decimal> LayDoanhThuDoAnTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDon> danhSachHoaDon = hoaDonDL.TimKiem("", "", "", tuNgay, denNgay);
            Dictionary<DateTime, decimal> doanhThuDoAnTheoNgay = new Dictionary<DateTime, decimal>();

            foreach (var hoaDon in danhSachHoaDon)
            {
                List<ChiTietHoaDonDoAn> chiTietDoAns = chiTietDoAnDL.LayTheoMaHD(hoaDon.MaHoaDon);
                decimal tongTienDoAn = chiTietDoAns.Sum(ct => ct.SoLuong * ct.DonGia);
                DateTime ngayLap = hoaDon.NgayLap.Date;

                if (doanhThuDoAnTheoNgay.ContainsKey(ngayLap))
                {
                    doanhThuDoAnTheoNgay[ngayLap] += tongTienDoAn;
                }
                else
                {
                    doanhThuDoAnTheoNgay[ngayLap] = tongTienDoAn;
                }
            }
            return doanhThuDoAnTheoNgay;
        }
        public Dictionary<DateTime, int> LaySoLuongHoaDonTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDon> danhSachHoaDon = hoaDonDL.TimKiem("", "", "", tuNgay, denNgay);
            return danhSachHoaDon.GroupBy(hd => hd.NgayLap.Date)
                                 .ToDictionary(g => g.Key, g => g.Count());
        }
    }

}

