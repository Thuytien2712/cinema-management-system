using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using TransferObject;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Rapchieuphim
{
    public partial class QLNVien : Form
    {
        private NhanVienBL nvienBL;
        public QLNVien()
        {
            InitializeComponent();
            nvienBL = new NhanVienBL();
        }

        private void QLNVien_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewQLNV.DataSource = nvienBL.GetNhanVien();

                if (dataGridViewQLNV.Columns["ngay_sinh"] != null)
                {
                    dataGridViewQLNV.Columns["ngay_sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ho_ten, gioi_tinh, dia_chi, sdt, chuc_vu;
            DateTime ngay_sinh;
            
            ho_ten = textBoxHoten.Text.Trim();
            ngay_sinh = dateTimeNgaysinh.Value;
            gioi_tinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            dia_chi = textBoxDiachi.Text.Trim();
            sdt = textBoxSĐT.Text.Trim();
            chuc_vu = comboBoxChucvu.Text.Trim();

            //do có tên trùng nên dùng TransferObject.NhanVienDTO để gọi constructor
            TransferObject.NhanVienDTO nv = new NhanVienDTO( ho_ten,  ngay_sinh,  gioi_tinh,  dia_chi,  sdt,  chuc_vu);
            try
            {
                int result = nvienBL.ThemNhanVien(nv);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewQLNV.DataSource = nvienBL.GetNhanVien();
                    //textBoxMaNV.Clear();
                    textBoxHoten.Clear();
                    dateTimeNgaysinh.Value = DateTime.Today;
                    radioButtonNam.Checked = false;
                    radioButtonNu.Checked = false;
                    textBoxDiachi.Clear();
                    textBoxSĐT.Clear();
                    comboBoxChucvu.SelectedIndex = -1;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string id_nv, ho_ten, gioi_tinh, dia_chi, sdt, chuc_vu;
            DateTime ngay_sinh;

            id_nv = textBoxMaNV.Text;
            ho_ten = textBoxHoten.Text.Trim();
            ngay_sinh = dateTimeNgaysinh.Value;
            gioi_tinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            dia_chi = textBoxDiachi.Text.Trim();
            sdt = textBoxSĐT.Text.Trim();
            chuc_vu = comboBoxChucvu.Text.Trim();

            NhanVienDTO nv = new NhanVienDTO(id_nv, ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, chuc_vu);
            try
            {
                int result = nvienBL.CapNhatNhanVien(nv);
                if (result > 0)
                {
                    MessageBox.Show("Chỉnh sửa thông tin thành công");
                    dataGridViewQLNV.DataSource = nvienBL.GetNhanVien();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thông tin thất bại");
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
            string id_nv;
            id_nv = textBoxMaNV.Text;

            //do có tên trùng nên dùng TransferObject.NhanVienDTO để gọi constructor
            TransferObject.NhanVienDTO nv = new NhanVienDTO(id_nv);
            try
            {
                int result = nvienBL.XoaNhanVien(nv);
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewQLNV.DataSource = nvienBL.GetNhanVien();
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

        private void dataGridViewQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewQLNV.Rows[e.RowIndex];

                textBoxMaNV.Text = row.Cells["id_nv"].Value.ToString();
                textBoxHoten.Text = row.Cells["ho_ten"].Value.ToString();
                dateTimeNgaysinh.Value = Convert.ToDateTime(row.Cells["ngay_sinh"].Value);
                string gioiTinh = row.Cells["gioi_tinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    radioButtonNam.Checked = true;
                else
                    radioButtonNu.Checked = true;
                textBoxDiachi.Text = row.Cells["dia_chi"].Value.ToString();
                textBoxSĐT.Text = row.Cells["sdt"].Value.ToString();
                comboBoxChucvu.Text = row.Cells["chuc_vu"].Value.ToString();
            }
        }
    }
}
