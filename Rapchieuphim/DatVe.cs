using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TransferObject;

namespace Rapchieuphim
{
    public partial class DatVe : Form
    {
        private List<GheDTO> gheDaChon;
        private int tongSoLuongGheDaChon;
        BLL_LoaiVe bll = new BLL_LoaiVe();
        VeBUS bllve = new VeBUS();
        private string MaSC;
        public List<ChiTietHoaDonVe> DanhSachChiTietHoaDonVe;

        public DatVe(List<GheDTO> gheDaChon, string MaSC)
        {
            InitializeComponent();
            this.gheDaChon = gheDaChon;
            this.MaSC = MaSC;
            tongSoLuongGheDaChon = gheDaChon.Count; // Tổng số lượng ghế đã chọn
        }

        private void LoadLoaiVe()
        {
            List<LoaiVeDTO> ve = bll.LayDanhSachLoaiVe();

            foreach (var v in ve)
            {
                // Tạo Panel cho mỗi loại vé
                Panel panel = new Panel
                {
                    Width = 400,
                    Height = 40,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = v
                };

                // Thêm Label hiển thị thông tin vé
                Label label = new Label
                {
                    Text = $"{v.Ten} - {v.GiaVe} VNĐ",
                    Dock = DockStyle.Top
                };
                panel.Controls.Add(label);

                // Thêm ComboBox để chọn số lượng
                ComboBox quantityComboBox = new ComboBox
                {
                    Dock = DockStyle.Bottom,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                // Giới hạn số lượng vé có thể chọn
                for (int i = 0; i <= tongSoLuongGheDaChon; i++) // Giới hạn số lượng tối đa theo số ghế đã chọn
                {
                    quantityComboBox.Items.Add(i);
                }

                // Mặc định chọn số lượng 1
                quantityComboBox.SelectedIndex = 0;
                panel.Controls.Add(quantityComboBox);

                // Thêm Panel vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(panel);
            }

            // Hiển thị danh sách ghế đã chọn
            foreach (var ghe in gheDaChon)
            {
                labelGhe.Text = labelGhe.Text + " " + ghe.ViTri;
            }
        }

        private void DatVe_Load(object sender, EventArgs e)
        {
            LoadLoaiVe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tongSoLuongVe = 0;
            double tongTienVe = 0;
            double tongTienPhuThu = 0;

            // Tính tổng số lượng vé và tiền vé từ tất cả ComboBox
            foreach (Panel panel in flowLayoutPanel1.Controls)
            {
                ComboBox comboBox = panel.Controls.OfType<ComboBox>().FirstOrDefault();
                if (comboBox != null && comboBox.SelectedItem != null)
                {
                    int soLuongVaoComboBox = (int)comboBox.SelectedItem;
                    tongSoLuongVe += soLuongVaoComboBox;

                    // Tính tiền vé cho mỗi loại vé
                    LoaiVeDTO loaiVe = (LoaiVeDTO)panel.Tag; // Gán LoaiVeDTO vào Tag của panel khi tạo
                    tongTienVe += loaiVe.GiaVe * soLuongVaoComboBox;
                }
            }

            // Kiểm tra nếu tổng số lượng vé khác số ghế đã chọn
            if (tongSoLuongVe != tongSoLuongGheDaChon)
            {
                MessageBox.Show("Tổng số lượng vé phải bằng số ghế đã chọn. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var ghe in gheDaChon)
            {
                tongTienPhuThu += ghe.PhuThu;
            }

            // Tính tổng tiền
            double tongTien = tongTienVe + tongTienPhuThu;

            DialogResult result = MessageBox.Show($"Tổng tiền: {tongTien:N0} VND\nBạn có muốn xác nhận đặt vé?", "Xác nhận đặt vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gọi hàm lưu vé
                TaoDanhSachChiTietHoaDonVe();

                // 2. Truyền dữ liệu vé và đồ ăn (nếu có) vào frmHoaDon
                frmHoaDon hoaDonForm = new frmHoaDon(DanhSachChiTietHoaDonVe);


                frmbanhang Frmbanhang = new frmbanhang(DanhSachChiTietHoaDonVe);
                Frmbanhang.ShowDialog();

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }
        

        private void TaoDanhSachChiTietHoaDonVe()
        {
            DanhSachChiTietHoaDonVe = new List<ChiTietHoaDonVe>();
            int gheIndex = 0;

            foreach (Panel panel in flowLayoutPanel1.Controls)
            {
                ComboBox comboBox = panel.Controls.OfType<ComboBox>().FirstOrDefault();
                if (comboBox != null && comboBox.SelectedItem != null)
                {
                    int soLuongVe = (int)comboBox.SelectedItem;
                    if (soLuongVe > 0)
                    {
                        LoaiVeDTO loaiVe = (LoaiVeDTO)panel.Tag;

                        for (int i = 0; i < soLuongVe; i++)
                        {
                            var ghe = gheDaChon[gheIndex];

                            DanhSachChiTietHoaDonVe.Add(new ChiTietHoaDonVe
                            {
                                MaHD = 0, // gán sau khi có mã hóa đơn
                                IdSuatChieu = MaSC,
                                IdGhe = ghe.IdGhe,
                                IdLoaiVe = loaiVe.IdLoaiVe,
                                GiaVe = (decimal)(loaiVe.GiaVe + ghe.PhuThu)
                            });

                            gheIndex++;
                        }
                    }
                }
            }
        }


    }
}