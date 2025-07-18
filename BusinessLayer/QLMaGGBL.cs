using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

using TransferObject;

namespace BusinessLayer
{
    public class QLMaGGBL
    {

        private QLMaGGDL qlmggdl = new QLMaGGDL();

        public List<MaGiamGia> LayTatCa()
        {
            return qlmggdl.LayDanhSach();
        }

        public int ThemMaGiamGia(MaGiamGia magiamgia)
        {

            if (magiamgia.NgayBatDau >= magiamgia.NgayKetThuc)
            {
                throw new ArgumentException("Ngày kết thúc phải sau ngày bắt đầu.");
            }

            return qlmggdl.ThemMaGiamGia(magiamgia);
        }


        public int SuaMaGiamGia(MaGiamGia magiamgia)
        {
            return qlmggdl.SuaMaGiamGia(magiamgia);
        }

        public int XoaMaGiamGia(MaGiamGia magiamgia)
        {
            return qlmggdl.XoaMaGiamGia(magiamgia);
        }

        public List<MaGiamGia> LayMaGiamGiaHopLe(int tongTien)
        {
            var ds = qlmggdl.LayDanhSach();
            DateTime now = DateTime.Now;

            return ds.Where(m =>
                now >= m.NgayBatDau &&
                now <= m.NgayKetThuc &&
                tongTien >= m.DonToiThieu
            ).ToList();
        }

        public int TinhTienGiam(int tongTien, MaGiamGia mgg)
        {
            if (mgg == null || tongTien < mgg.DonToiThieu)
                return 0;

            int tienGiam = (tongTien * mgg.PhanTramGiam) / 100;
            if (mgg.GiamToiDa > 0 && tienGiam > mgg.GiamToiDa)
                tienGiam = mgg.GiamToiDa;

            return tienGiam;
        }


    }
}
