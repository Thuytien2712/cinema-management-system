using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class GheDaChonDTO
    {
        public string ViTri { get; set; }               // VD: A5, B7
        public LoaiVeDTO LoaiVe { get; set; }           // Vé người lớn, sinh viên,...
        public LoaiGheDTO LoaiGhe { get; set; }         // Ghế thường, VIP,...

        public int ThanhTien => LoaiVe.GiaVe + LoaiGhe.PhuThu;
    }

}
