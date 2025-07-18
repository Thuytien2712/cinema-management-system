using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Rapchieuphim
{
    public partial class QLYMaGG : Form
    {
        QLMaGGBL bl = new QLMaGGBL();
        public QLYMaGG()
        {
            

            InitializeComponent();
        }
        void LoadData()
        {
            List<MaGiamGia> ds = bl.LayTatCa();
            dgvMaGiamGia.DataSource = ds;
        }

        private void QLYMaGG_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private MaGiamGia GetMaGGFromForm()
        {
            return new MaGiamGia
            {
                MaGG = txtMaGG.Text.Trim(),
                PhanTramGiam = int.Parse(txtPhanTram.Text),
                GiamToiDa = int.Parse(txtGiamToiDa.Text),
                DieuKien = txtDieuKien.Text.Trim(),
                NgayBatDau = dtpNgayBD.Value,
                NgayKetThuc = dtpNgayKT.Value,
                DonToiThieu = int.Parse(txtDontoithieu.Text),
                //SoLuong= int.Parse(txtSoluong.Text),
                //DaSuDung = int.Parse(txtDasudung.Text),
                //MoTa = txtMota.Text.Trim(),
            };
        }
  
       
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                MaGiamGia mgg = GetMaGGFromForm();

                // Kiểm tra input
                if (!IsAllInputFilled(this))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi BL để thêm mã
                int numOfRows = bl.ThemMaGiamGia(mgg);

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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                MaGiamGia mgg = GetMaGGFromForm();

                // Kiểm tra dữ liệu đầu vào
                if (!IsAllInputFilled(this))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm sửa từ Business Layer, trả về số dòng ảnh hưởng
                int numOfRows = bl.SuaMaGiamGia(mgg);

                if (numOfRows > 0)
                {
                    MessageBox.Show("Sửa mã giảm giá thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã giảm giá để sửa.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                MaGiamGia mgg = GetMaGGFromForm();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mã giảm giá này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int numOfRows = bl.XoaMaGiamGia(mgg); // Gọi BL

                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Xóa mã giảm giá thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Cập nhật lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã để xóa.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaGiamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaGiamGia.Rows[e.RowIndex];

                // Gán dữ liệu lên các TextBox/Control
                txtMaGG.Text = row.Cells["MaGG"].Value.ToString();
                txtPhanTram.Text = row.Cells["PhanTramGiam"].Value.ToString();
                txtGiamToiDa.Text = row.Cells["GiamToiDa"].Value.ToString();
                txtDieuKien.Text = row.Cells["DieuKien"].Value.ToString();
                dtpNgayBD.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpNgayKT.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                txtDontoithieu.Text = row.Cells["DonToiThieu"].Value.ToString();
                //txtSoluong.Text= row.Cells["SoLuong"].Value.ToString();
                //txtDasudung.Text= row.Cells["DaSuDung"].Value.ToString();
                //txtMota.Text= row.Cells["MoTa"].Value.ToString();
            }
        }
        private bool IsAllInputFilled(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                    return false;
                if (c is DateTimePicker dtp && (dtp.Value == null))
                    return false;
            }
            return true;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
