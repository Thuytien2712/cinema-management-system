using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Principal;
using BusinessLayer;
using TransferObject;
namespace Rapchieuphim
{
    public partial class frmdangnhap : Form
    {
        private LoginBL loginBL;
        public frmdangnhap()
        {
            InitializeComponent();
            loginBL = new LoginBL();

        }


        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string email = txtdangnhap.Text.Trim();
            string password = txtpassword.Text;

            Account acc = new Account(email, password);
            Account result = loginBL.LoginWithRole(acc); // gọi Login mới

            if (result != null)
            {
                // MessageBox.Show("Đăng nhập thành công!", "Login");

                // Phân quyền theo Chức vụ
                if (result.Chucvu == "Quản lý")
                {
                    Quanly formQL = new Quanly(result); // form giao diện quản lý
                    formQL.Show();
                }
                else if (result.Chucvu == "Nhân viên")
                {
                    NhanVien formNV = new NhanVien(result); // form giao diện nhân viên
                    formNV.Show();
                    
                }

                this.Hide(); // ẩn form đăng nhập
            }
            else
            {
                string msg = "Email hoặc mật khẩu không đúng!";
                DialogResult dialog = MessageBox.Show(msg, "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Retry)
                {
                    txtpassword.Clear();
                    txtdangnhap.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }


        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Hide(); // ẩn form đăng nhập

            frmhome home = new frmhome();
            home.Show();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
