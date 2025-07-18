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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            frmdangnhap formDangNhap = new frmdangnhap();
            formDangNhap.ShowDialog();
            this.Hide();
        }

        private void frmhome_Load(object sender, EventArgs e)
        {

        }
    }
}
