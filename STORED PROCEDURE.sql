USE RAPCHIEUPHIM
GO

--DƯƠNG
-- STORED PROCEDURE Thêm nhân viên, quản lý
CREATE PROCEDURE sp_ThemNhanVien
    @ho_ten NVARCHAR(45),
    @ngay_sinh DATE,
    @gioi_tinh NVARCHAR(10),
    @dia_chi NVARCHAR(100),
    @sdt VARCHAR(10),
    @chuc_vu NVARCHAR(50)
AS
BEGIN
    INSERT INTO NHANVIEN (ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, chuc_vu)
    VALUES (@ho_ten, @ngay_sinh, @gioi_tinh, @dia_chi, @sdt, @chuc_vu)
END
GO


--Stored Procedure cập nhật nhân viên 
CREATE PROCEDURE sp_CapNhatNhanVien
    @id_nv VARCHAR(15),
    @ho_ten NVARCHAR(45),
    @ngay_sinh DATE,
    @gioi_tinh NVARCHAR(10),
    @dia_chi NVARCHAR(100),
    @sdt VARCHAR(10),
    @chuc_vu NVARCHAR(50)
AS
BEGIN

    -- Cập nhật thông tin nhân viên
    UPDATE NHANVIEN
    SET 
        ho_ten = @ho_ten,
        ngay_sinh = @ngay_sinh,
        gioi_tinh = @gioi_tinh,
        dia_chi = @dia_chi,
        sdt = @sdt,
        chuc_vu = @chuc_vu
    WHERE id_nv = @id_nv;

    SELECT @@ROWCOUNT;
END
GO

--Stored Procedure xóa nhân viên
CREATE PROCEDURE sp_XoaNhanVien
    @id_nv varchar(15)
AS
BEGIN
    DELETE FROM NHANVIEN 
	WHERE id_nv = @id_nv;
END
GO


--Stored Procedure thêm khách hàng
CREATE PROCEDURE sp_ThemKhachHang
    @ho_ten NVARCHAR(50),
    @ngay_sinh DATE,
    @gioi_tinh NVARCHAR(10),
    @dia_chi NVARCHAR(100),
    @sdt VARCHAR(10),
    @email VARCHAR(50)
AS
BEGIN
    INSERT INTO KHACHHANG (ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, email)
    VALUES (@ho_ten, @ngay_sinh, @gioi_tinh, @dia_chi, @sdt, @email)
END
GO

--Stored Procedure cập nhật khách hàng
CREATE PROCEDURE sp_CapNhatKhachHang
    @id_kh     VARCHAR(15),
    @ho_ten    NVARCHAR(50),
    @ngay_sinh DATE,
    @gioi_tinh NVARCHAR(10),
    @dia_chi   NVARCHAR(100),
    @sdt       VARCHAR(10),
    @email     VARCHAR(50)
AS
BEGIN
    UPDATE KHACHHANG
    SET 
        ho_ten     = @ho_ten,
        ngay_sinh  = @ngay_sinh,
        gioi_tinh  = @gioi_tinh,
        dia_chi    = @dia_chi,
        sdt        = @sdt,
        email      = @email
    WHERE id_kh = @id_kh;

    SELECT @@ROWCOUNT;
END
GO

--Stored Procedure xóa khách hàng
CREATE PROCEDURE sp_XoaKhachHang
    @id_kh varchar(15)
AS
BEGIN
    DELETE FROM KHACHHANG 
    WHERE id_kh = @id_kh;
END
GO

---Stored Procedure thêm hàng hóa (đồ ăn, nước uống)
CREATE PROCEDURE sp_ThemDoAn
  @ten nvarchar(45),
  @id_loai varchar(5),
  @gia int,
  @so_luong int
AS
BEGIN
  DECLARE @sl_con_lai int = @so_luong;

  INSERT INTO DOAN (ten, id_loai, gia, so_luong, sl_con_lai)
  VALUES (@ten, @id_loai, @gia, @so_luong, @sl_con_lai);
END
GO

---Stored Procedure cập nhật hàng hóa (đồ ăn, nước uống)
CREATE PROCEDURE sp_CapNhatDoAn
    @id_do_an varchar(15),
    @ten nvarchar(45),
    @id_loai varchar(5),
    @gia int,
    @so_luong int
AS
BEGIN
    UPDATE DOAN
    SET 
        ten = @ten,
        id_loai = @id_loai,
        gia = @gia,
        so_luong = @so_luong,
        sl_con_lai = @so_luong -- hoặc giữ nguyên nếu bạn không muốn thay đổi
    WHERE id_do_an = @id_do_an;

    SELECT @@ROWCOUNT;
END
GO

--Stored Procedure xóa hàng hóa (đồ ăn, nước uống)
CREATE PROCEDURE sp_XoaDoAn
    @id_do_an varchar(15)
AS
BEGIN
    DELETE FROM DOAN WHERE id_do_an = @id_do_an;
END
GO

--SP giảm số lượng còn lại khi bán hàng
CREATE PROCEDURE sp_TinhSoLuongTon   --sp_CapNhatTonKhoSauKhiBan
    @id_do_an VARCHAR(15),
    @so_luong INT
AS
BEGIN
    DECLARE @sl_con_lai INT;
    SELECT @sl_con_lai = sl_con_lai FROM DOAN WHERE id_do_an = @id_do_an;
    
    IF @sl_con_lai = 0
    BEGIN
        RAISERROR(N'Món đã hết hàng.', 16, 1);
        RETURN;
    END
    
    IF @so_luong > @sl_con_lai
    BEGIN
        RAISERROR(N'Số lượng tồn kho không đủ để bán', 16, 1);
        RETURN;
    END
    UPDATE DOAN
    SET sl_con_lai = sl_con_lai - @so_luong
    WHERE id_do_an = @id_do_an;
END
GO

--Stored Procedure truy vấn ds món còn hàng
CREATE PROCEDURE sp_DsMonConHang
AS
BEGIN
    SELECT id_do_an, ten, sl_con_lai, gia
    FROM DOAN
    WHERE sl_con_lai > 0;
END
GO

--Stored Procedure lọc theo loại đồ ăn/nước uống
CREATE PROCEDURE sp_LocMonTheoLoai 
    @TenLoai NVARCHAR(45)
AS
BEGIN
    SELECT M.id_do_an, M.ten, M.gia
    FROM DOAN M
    JOIN LOAIDOAN L ON M.id_loai = L.id_loai
    WHERE L.ten = @TenLoai
END
GO

--Procedure lấy id món theo tên 
CREATE PROCEDURE sp_GetIdLoaiByTen
    @ten NVARCHAR(100)
AS
BEGIN
    SELECT id_loai FROM LOAIDOAN WHERE ten = @ten;
END
GO

--TIÊN
--QUẢN LÍ MÃ GIẢM GIÁ
--Thêm
CREATE PROCEDURE uspThemMaGiamGia
    @MaGG VARCHAR(20),
    @PhanTramGiam INT,
    @GiamToiDa INT,
    @NgayBatDau DATE,
    @NgayKetThuc DATE,
    @DieuKien NVARCHAR(100),
    @DonToiThieu INT = 0
AS
BEGIN
    INSERT INTO MaGiamGia (MaGG, PhanTramGiam, GiamToiDa, NgayBatDau, NgayKetThuc, DieuKien, DonToiThieu)
    VALUES (@MaGG, @PhanTramGiam, @GiamToiDa, @NgayBatDau, @NgayKetThuc, @DieuKien, @DonToiThieu)
END
GO
--Sửa
CREATE PROC uspSuaMaGiamGia
    @MaGG VARCHAR(20),
    @PhanTramGiam INT,
    @GiamToiDa INT,
    @NgayBatDau DATE,
    @NgayKetThuc DATE,
    @DieuKien NVARCHAR(100),
    @DonToiThieu INT = 0
AS
BEGIN
   UPDATE MaGiamGia
    SET PhanTramGiam = @PhanTramGiam,
        GiamToiDa=@GiamToiDa,
        DieuKien = @DieuKien,
        NgayBatDau = @NgayBatDau,
        NgayKetThuc = @NgayKetThuc,
        DonToiThieu=@DonToiThieu
                              
    WHERE MaGG = @MaGG
END
GO
--Xóa
CREATE PROC uspXoaMaGiamGia
	@MaGG varchar(20)
AS
BEGIN 
	DELETE FROM MAGIAMGIA
	WHERE MaGG=@MaGG;
END
GO
--QUẢN LÍ TÍCH ĐIỂM
--Thêm tích điểm tự mã tự động
CREATE PROC sp_ThemLichSuTichDiem
    @ngay_tich_diem DATE,
    @diem INT,
    @noi_dung NVARCHAR(255),
    @id_kh VARCHAR(15),
    @mahoadon int
AS
BEGIN
    DECLARE @MaMoi VARCHAR(15)

    -- Sinh mã mới dạng TD01, TD02,...
    SELECT @MaMoi = 'TD' + RIGHT('00' + CAST(ISNULL(MAX(CAST(SUBSTRING(id_tich_diem, 3, LEN(id_tich_diem)) AS INT)) + 1, 1) AS VARCHAR), 2)
    FROM LICHSUTICHDIEM

    -- Thêm dòng lịch sử tích điểm
    INSERT INTO LICHSUTICHDIEM (id_tich_diem, ngay_tich_diem, diem, noi_dung, id_kh, mahoadon)
    VALUES (@MaMoi, @ngay_tich_diem, @diem, @noi_dung, @id_kh, @mahoadon)
END
GO
-- Sửa lịch sử tích điểm
CREATE PROC uspUpdateLichSuTichDiem
    @id_tich_diem VARCHAR(15),
    @ngay_tich_diem DATE,
    @diem INT,
    @noi_dung NVARCHAR(255),
    @id_kh VARCHAR(15),
    @mahoadon int
AS
BEGIN
    UPDATE LICHSUTICHDIEM
    SET ngay_tich_diem=@ngay_tich_diem,
        diem=@diem, 
        noi_dung=@noi_dung,
        id_kh=@id_kh,
        mahoadon=@mahoadon 
    WHERE id_tich_diem=@id_tich_diem;
END
GO
--Xóa lịch sử tích điểm
CREATE PROC uspDeleteLichSuTichDiem
	@id_tich_diem VARCHAR(15)
AS
BEGIN 
	DELETE FROM LICHSUTICHDIEM
	WHERE id_tich_diem=@id_tich_diem;
END
GO
--Kiểm tra mã khách hàng có tồn tại không 
CREATE PROCEDURE uspKiemTraKhachHangTonTai
    @id_kh VARCHAR(10)
AS
BEGIN
    SELECT COUNT(*) FROM KHACHHANG WHERE id_kh = @id_kh;
END
go
--QUẢN LÍ HÓA ĐƠN
-- Procedure để thêm mới một hóa đơn
-- (Table Type) được sử dụng để truyền danh sách các món đồ ăn
-- kèm theo số lượng và đơn giá khi thêm một hóa đơn mới.
CREATE TYPE TVP_CHITIET_DOAN AS TABLE (
    id_do_an VARCHAR(15),
    so_luong INT,
    don_gia DECIMAL(18,2)
);
go
-- (Table Type) được sử dụng để truyền danh sách các vé đã bán
-- kèm theo thông tin suất chiếu, ghế, giá vé và loại vé khi thêm một hóa đơn mới.
CREATE TYPE TVP_CHITIET_VE AS TABLE (
    id_suat_chieu VARCHAR(15),
    id_ghe VARCHAR(10),
    gia_ve DECIMAL(18,2),
	id_loai_ve VARCHAR(10) -- Added id_loai_ve
);
GO

-- Them chi tiet hoa don tích hợp vé và đồ ăn
CREATE PROCEDURE sp_ThemHoaDonVaChiTiet
    @id_kh VARCHAR(15),
    @id_nv VARCHAR(15),
    @MaGG VARCHAR(20),
    @NgayLap DATETIME,
    @DiemDaDung INT,
    @TongTien DECIMAL(18,2),
    @TienGiam DECIMAL(18,2),
    @TienThanhToan DECIMAL(18,2),
    @GhiChu NVARCHAR(255),
    @ChiTietDoAn TVP_CHITIET_DOAN READONLY,
    @ChiTietVe TVP_CHITIET_VE READONLY,
    @MaHoaDonMoi INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO HOADON (id_kh, id_nv, MaGG, NgayLap, DiemDaDung, TongTien, TienGiam, TienThanhToan, GhiChu)
        VALUES (@id_kh, @id_nv, @MaGG, @NgayLap, @DiemDaDung, @TongTien, @TienGiam, @TienThanhToan, @GhiChu);

        SET @MaHoaDonMoi = SCOPE_IDENTITY();

        -- Chèn chi tiết đồ ăn
        INSERT INTO CHITIETHOADONDOAN (MaHoaDon, id_do_an, so_luong, don_gia)
        SELECT @MaHoaDonMoi, id_do_an, so_luong, don_gia
        FROM @ChiTietDoAn;

        -- ✅ Chèn chi tiết vé
        INSERT INTO CHITIETHOADONVE (MaHoaDon, id_suat_chieu, id_ghe, gia_ve, id_loai_ve)
        SELECT @MaHoaDonMoi, id_suat_chieu, id_ghe, gia_ve, id_loai_ve
        FROM @ChiTietVe;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SET @MaHoaDonMoi = -1;
    END CATCH
END;
Go

--Produce lấy thông tin phim theo suất chiếu để làm hóa đơn(để hiện lên giao diện)
CREATE PROCEDURE sp_LayThongTinPhimTheoSuatChieu
    @id_suat_chieu VARCHAR(15)
AS
BEGIN
    SELECT 
        PHIM.TenPhim,
        SUATCHIEU.tg_bat_dau,
        SUATCHIEU.ngay_chieu,
        SUATCHIEU.id_phong
    FROM SUATCHIEU
    JOIN PHIM ON PHIM.MaPhim = SUATCHIEU.MaPhim
    WHERE SUATCHIEU.id_suat_chieu = @id_suat_chieu
END
go
--QLY TAIKHOAN
-- proc Them tai khoan
CREATE PROCEDURE sp_ThemTaiKhoan (
    @id_nv VARCHAR(15),
    @Email VARCHAR(50),
    @MatKhau NVARCHAR(100),
    @chuc_vu NVARCHAR(50)
)
AS
BEGIN
    INSERT INTO TAIKHOAN (id_nv, Email, MatKhau, chuc_vu)
    VALUES (@id_nv, @Email, @MatKhau, @chuc_vu);
END;
GO
--proc sửa tài khoản
CREATE PROCEDURE sp_SuaTaiKhoan (
    @id_nv VARCHAR(15),
    @Email VARCHAR(50),
    @MatKhau NVARCHAR(100),
    @chuc_vu NVARCHAR(50)
)
AS
BEGIN
UPDATE TAIKHOAN
    SET
        Email = @Email,
        MatKhau = @MatKhau,
        chuc_vu = @chuc_vu
    WHERE id_nv = @id_nv;
END;
GO
--proc xóa tài khoản
CREATE PROC sp_XoaTaiKhoan
	@id_nv varchar(15)
AS
BEGIN 
	DELETE FROM TAIKHOAN
	WHERE id_nv=@id_nv;
END
GO


