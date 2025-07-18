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
    public partial class QLPhongChieu : Form
    {
        public QLPhongChieu()
        {
            InitializeComponent();
        }

        PhongBUS bus = new PhongBUS();

        private void btnthem_Click(object sender, EventArgs e)
        {
            string id = txtmaphongchieu.Text.Trim();
            string ten = txtTen.Text.Trim();
            string soGheText = txtGhe.Text.Trim();

            // 1. Kiểm tra nhập đủ 3 trường
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(soGheText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra số ghế có phải là số không
            int soGhe;
            if (!int.TryParse(soGheText, out soGhe) || soGhe <= 0)
            {
                MessageBox.Show("Số ghế phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Kiểm tra trùng mã phòng
            if (bus.KiemTraMaPhong(id))
            {
                MessageBox.Show("Mã phòng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Kiểm tra trùng tên phòng
            if (bus.KiemTraTenPhong(ten))
            {
                MessageBox.Show("Tên phòng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PhongDTO phong = new PhongDTO()
            {
                IdPhong = id,
                TenPhong = ten,
                SoLuongGhe = soGhe
            };

            if (bus.ThemPhong(phong))
            {
                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhong();
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string maPhongDangChon = "";

        private void dtGVQLPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVQLPC.Rows[e.RowIndex];
                maPhongDangChon = row.Cells["id_phong"].Value.ToString();
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string maPhong = txtmaphongchieu.Text.Trim();
            string tenPhong = txtTen.Text.Trim();

            DataTable dt = bus.TimKiemPhong(maPhong, tenPhong);
            dtGVQLPC.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPhongDangChon))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = bus.XoaPhong(maPhongDangChon);
                if (kq)
                {
                    foreach (DataGridViewRow row in dtGVQLPC.Rows)
                    {
                        if (row.Cells["id_phong"].Value.ToString() == maPhongDangChon)
                        {
                            // hủy nếu đang chọn dòng này
                            if (row.Index == dtGVQLPC.CurrentCell?.RowIndex)
                            {
                                dtGVQLPC.CurrentCell = null; // ✅ Deselect trước
                            }
                            row.Visible = false; // ✅ Ẩn an toàn
                            break;
                        }
                    }

                    MessageBox.Show("Đã xóa phòng thành công!");
                    maPhongDangChon = null;
                }
                else
                {
                    // Thông báo lỗi đã xử lý bên DAL
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLPhongChieu_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhong(); // Khi form load, gọi hàm để load danh sách phòng chiếu

        }
        private void LoadDanhSachPhong()
        {
            // Gán danh sách phòng chiếu vào DataGridView
            PhongBUS phongBUS = new PhongBUS();
            var dt = phongBUS.GetTatCaPhong(); // đúng vì gọi qua instance

            dtGVQLPC.DataSource = dt;
            // Kiểm tra nếu DataGridView đã có cột thì mới gán HeaderText
            if (dtGVQLPC.Columns["id_phong"] != null)
                dtGVQLPC.Columns["id_phong"].HeaderText = "Mã phòng";

            if (dtGVQLPC.Columns["ten_phong"] != null)
                dtGVQLPC.Columns["ten_phong"].HeaderText = "Tên phòng";

            if (dtGVQLPC.Columns["so_luong_ghe"] != null)
                dtGVQLPC.Columns["so_luong_ghe"].HeaderText = "Số lượng ghế";
        }
    }
}
