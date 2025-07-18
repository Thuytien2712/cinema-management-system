using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLL_DDPhim
    {
        DAL_DDPhim dal = new DAL_DDPhim();
        public DataTable GetDDPhim()
        {
            return dal.GetAllDDPhim();
        }
    }
}
