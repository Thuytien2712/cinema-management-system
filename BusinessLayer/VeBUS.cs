using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace BusinessLayer
{
    public class VeBUS
    {
        private DAL_Ve veDAL = new DAL_Ve();

        public void ThemVe(VeDTO ve)
        {
            veDAL.ThemVe(ve);
        }
    }

}
