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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Rapchieuphim
{
    public partial class QLKhachHang : Form
    {
        private KhachHangBL khachBL;

        public QLKhachHang()
        {
            InitializeComponent();
            khachBL = new KhachHangBL();

        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dgvKhachHang.DataSource = khachBL.GetKhachHang();
                if (dgvKhachHang.Columns["ngay_sinh"] != null)
                {
                    dgvKhachHang.Columns["ngay_sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                ThemCotBarcode();     // thêm cột mới
                HienThiBarcode();     // gán hình ảnh barcode vào từng dòng


            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        private void ThemCotBarcode()
        {
            if (!dgvKhachHang.Columns.Contains("Barcode"))
            {
                DataGridViewImageColumn barcodeColumn = new DataGridViewImageColumn();
                barcodeColumn.Name = "Barcode";
                barcodeColumn.HeaderText = "Barcode";
                barcodeColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvKhachHang.Columns.Add(barcodeColumn);
            }
        }
        private void HienThiBarcode()
        {
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Cells["Id_kh"].Value != null)
                {
                    string maKH = row.Cells["Id_kh"].Value.ToString();
                    Image barcode = khachBL.TaoBarcodeTuMaKH(maKH);
                    row.Cells["Barcode"].Value = barcode;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ho_ten, gioi_tinh, dia_chi, sdt, email;
            DateTime ngay_sinh;

            ho_ten = txtTenKH.Text.Trim();
            ngay_sinh = dtpNgaySinhKH.Value;
            gioi_tinh = rdbNam.Checked ? "Nam" : "Nữ";
            dia_chi = txtDiaChi.Text.Trim();
            sdt = txtSdt.Text.Trim();
            email = txtEmail.Text.Trim();

            
            KhachHangDTO kh = new KhachHangDTO(ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, email);
            try
            {
                int result = khachBL.ThemKhacHang(kh);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvKhachHang.DataSource = khachBL.GetKhachHang();
                    ThemCotBarcode();
                    HienThiBarcode();

                    //textBoxMaNV.Clear();
                    txtTenKH.Clear();
                    dtpNgaySinhKH.Value = DateTime.Today;
                    rdbNam.Checked = false;
                    rdbNu.Checked = false;
                    txtDiaChi.Clear();
                    txtSdt.Clear();
                    txtEmail.Clear();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id_kh, ho_ten, gioi_tinh, dia_chi, sdt, email;
            DateTime ngay_sinh;

            id_kh = txtMaKH.Text;
            ho_ten = txtTenKH.Text.Trim();
            ngay_sinh = dtpNgaySinhKH.Value;
            gioi_tinh = rdbNam.Checked ? "Nam" : "Nữ";
            dia_chi = txtDiaChi.Text.Trim();
            sdt = txtSdt.Text.Trim();
            email = txtEmail.Text.Trim();

            KhachHangDTO kh = new KhachHangDTO(id_kh, ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, email);
            try
            {
                int result = khachBL.CapNhatKhachHang(kh);
                if (result > 0)
                {
                    MessageBox.Show("Chỉnh sửa thông tin thành công");
                    dgvKhachHang.DataSource = khachBL.GetKhachHang();

                    ThemCotBarcode();
                    HienThiBarcode();
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["id_kh"].Value.ToString();
                txtTenKH.Text = row.Cells["ho_ten"].Value.ToString();
                dtpNgaySinhKH.Value = Convert.ToDateTime(row.Cells["ngay_sinh"].Value);
                string gioiTinh = row.Cells["gioi_tinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txtDiaChi.Text = row.Cells["dia_chi"].Value.ToString();
                txtSdt.Text = row.Cells["sdt"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id_kh;
            id_kh = txtMaKH.Text;

            KhachHangDTO kh = new KhachHangDTO(id_kh);
            try
            {
                int result = khachBL.XoaKhachHang(kh);
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKhachHang.DataSource = khachBL.GetKhachHang();
                    ThemCotBarcode();
                    HienThiBarcode();
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
