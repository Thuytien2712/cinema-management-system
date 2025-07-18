using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class VeDTO
    {
        public string IdVe { get; set; }
        public DateTime NgayBan { get; set; }
        public int TongTien { get; set; }
        public string SuatChieuId { get; set; }
        public string IdLoaiVe { get; set; }
        public string IdGhe { get; set; }
        public string IdKh { get; set; }  // Có thể null
        public string IdNv { get; set; }  // Có thể null
    }

}
