using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class LoaiVeBUS
    {
        private LoaiVeDAL dal = new LoaiVeDAL();

        public List<LoaiVeDTO> LayDanhSachLoaiVe()
        {
            return dal.LayDanhSachLoaiVe();
        }
    }
}
