using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Rapchieuphim
{
    public partial class NhanVien : Form
    {
        private Account currentAccount;
        public NhanVien()
        {
            InitializeComponent();
        }

        public NhanVien(Account acc)
        {
            InitializeComponent();
            currentAccount = acc;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDKLL_Click(object sender, EventArgs e)
        {
            TimKiemPhim timKiemPhim = new TimKiemPhim();
            this.Hide();
            timKiemPhim.ShowDialog();
            this.Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = currentAccount.Id_nv;
        }

        private void lblTTCN_Click(object sender, EventArgs e)
        {

        }

        private void lblBH_Click(object sender, EventArgs e)
        {
            frmbanhang FormBanHang = new frmbanhang();
            this.Hide();
            FormBanHang.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();

            frmhome home = new frmhome();
            home.Show();
        }
    }
}
