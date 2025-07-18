using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class DoAnBL
    {
        private DoAnDL doanDL;
        private LoaiDoAnDL loaiDL = new LoaiDoAnDL();

        public DoAnBL()
        {
            doanDL = new DoAnDL();
        }

        public List<DoAnDTO> GetDoAn()
        {
            try
            {
                return (doanDL.GetDoAn());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemDoAn(DoAnDTO da, string ten)
        {
            try
            {
                string id_loai = loaiDL.GetIdLoaiByTen(ten);
                da.Id_loai = id_loai;
                return doanDL.ThemDoAn(da);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhatDoAn(DoAnDTO da,string ten)
        {
            try
            {
                string id_loai = loaiDL.GetIdLoaiByTen(ten);
                da.Id_loai = id_loai;
                return doanDL.CapNhatDoAn(da);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int XoaDoAn(DoAnDTO da)
        {
            try
            {
                return doanDL.XoaDoAn(da);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<DoAnDTO> LayDanhSachMonTheoLoai(string tenLoai)
        {
            try
            {
                return (doanDL.LayMonTheoLoai(tenLoai));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable LayDanhSachMonConHang()
        {
            try
            {
                return (doanDL.LayDanhSachMonConHang());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CapNhatTonKho(string idDoAn, int soLuong)
        {
            try
            {
                DoAnDL dal = new DoAnDL();
                dal.CapNhatTonKhoSauKhiBan(idDoAn, soLuong);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi cập nhật tồn kho: " + ex.Message);
            }
        }

    }
}
