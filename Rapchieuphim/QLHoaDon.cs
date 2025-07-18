using BusinessLayer;
using DataLayer;
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
    public partial class QLHoaDon : Form
    {

        QLHOADONBL bl = new QLHOADONBL();
        

        void LoadData()
        {
            List<TransferObject.HoaDon> ds = bl.LayTatCa();
            dtGVhoadon.DataSource = ds;

        }
        public QLHoaDon()
        {
            InitializeComponent();
        }

    

        private void grBTimKiem_Enter(object sender, EventArgs e)
        {

        }

        private void dtGVhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void LoadChiTietHoaDonDoAn(int maHoaDon)
        {
            // Gọi Business Logic Layer (hoặc Data Access Layer) để lấy chi tiết hóa đơn đồ ăn
            // dựa trên mã hóa đơn.
            
            QLHOADONBL qlHoaDonBL = new QLHOADONBL();
            List<ChiTietHoaDonDoAn> danhSachChiTiet = qlHoaDonBL.LayChiTietHoaDonDoAn(maHoaDon);

            // Hiển thị danh sách chi tiết ở DataGridView phía dưới
            dtgvchitietdoan.DataSource = danhSachChiTiet;

        }
        private void LoadChiTietHoaDonVe(int maHoaDon)
        {
            QLHOADONBL qlHoaDonBL = new QLHOADONBL();
            List<ChiTietHoaDonVe> danhSachChiTietVe = qlHoaDonBL.LayChiTietHoaDonVe(maHoaDon);

            // Có thể gộp vé và đồ ăn vào cùng 1 DataGridView nếu muốn, hoặc tạo DataGridView riêng nếu tách biệt
            dtgvchitietdoan.DataSource = danhSachChiTietVe;

            
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHD = txtmaHD.Text.Trim();
            string maNV = txtmaNV.Text.Trim();
            string maKH = txtmaKH.Text.Trim();
            DateTime tuNgay = dtptungay.Value;
            DateTime denNgay = dtpdenngay.Value;

            QLHOADONBL hdbl = new QLHOADONBL();
            List<TransferObject.HoaDon> ketQua = hdbl.TimKiemHD(maHD, maNV, maKH, tuNgay, denNgay);
            dtGVhoadon.DataSource = ketQua;
        }

        private void dtGVhoadon_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGVhoadon.SelectedRows.Count > 0)
            {
                if (dtGVhoadon.SelectedRows[0].Cells[0].Value != null &&
                    int.TryParse(dtGVhoadon.SelectedRows[0].Cells[0].Value.ToString(), out int maHoaDon))
                {
                    LoadChiTietHoaDonDoAn(maHoaDon);
                    // Load vé
                    List<ChiTietHoaDonVe> dsVe = bl.LayChiTietHoaDonVe(maHoaDon);
                    dtgvchitietve.DataSource = dsVe;

                }
                else
                {
                    dtgvchitietdoan.DataSource = null;
                    dtgvchitietdoan.Rows.Clear();
                    MessageBox.Show("Mã hóa đơn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dtgvchitietve.DataSource = null;
                dtgvchitietve.Rows.Clear();

                dtgvchitietdoan.DataSource = null;
                dtgvchitietdoan.Rows.Clear();
            }
        }

        private void dtgvchitietve_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void QLHoaDon_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
