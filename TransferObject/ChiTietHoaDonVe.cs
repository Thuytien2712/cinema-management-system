using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class ChiTietHoaDonVe
    {
        public int MaHD { get; set; }
        public string IdSuatChieu { get; set; }
        public string IdGhe { get; set; }
        public decimal GiaVe { get; set; }
        public string IdLoaiVe { get; set; } // << Thêm dòng này

        public ChiTietHoaDonVe() { }

        public ChiTietHoaDonVe(int maHD, string idSuatChieu, string idGhe, decimal giaVe, string idLoaiVe)
        {
            MaHD = maHD;
            IdSuatChieu = idSuatChieu;
            IdGhe = idGhe;
            GiaVe = giaVe;
            IdLoaiVe = idLoaiVe;
        }
    }

}
