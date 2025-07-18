using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class NhanVienBL
    {
        private NhanVienDL nvienDL;

        public NhanVienBL()
        {
            nvienDL = new NhanVienDL();
        }

        public List<NhanVienDTO> GetNhanVien()
        {
            try
            {
                return (nvienDL.GetNhanVien());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemNhanVien(NhanVienDTO nv)
        {
            if (nv.Sdt.Length != 10 || !nv.Sdt.All(char.IsDigit))
            {
                //MessageBox.Show("Không được chỉnh sửa. Hãy kiểm tra lại số điện thoại!");
                throw new Exception("Không được thêm. Số điện thoại phải gồm 10 ký tự và không có chữ");
            }
            try
            {
                return nvienDL.ThemNhanVien(nv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhatNhanVien(NhanVienDTO nv)
        {
            if (nv.Sdt.Length != 10 || !nv.Sdt.All(char.IsDigit))
            {
                //MessageBox.Show("Không được chỉnh sửa. Hãy kiểm tra lại số điện thoại!");
                throw new Exception("Không được chỉnh sửa. Số điện thoại phải gồm 10 ký tự");
            }
            try
            {
                return nvienDL.CapNhatNhanVien(nv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int XoaNhanVien(NhanVienDTO nv)
        {
            try
            {
                return nvienDL.XoaNhanVien(nv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
