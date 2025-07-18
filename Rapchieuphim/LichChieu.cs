using BusinessLayer;
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
    public partial class LichChieu : Form
    {
        SuatChieuBUS bus = new SuatChieuBUS();
        public LichChieu()
        {
            InitializeComponent();
        }

        private string maPhim;
        private string tenPhim;

        public LichChieu(string maPhim, string tenPhim)
        {
            InitializeComponent();
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
        }


        private void LichChieu_Load(object sender, EventArgs e)
        {
            HienThiSuatChieu(maPhim, tenPhim);
        }

        private void HienThiSuatChieu(string maPhim, string tenPhim)
        {
            labelTen.Text = labelTen.Text + tenPhim;


            var ds = bus.TimKiemSuatChieu(null, maPhim, null);

            panelSC.Controls.Clear();
            panelSC.AutoScroll = true;

            var danhSachSuat = ds.Where(s =>
                s.NgayChieu > DateTime.Today ||
                (s.NgayChieu == DateTime.Today && s.TgBatDau > DateTime.Now.TimeOfDay)
            ).ToList();

            int y = 10;

            foreach (var sc in danhSachSuat)
            {
                Panel item = new Panel();
                item.Size = new Size(750, 110);
                item.Location = new Point(30, y);
                item.BorderStyle = BorderStyle.FixedSingle;

                // Ngày chiếu
                Label lblNgay = new Label();
                lblNgay.Text = $"📅 Ngày chiếu: {sc.NgayChieu:dd/MM/yyyy}";
                lblNgay.Location = new Point(10, 10);
                lblNgay.AutoSize = true;

                // Giờ bắt đầu
                Label lblBatDau = new Label();
                lblBatDau.Text = $"🕒 Bắt đầu: {sc.TgBatDau:hh\\:mm}";
                lblBatDau.Location = new Point(10, 35);
                lblBatDau.AutoSize = true;

                // Giờ kết thúc
                Label lblKetThuc = new Label();
                lblKetThuc.Text = $"⏰ Kết thúc: {sc.TgKetThuc:hh\\:mm}";
                lblKetThuc.Location = new Point(10, 60);
                lblKetThuc.AutoSize = true;

                // Phòng chiếu
                Label lblPhong = new Label();
                lblPhong.Text = $"🏠 Phòng: {sc.IdPhong}";
                lblPhong.Location = new Point(10, 85);
                lblPhong.AutoSize = true;

                // Nút đặt vé
                Button btnDatVe = new Button();
                btnDatVe.Text = "Chọn ghế";
                btnDatVe.Location = new Point(650, 15);
                btnDatVe.Click += (s, e) =>
                {
                    var formDatVe = new Phongchieu(sc.IdPhong, sc.MaSC);
                    this.Close();
                    formDatVe.ShowDialog();
                };

                item.Controls.Add(lblNgay);
                item.Controls.Add(lblBatDau);
                item.Controls.Add(lblKetThuc);
                item.Controls.Add(lblPhong);
                item.Controls.Add(btnDatVe);

                panelSC.Controls.Add(item);
                y += item.Height + 10;
            }
        }

        private void panelSC_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
