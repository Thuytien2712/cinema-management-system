using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class BLL_Phim
    {
        DAL_Phim dal = new DAL_Phim();
        public DataTable GetPhim()
        {
            return dal.GetAllPhim();
        }

        public bool KiemTraMaPhim(string maSC)
        {
            return dal.KiemTraMaPhim(maSC);
        }

        public bool ThemPhim(PhimDTO phim)
        {
            return dal.ThemPhim(phim);
        }

        public List<PhimDTO> TimKiemPhim(string maPhim, string tenPhim, string theLoai)
        {
            return dal.TimKiemPhim(maPhim, tenPhim, theLoai);
        }

        public bool XoaPhim(string maPhim)
        {
            return dal.XoaPhim(maPhim);
        }

        public List<PhimDTO> LayPhim24hToi()
        {
            return dal.LayPhim24hToi();
        }
        public DataTable LayDanhSachPhim()
        {
            return dal.LayDanhSachPhim();
        }
    }

}
