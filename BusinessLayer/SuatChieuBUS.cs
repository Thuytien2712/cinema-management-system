using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class SuatChieuBUS
    {
        private SuatChieuDAL dal = new SuatChieuDAL();

        public bool ThemSuatChieu(SuatChieuDTO sc)
        {
            return dal.ThemSuatChieu(sc);
        }

        public bool KiemTraTrungSuatChieu(string maPhong, DateTime batDauMoi, DateTime ketThucMoi)
        {
            List<SuatChieuDTO> danhSach = dal.LaySuatChieuTheoPhongVaNgay(maPhong, batDauMoi.Date);

            foreach (var sc in danhSach)
            {
                DateTime batDauCu = sc.NgayChieu.Date + sc.TgBatDau;
                DateTime ketThucCu = sc.NgayChieu.Date + sc.TgKetThuc;

                // Giao nhau nếu không tách biệt
                if (!(ketThucMoi <= batDauCu || batDauMoi >= ketThucCu))
                {
                    return true; // Giao nhau
                }
            }

            return false; // Không trùng
        }

        public bool KiemTraMaSC(string maSC)
        {
            return dal.KiemTraMaSC(maSC);
        }

        public List<SuatChieuDTO> TimKiemSuatChieu(string maSC, string maPhim, string maPhong)
        {
            return dal.TimKiemSuatChieu(maSC, maPhim, maPhong);
        }

        public bool XoaSuatChieu(string maSC)
        {
            return dal.XoaSuatChieu(maSC);
        }

        //ham dùng cho hiển thị trên hóa đơn
        public (string TenPhim, TimeSpan GioBatDau, DateTime NgayChieu, string MaPhong) LayThongTinPhimTheoSuatChieu(string idSuatChieu)
        {
            return dal.LayThongTinPhimTheoSuatChieu(idSuatChieu);
        }
    }
}
