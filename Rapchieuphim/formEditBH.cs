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
    public partial class formEditBH : Form
    {
        public formEditBH()
        {
            InitializeComponent();
        }

        public int SoLuongMoi { get; private set; }
        private int soLuongCu;
        public formEditBH(string tenSP, int soLuong, decimal donGia)
        {
            InitializeComponent();

            //gan dl 
            lblhientensp.Text = tenSP;
            numUpDownSL.Value = soLuong;
            lbhiengiatien.Text = donGia.ToString();
            lblhienThanhTien.Text = (soLuong * donGia).ToString();
            //luu sl cu de ktra co thay doi gi ko
            soLuongCu = soLuong;
            
            btnXacNhan.Enabled = false; //tat nut xác nhận nếu chưa đổi sl
            // Cập nhật thành tiền khi thay đổi số lượng
            numUpDownSL.ValueChanged += (s, e) =>   //xu ly su kien valuechanged
            {
                int sl = (int)numUpDownSL.Value;  
                lblhienThanhTien.Text = (sl * donGia).ToString();
                btnXacNhan.Enabled = (sl != soLuongCu); //chỉ bật khi số lượng đổi sl
            };
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SoLuongMoi = (int)numUpDownSL.Value; //gan gtri SoLuongMoi de frmbanhang co the lay dc slmoi
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
