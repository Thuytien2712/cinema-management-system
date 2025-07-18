using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class LoaiGheBUS
    {
        private LoaiGheDAL dal = new LoaiGheDAL();

        public List<LoaiGheDTO> LayDanhSachLoaiGhe()
        {
            return dal.LayDanhSachLoaiGhe();
        }
    }
}
