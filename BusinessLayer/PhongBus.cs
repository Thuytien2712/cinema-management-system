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
    public class PhongBUS
    {
        DAL_Phong dal = new DAL_Phong();

        public bool ThemPhong(PhongDTO phong)
        {
            return dal.ThemPhong(phong);
        }

        public bool KiemTraTenPhong(string tenPhong)
        {
            return dal.KiemTraTenPhong(tenPhong);
        }

        public bool KiemTraMaPhong(string maPhong)
        {
            return dal.KiemTraMaPhong(maPhong);
        }

        public DataTable TimKiemPhong(string maPhong, string tenPhong)
        {
            return dal.TimKiemPhong(maPhong, tenPhong);
        }

        public bool XoaPhong(string maPhong)
        {
            return dal.XoaPhong(maPhong);
        }

        public DataTable GetTatCaPhong()
        {
            return dal.GetTatCaPhong();
        }

    }

}
