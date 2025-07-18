using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class QLYTAIKHOANBL
    {
        private QLyTaiKhoanDL qltkdl = new QLyTaiKhoanDL();
        public List<Account> accounts = new List<Account>();
        public List<Account> LayDanhSach()
        {
            return qltkdl.LayDanhSach();
        }
        public int ThemTaiKhoan(Account account)
        {
            return qltkdl.ThemTaiKhoan(account);
        }
        public int SuaTaiKhoan(Account account)
        {
            return qltkdl.SuaTaiKhoan(account);
        }
        public int XoaTaiKhoan(Account account)
        {
            return qltkdl.XoaTaiKhoan(account);
        }


    }
}
