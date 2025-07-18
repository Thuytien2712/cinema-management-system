using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLL_Phong
    {
        DAL_Phong dal = new DAL_Phong();
        public DataTable GetPhong()
        {
            return dal.GetAllPhong();
        }
    }

}
