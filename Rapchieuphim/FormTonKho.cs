using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rapchieuphim
{
    public partial class FormTonKho : Form
    {
        private DoAnBL doanBL = new DoAnBL();
        public FormTonKho()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTonKho_Load(object sender, EventArgs e)
        {
            try
            {
                DoAnBL doAnBL = new DoAnBL();
                DataTable dt = doAnBL.LayDanhSachMonConHang();
                dgvDsMonCon.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
