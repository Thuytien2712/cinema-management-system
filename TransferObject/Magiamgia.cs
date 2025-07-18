using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class MaGiamGia
    {
        
            public string MaGG { get; set; }
            public int PhanTramGiam { get; set; }
            public int GiamToiDa { get; set; }
            public string DieuKien { get; set; }
            public DateTime NgayBatDau { get; set; }
            public DateTime NgayKetThuc { get; set; }
            public int DonToiThieu { get; set; }
            
   

        public MaGiamGia() { }

        public MaGiamGia(string magg, int phantramgiam, int giamtoida, string dieukien, DateTime ngaybatdau, DateTime ngayketthuc, int dontoithieu, int soluong, int dasudung, string mota)
        {
            this.MaGG= magg;
            this.PhanTramGiam = phantramgiam;
            this.GiamToiDa = giamtoida;
            this.DieuKien = dieukien;
            this.NgayBatDau = ngaybatdau;
            this.NgayKetThuc = ngayketthuc;
     

        }

      
    }

}
