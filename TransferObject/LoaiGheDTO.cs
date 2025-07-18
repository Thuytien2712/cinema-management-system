using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class LoaiGheDTO
    {
        public string IdLoaiGhe { get; set; }
        public string Ten { get; set; }
        public int PhuThu { get; set; } // Phụ thu thêm vào giá vé
    }

}
