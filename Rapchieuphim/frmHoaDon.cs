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
using DataLayer;
using TransferObject;

namespace Rapchieuphim
{
    public partial class frmHoaDon : Form
    {
        private QLYTICHDIEMBL qlTichDiem = new QLYTICHDIEMBL();

        private QLMaGGBL qlgg = new QLMaGGBL();
        private List<MaGiamGia> danhSachMaGiamGia = new List<MaGiamGia>();
        private decimal tongTienVeBanDau = 0;

        public frmHoaDon()
        {
            InitializeComponent();
        }
        public List<ChiTietHoaDonVe> DanhSachChiTietHoaDonVe;
        private List<ChiTietHoaDonDoAn> danhSachDoAn;

        public frmHoaDon(List<ChiTietHoaDonDoAn> dsDoAn)
        {
            InitializeComponent();
            this.danhSachDoAn = dsDoAn;

            HienThiDoAnLenDataGridView();

            cbBmagg.SelectedIndexChanged += cbbMaGiamGia_SelectedIndexChanged;
            lblthongbao.BringToFront();
        }


        // Constructor cho trường hợp có cả vé và đồ ăn(hoặc chỉ có vé)
        public frmHoaDon( List<ChiTietHoaDonVe> dsVe, List<ChiTietHoaDonDoAn> dsDoAn = null)
        {
            InitializeComponent();
            this.DanhSachChiTietHoaDonVe = dsVe;
            this.danhSachDoAn = dsDoAn ?? new List<ChiTietHoaDonDoAn>(); // Nếu dsDoAn null thì khởi tạo rỗng

            HienThiThongTinVe(); // Hàm hiển thị thông tin vé
            HienThiDoAnLenDataGridView(); //  gọi hàm hiển thị đồ ăn
            cbBmagg.SelectedIndexChanged += cbbMaGiamGia_SelectedIndexChanged;
            lblthongbao.BringToFront();
        }

        private void HienThiThongTinVe()
        {
            if (DanhSachChiTietHoaDonVe != null && DanhSachChiTietHoaDonVe.Count > 0)
            {


                // Gọi BL để lấy thông tin phim
                SuatChieuBUS suatChieuBL = new SuatChieuBUS();
                string idSuatChieu = DanhSachChiTietHoaDonVe[0].IdSuatChieu;
                string idloaive = DanhSachChiTietHoaDonVe[0].IdLoaiVe;
                var (tenPhim, gioBatDau, ngayChieu, maPhong) = suatChieuBL.LayThongTinPhimTheoSuatChieu(idSuatChieu);

                lblPhim.Text = tenPhim;
                lblSuatchieu.Text = $"{ngayChieu:dd/MM/yyyy} {gioBatDau:hh\\:mm}";

                lblPhong.Text = maPhong;
                // Nhóm vé theo IdLoaiVe
                var groupedTickets = DanhSachChiTietHoaDonVe.GroupBy(v => v.IdLoaiVe)
                                                          .Select(g => new
                                                          {
                                                              IdLoaiVe = g.Key,
                                                              SoLuong = g.Count(),
                                                              Ghe = string.Join(", ", g.Select(ve => ve.IdGhe)),
                                                              DonGia = g.First().GiaVe
                                                          })
                                                          .ToList();
                // Hiển thị thông tin dựa trên IdLoaiVe
                foreach (var group in groupedTickets)
                {
                    string idLoaiVe = group.IdLoaiVe.ToString().ToUpper(); // Chuyển về chữ in hoa để so sánh

                    if (idLoaiVe == "STUDENT")
                    {
                        lblsoluongvesv.Text = group.SoLuong.ToString();
                        lblGheSinhVien.Text = group.Ghe;
                        lbldongiavesinhvien.Text = $"{group.DonGia:N0}đ";
                    }
                    else if (idLoaiVe == "KID")
                    {
                        lblsoluongvetreem.Text = group.SoLuong.ToString();
                        lblGhetreem.Text = group.Ghe;
                        lbldongiavetreem.Text = $"{group.DonGia:N0}đ";
                    }
                    else if (idLoaiVe == "ADULT")
                    {
                        lblsoluongvenguoilon.Text = group.SoLuong.ToString();
                        lblghenguoilon.Text = group.Ghe;
                        lbldongianguoilon.Text = $"{group.DonGia:N0}đ";
                    }
                }

                lblghe.Text = string.Join(", ", DanhSachChiTietHoaDonVe.Select(v => v.IdGhe));

                lblSoluong.Text = DanhSachChiTietHoaDonVe.Count.ToString();
                decimal tongTienVe = DanhSachChiTietHoaDonVe.Sum(v => v.GiaVe);

                lblTongtienve.Text = tongTienVe.ToString("N0") + "đ";
                tongTienVeBanDau = tongTienVe;

            }
            else
            {
                // Xử lý trường hợp không có thông tin vé
                lblPhim.Text = "";
                lblSuatchieu.Text = "";
                lblPhong.Text = "";
                lblGheSinhVien.Text = "";
                lblSoluong.Text = "0";
                lblTongtienve.Text = "0đ";
                lblsoluongvesv.Text = "";
                lblGheSinhVien.Text = "";
                lbldongiavesinhvien.Text = "";
                lblsoluongvetreem.Text = "";
                lblGhetreem.Text = "";
                lbldongiavetreem.Text = "";
                lblsoluongvenguoilon.Text = "";
                lblghenguoilon.Text = "";
                lbldongianguoilon.Text = "";
            }
        }


        private void HienThiDoAnLenDataGridView()
        {
            

            foreach (var item in danhSachDoAn)
            {
                int rowIndex = dtgvDsdoan.Rows.Add();
                dtgvDsdoan.Rows[rowIndex].Cells["IdDoAn"].Value = item.IdDoAn;
                dtgvDsdoan.Rows[rowIndex].Cells["TenMon"].Value = item.TenMon;
                dtgvDsdoan.Rows[rowIndex].Cells["SoLuong"].Value = item.SoLuong;
                dtgvDsdoan.Rows[rowIndex].Cells["DonGia"].Value = item.DonGia;
                dtgvDsdoan.Rows[rowIndex].Cells["ThanhTien"].Value = item.SoLuong * item.DonGia;
            }
        }

        private void TinhTongTienBanDau()
        {
            decimal tongDoAn = 0;
            foreach (var item in danhSachDoAn)
            {
                tongDoAn += item.SoLuong * item.DonGia;
            }

            decimal tongBanDau = tongDoAn + tongTienVeBanDau; // Cộng tổng tiền vé vào
            lblTongtien.Text = tongBanDau.ToString("N0") + "đ";
            lblTongtienphaitra.Text = lblTongtien.Text; // Khởi tạo tổng tiền phải trả
        }

        private int LayTongTienTuForm()
        {

            if (int.TryParse(lblTongtien.Text.Replace("đ", "").Replace(",", "").Trim(), out int tongTien))
                return tongTien;
            return 0;
        }
        private void LoadMaGiamGia()
        {
            int tongTien = LayTongTienTuForm(); // Lấy tổng tiền từ giao diện

            danhSachMaGiamGia = qlgg.LayMaGiamGiaHopLe(tongTien);
            cbBmagg.DataSource = danhSachMaGiamGia;
            cbBmagg.DisplayMember = "MaGG";
            cbBmagg.ValueMember = "MaGG";
            cbBmagg.SelectedIndex = -1;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadMaGiamGia();
            TinhTongTienBanDau();

        }

        private void cbbMaGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBmagg.SelectedIndex >= 0)
            {
                MaGiamGia selectedMGG = (MaGiamGia)cbBmagg.SelectedItem;
                int tongTien = LayTongTienTuForm();

                int giam = qlgg.TinhTienGiam(tongTien, selectedMGG);
                int saukhuyenmai = tongTien - giam;

                lblKhuyenmai.Text = giam.ToString("N0") + "đ";
                lblTongtienphaitra.Text = saukhuyenmai.ToString("N0") + "đ";
            }
            else
            {
                lblKhuyenmai.Text = "0đ";
                lblTongtienphaitra.Text = lblTongtien.Text;
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            decimal.TryParse(lblTongtien.Text.Trim().Replace("đ", "").Replace(",", ""), out decimal tongTien);
            decimal.TryParse(lblKhuyenmai.Text.Replace("đ", "").Replace(",", ""), out decimal tienGiamKhuyenMai);
            decimal.TryParse(lbltienduocgiam.Text.Replace("đ", "").Replace(",", ""), out decimal tienGiamDiem);
            decimal.TryParse(lblTongtienphaitra.Text.Replace("đ", "").Replace(",", ""), out decimal tienThanhToan);
            int.TryParse(txtnhapdiem.Text.Trim(), out int diemDaDung); // Lấy số điểm đã dùng

            if (tongTien == 0)
            {
                MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QLYTICHDIEMBL qlTichDiem = new QLYTICHDIEMBL();
            if (!string.IsNullOrEmpty(maKH))
            {
                if (!qlTichDiem.KiemTraMaKhachHang(maKH))
                {
                    MessageBox.Show($"Mã KH '{maKH}' không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            HoaDon hoaDon = new HoaDon
            {
                IdKH = maKH,
                IdNV = txtmaNV.Text.Trim(),
                MaGG = cbBmagg.SelectedValue?.ToString(),
                NgayLap = DateTime.Now,
                DiemDaDung = cBsddiem.Checked && int.TryParse(txtnhapdiem.Text.Trim(), out int diem) ? diem : 0,
                TongTien = tongTien,
                TienGiam = tienGiamKhuyenMai + tienGiamDiem,
                TienThanhToan = tienThanhToan,
                GhiChu = "Hóa đơn"
            };

            QLHOADONBL hdbl = new QLHOADONBL();
            int maHoaDonMoi = hdbl.ThemHoaDonVaChiTiet(hoaDon, danhSachDoAn, DanhSachChiTietHoaDonVe);

            if (maHoaDonMoi > 0)
            {
                if (!string.IsNullOrEmpty(maKH))
                {
                    // Trừ điểm nếu có sử dụng
                    if (cBsddiem.Checked && diemDaDung > 0)
                    {
                        qlTichDiem.TruDiem(maKH, diemDaDung, maHoaDonMoi);
                        // Cập nhật lại tổng điểm hiển thị (nếu cần)
                        lbltongdiem.Text = $"Bạn đang có: {qlTichDiem.LayTongDiemTheoKH(maKH)} điểm";
                    }

                    // Cộng điểm tự động sau khi thanh toán
                    try
                    {
                        int ketQua = qlTichDiem.CongDiemTuDong(maKH, maHoaDonMoi, tienThanhToan);
                        lbltongdiem.Text = $"Bạn đang có: {qlTichDiem.LayTongDiemTheoKH(maKH)} điểm";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi tích điểm: {ex.Message}");
                        MessageBox.Show("Lỗi khi tích điểm. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show($"Thanh toán thành công! Mã hóa đơn: {maHoaDonMoi}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            if (maKH != "")
            {
                KhachHangBL khBL = new KhachHangBL();
                KhachHangDTO kh = khBL.TimKhachHangTheoMa(maKH);

                if (kh != null)
                {
                    lbltenkh.Text = kh.Ho_ten;
                    lblsdt.Text = kh.Sdt;
                }
                else
                {
                    lbltenkh.Text = "";
                    lblsdt.Text = "";
                    lbltenkh.Text = "Không tìm thấy KH!";
                }
            }
            if (qlTichDiem.KiemTraMaKhachHang(maKH))
            {
                int tongDiem = qlTichDiem.LayTongDiemTheoKH(maKH);
                lbltongdiem.Text = $"Bạn đang có: {tongDiem} điểm";
            }
            else
            {
                lbltongdiem.Text = "Không tìm thấy KH!";
            }
        }
        private void CapNhatTongTienCuoi()
        {
            int tongTien = LayTongTienTuForm();

            // Trừ khuyến mãi
            int giam = 0;
            if (cbBmagg.SelectedIndex >= 0)
            {
                MaGiamGia selectedMGG = (MaGiamGia)cbBmagg.SelectedItem;
                giam = qlgg.TinhTienGiam(tongTien, selectedMGG);
            }

            // Trừ điểm
            int diemTru = 0;
            if (cBsddiem.Checked && int.TryParse(txtnhapdiem.Text.Trim(), out int diemNhap))
            {
                diemTru = diemNhap * 1000;
            }

            int tongCuoi = tongTien - giam - diemTru;
            if (tongCuoi < 0) tongCuoi = 0;

            lblTongtienphaitra.Text = tongCuoi.ToString("N0") + "đ";
        }

        private void cBsddiem_CheckedChanged(object sender, EventArgs e)
        {
            txtnhapdiem.Enabled = cBsddiem.Checked;
            if (!cBsddiem.Checked)
            {
                txtnhapdiem.Text = "";
                lbltienduocgiam.Text = "0đ";
                CapNhatTongTienCuoi();
            }
        }

        private void txtnhapdiem_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtnhapdiem.Text.Trim(), out int diemNhap)) return;

            // Lấy tổng điểm hiện có
            string maKH = txtMaKH.Text.Trim();
            int diemHienCo = qlTichDiem.LayTongDiemTheoKH(maKH);

            if (diemNhap > diemHienCo)
            {
                MessageBox.Show("Bạn không đủ điểm!");
                txtnhapdiem.Text = diemHienCo.ToString();
                diemNhap = diemHienCo;
            }

            decimal tienTru = diemNhap * 1000;
            lbltienduocgiam.Text = tienTru.ToString("N0") + "đ";

            CapNhatTongTienCuoi();
        }
    }
}
