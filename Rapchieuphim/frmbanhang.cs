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

using BusinessLayer;
using DataLayer;
using System.Security.Principal;

namespace Rapchieuphim
{
    public partial class frmbanhang : Form
    {
        
        public List<ChiTietHoaDonVe> DanhSachChiTietHoaDonVe;
        private DoAnBL doAnBL;
        public frmbanhang(List<ChiTietHoaDonVe> danhSachVe)
        {
            InitializeComponent();
            doAnBL = new DoAnBL();
            DanhSachChiTietHoaDonVe = danhSachVe;
        }


        public frmbanhang() // Mặc định – dùng khi không có vé
        {
            InitializeComponent();
            doAnBL = new DoAnBL();
            DanhSachChiTietHoaDonVe = new List<ChiTietHoaDonVe>(); // tránh null
        }

        private void frmbanhang_Load(object sender, EventArgs e)
        {
            cbbLoai.Items.Add("Đồ ăn");
            cbbLoai.Items.Add("Nước uống");
            dgvDSMon.AllowUserToAddRows = false; //ko cho user thêm hàng mới thủ công 
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoai = cbbLoai.SelectedItem.ToString();
            List<DoAnDTO> dsMon = doAnBL.LayDanhSachMonTheoLoai(tenLoai);
            cbbTenMon.DataSource = dsMon;
            cbbTenMon.DisplayMember = "ten";
            cbbTenMon.ValueMember = "id_do_an";
            cbbTenMon.DroppedDown = true; //dropdown sau khi chọn loại
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoAnDTO mon = (DoAnDTO)cbbTenMon.SelectedItem;
            int soLuong = (int)numUpDownSL.Value;
            if (soLuong == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numUpDownSL.Focus();
                return;
            }
            try
            {
                // kiểm tra và cập nhật tồn kho
                doAnBL.CapNhatTonKho(mon.Id_do_an, soLuong);

                // nếu thành công thì thêm vào datagridview
                decimal thanhTien = mon.Gia * soLuong;

                dgvDSMon.Rows.Add(
                    dgvDSMon.Rows.Count + 1,
                    mon.Id_do_an,
                    mon.Ten,
                    soLuong,
                    mon.Gia,
                    thanhTien
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDSMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            //khi chọn ô Xóa
            if (dgvDSMon.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này khỏi đơn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvDSMon.Rows.RemoveAt(e.RowIndex); // chỉ xóa trên dgv, không đụng DB
                    CapNhatSTT();
                }
            }

            //Khi chọn ô edit
            if (dgvDSMon.Columns[e.ColumnIndex].Name == "edit")
            {
                int rowIndex = e.RowIndex;
                string ten = dgvDSMon.Rows[rowIndex].Cells["ten"].Value.ToString();
                int soLuong = Convert.ToInt32(dgvDSMon.Rows[rowIndex].Cells["so_luong"].Value);
                decimal gia = Convert.ToDecimal(dgvDSMon.Rows[rowIndex].Cells["gia"].Value);

                formEditBH frmEdit = new formEditBH(ten, soLuong, gia);
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    int soLuongMoi = frmEdit.SoLuongMoi;
                    dgvDSMon.Rows[rowIndex].Cells["so_luong"].Value = soLuongMoi;
                    dgvDSMon.Rows[rowIndex].Cells["thanh_tien"].Value = gia * soLuongMoi;
                    MessageBox.Show("Đã cập nhật số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvDSMon.Rows.Count; i++)
            {
                dgvDSMon.Rows[i].Cells[0].Value = i + 1; // Giả sử STT là cột đầu tiên (index 0)
            }
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            FormTonKho frm = new FormTonKho();
            frm.ShowDialog();
        }

        private List<ChiTietHoaDonDoAn> LayDanhSachChiTietDoAn()
        {
            List<ChiTietHoaDonDoAn> dsChiTiet = new List<ChiTietHoaDonDoAn>();

            foreach (DataGridViewRow row in dgvDSMon.Rows)
            {
                if (row.IsNewRow) continue;

                string maDoAn = row.Cells["id_do_an"].Value?.ToString();
                string tenMon = row.Cells["ten"].Value?.ToString();
                int soLuong = int.Parse(row.Cells["so_luong"].Value.ToString());
                decimal donGia = decimal.Parse(row.Cells["gia"].Value.ToString());

                ChiTietHoaDonDoAn chiTiet = new ChiTietHoaDonDoAn
                {
                    IdDoAn = maDoAn,
                    TenMon = tenMon,
                    SoLuong = soLuong,
                    DonGia = donGia

                };

                dsChiTiet.Add(chiTiet);
            }

            return dsChiTiet;
        }

        private void btnTieptuc_Click_1(object sender, EventArgs e)
        {
            List<ChiTietHoaDonDoAn> dsDoAn = LayDanhSachChiTietDoAn();

            
            frmHoaDon formHoaDon = new frmHoaDon(DanhSachChiTietHoaDonVe, dsDoAn);
            // frmHoaDon formHoaDon = new frmHoaDon(dsDoAn);
            this.Close();
            formHoaDon.ShowDialog();
            this.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
