CREATE DATABASE RAPCHIEUPHIM
GO

USE RAPCHIEUPHIM
GO

---DƯƠNG
--Tạo bảng Khách hàng
CREATE TABLE KHACHHANG (
  id_kh varchar(15) NOT NULL primary key,
  ho_ten nvarchar(50) NOT NULL,
  ngay_sinh date NOT NULL,
  gioi_tinh NVARCHAR(10) CHECK (gioi_tinh IN ('Nam', N'Nữ')),
  dia_chi Nvarchar(100) NOT NULL,
  sdt varchar(10) not null,
  email varchar(50) not null
)
GO

INSERT INTO KHACHHANG VALUES 
('KH0001', N'Hồ Vĩ Khang', '2000-05-25', 'Nam', N'Quận 10', '0722636228', 'vikhang@gmail.com'),
('KH0002', N'Phạm Thành Tài', '2006-12-09', 'Nam',N'Quận Tân Phú', '0932938178', 'thanhtai@gmail.com'),
('KH0003', N'Trương Tiểu Mỹ', '1992-12-09', N'Nữ',N'Quận 11', '0711234123', 'tieumy@gmail.com'),
('KH0004', N'Lê Nhật Minh', '2001-01-15', 'Nam', N'Quận 3', '0911122233', 'nhatminh@gmail.com'),
('KH0005', N'Nguyễn Thị Hồng Anh', '1998-07-30', N'Nữ', N'Quận Bình Tân', '0922233344', 'honganh@gmail.com'),
('KH0006', N'Bùi Trung Hiếu', '1995-05-20', 'Nam', N'Quận Phú Nhuận', '0933344455', 'trunghieu@gmail.com'),
('KH0007', N'Võ Mai Lan', '2003-03-18', N'Nữ', N'Quận Gò Vấp', '0944455566', 'mailan@gmail.com')
GO

--Tạo bảng nhân viên
CREATE TABLE NHANVIEN (
  id_nv varchar(15) NOT NULL primary key,
  ho_ten nvarchar(45) NOT NULL,
  ngay_sinh date NOT NULL,
  gioi_tinh nVARCHAR(10) CHECK (gioi_tinh IN ('Nam', N'Nữ')),
  dia_chi nvarchar(100) NOT NULL,
  sdt varchar(10) not null,
  chuc_vu nvarchar(50)CHECK (chuc_vu IN (N'Quản lý', N'Nhân viên')) NOT NULL
)
GO

INSERT INTO NHANVIEN VALUES 
('NV0001', N'Trần Duy Quang', '2001-03-27', 'Nam', N'Quận 8', '0723357246', N'Nhân viên'),
('NV0002', N'Nguyễn Ái Xuân', '2005-11-08', N'Nữ', N'Quận Tân Bình', '0826346728', N'Nhân viên'),
('QL0001', N'Lê Phạm Tuấn Kiệt', '1999-09-16', 'Nam', N'Quận 5', '0927763253', N'Quản lý')
GO

--Tạo bảng Loại đồ ăn
CREATE TABLE LOAIDOAN (
  id_loai varchar(5) NOT NULL primary key,
  ten nvarchar(45) NOT NULL
)
go

INSERT INTO LOAIDOAN VALUES 
('DA', N'Đồ ăn'),
('NU', N'Nước uống')
GO

--Tạo bảng Đồ ăn
CREATE TABLE DOAN (
  id_do_an varchar(15) NOT NULL PRIMARY KEY,
  ten nvarchar(45) NOT NULL,
  id_loai varchar(5) NOT NULL,
  gia int not null,
  so_luong int not null,
  sl_con_lai int
)
GO
ALTER TABLE DOAN ADD CONSTRAINT FK_LOAIDOAN_DOAN FOREIGN KEY (id_loai) REFERENCES LOAIDOAN(id_loai)

INSERT INTO DOAN VALUES 
('DA001', N'Bánh snack cua','DA',10000, 10,10),
('DA002', N'Kẹo dẻo Boom Jelly','DA',20000,10,10),
('DA003', N'Bắp rang', 'DA',40000, 20,20),
('NU001', 'CocaCola', 'NU',25000, 25,25),
('NU002', N'Nước ép cam','NU',20000, 8,8),
('NU003', N'Sting dâu', 'NU',25000, 15,15);

INSERT INTO DOAN VALUES 
('DA004', N'Bánh snack bắp','DA',10000, 10,0),
('NU004', N'7Up','NU',10000, 10,5)


--HUYỀN
/****** Object:  Table [dbo].[DINHDANGPHIM]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DINHDANGPHIM](
	[id_dinh_dang] [varchar](10) NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
	[phu_thu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_dinh_dang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GHE]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GHE](
	[id_ghe] [varchar](10) NOT NULL,
	[vi_tri] [varchar](2) NOT NULL,
	[id_phong] [varchar](10) NOT NULL,
	[id_loai_ghe] [varchar](10) NOT NULL,
 CONSTRAINT [PK__GHE__D79649D80DDAF522] PRIMARY KEY CLUSTERED 
(
	[id_ghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIGHE]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIGHE](
	[id_loai_ghe] [varchar](10) NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
	[phu_thu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_loai_ghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIVE]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIVE](
	[id_loai_ve] [varchar](10) NOT NULL,
	[ten] [nvarchar](45) NOT NULL,
	[gia_ve] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_loai_ve] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIM]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIM](
	[MaPhim] [varchar](10) NOT NULL,
	[TenPhim] [nvarchar](50) NOT NULL,
	[NgayKhoiChieu] [date] NOT NULL,
	[ThoiLuong] [nvarchar](50) NOT NULL,
	[DaoDien] [nvarchar](50) NOT NULL,
	[DienVien] [nvarchar](200) NOT NULL,
	[NgonNgu] [nvarchar](50) NOT NULL,
	[MoTaNoiDung] [nvarchar](2000) NOT NULL,
	[id_dinh_dang] [varchar](10) NOT NULL,
	[id_the_loai] [int] NOT NULL,
	[Rated] [nvarchar](200) NOT NULL,
	[HinhAnh] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK__PHIM__4AC03DE3B05C4327] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[id_phong] [varchar](10) NOT NULL,
	[ten_phong] [nvarchar](50) NOT NULL,
	[sl_ghe] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_phong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUATCHIEU]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUATCHIEU](
	[id_suat_chieu] [varchar](15) NOT NULL,
	[tg_bat_dau] [time](7) NOT NULL,
	[tg_ket_thuc] [time](7) NOT NULL,
	[ngay_chieu] [date] NOT NULL,
	[MaPhim] [varchar](10) NOT NULL,
	[id_phong] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_suat_chieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAIPHIM]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAIPHIM](
	[id_the_loai] [int] NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_the_loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VE]    Script Date: 5/11/2025 10:50:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VE](
	[id_ve] [varchar](15) NOT NULL,
	[ngay_ban] [date] NOT NULL,
	[tong_tien] [int] NULL,
	[suat_chieu_id] [varchar](15) NOT NULL,
	[id_loai_ve] [varchar](10) NOT NULL,
	[id_ghe] [varchar](10) NOT NULL,
	[id_kh] [varchar](15) NULL,
	[id_nv] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ve] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GHE]  WITH CHECK ADD  CONSTRAINT [FK_LOAIGHE_GHE] FOREIGN KEY([id_loai_ghe])
REFERENCES [dbo].[LOAIGHE] ([id_loai_ghe])
GO
ALTER TABLE [dbo].[GHE] CHECK CONSTRAINT [FK_LOAIGHE_GHE]
GO
ALTER TABLE [dbo].[GHE]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_GHE] FOREIGN KEY([id_phong])
REFERENCES [dbo].[PHONG] ([id_phong])
GO
ALTER TABLE [dbo].[GHE] CHECK CONSTRAINT [FK_PHONG_GHE]
GO
ALTER TABLE [dbo].[PHIM]  WITH CHECK ADD  CONSTRAINT [FK_DINHDANGPHIM_PHIM] FOREIGN KEY([id_dinh_dang])
REFERENCES [dbo].[DINHDANGPHIM] ([id_dinh_dang])
GO
ALTER TABLE [dbo].[PHIM] CHECK CONSTRAINT [FK_DINHDANGPHIM_PHIM]
GO
ALTER TABLE [dbo].[PHIM]  WITH CHECK ADD  CONSTRAINT [FK_THELOAIPHIM_PHIM] FOREIGN KEY([id_the_loai])
REFERENCES [dbo].[THELOAIPHIM] ([id_the_loai])
GO
ALTER TABLE [dbo].[PHIM] CHECK CONSTRAINT [FK_THELOAIPHIM_PHIM]
GO
ALTER TABLE [dbo].[SUATCHIEU]  WITH CHECK ADD  CONSTRAINT [FK_PHIM_SUATCHIEU] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[PHIM] ([MaPhim])
GO
ALTER TABLE [dbo].[SUATCHIEU] CHECK CONSTRAINT [FK_PHIM_SUATCHIEU]
GO
ALTER TABLE [dbo].[SUATCHIEU]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_SUATCHIEU] FOREIGN KEY([id_phong])
REFERENCES [dbo].[PHONG] ([id_phong])
GO
ALTER TABLE [dbo].[SUATCHIEU] CHECK CONSTRAINT [FK_PHONG_SUATCHIEU]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_GHE_VE] FOREIGN KEY([id_ghe])
REFERENCES [dbo].[GHE] ([id_ghe])
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_GHE_VE]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_VE] FOREIGN KEY([id_kh])
REFERENCES [dbo].[KHACHHANG] ([id_kh])
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_KHACHHANG_VE]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_LOAIVE_VE] FOREIGN KEY([id_loai_ve])
REFERENCES [dbo].[LOAIVE] ([id_loai_ve])
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_LOAIVE_VE]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_VE] FOREIGN KEY([id_nv])
REFERENCES [dbo].[NHANVIEN] ([id_nv])
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_NHANVIEN_VE]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_VE_SUATCHIEU] FOREIGN KEY([suat_chieu_id])
REFERENCES [dbo].[SUATCHIEU] ([id_suat_chieu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_VE_SUATCHIEU]
GO

----INSERT HUYỀN
INSERT [dbo].[DINHDANGPHIM] ([id_dinh_dang], [ten], [phu_thu]) VALUES (N'2D', N'Định dạng 2D', 0)
GO
INSERT [dbo].[DINHDANGPHIM] ([id_dinh_dang], [ten], [phu_thu]) VALUES (N'3D', N'Định dạng 3D', 20000)
GO
INSERT [dbo].[DINHDANGPHIM] ([id_dinh_dang], [ten], [phu_thu]) VALUES (N'4D', N'Định dạng 4D', 35000)
GO
INSERT [dbo].[DINHDANGPHIM] ([id_dinh_dang], [ten], [phu_thu]) VALUES (N'IMAX', N'Định dạng IMAX', 50000)
GO
INSERT [dbo].[THELOAIPHIM] ([id_the_loai], [ten]) VALUES (1027, N'Hành động')
GO
INSERT [dbo].[THELOAIPHIM] ([id_the_loai], [ten]) VALUES (1028, N'Hài hước')
GO
INSERT [dbo].[THELOAIPHIM] ([id_the_loai], [ten]) VALUES (1029, N'Tình cảm')
GO
INSERT [dbo].[THELOAIPHIM] ([id_the_loai], [ten]) VALUES (1031, N'Kinh dị')
GO
INSERT [dbo].[THELOAIPHIM] ([id_the_loai], [ten]) VALUES (1032, N'Hoạt hình')
GO
INSERT [dbo].[THELOAIPHIM] ([id_the_loai], [ten]) VALUES (1033, N'Lịch sử')
GO
INSERT [dbo].[THELOAIPHIM] ([id_the_loai], [ten]) VALUES (1034, N'Khoa học viễn tưởng')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P001', N'ĐỊA ĐẠO: MẶT TRỜI TRONG BÓNG TỐI', CAST(N'2025-04-04' AS Date), N'128 phút', N'Bùi Thạc Chuyên', N'Thái Hòa; Quang Tuấn; Diễm Hằng Lamoon; Anh Tú Wilson; Hồ Thu Anh; Uyển Ân', N'Tiếng Việt - Phụ đề Tiếng Anh', N'Nhân dịp kỷ niệm 50 năm đất nước hoà bình này còn phim nào thoả được nỗi niềm thưởng thức thước phim thời chiến đầy hào hùng như Địa Đạo: Mặt Trời Trong Bóng Tối. Nay còn có thêm định dạng 4D cho khán giả trải nghiệm chui hầm dưới lòng Củ Chi đất thép.', N'4D', 1033, N'T16 - Phim được phổ biến đến người xem từ đủ 16 tuổi trở lên (16+)', N'Diadaomattroitrongbongtoi')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P002', N'MỘT BỘ PHIM MINECRAFT', CAST(N'2025-04-04' AS Date), N'101 phút', N'Jared Hess', N'Jason Momoa, Jack Black, Emma Myers, Sebastian Eugene Hansen, Danielle Brooks', N'Tiếng Anh – Phụ đề Tiếng Việt', N'Chào mừng bạn đến với thế giới của Minecraft, nơi sự sáng tạo không chỉ giúp bạn chế tạo mà còn là yếu tố quan trọng để sống sót! Bốn kẻ lạc lõng - Garrett “The Garbage Man” Garrison (Momoa), Henry (Hansen), Natalie (Myers) và Dawn (Brooks) - bất ngờ gặp rắc rối khi họ bị kéo qua cánh cửa bí ẩn dẫn đến Overworld: một thế giới kỳ lạ được tạo bởi những khối lập phương và phát triển nhờ vào trí tưởng tượng. Để trở về nhà, họ cần phải làm chủ được thế giới này (và bảo vệ nó khỏi những thực thể tà ác như Piglins và Thây Ma) trong khi dấn thân vào chuyến phiêu lưu màu nhiệm với một thợ chế tạo chuyên nghiệp và khó lường - Steve (Black). Chuyến hành trình này sẽ thách thức sự can đảm của cả năm người, thúc đẩy họ tìm lại với những phẩm chất làm nên sự đặc biệt của riêng mình,… đồng thời là những kỹ năng cần thiết để trở lại với thế giới thật.', N'3D', 1027, N'K - Phim được phổ biến đến người xem dưới 13 tuổi và có người bảo hộ đi kèm', N'motbophimminecraft')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P003', N'MẬT VỤ PHỤ HỒ', CAST(N'2025-04-04' AS Date), N'116 phút', N'David Ayer', N'Jason Statham, David Harbour, Michael Peña, Jason Flemyng', N'Tiếng Anh – Phụ đề Tiếng Việt', N'Levon Cade - cựu biệt kích tinh nhuệ thuộc lực lượng Thủy quân Lục chiến Hoàng gia Anh. Sau khi nghỉ hưu, anh sống cuộc đời yên bình là một công nhân xây dựng tại Chicago (Mỹ). Levon có mối quan hệ rất tốt với gia đình ông chủ Joe Garcia (Michael Peña). Một ngày nọ, cô con gái tuổi teen Jenny (Arianna Rivas) của Joe bị bắt cóc khiến chàng cựu quân nhân phải sử dụng lại các kỹ năng giết chóc của mình để giúp đỡ.', N'2D', 1027, N'T18 - Phim được phổ biến đến người xem từ đủ 18 tuổi trở lên (18+)', N'matvuphuho')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P004', N'QUỶ NHẬP TRÀNG', CAST(N'2025-03-07' AS Date), N'	121 phút 51 giây', N'Pom Nguyễn', N'Quang Tuấn, Khả Như, NSƯT Phú Đôn, Vân Dung, NSND Thanh Nam, Hoàng Mèo, Thanh Tân', N'Tiếng Việt - Phụ đề Tiếng Anh', N'Phim lấy cảm hứng từ câu chuyện có thật và “truyền thuyết kinh dị nhất về người chết sống lại” - Ở một ngôi làng vùng cao, cặp vợ chồng Quang và Như sống bằng nghề mai táng. Cuộc sống yên bình của họ bị xáo trộn khi phát hiện một cỗ quan tài vô chủ trên mảnh đất nhà mình. Từ đây, những hiện tượng kỳ lạ bắt đầu xảy ra và ám ảnh cả ngôi làng.', N'2D', 1031, N'T18 - Phim được phổ biến đến người xem từ đủ 18 tuổi trở lên (18+)', N'quynhaptrang')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P005', N'INTERSTELLAR (CHIẾU LẠI)', CAST(N'2024-02-28' AS Date), N'169  phút', N'Christopher Nolan', N'Matthew McConaughey, Anne Hathaway, Jessica Chastain', N'Tiếng Anh - Phụ đề Tiếng Việt', N'Một đoàn thám hiểm vũ trụ sử dụng một hố đen mới được khám phá để du hành xuyên không gian đến những vì sao xa xôi và tìm kiếm hy vọng cho loài người. “Interstellar” là biên niên ký về cuộc phiêu lưu vĩ đại của một nhóm các nhà thám hiểm sử dụng khám phá mới về lỗ đen vũ trụ để vượt qua các giới hạn thông thường trong du hành không gian, chinh phục khoảng không mênh mông trên một chuyến hành trình xuyên dải ngân hà.. Cùng trải nghiệm một INTERSTELLAR hoàn toàn khác biệt. Siêu phẩm của đạo diễn Christopher Nolan sẽ trở lại ĐỘC QUYỀN VỚI ĐỊNH DẠNG IMAX từ ngày 28.02.2025', N'IMAX', 1034, N'T13 - Phim được phổ biến đến người xem từ đủ 13 tuổi trở lên (13+)', N'interstellar')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P006', N'GẤU YÊU CỦA ANH', CAST(N'2025-03-21' AS Date), N'119 phút', N'Ping Lumprapleng', N'Jirayu Laongmanee, Sananthachat Thanapatpisal, Chinawut Indracusin, Supathat Opas, Kittisak Vechprasarn, Attawut Inthon, Likit Sittiphun,...', N'Tiếng Thái - Phụ đề tiếng Việt', N'	San mơ ngày trở lại gây dựng sự nghiệp, ai ngờ lại "trượt chân" vào lưới tình với Momo. Dù bị ông cậu khó tính Sanan ra sức cấm cản, anh chàng vẫn quyết tâm giành lấy chân ái đời mình. Hành trình chinh phục tình yêu của San bỗng chốc trở thành một chuỗi tình huống oái oăm, dở khóc dở cười!', N'2D', 1028, N'T16 - Phim được phổ biến đến người xem từ đủ 16 tuổi trở lên (16+)', N'gauyeucuaanh')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P007', N'KAYARA: CÔ BÉ CHIẾN BINH', CAST(N'2025-04-04' AS Date), N'80 phút	', N'César Zelada', N'', N'Lồng Tiếng Việt	', N'Kayara, một thiếu nữ xinh đẹp và mạnh mẽ, quyết tâm trở thành nữ sứ giả đầu tiên của Đế chế Inca. Trên hành trình đầy thử thách, cô gái phải vượt qua nhiều khó khăn và sự hiểm trở để bảo vệ thành phố Vàng khỏi những nguy cơ khai thác và cứu bạn bè, gia đình khỏi những mối đe dọa bất ngờ. Trong hành trình đầy thử thách đó, Kayara học được rằng sức mạnh thực sự không chỉ nằm ở thể chất mà còn ở sức mạnh của trí tuệ và sự đoàn kết.', N'2D', 1032, N'P - Phim được phép phổ biến đến người xem ở mọi độ tuổi.', N'cobechienbinh')
GO
INSERT [dbo].[PHIM] ([MaPhim], [TenPhim], [NgayKhoiChieu], [ThoiLuong], [DaoDien], [DienVien], [NgonNgu], [MoTaNoiDung], [id_dinh_dang], [id_the_loai], [Rated], [HinhAnh]) VALUES (N'P008', N'NGÀY XƯA CÓ MỘT CHUYỆN TÌNH (CHIẾU LẠI)', CAST(N'2024-10-28' AS Date), N'135 phút', N'Trịnh Đình Lê Minh', N'Avin Lu, Ngọc Xuân, Đỗ Nhật Hoàng, Thanh Tú, Bảo Tiên, Hạo Khang', N'Tiếng Việt - Phụ đề Tiếng Anh', N'Ngày Xưa Có Một Chuyện Tình xoay quanh câu chuyện tình bạn, tình yêu giữa hai chàng trai và một cô gái từ thuở ấu thơ cho đến khi trưởng thành, phải đối mặt với những thử thách của số phận. Trải dài trong 4 giai đoạn từ năm 1987 - 2000, ba người bạn cùng tuổi - Vinh, Miền, Phúc đã cùng yêu, cùng bỡ ngỡ bước vào đời, va vấp và vượt qua. (CHIẾU LẠI TỪ 28/03/2025)', N'2D', 1029, N'T16 - Phim được phổ biến đến người xem từ đủ 16 tuổi trở lên (16+)', N'ngayxuacomotchuyentinh')
GO
INSERT [dbo].[PHONG] ([id_phong], [ten_phong], [sl_ghe]) VALUES (N'R1', N'Room 1', 50)
GO
INSERT [dbo].[PHONG] ([id_phong], [ten_phong], [sl_ghe]) VALUES (N'R2', N'Room 2', 30)
GO
INSERT [dbo].[PHONG] ([id_phong], [ten_phong], [sl_ghe]) VALUES (N'R3', N'Room 3', 40)
GO
INSERT [dbo].[PHONG] ([id_phong], [ten_phong], [sl_ghe]) VALUES (N'R4', N'room 4', 20)
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC008', CAST(N'08:15:00' AS Time), CAST(N'10:15:00' AS Time), CAST(N'2025-05-20' AS Date), N'P003', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC009', CAST(N'15:25:00' AS Time), CAST(N'17:10:00' AS Time), CAST(N'2025-05-29' AS Date), N'P003', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC010', CAST(N'18:45:00' AS Time), CAST(N'20:20:00' AS Time), CAST(N'2025-05-31' AS Date), N'P004', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC011', CAST(N'11:10:00' AS Time), CAST(N'13:30:00' AS Time), CAST(N'2025-05-22' AS Date), N'P004', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC012', CAST(N'14:50:00' AS Time), CAST(N'16:15:00' AS Time), CAST(N'2025-05-23' AS Date), N'P005', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC013', CAST(N'19:00:00' AS Time), CAST(N'21:15:00' AS Time), CAST(N'2025-05-26' AS Date), N'P005', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC014', CAST(N'12:50:00' AS Time), CAST(N'14:30:00' AS Time), CAST(N'2025-05-24' AS Date), N'P006', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC015', CAST(N'15:25:00' AS Time), CAST(N'17:10:00' AS Time), CAST(N'2025-05-24' AS Date), N'P006', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC016', CAST(N'09:40:00' AS Time), CAST(N'11:10:00' AS Time), CAST(N'2025-05-25' AS Date), N'P006', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC017', CAST(N'16:02:00' AS Time), CAST(N'18:20:00' AS Time), CAST(N'2025-05-21' AS Date), N'P007', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC018', CAST(N'13:25:00' AS Time), CAST(N'15:15:00' AS Time), CAST(N'2025-05-21' AS Date), N'P007', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC019', CAST(N'09:00:00' AS Time), CAST(N'11:08:00' AS Time), CAST(N'2025-05-16' AS Date), N'P001', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC02', CAST(N'19:15:00' AS Time), CAST(N'22:30:00' AS Time), CAST(N'2025-05-17' AS Date), N'P001', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC020', CAST(N'14:00:00' AS Time), CAST(N'16:08:00' AS Time), CAST(N'2025-05-18' AS Date), N'P001', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC021', CAST(N'18:30:00' AS Time), CAST(N'20:38:00' AS Time), CAST(N'2025-05-17' AS Date), N'P001', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC022', CAST(N'12:00:00' AS Time), CAST(N'13:41:00' AS Time), CAST(N'2025-05-23' AS Date), N'P002', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC023', CAST(N'19:00:00' AS Time), CAST(N'20:41:00' AS Time), CAST(N'2025-05-24' AS Date), N'P002', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC024', CAST(N'20:00:00' AS Time), CAST(N'21:41:00' AS Time), CAST(N'2025-05-21' AS Date), N'P002', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC025', CAST(N'12:00:00' AS Time), CAST(N'13:56:00' AS Time), CAST(N'2025-05-20' AS Date), N'P003', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC026', CAST(N'20:00:00' AS Time), CAST(N'21:56:00' AS Time), CAST(N'2025-05-21' AS Date), N'P003', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC027', CAST(N'09:00:00' AS Time), CAST(N'10:56:00' AS Time), CAST(N'2025-05-19' AS Date), N'P003', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC028', CAST(N'21:00:00' AS Time), CAST(N'23:02:00' AS Time), CAST(N'2025-05-26' AS Date), N'P004', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC029', CAST(N'23:30:00' AS Time), CAST(N'01:32:00' AS Time), CAST(N'2025-05-19' AS Date), N'P004', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'sc03', CAST(N'17:03:33' AS Time), CAST(N'23:03:33' AS Time), CAST(N'2025-05-23' AS Date), N'P007', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC030', CAST(N'14:30:00' AS Time), CAST(N'17:19:00' AS Time), CAST(N'2025-05-25' AS Date), N'P005', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC031', CAST(N'18:00:00' AS Time), CAST(N'20:49:00' AS Time), CAST(N'2025-05-21' AS Date), N'P005', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC032', CAST(N'08:30:00' AS Time), CAST(N'10:29:00' AS Time), CAST(N'2025-05-26' AS Date), N'P006', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC033', CAST(N'16:00:00' AS Time), CAST(N'17:59:00' AS Time), CAST(N'2025-05-23' AS Date), N'P006', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC034', CAST(N'12:00:00' AS Time), CAST(N'13:20:00' AS Time), CAST(N'2025-05-25' AS Date), N'P007', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC035', CAST(N'10:00:00' AS Time), CAST(N'11:20:00' AS Time), CAST(N'2025-05-22' AS Date), N'P007', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC036', CAST(N'20:30:00' AS Time), CAST(N'22:45:00' AS Time), CAST(N'2025-05-25' AS Date), N'P008', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC037', CAST(N'15:00:00' AS Time), CAST(N'17:15:00' AS Time), CAST(N'2025-05-20' AS Date), N'P008', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC038', CAST(N'18:20:00' AS Time), CAST(N'20:15:00' AS Time), CAST(N'2025-05-25' AS Date), N'P008', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC039', CAST(N'15:00:00' AS Time), CAST(N'18:10:00' AS Time), CAST(N'2025-05-22' AS Date), N'P004', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC040', CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(N'2025-05-20' AS Date), N'P001', N'R1')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC041', CAST(N'10:15:00' AS Time), CAST(N'14:20:00' AS Time), CAST(N'2025-05-21' AS Date), N'P001', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC042', CAST(N'09:10:00' AS Time), CAST(N'11:25:00' AS Time), CAST(N'2025-05-21' AS Date), N'P001', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC043', CAST(N'22:00:00' AS Time), CAST(N'00:15:00' AS Time), CAST(N'2025-05-22' AS Date), N'P001', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC044', CAST(N'08:30:00' AS Time), CAST(N'10:10:00' AS Time), CAST(N'2025-05-22' AS Date), N'P002', N'R2')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC045', CAST(N'12:00:00' AS Time), CAST(N'14:25:00' AS Time), CAST(N'2025-05-22' AS Date), N'P002', N'R3')
GO
INSERT [dbo].[SUATCHIEU] ([id_suat_chieu], [tg_bat_dau], [tg_ket_thuc], [ngay_chieu], [MaPhim], [id_phong]) VALUES (N'SC046', CAST(N'21:45:00' AS Time), CAST(N'23:30:00' AS Time), CAST(N'2025-05-23' AS Date), N'P002', N'R1')
GO
INSERT [dbo].[LOAIGHE] ([id_loai_ghe], [ten], [phu_thu]) VALUES (N'GT', N'Ghế thuờng', 0)
GO
INSERT [dbo].[LOAIGHE] ([id_loai_ghe], [ten], [phu_thu]) VALUES (N'GV', N'Ghế VIP', 35000)
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A0', N'A0', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A1', N'A1', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A2', N'A2', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A3', N'A3', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A4', N'A4', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A5', N'A5', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A6', N'A6', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A7', N'A7', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A8', N'A8', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1A9', N'A9', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1B1', N'B1', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1B2', N'B2', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1B3', N'B3', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1B4', N'B4', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1B5', N'B5', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1C1', N'C1', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1C2', N'C2', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1C3', N'C3', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1C4', N'C4', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1C5', N'C5', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D0', N'D0', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D1', N'D1', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D2', N'D2', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D3', N'D3', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D4', N'D4', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D5', N'D5', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D6', N'D6', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D7', N'D7', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D8', N'D8', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1D9', N'D9', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E0', N'E0', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E1', N'E1', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E2', N'E2', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E3', N'E3', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E4', N'E4', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E5', N'E5', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E6', N'E6', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E7', N'E7', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E8', N'E8', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1E9', N'E9', N'R1', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F0', N'F0', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F1', N'F1', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F2', N'F2', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F3', N'F3', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F4', N'F4', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F5', N'F5', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F6', N'F6', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F7', N'F7', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F8', N'F8', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'1F9', N'F9', N'R1', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2A0', N'A0', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2A1', N'A1', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2A2', N'A2', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2A3', N'A3', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2A4', N'A4', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2B0', N'B0', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2B1', N'B1', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2B2', N'B2', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2B3', N'B3', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2B4', N'B4', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2C0', N'C0', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2C1', N'C1', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2C2', N'C2', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2C3', N'C3', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2C4', N'C4', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2D0', N'D0', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2D1', N'D1', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2D2', N'D2', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2D3', N'D3', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2D4', N'D4', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2E0', N'E0', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2E1', N'E1', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2E2', N'E2', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2E3', N'E3', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2E4', N'E4', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2F0', N'F0', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2F1', N'F1', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2F2', N'F2', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2F3', N'F3', N'R2', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'2F4', N'F4', N'R2', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A0', N'A0', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A1', N'A1', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A2', N'A2', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A3', N'A3', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A4', N'A4', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A5', N'A5', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A6', N'A6', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A7', N'A7', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A8', N'A8', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3A9', N'A9', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B0', N'B0', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B1', N'B1', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B2', N'B2', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B3', N'B3', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B4', N'B4', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B5', N'B5', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B6', N'B6', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B7', N'B7', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B8', N'B8', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3B9', N'B9', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C0', N'C0', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C1', N'C1', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C2', N'C2', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C3', N'C3', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C4', N'C4', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C5', N'C5', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C6', N'C6', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C7', N'C7', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C8', N'C8', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3C9', N'C9', N'R3', N'GV')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E0', N'E0', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E1', N'E1', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E2', N'E2', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E3', N'E3', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E4', N'E4', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E5', N'E5', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E6', N'E6', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E7', N'E7', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E8', N'E8', N'R3', N'GT')
GO
INSERT [dbo].[GHE] ([id_ghe], [vi_tri], [id_phong], [id_loai_ghe]) VALUES (N'3E9', N'E9', N'R3', N'GT')
GO
INSERT [dbo].[LOAIVE] ([id_loai_ve], [ten], [gia_ve]) VALUES (N'ADULT', N'Người lớn', 60000)
GO
INSERT [dbo].[LOAIVE] ([id_loai_ve], [ten], [gia_ve]) VALUES (N'KID', N'Trẻ em', 30000)
GO
INSERT [dbo].[LOAIVE] ([id_loai_ve], [ten], [gia_ve]) VALUES (N'STUDENT', N'Học sinh, sinh viên', 45000)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'0969fef5-b46c-4', CAST(N'2025-05-10' AS Date), 0, N'SC019', N'STUDENT', N'1B1', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'1416267f-4723-4', CAST(N'2025-05-10' AS Date), 0, N'SC019', N'STUDENT', N'1D0', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'27169606-db15-4', CAST(N'2025-05-11' AS Date), 0, N'SC018', N'STUDENT', N'3B4', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'3376751e-0fb9-4', CAST(N'2025-05-11' AS Date), 0, N'SC018', N'STUDENT', N'3B5', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'594eec1a-62f7-4', CAST(N'2025-05-10' AS Date), 0, N'SC019', N'STUDENT', N'1A0', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'a6786e74-5e40-4', CAST(N'2025-05-11' AS Date), 0, N'SC018', N'STUDENT', N'3B6', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'a90f552d-422e-4', CAST(N'2025-05-11' AS Date), 0, N'SC018', N'STUDENT', N'3B7', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'b957358c-b7c8-4', CAST(N'2025-05-11' AS Date), 0, N'SC018', N'STUDENT', N'3B8', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'd4fce174-4674-4', CAST(N'2025-05-10' AS Date), 0, N'SC019', N'STUDENT', N'1F0', NULL, NULL)
GO
INSERT [dbo].[VE] ([id_ve], [ngay_ban], [tong_tien], [suat_chieu_id], [id_loai_ve], [id_ghe], [id_kh], [id_nv]) VALUES (N'e59d6053-59d2-4', CAST(N'2025-05-10' AS Date), 0, N'SC019', N'STUDENT', N'1E0', NULL, NULL)
GO
---TIÊN
-- Tạo bảng tài khoản
CREATE TABLE TAIKHOAN (
    id_nv VARCHAR(15) NOT NULL PRIMARY KEY,
    Email VARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(100) NOT NULL,
    chuc_vu NVARCHAR(50) 
        CHECK (chuc_vu IN (N'Quản lý', N'Nhân viên')) 
        NOT NULL
);
INSERT INTO TAIKHOAN (id_nv, Email, MatKhau, chuc_vu)
VALUES 
('NV0001', 'quang@gmail.com', '123', N'Nhân viên');

INSERT INTO TAIKHOAN (id_nv, Email, MatKhau, chuc_vu)
VALUES 
('NV0002', 'xuan@gmail.com', '123', N'Nhân viên');

INSERT INTO TAIKHOAN (id_nv, Email, MatKhau, chuc_vu)
VALUES 
('QL0001', 'kietlpt2@gmail.com', '123', N'Quản lý');

ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_TAIKHOAN_NHANVIEN
FOREIGN KEY (id_nv) REFERENCES NHANVIEN(id_nv);


CREATE TABLE MAGIAMGIA (
    MaGG VARCHAR(20) PRIMARY KEY NOT NULL,
    PhanTramGiam INT NOT NULL,
    GiamToiDa INT NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    DieuKien NVARCHAR(100) NOT NULL,
    DonToiThieu INT NOT NULL DEFAULT 0,	
);
INSERT INTO MAGIAMGIA (MaGG, PhanTramGiam, GiamToiDa, NgayBatDau, NgayKetThuc, DieuKien)
VALUES 
    ('MOVIE10', 10, 30000, '2025-04-11', '2025-07-30', N'Áp dụng cho tất cả người dùng'),
    ('STUDENT50', 50, 100000, '2025-04-11', '2026-12-31', N'Phải có thẻ sinh viên'),
    ('NIGHTOWL15', 15, 20000, '2025-04-01', '2025-05-15', N'Áp dụng cho suất chiếu sau 21h');

CREATE TABLE HOADON (
    MaHoaDon INT PRIMARY KEY IDENTITY(1,1),
    id_kh VARCHAR(15) NULL,                      -- FK đến KHACHHANG
    id_nv VARCHAR(15) NOT NULL,                  -- FK đến NHANVIEN
    MaGG VARCHAR(20) NULL,                       -- FK đến MAGIAMGIA

    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    DiemDaDung INT DEFAULT 0,
    TongTien DECIMAL(18, 2) NOT NULL,
    TienGiam DECIMAL(18, 2) DEFAULT 0,
    TienThanhToan DECIMAL(18, 2) NOT NULL,
    GhiChu NVARCHAR(255) NULL,

    FOREIGN KEY (id_kh) REFERENCES KHACHHANG(id_kh),
    FOREIGN KEY (id_nv) REFERENCES NHANVIEN(id_nv),
    FOREIGN KEY (MaGG) REFERENCES MAGIAMGIA(MaGG)
); 



CREATE TABLE LICHSUTICHDIEM (
    id_tich_diem VARCHAR(15) PRIMARY KEY,
    ngay_tich_diem DATE NOT NULL,
    diem INT NOT NULL,
    noi_dung NVARCHAR(255),
    id_kh VARCHAR(15),      -- Mã khách hàng
    MaHoaDon int,    -- Mã hóa đơn

    FOREIGN KEY (id_kh) REFERENCES KHACHHANG(id_kh),
    FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon)
);

CREATE TABLE CHITIETHOADONVE (
    MaHoaDon INT ,
    id_suat_chieu VARCHAR(15),
    id_ghe VARCHAR(10),
    gia_ve DECIMAL(18,2) NOT NULL,
    id_loai_ve varchar(10)

    PRIMARY KEY (MaHoaDon, id_suat_chieu, id_ghe),
    FOREIGN KEY (id_loai_ve) REFERENCES LOAIVE(id_loai_ve),
    FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon),
    FOREIGN KEY (id_suat_chieu) REFERENCES SUATCHIEU(id_suat_chieu),
    FOREIGN KEY (id_ghe) REFERENCES GHE(id_ghe)
);

CREATE TABLE CHITIETHOADONDOAN (
    MaHoaDon INT ,
    id_do_an VARCHAR(15),
    so_luong INT NOT NULL,
    don_gia DECIMAL(18,2) NOT NULL, -- giá tại thời điểm bán (không phụ thuộc giá hiện tại)
    
    PRIMARY KEY (MaHoaDon, id_do_an),
    
    FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon),
    FOREIGN KEY (id_do_an) REFERENCES DOAN(id_do_an)
);
go


