using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Rapchieuphim
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QLPhim());
            //Application.Run(new QLNVien());
            //Application.Run(new QLKhachHang());
            //Application.Run(new QLDoan());
            Application.Run(new frmhome());
            //Application.Run(new frmbanhang());
            //Application.Run(new TimKiemPhim());

        }
    }

}
