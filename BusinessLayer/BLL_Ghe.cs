using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class BLL_Ghe
    {
        DAL_Ghe gheDAL = new DAL_Ghe();

        public List<GheDTO> LayDanhSachGhe(string idPhong)
        {
            return gheDAL.LayDanhSachGheTheoPhong(idPhong);
        }
    }
}
