using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using TransferObject;
namespace BusinessLayer
{
    public class QLYTICHDIEMBL
    {
        private QLYTICHDIEMDL qlytichdiemdl = new QLYTICHDIEMDL();

        public List<TichDiem> LayTatCa()
        {
            return qlytichdiemdl.LayDanhSach();
        }

        public int ThemDiem(TichDiem tichdiem)
        {

            return qlytichdiemdl.Them(tichdiem);
        }
        public int SuaDiem(TichDiem tichdiem)
        {
            return qlytichdiemdl.Sua(tichdiem);
        }
        public int XoaDiem(TichDiem tichdiem)
        {
            return qlytichdiemdl.Xoa(tichdiem);
        }

        public bool KiemTraMaKhachHang(string maKH)
        {
            return qlytichdiemdl.KiemTraMaKhachHang(maKH);

        }
        public int LayTongDiemTheoKH(string idKH)
        {
            List<TichDiem> ds = qlytichdiemdl.LayDanhSachTichDiemTheoKH(idKH);
            return ds.Sum(d => d.diem);
        }
        public int CongDiemTuDong(string idKH, int mahoadon, decimal tongTien)
        {
            if (tongTien <= 0 || string.IsNullOrWhiteSpace(idKH) || mahoadon <= 0) // Kiểm tra mahoadon > 0)
                return 0;

            int diemCong = (int)(tongTien / 10000);
            if (diemCong <= 0)
                return 0;

            TichDiem diem = new TichDiem
            {
                id_kh = idKH,
                Mahoadon = mahoadon,
                diem = diemCong,
                ngay_tich_diem = DateTime.Now,
                noi_dung = $"Tích {diemCong} điểm từ hóa đơn {mahoadon}"
            };

            return qlytichdiemdl.Them(diem);
        }

        public bool TruDiem(string idKH, int soDiemTru, int mahoadon)
        {
            if (soDiemTru <= 0 || string.IsNullOrWhiteSpace(idKH) || mahoadon <= 0) // Kiểm tra mahoadon <= 0
                return false;

            TichDiem diem = new TichDiem
            {
                id_kh = idKH,
                Mahoadon = mahoadon,
                diem = -soDiemTru,
                ngay_tich_diem = DateTime.Now,
                noi_dung = $"Trừ {soDiemTru} điểm từ hóa đơn {mahoadon}"
            };

            return qlytichdiemdl.Them(diem) > 0;
        }

    }
}
