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
    public partial class Quanly : Form
    {
        private Account currentAccount;
        public Quanly()
        {
            InitializeComponent();
        }

        public Quanly(Account acc)
        {
            InitializeComponent();
            currentAccount = acc;
        }

        private void lblQLGG_Click(object sender, EventArgs e)
        {
            QLYMaGG qlmgg = new QLYMaGG();
            this.Hide();
            qlmgg.ShowDialog();
          
            this.Show();
        }

        private void pnlQLGG_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void lblQLTD_Click(object sender, EventArgs e)
        {
            QLTichDiem qltd = new QLTichDiem();
            this.Hide();
            qltd.ShowDialog();
            this.Show();
        }

        private void lblQLNV_Click(object sender, EventArgs e)
        {
            QLNVien formQLNV = new QLNVien();
            this.Hide();

            formQLNV.ShowDialog();
            this.Show();
        }

        private void lblQLSC_Click(object sender, EventArgs e)
        {
            QlSuatChieu formQLSC = new QlSuatChieu();
            this.Hide();

            formQLSC.ShowDialog();
            this.Show();
        }

        private void lblQLKH_Click(object sender, EventArgs e)
        {
            QLKhachHang formQLKH = new QLKhachHang();
            this.Hide();

            formQLKH.ShowDialog();
            this.Show();
        }

        private void lblQLPhim_Click(object sender, EventArgs e)
        {
            QLPhim formQLPhim = new QLPhim();
            this.Hide();
            formQLPhim.ShowDialog();
            this.Show();
        }

        private void lblQLPC_Click(object sender, EventArgs e)
        {
            QLPhongChieu formQLPC = new QLPhongChieu();
            this.Hide();

            formQLPC.ShowDialog();
            this.Show();
        }

        private void lblQLdoan_Click(object sender, EventArgs e)
        {
            QLDoan formQLDoan = new QLDoan();
            this.Hide();
            formQLDoan.ShowDialog();
            this.Show();
        }

        private void lblQLTaiKhoan_Click(object sender, EventArgs e)
        {
            QLyTaiKhoan QLTK = new QLyTaiKhoan();
            this.Hide();
            QLTK.ShowDialog();
            this.Show();
        }

        private void lblQLDoanhThu_Click(object sender, EventArgs e)
        {
            QLyDoanhThu QLDT = new QLyDoanhThu();
            this.Hide();
            QLDT.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();

            frmhome home = new frmhome();
            home.Show();
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = currentAccount.Id_nv;
        }

        private void lblQLHD_Click(object sender, EventArgs e)
        {
            QLHoaDon QLHD = new QLHoaDon();
            this.Hide();
            QLHD.ShowDialog();
            this.Show();
        }
    }
}
