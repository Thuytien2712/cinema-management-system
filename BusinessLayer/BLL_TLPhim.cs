using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLL_TLPhim
    {
        DAL_TLPhim dal = new DAL_TLPhim();
        public DataTable GetTLPhim()
        {
            return dal.GetAllTLPhim();
        }
    }
}
