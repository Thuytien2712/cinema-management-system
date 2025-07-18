using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string Id_nv { get; set; }

        public string Chucvu { get; set; }

        public Account(string email, string matkhau)
        {
            this.Email = email;
            this.MatKhau = matkhau;
        }

        public Account(string email, string matkhau, string chucvu)
        {
            this.Email = email;
            this.MatKhau = matkhau;
            this.Chucvu = chucvu;
        }

        public Account(string email, string matkhau, string id_nv, string chucvu)
        {
            this.Email = email;
            this.MatKhau = matkhau;
            this.Id_nv = id_nv;
            this.Chucvu = chucvu;
        }

        public Account(string id_nv)
        {
            this.Id_nv = id_nv;
            
        }
        public Account() { }
    }

}