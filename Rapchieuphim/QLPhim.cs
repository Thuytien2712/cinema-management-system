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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TransferObject;

namespace Rapchieuphim
{
    public partial class QLPhim : Form
    {
        public QLPhim()
        {
            InitializeComponent();
        }

        private void QLPhim_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            // Đặt MaxDate trước để tránh lỗi MinDate > MaxDate
            dateTimeNgaykhoichieu.MaxDate = DateTimePicker.MaximumDateTime; // hoặc DateTime.Today.AddYears(10);
            dateTimeNgaykhoichieu.MinDate = DateTime.Today;

            // (Tùy chọn) Đặt giá trị mặc định là ngày hôm nay
            dateTimeNgaykhoichieu.Value = DateTime.Today;
        }

        BLL_DDPhim bllDDPhim = new BLL_DDPhim();
        BLL_TLPhim bllTLPhim = new BLL_TLPhim();
        BLL_Phim phimBUS = new BLL_Phim();


        private void QlSuatChieu_Load(object sender, EventArgs e)
        {
            LoadComboBox(); // Khi form load, gọi hàm để load dữ liệu
        }

        private void LoadComboBox()
        {
            comboBoxDinhdang.DataSource = bllDDPhim.GetDDPhim();
            comboBoxDinhdang.DisplayMember = "ten";
            comboBoxDinhdang.ValueMember = "id_dinh_dang";

            comboBoxTheLoai.DataSource = bllTLPhim.GetTLPhim();
            comboBoxTheLoai.DisplayMember = "ten";
            comboBoxTheLoai.ValueMember = "id_the_loai";

            var dt = phimBUS.TimKiemPhim(null, null, null);
            dataGridViewQLP.DataSource = dt;
            dataGridViewQLP.Columns["HinhAnh"].Visible = false;
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenfile_Click(object sender, EventArgs e)
        {

        }

        private BLL_Phim bll = new BLL_Phim();

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(textBoxMaphim.Text) ||
                string.IsNullOrWhiteSpace(textBoxTenphim.Text) ||
                //string.IsNullOrWhiteSpace(textBoxDaodien.Text) ||
                //string.IsNullOrWhiteSpace(textBoxDienvien.Text) ||
                //string.IsNullOrWhiteSpace(textBoxNN.Text) ||
                //string.IsNullOrWhiteSpace(textBoxMota.Text) ||
                //string.IsNullOrWhiteSpace(textBoxThoiluong.Text) ||
                //string.IsNullOrWhiteSpace(textBoxRated.Text) ||
                pictureBoxHinhanh.ImageLocation == null ||
                comboBoxDinhdang.SelectedIndex == -1 ||
                comboBoxTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bll.KiemTraMaPhim(textBoxMaphim.Text))
            {
                MessageBox.Show("Mã phim đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Tạo đối tượng PhimDTO
            PhimDTO phim = new PhimDTO()
            {
                MaPhim = textBoxMaphim.Text,
                TenPhim = textBoxTenphim.Text,
                NgayKhoiChieu = dateTimeNgaykhoichieu.Value,
                ThoiLuong = textBoxThoiluong.Text,
                DaoDien = textBoxDaodien.Text,
                DienVien = textBoxDienvien.Text,
                NgonNgu = textBoxNN.Text,
                MoTaNoiDung = textBoxMoTa.Text,
                IdDinhDang = comboBoxDinhdang.SelectedValue.ToString(),
                IdTheLoai = comboBoxTheLoai.SelectedValue.ToString(),
                Rated = textBoxRated.Text,
                HinhAnh = pictureBoxHinhanh.ImageLocation
            };


            // 3. Gọi BUS để thêm phim
            bool result = bll.ThemPhim(phim);

            if (result)
            {
                MessageBox.Show("Thêm phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset các điều khiển
                textBoxMaphim.Clear();
                textBoxTenphim.Clear();
                textBoxDaodien.Clear();
                textBoxDienvien.Clear();
                textBoxNN.Clear();
                textBoxNN.Clear();
                textBoxThoiluong.Clear();
                textBoxRated.Clear();
                pictureBoxHinhanh.ImageLocation = null;
                comboBoxDinhdang.SelectedIndex = -1;
                comboBoxTheLoai.SelectedIndex = -1;
                textBoxMaphim.Focus();

                var dt = phimBUS.TimKiemPhim(null, null, null);
                dataGridViewQLP.DataSource = dt;
                dataGridViewQLP.Columns["HinhAnh"].Visible = false;
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenfile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxHinhanh.Image = Image.FromFile(ofd.FileName);
                pictureBoxHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;

                // Gán đường dẫn ảnh vào ImageLocation để dùng về sau
                pictureBoxHinhanh.ImageLocation = ofd.FileName;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            string maPhim = textBoxMaphim.Text.Trim();
            string tenPhim = textBoxTenphim.Text.Trim();
            string theLoai = comboBoxTheLoai.SelectedIndex >= 0 ? comboBoxTheLoai.SelectedValue.ToString() : "";

            // Gọi phương thức tìm kiếm phim từ PhimBUS
            var dt = bll.TimKiemPhim(maPhim, tenPhim, theLoai);

            //    // Hiển thị kết quả tìm kiếm lên DataGridView
            dataGridViewQLP.DataSource = dt;
            //    dataGridViewQLP.Columns["IdDinhDang"].Visible = false;
            //    dataGridViewQLP.Columns["IdTheLoai"].Visible = false;
            //    dataGridViewQLP.Columns["Rated"].Visible = false;
            //    dataGridViewQLP.Columns["HinhAnh"].Visible = false;
            //    dataGridViewQLP.Columns["MoTaNoiDung"].Visible = false;
        }

        private string maPhimDangChon = "";
        private void dataGridViewQLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewQLP.Rows[e.RowIndex];
                maPhimDangChon = row.Cells["MaPhim"].Value.ToString();
            }
        }

        private void bynXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPhimDangChon))
            {
                MessageBox.Show("Vui lòng chọn phim cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phim này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = bll.XoaPhim(maPhimDangChon);
                if (kq)
                {
                    // Xóa khỏi DataGridView (không cần reload)
                    foreach (DataGridViewRow row in dataGridViewQLP.Rows)
                    {
                        if (row.Cells["MaPhim"].Value.ToString() == maPhimDangChon)
                        {
                            // Hủy chọn nếu đang chọn dòng này
                            if (row.Index == dataGridViewQLP.CurrentCell?.RowIndex)
                            {
                                dataGridViewQLP.CurrentCell = null; // ✅ Deselect trước
                            }
                            row.Visible = false; // ✅ Ẩn an toàn
                            break;
                        }
                    }

                    MessageBox.Show("Đã xóa phim thành công!");
                    maPhimDangChon = null; // reset
                }
                else
                {
                    MessageBox.Show("Xóa phim thất bại. Vui lòng thử lại.");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
