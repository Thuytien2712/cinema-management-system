using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class DoAnDTO
    {
        public string Id_do_an { get; set; }
        public string Ten { get; set; }
        public string Id_loai { get; set; }
        public decimal Gia { get; set; }
        public string So_luong { get; set; }
        public string Sl_con_lai { get; set; }


        public DoAnDTO(string id_do_an, string ten, string id_loai, decimal gia, string so_luong, string sl_con_lai)
        {
            Id_do_an = id_do_an;
            Ten = ten;
            Id_loai = id_loai;
            Gia = gia;
            So_luong = so_luong;
            Sl_con_lai = sl_con_lai;
        }

        public DoAnDTO( string ten, string id_loai, decimal gia, string so_luong, string sl_con_lai)
        {
            Ten = ten;
            Id_loai = id_loai;
            Gia = gia;
            So_luong = so_luong;
            Sl_con_lai = sl_con_lai;
        }

        public DoAnDTO(string id_do_an)
        {
            Id_do_an = id_do_an;
        }

        public DoAnDTO(string id_do_an, string ten, decimal gia)
        {
            Id_do_an = id_do_an;
            Ten = ten;
            Gia = gia;
        }

        public DoAnDTO()
        {
        }
    }
}
