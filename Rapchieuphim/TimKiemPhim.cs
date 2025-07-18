using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Rapchieuphim
{
    public partial class TimKiemPhim : Form
    {
        BLL_Phim bllPhim = new BLL_Phim();

        public TimKiemPhim()
        {
            InitializeComponent();
        }

        private void HienThiPhim24hToi()
        {
            var danhSachPhim = bllPhim.LayPhim24hToi();
            HienThiPhim(danhSachPhim);
        }

        private void HienThiPhim(List<PhimDTO> danhSachPhim)
        {
            pnlChitietphim.Controls.Clear();

            int y = 10;
            foreach (var phim in danhSachPhim)
            {
                // PictureBox
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 100);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.BorderStyle = BorderStyle.FixedSingle;

                try
                {
                    var img = (Image)Properties.Resources.ResourceManager.GetObject(phim.HinhAnh);
                    pic.Image = img ?? Properties.Resources.qlphm;
                }
                catch
                {
                    pic.Image = Properties.Resources.qlphm;
                }
                pic.Location = new Point(7, 7);

                // Label tên phim
                Label lblTen = new Label();
                lblTen.Text = phim.TenPhim;
                lblTen.Font = new Font("Arial", 10, FontStyle.Bold);
                lblTen.Location = new Point(120, 10);
                lblTen.AutoSize = true;

                // Label ngày khởi chiếu
                Label lblNgay = new Label();
                lblNgay.Text = "Ngày khởi chiếu: " + phim.NgayKhoiChieu.ToString("dd/MM/yyyy");
                lblNgay.Location = new Point(120, 35);
                lblNgay.AutoSize = true;

                // Label mô tả
                Label lblMoTa = new Label();
                lblMoTa.Text = phim.MoTaNoiDung.Length > 300 ? phim.MoTaNoiDung.Substring(0, 300) + "..." : phim.MoTaNoiDung;
                lblMoTa.Font = new Font("Arial", 8, FontStyle.Regular);
                lblMoTa.Location = new Point(120, 55);
                lblMoTa.Size = new Size(450, 50);
                lblMoTa.AutoSize = false;

                // Nút chọn lịch
                Button btnLich = new Button();
                btnLich.Text = "Chọn lịch";
                btnLich.Size = new Size(90, 30);
                btnLich.Location = new Point(610, 20);
                // Gắn cả mã phim và tên phim để truyền
                btnLich.Tag = Tuple.Create(phim.MaPhim, phim.TenPhim);

                btnLich.Click += (s, e) =>
                {
                    var tag = (s as Button).Tag as Tuple<string, string>;
                    string maPhim = tag.Item1;
                    string tenPhim = tag.Item2;

                    LichChieu frm = new LichChieu(maPhim, tenPhim); // Gọi form lịch chiếu
                    frm.ShowDialog();
                    ///
                    this.Close();
                };


                // Panel chứa phim
                Panel item = new Panel();
                item.Size = new Size(730, 120);
                item.Location = new Point(10, y);
                item.BorderStyle = BorderStyle.FixedSingle;

                item.Controls.Add(pic);
                item.Controls.Add(lblTen);
                item.Controls.Add(lblNgay);
                item.Controls.Add(lblMoTa);
                item.Controls.Add(btnLich);

                pnlChitietphim.Controls.Add(item);
                y += 130;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tenPhim = textBoxTen.Text.Trim();

            // Gọi phương thức tìm kiếm phim từ PhimBUS
            var dt = bllPhim.TimKiemPhim(null, tenPhim, null);

            // Hiển thị kết quả tìm kiếm lên DataGridView
            HienThiPhim(dt);
        }

        private void TimKiemPhim_Load(object sender, EventArgs e)
        {
            HienThiPhim24hToi();
        }
    }
}
