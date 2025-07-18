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
    public partial class QLDoan : Form
    {
        private DoAnBL doAnBL;
        public QLDoan()
        {
            InitializeComponent();
            doAnBL = new DoAnBL();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten, id_loai, so_luong, sl_con_lai;
            decimal gia;

            ten = txtTenmon.Text.Trim();
            id_loai = comboBoxLoai.Text.Trim();
            if (decimal.TryParse(txtGiaban.Text.Trim(), out gia) == false)
            {
                MessageBox.Show("Giá bán không hợp lệ. Vui lòng nhập số hợp lệ.");
                return;
            }
            so_luong = txtSoLuong.Text.Trim();
            sl_con_lai = txtConlai.Text.Trim();

            DoAnDTO da = new DoAnDTO(ten, id_loai, gia, so_luong, sl_con_lai);
            try
            {
                int result = doAnBL.ThemDoAn(da,comboBoxLoai.Text);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDSMon.DataSource = doAnBL.GetDoAn();

                    //txtMamon.Clear();
                    txtTenmon.Clear();
                    comboBoxLoai.SelectedIndex = -1;
                    txtGiaban.Clear();
                    txtSoLuong.Clear();
                    txtConlai.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
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

        private void QLDoan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDSMon.DataSource = doAnBL.GetDoAn();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void dgvDSMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSMon.Rows[e.RowIndex];

                txtMamon.Text = row.Cells["id_do_an"].Value.ToString();
                txtTenmon.Text = row.Cells["ten"].Value.ToString();
                comboBoxLoai.Text = row.Cells["id_loai"].Value.ToString();
                txtGiaban.Text = row.Cells["gia"].Value.ToString();
                txtSoLuong.Text = row.Cells["so_luong"].Value.ToString();
                txtConlai.Text = row.Cells["sl_con_lai"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id_do_an, ten, id_loai, so_luong, sl_con_lai;
            decimal gia;

            id_do_an = txtMamon.Text.Trim();
            ten = txtTenmon.Text.Trim();
            id_loai = comboBoxLoai.Text.Trim();
            gia = decimal.Parse(txtGiaban.Text.Trim());
            so_luong = txtSoLuong.Text.Trim();
            sl_con_lai = txtConlai.Text.Trim();

            DoAnDTO da = new DoAnDTO(id_do_an, ten, id_loai, gia, so_luong, sl_con_lai);
            try
            {
                int result = doAnBL.CapNhatDoAn(da, comboBoxLoai.Text);
                if (result > 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công!");
                    dgvDSMon.DataSource = doAnBL.GetDoAn();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id_do_an;
            id_do_an = txtMamon.Text;

            DoAnDTO da = new DoAnDTO(id_do_an);
            try
            {
                int result = doAnBL.XoaDoAn(da);
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDSMon.DataSource = doAnBL.GetDoAn();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
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
    }
}
