USE RAPCHIEUPHIM
GO

---- Trigger thêm nhân viên, quản lý + auto mã nv, mã ql
CREATE TRIGGER trg_ThemNhanVien_AutoId
ON NHANVIEN
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    -- Kiểm tra dữ liệu không hợp lệ
    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE 
            (ho_ten IS NULL OR LTRIM(RTRIM(ho_ten)) = '') OR
            (ngay_sinh IS NULL OR CAST(ngay_sinh AS DATE) >= CAST(GETDATE() AS DATE)) OR
            (gioi_tinh IS NULL OR LTRIM(RTRIM(gioi_tinh)) = '') OR
            (dia_chi IS NULL OR LTRIM(RTRIM(dia_chi)) = '') OR
            (sdt IS NULL OR LEN(sdt) <> 10 OR sdt LIKE '%[^0-9]%') OR
            (chuc_vu NOT IN (N'Nhân viên', N'Quản lý'))
    )
    BEGIN
        RAISERROR(N'Dữ liệu nhân viên không hợp lệ. Kiểm tra lại họ tên, ngày sinh, giới tính, địa chỉ, số điện thoại hoặc chức vụ', 16, 1);
        RETURN;
    END
    -- Sinh mã cho từng nhóm chức vụ
    INSERT INTO NHANVIEN (id_nv, ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, chuc_vu)
    SELECT 
        -- Nếu là nhân viên thì NV, quản lý thì QL
        CASE 
            WHEN chuc_vu = N'Nhân viên' THEN 
                'NV' + RIGHT('0000' + CAST(
                    (SELECT ISNULL(MAX(CAST(SUBSTRING(id_nv, 3, LEN(id_nv)) AS INT)), 0) 
                     FROM NHANVIEN WHERE id_nv LIKE 'NV%') 
                    + ROW_NUMBER() OVER (PARTITION BY chuc_vu ORDER BY (SELECT NULL)) 
                AS VARCHAR), 4)
            WHEN chuc_vu = N'Quản lý' THEN 
                'QL' + RIGHT('0000' + CAST(
                    (SELECT ISNULL(MAX(CAST(SUBSTRING(id_nv, 3, LEN(id_nv)) AS INT)), 0) 
                     FROM NHANVIEN WHERE id_nv LIKE 'QL%') 
                    + ROW_NUMBER() OVER (PARTITION BY chuc_vu ORDER BY (SELECT NULL)) 
                AS VARCHAR), 4)
        END,
        ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, chuc_vu
    FROM inserted;
END
GO


---- Trigger kiểm tra khi cập nhật nhân viên
CREATE TRIGGER trg_CapNhatNhanVien
ON NHANVIEN
INSTEAD OF UPDATE
AS
BEGIN
    -- Kiểm tra dữ liệu không hợp lệ
    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE 
            (ho_ten IS NULL OR LTRIM(RTRIM(ho_ten)) = '') OR
            (ngay_sinh IS NULL OR CAST(ngay_sinh AS DATE) >= CAST(GETDATE() AS DATE)) OR
            (gioi_tinh IS NULL OR LTRIM(RTRIM(gioi_tinh)) = '') OR
            (dia_chi IS NULL OR LTRIM(RTRIM(dia_chi)) = '') OR
            (sdt IS NULL OR LEN(sdt) <> 10 OR sdt LIKE '%[^0-9]%') OR
            (chuc_vu IS NULL OR chuc_vu NOT IN (N'Nhân viên', N'Quản lý'))
    )
    BEGIN
        RAISERROR(N'Cập nhật thất bại: Dữ liệu nhân viên không hợp lệ hoặc bị bỏ trống.', 16, 1);
        RETURN;
    END
    -- Cập nhật dữ liệu nếu hợp lệ
    UPDATE NHANVIEN
    SET 
        ho_ten = i.ho_ten,
        ngay_sinh = i.ngay_sinh,
        gioi_tinh = i.gioi_tinh,
        dia_chi = i.dia_chi,
        sdt = i.sdt,
        chuc_vu = i.chuc_vu
    FROM NHANVIEN n
    INNER JOIN inserted i ON n.id_nv = i.id_nv;
END
GO


--Trigger kiểm tra khi thêm khách hàng và sinh mã khách hàng tự động
CREATE TRIGGER trg_ThemKhachHang_AutoId
ON KHACHHANG
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    -- Kiểm tra dữ liệu không hợp lệ
    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE 
            -- Họ tên không được bỏ trống
            (ho_ten IS NULL OR LTRIM(RTRIM(ho_ten)) = '') OR
            -- Ngày sinh không được là hiện tại hoặc tương lai
            (ngay_sinh IS NULL OR CAST(ngay_sinh AS DATE) >= CAST(GETDATE() AS DATE)) OR
            -- Giới tính không được bỏ trống
            (gioi_tinh IS NULL OR LTRIM(RTRIM(gioi_tinh)) = '') OR
            -- Địa chỉ không được bỏ trống
            (dia_chi IS NULL OR LTRIM(RTRIM(dia_chi)) = '') OR
            -- Số điện thoại phải đúng 10 chữ số
            (sdt IS NULL OR LEN(sdt) <> 10 OR sdt LIKE '%[^0-9]%') OR
            -- Email phải có ký tự @
            (email IS NULL OR CHARINDEX('@', email) = 0)
    )
    BEGIN
        RAISERROR(N'Dữ liệu không hợp lệ: Kiểm tra lại họ tên, ngày sinh, giới tính, địa chỉ, số điện thoại hoặc email.', 16, 1);
        RETURN;
    END
    -- Sinh mã khách hàng tự động dựa trên mã KH hiện có
    DECLARE @MaxID INT;
    SELECT @MaxID = ISNULL(MAX(CAST(SUBSTRING(id_kh, 3, LEN(id_kh)) AS INT)), 0) FROM KHACHHANG;
    -- Chèn dữ liệu hợp lệ với mã KH mới
    INSERT INTO KHACHHANG (id_kh, ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, email)
    SELECT 
        'KH' + RIGHT('0000' + CAST(@MaxID + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS VARCHAR), 4),
        ho_ten, ngay_sinh, gioi_tinh, dia_chi, sdt, email
    FROM inserted;
END
GO

---- Trigger kiểm tra khi cập nhật khách hàng
CREATE TRIGGER trg_CapNhatKhachHang
ON KHACHHANG
INSTEAD OF UPDATE
AS
BEGIN
    -- Kiểm tra dữ liệu không hợp lệ
    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE 
            -- Họ tên không được null hoặc chỉ chứa khoảng trắng
            (ho_ten IS NULL OR LTRIM(RTRIM(ho_ten)) = '') OR

            -- Ngày sinh không hợp lệ (tương lai hoặc null)
            (ngay_sinh IS NULL OR CAST(ngay_sinh AS DATE) >= CAST(GETDATE() AS DATE)) OR

            -- Giới tính không hợp lệ (không nằm trong 2 giá trị cho phép)
            (gioi_tinh IS NULL OR gioi_tinh NOT IN (N'Nam', N'Nữ')) OR

            -- Địa chỉ không hợp lệ
            (dia_chi IS NULL OR LTRIM(RTRIM(dia_chi)) = '') OR

            -- SĐT không đúng 10 chữ số
            (sdt IS NULL OR LEN(sdt) <> 10 OR sdt LIKE '%[^0-9]%') OR

            -- Email không chứa ký tự @
            (email IS NULL OR CHARINDEX('@', email) = 0)
    )
    BEGIN
        RAISERROR(N'Cập nhật thất bại: Dữ liệu không hợp lệ hoặc bị bỏ trống.', 16, 1);
        RETURN;
    END
    -- Cập nhật dữ liệu nếu hợp lệ
    UPDATE KHACHHANG
    SET 
        ho_ten     = i.ho_ten,
        ngay_sinh  = i.ngay_sinh,
        gioi_tinh  = i.gioi_tinh,
        dia_chi    = i.dia_chi,
        sdt        = i.sdt,
        email      = i.email
    FROM KHACHHANG k
    INNER JOIN inserted i ON k.id_kh = i.id_kh;
END
GO

--Trigger kiểm tra khi thêm đồ ăn, nước uống và sinh mã tự động
CREATE TRIGGER trg_ThemDoAn_AutoId
ON DOAN
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra dữ liệu không hợp lệ
    IF EXISTS (
        SELECT 1
        FROM inserted i
        LEFT JOIN LOAIDOAN l ON i.id_loai = l.id_loai
        WHERE 
            (i.ten IS NULL OR LTRIM(RTRIM(i.ten)) = '') OR
            (l.ten NOT IN (N'Đồ ăn', N'Nước uống')) OR
            (i.gia IS NULL OR i.gia <= 0) OR
            (i.so_luong IS NULL OR i.so_luong <= 0)
    )
    BEGIN
        RAISERROR(N'Dữ liệu không hợp lệ. Kiểm tra lại tên món, loại, giá và số lượng.', 16, 1);
        RETURN;
    END

    -- Sinh mã tự động theo loại (DA hoặc NU)
    INSERT INTO DOAN (id_do_an, ten, id_loai, gia, so_luong, sl_con_lai)
    SELECT 
        CASE 
            WHEN l.ten = N'Đồ ăn' THEN 
                'DA' + RIGHT('000' + CAST(
                    (SELECT ISNULL(MAX(CAST(SUBSTRING(id_do_an, 3, LEN(id_do_an)) AS INT)), 0)
                     FROM DOAN WHERE id_do_an LIKE 'DA%') 
                    + ROW_NUMBER() OVER (PARTITION BY l.ten ORDER BY (SELECT NULL))
                AS VARCHAR), 3)
            WHEN l.ten = N'Nước uống' THEN 
                'NU' + RIGHT('000' + CAST(
                    (SELECT ISNULL(MAX(CAST(SUBSTRING(id_do_an, 3, LEN(id_do_an)) AS INT)), 0)
                     FROM DOAN WHERE id_do_an LIKE 'NU%') 
                    + ROW_NUMBER() OVER (PARTITION BY l.ten ORDER BY (SELECT NULL))
                AS VARCHAR), 3)
        END,
        i.ten, i.id_loai, i.gia, i.so_luong, i.so_luong
    FROM inserted i
    JOIN LOAIDOAN l ON i.id_loai = l.id_loai;
END
GO

--Trigger check cập nhật món
CREATE TRIGGER trg_Check_CapNhatDoAn
ON DOAN
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra dữ liệu hợp lệ
    IF EXISTS (
        SELECT 1
        FROM inserted i
        LEFT JOIN LOAIDOAN l ON i.id_loai = l.id_loai
        WHERE 
            (i.ten IS NULL OR LTRIM(RTRIM(i.ten)) = '') OR
            (l.ten NOT IN (N'Đồ ăn', N'Nước uống')) OR
            (i.gia IS NULL OR i.gia <= 0) OR
            (i.so_luong IS NULL OR i.so_luong <= 0) OR
            (i.sl_con_lai IS NULL OR i.sl_con_lai < 0) OR
            (i.sl_con_lai > i.so_luong)
    )
    BEGIN
        RAISERROR(N'Dữ liệu cập nhật không hợp lệ. Vui lòng kiểm tra tên, loại, giá, số lượng và số lượng còn lại.', 16, 1);
        RETURN;
    END

    -- Cập nhật
    UPDATE d
    SET 
        d.ten = i.ten,
        d.id_loai = i.id_loai,
        d.gia = i.gia,
        d.so_luong = i.so_luong,
        d.sl_con_lai = i.sl_con_lai
    FROM inserted i
    JOIN DOAN d ON d.id_do_an = i.id_do_an;
END
GO
