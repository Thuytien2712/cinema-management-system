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
using DataLayer;
using TransferObject;

namespace Rapchieuphim
{
    public partial class QLTichDiem : Form
    {

        QLYTICHDIEMBL bl = new QLYTICHDIEMBL();
        public QLTichDiem()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            List<TichDiem> ds = bl.LayTatCa();
            dtgvTichdiem.DataSource = ds;
        }
        private void QLTichDiem_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private TichDiem GetTichdiemFromForm()
        {
            return new TichDiem
            {
                id_tich_diem = txtmatichdiem.Text.Trim(),
                diem = int.Parse(txtbDiemtichluy.Text),
                Mahoadon = int.Parse(txtbMaHD.Text),
                id_kh = txtmaKH.Text.Trim(),
                ngay_tich_diem = dtpngaytichdiem.Value,
                noi_dung = txtNoidung.Text.Trim(),

            };
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TichDiem tichDiem = GetTichdiemFromForm();

                // Gọi BL để thêm mã
                int numOfRows = bl.ThemDiem(tichDiem);

                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm mã giảm giá thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Không thể thêm mã giảm giá.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TichDiem tichDiem = GetTichdiemFromForm();

                // Gọi hàm sửa từ Business Layer, trả về số dòng ảnh hưởng
                int numOfRows = bl.SuaDiem(tichDiem);

                if (numOfRows > 0)
                {
                    MessageBox.Show("Cật nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Không thể sửa.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TichDiem tichdiem = GetTichdiemFromForm();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int numOfRows = bl.XoaDiem(tichdiem); // Gọi BL

                if (numOfRows > 0)
                {
                    MessageBox.Show("Xóa mã lịch sử tích điểm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Không thể xóa.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dtgvTichdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvTichdiem.Rows[e.RowIndex];

                // Gán dữ liệu lên các TextBox/Control
                txtmatichdiem.Text = row.Cells["id_tich_diem"].Value.ToString();
                txtbDiemtichluy.Text = row.Cells["diem"].Value.ToString();
                txtNoidung.Text = row.Cells["noi_dung"].Value.ToString();
                txtmaKH.Text = row.Cells["id_kh"].Value.ToString();
                dtpngaytichdiem.Value = Convert.ToDateTime(row.Cells["Ngay_tich_diem"].Value);
                txtbMaHD.Text = row.Cells["mahoadon"].Value.ToString();

            }
        }
    }
}
