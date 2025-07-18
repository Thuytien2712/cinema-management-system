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
using TransferObject;

namespace Rapchieuphim
{
    public partial class QlSuatChieu : Form
    {
        public QlSuatChieu()
        {
            InitializeComponent();
            //test
        }

        SuatChieuBUS bus = new SuatChieuBUS();
        BLL_Phim bllPhim = new BLL_Phim();
        BLL_Phong bllPhong = new BLL_Phong();


        private void QlSuatChieu_Load(object sender, EventArgs e)
        {
            LoadComboBox(); // Khi form load, gọi hàm để load dữ liệu
        }

        private void LoadComboBox()
        {
            comboBoxPhim.DataSource = bllPhim.GetPhim();
            comboBoxPhim.DisplayMember = "TenPhim";
            comboBoxPhim.ValueMember = "MaPhim";

            comboBoxPhong.DataSource = bllPhong.GetPhong();
            comboBoxPhong.DisplayMember = "id_phong";
            comboBoxPhong.ValueMember = "id_phong";

            //đây nè Huỳn 
            var dt = suatChieuBUS.TimKiemSuatChieu(null, null, null);
            dtGVQLSuatChieu.DataSource = dt;
            //đây nè Huỳn 
        }

        private SuatChieuBUS suatChieuBUS = new SuatChieuBUS();

        private void btnthem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (comboBoxPhong.SelectedIndex == -1 
                || comboBoxPhim.SelectedIndex == -1 
                || textBoxSC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã suất chiếu, chọn mã phòng và mã phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy dữ liệu
            string maSC = textBoxSC.Text;
            string maPhong = comboBoxPhong.SelectedValue.ToString();
            string maPhim = comboBoxPhim.SelectedValue.ToString();
            DateTime batDau = dtPthoigianchieu.Value;
            DateTime ketThuc = dtPthoigianhet.Value;

            // 3. Kiểm tra thời gian
            if (batDau >= ketThuc)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Kiểm tra trùng suất chiếu (cùng phòng, cùng ngày, và thời gian bị giao nhau)
            if (suatChieuBUS.KiemTraTrungSuatChieu(maPhong, batDau, ketThuc))
            {
                MessageBox.Show("Suất chiếu đã bị trùng thời gian với một suất khác trong cùng phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Kiểm tra mã sc đã tồn tại chưa
            if (bus.KiemTraMaSC(maSC))
            {
                MessageBox.Show("Mã suất chiếu đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SuatChieuDTO sc = new SuatChieuDTO() 
            {
                MaSC = maSC,
                TgBatDau = batDau.TimeOfDay,
                TgKetThuc = ketThuc.TimeOfDay,
                NgayChieu = batDau.Date ,
                MaPhim = maPhim,
                IdPhong = maPhong
            };

            bool result = suatChieuBUS.ThemSuatChieu(sc);

            if (result)
            {
                MessageBox.Show("Thêm suất chiếu thành công!");
                // Reset các control về mặc định
                textBoxSC.Clear();
                comboBoxPhong.SelectedIndex = -1;
                comboBoxPhim.SelectedIndex = -1;
                dtPthoigianchieu.Value = DateTime.Now;
                dtPthoigianhet.Value = DateTime.Now;

                // (Tuỳ chọn) Focus lại vào TextBox đầu tiên
                textBoxSC.Focus();
                textBoxSC.Focus();
                var dt = suatChieuBUS.TimKiemSuatChieu(null, null, null);
                dtGVQLSuatChieu.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Thêm suất chiếu thất bại!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maSC = textBoxSC.Text.Trim();

            string tenPhim = comboBoxPhim.SelectedIndex >= 0 ? comboBoxPhim.SelectedValue.ToString() : "";
            string maPhong = comboBoxPhong.SelectedIndex >= 0 ? comboBoxPhong.SelectedValue.ToString() : "";

            var dt = suatChieuBUS.TimKiemSuatChieu(maSC, tenPhim, maPhong);
            dtGVQLSuatChieu.DataSource = dt;

        }


        private string maSuatChieuDangChon = "";
        private void dtGVQLSuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVQLSuatChieu.Rows[e.RowIndex];
                maSuatChieuDangChon = row.Cells["MaSC"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSuatChieuDangChon))
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa suất chiếu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = suatChieuBUS.XoaSuatChieu(maSuatChieuDangChon);
                if (kq)
                {
                    //đây nè Huỳn 
                    foreach (DataGridViewRow row in dtGVQLSuatChieu.Rows)
                    {
                        if (row.Cells["MaSC"].Value.ToString() == maSuatChieuDangChon)
                        {
                            // Hủy chọn nếu đang chọn dòng này
                            if (row.Index == dtGVQLSuatChieu.CurrentCell?.RowIndex)
                            {
                                dtGVQLSuatChieu.CurrentCell = null; // ✅ Deselect trước
                            }

                            row.Visible = false; // ✅ Ẩn an toàn
                            break;
                        }
                    }
                    //đây nè Huỳn 


                    MessageBox.Show("Đã xóa thành công!");
                    maSuatChieuDangChon = null; // reset
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại.");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
