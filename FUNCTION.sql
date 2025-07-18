USE CINEMA_TEST
GO

-- Lấy thông tin hàng hóa: tên, đơn giá
CREATE FUNCTION dbo.ThongTinDoAn
(
    @id_do_an VARCHAR(15)
)
RETURNS TABLE
AS
RETURN (
    SELECT ten, gia
    FROM DOAN
    WHERE id_do_an = @id_do_an
)
GO

-- Lấy thông tin khách hàng
CREATE FUNCTION dbo.ThongTinKhachHang(@id_kh VARCHAR(15))
RETURNS TABLE
AS RETURN (
    SELECT *
    FROM KHACHHANG
    WHERE id_kh = @id_kh
)
GO

-- Lấy thông tin nhân viên
CREATE FUNCTION dbo.ThongTinNhanVien(@id_nv VARCHAR(15))
RETURNS TABLE
AS RETURN (
    SELECT *
    FROM NHANVIEN
    WHERE id_nv = @id_nv
)
GO