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
using BusinessLayer;
using DataLayer;
using TransferObject;

namespace Rapchieuphim
{
    public partial class QLyTaiKhoan : Form
    {
        QLYTAIKHOANBL qltkbl = new QLYTAIKHOANBL();
        string[] cacChucVu = { "Quản lý", "Nhân viên" };
        public QLyTaiKhoan()
        {
            InitializeComponent();
            LoadData();
        }

        private void QLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        void LoadData()
        {
            List<Account> ds = qltkbl.LayDanhSach();
            cbBPhanquyen.DataSource = cacChucVu;
            dtgvtaikhoan.DataSource = ds;

        }

        private Account GetTaiKhoanFromForm()
        {
            return new Account
            {
                Id_nv = txtidNhanVien.Text.Trim(),
                MatKhau = textBoxMatkhau.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Chucvu = cbBPhanquyen.SelectedItem?.ToString() ?? string.Empty

            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = GetTaiKhoanFromForm();
                int numOfRows = qltkbl.ThemTaiKhoan(account);

                if (numOfRows > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Không thêm sửa tài khoản.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.Cancel;
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = GetTaiKhoanFromForm();
                int numOfRows = qltkbl.SuaTaiKhoan(account);

                if (numOfRows > 0)
                {
                    MessageBox.Show("Sửa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Không thể sửa tài khoản.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.Cancel;
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = GetTaiKhoanFromForm();
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    int numOfRows = qltkbl.XoaTaiKhoan(account); // Gọi BL

                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Cập nhật lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy id để xóa.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void dtgvtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvtaikhoan.Rows[e.RowIndex];

                // Gán dữ liệu lên các TextBox/Control
                txtidNhanVien.Text = row.Cells["id_nv"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxMatkhau.Text = row.Cells["MatKhau"].Value.ToString();
                cbBPhanquyen.Text = row.Cells["ChucVu"].Value.ToString();

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
