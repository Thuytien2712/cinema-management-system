using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Rapchieuphim
{
    public partial class Phongchieu : Form
    {
        BLL_Ghe gheBUS = new BLL_Ghe();
        List<GheDTO> gheDuocChon = new List<GheDTO>();
        private string MaSC;

        public Phongchieu()
        {
            InitializeComponent();
        }

        public Phongchieu(string idPhong, string MaSC)
        {
            InitializeComponent();
            labelPhong.Text = labelPhong.Text + idPhong;
            HienThiGhe(idPhong);
            this.MaSC = MaSC;
        }

        private void HienThiGhe(string idPhong)
        {
            pnlGhe.Controls.Clear();
            List<GheDTO> dsGhe = gheBUS.LayDanhSachGhe(idPhong);

            int x = 10, y = 10, count = 0;
            foreach (var ghe in dsGhe)
            {
                Button btn = new Button();
                btn.Text = ghe.ViTri + "\n+" + ghe.PhuThu + "đ";
                btn.Tag = ghe;
                btn.Size = new Size(60, 50);
                btn.BackColor = ghe.IdGhe == "VIP" ? Color.Gold : Color.LightGray;

                btn.Click += (s, e) =>
                {
                    Button b = s as Button;
                    GheDTO g = (GheDTO)b.Tag;

                    if (b.BackColor == Color.Green)
                    {
                        b.BackColor = g.TenLoaiGhe == "VIP" ? Color.Gold : Color.LightGray;
                        gheDuocChon.RemoveAll(item => item.IdGhe == g.IdGhe);
                    }
                    else
                    {
                        b.BackColor = Color.Green;
                        gheDuocChon.Add(g);
                    }
                };

                btn.Location = new Point(x, y);
                pnlGhe.Controls.Add(btn);

                x += 84;
                count++;
                if (count % 10 == 0)
                {
                    x = 10;
                    y += 60;
                }
            }

            // Tạo nút Đặt vé
            Button btnDatVe = new Button();
            btnDatVe.Text = "Chọn ghế";
            btnDatVe.Size = new Size(100, 40);
            btnDatVe.Location = new Point(10, y + 70); // Đặt phía dưới hàng ghế cuối
            btnDatVe.BackColor = Color.DodgerBlue;
            btnDatVe.ForeColor = Color.White;

            btnDatVe.Click += (s, e) =>
            {
                if (gheDuocChon.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo");
                    return;
                }

                List<GheDTO> danhSachGheDaChon = new List<GheDTO>();

                // Duyệt qua danh sách ghế đã chọn và thêm thông tin vào danh sách danhSachGheDaChon
                foreach (var ghe in gheDuocChon)
                {
                    // Giả sử ghe có các thuộc tính cần thiết: id_ghe, vi_tri, id_phong, id_loai_ghe
                    GheDTO gheDTO = new GheDTO
                    {
                        IdGhe = ghe.IdGhe,          // id_ghe
                        ViTri = ghe.ViTri,          // vi_tri
                        IdPhong = ghe.IdPhong,      // id_phong
                        TenLoaiGhe = ghe.TenLoaiGhe, // id_loai_ghe
                        PhuThu = ghe.PhuThu
                    };
                    danhSachGheDaChon.Add(gheDTO);
                }

                // Hiển thị xác nhận
                string text = string.Join(", ", danhSachGheDaChon.Select(g => g.ViTri));
                DialogResult result = MessageBox.Show(
                    $"Ghế đã chọn: {text}\n\nBạn có chắc chắn muốn đặt vé?",
                    "Xác nhận đặt vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DatVe formTinhTien = new DatVe(danhSachGheDaChon, MaSC);
                    this.Close();
                    formTinhTien.ShowDialog();
                    
                }
            };



            pnlGhe.Controls.Add(btnDatVe);
        }

    }
}
