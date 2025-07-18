using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class TichDiem
    {
        public string id_tich_diem { get; set; }
        public DateTime ngay_tich_diem { get; set; }
        public int diem { get; set; }
        public string noi_dung { get; set; }
        public string id_kh { get; set; }
        public int Mahoadon { get; set; }

        public TichDiem(string noidung, int diem, string idkh, int mahoadon, DateTime ngaytichdiem)
        {

            this.ngay_tich_diem = ngaytichdiem;
            this.diem = diem;
            this.id_kh = idkh;
            this.Mahoadon = mahoadon;
            this.noi_dung = noi_dung;
            this.ngay_tich_diem = ngaytichdiem;
        }
        public TichDiem(string idtichdiem)
        {
            this.id_tich_diem = idtichdiem;
        }
        public TichDiem()
        {

        }

    }

}
