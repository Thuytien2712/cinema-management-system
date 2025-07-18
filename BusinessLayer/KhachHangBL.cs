using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Drawing;
using Zen.Barcode;

namespace BusinessLayer
{
    public class KhachHangBL
    {
        private KhachHangDL khachDL;

        public KhachHangBL()
        {
            khachDL = new KhachHangDL();
        }

        public List<KhachHangDTO> GetKhachHang()
        {
            try
            {
                return (khachDL.GetKhachHang());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemKhacHang(KhachHangDTO kh)
        {
            if (kh.Sdt.Length != 10 || !kh.Sdt.All(char.IsDigit))
            {
                //MessageBox.Show("Không được chỉnh sửa. Hãy kiểm tra lại số điện thoại!");
                throw new Exception("Không được thêm. Số điện thoại phải gồm 10 ký tự và không có chữ");
            }
            try
            {
                return khachDL.ThemKhachHang(kh);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhatKhachHang(KhachHangDTO kh)
        {
            if (kh.Sdt.Length != 10 || !kh.Sdt.All(char.IsDigit))
            {
                //MessageBox.Show("Không được chỉnh sửa. Hãy kiểm tra lại số điện thoại!");
                throw new Exception("Không được chỉnh sửa. Số điện thoại phải gồm 10 ký tự");
            }
            try
            {
                return khachDL.CapNhatKhachHang(kh);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaKhachHang(KhachHangDTO kh)
        {
            try
            {
                return khachDL.XoaKhachHang(kh);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Image TaoBarcodeTuMaKH(string maKhachHang)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code128) as Code128BarcodeDraw;
            return barcode?.Draw(maKhachHang, 30);
        }
        public KhachHangDTO TimKhachHangTheoMa(string maKH)
        {
            return khachDL.TimKhachHangTheoMa(maKH);
        }


    }
}
