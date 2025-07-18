using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class SuatChieuDTO
    {
        public string MaSC { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan TgBatDau { get; set; }
        public TimeSpan TgKetThuc { get; set; }
        public string MaPhim { get; set; }
        public string IdPhong { get; set; }
    }

}
