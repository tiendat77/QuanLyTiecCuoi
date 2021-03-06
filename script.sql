USE [a]
GO
/****** Object:  Table [dbo].[BAOCAODOANHTHU]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAODOANHTHU](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nam] [int] NULL,
	[Thang] [int] NULL,
	[TongTiec] [int] NULL,
	[TongDoanhThu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CA]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenCa] [nvarchar](50) NULL,
 CONSTRAINT [PK_CA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETDICHVU]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDICHVU](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaChiTietDichVu]  AS (right('DV'+CONVERT([varchar](7),[id]),(7))) PERSISTED,
	[DoUong1] [nchar](50) NULL,
	[SLDoUong1] [int] NULL,
	[DoUong2] [nchar](50) NULL,
	[SLDoUong2] [int] NULL,
	[BanhKem] [nchar](50) NULL,
	[MC] [nchar](50) NULL,
	[BanNhac] [nchar](50) NULL,
	[CaSi] [nchar](50) NULL,
	[GiaCTDichVu] [money] NULL,
 CONSTRAINT [PK_CHITIETDICHVU] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[id] [int] NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaDichVu]  AS (right('DV'+CONVERT([varchar](7),[id]),(7))) PERSISTED,
	[TenDichVu] [nvarchar](50) NOT NULL,
	[MaLoaiDichVu] [nvarchar](10) NULL,
	[GiaDichVu] [money] NULL,
 CONSTRAINT [PK__DichVu__3213E83FFEDED205] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon]  AS (right('HÐ'+CONVERT([varchar](7),[id]),(7))) PERSISTED,
	[NgayLap] [date] NULL,
	[MaDatTiec] [int] NULL,
	[MaThongTinKhachHang] [int] NULL,
	[MaLoaiSanh] [int] NULL,
	[MaChiTietDichVu] [int] NULL,
	[MaThucDon] [int] NULL,
	[TienPhat] [money] NULL,
	[TongTienHoaDon] [money] NOT NULL,
	[TienCoc] [money] NOT NULL,
	[TienConLai] [money] NULL,
 CONSTRAINT [PK__HoaDon__3213E83F479F6D6E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LAPBAOCAO]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAPBAOCAO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaBaoCao]  AS (right('BC00'+CONVERT([varchar](5),[id]),(5))) PERSISTED,
	[NgayBaoCao] [date] NULL,
	[SoLuongTiec] [int] NULL,
	[DoanhThu] [int] NULL,
	[TiLe] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDICHVU]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDICHVU](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiDichVu] [nvarchar](10) NOT NULL,
	[TenLoaiDichVu] [nvarchar](50) NULL,
 CONSTRAINT [PK__LOAIDICH__3213E83F83A6E370] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIMONAN]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMONAN](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiMonAn] [nvarchar](10) NOT NULL,
	[TenLoaiMonAn] [nvarchar](50) NULL,
 CONSTRAINT [PK__LOAIMONA__3213E83F57635FC4] PRIMARY KEY CLUSTERED 
(
	[MaLoaiMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONAN](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaMonAn]  AS (right('MA'+CONVERT([varchar](7),[id]),(7))) PERSISTED,
	[TenMonAn] [nvarchar](50) NULL,
	[MaLoaiMonAn] [nvarchar](10) NULL,
	[GiaMonAn] [money] NULL,
 CONSTRAINT [PK__MONAN__3213E83FF2F421F8] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[id] [int] IDENTITY(5,1) NOT NULL,
	[MaNhanVien]  AS (right('NV00'+CONVERT([varchar](5),[id]),(5))) PERSISTED,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[SoDienThoai] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[LoaiSanh] [nvarchar](100) NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
	[Ca] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__TAIKHOAN__3213E83F389CC629] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINDATTIEC]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINDATTIEC](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaDatTiec]  AS (right('DT'+CONVERT([varchar](7),[id]),(7))) PERSISTED,
	[NgayLap] [date] NULL,
	[MaThongTinKhachHang] [int] NULL,
	[MaLoaiSanh] [int] NULL,
	[MaDichVu] [int] NULL,
	[MaThucDon] [int] NULL,
	[SoLuongNhanVien] [int] NOT NULL,
	[SoLuongBan] [int] NULL,
	[Ca] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__ThongTin__3213E83F24497C16] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINKHACHHANG]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINKHACHHANG](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang]  AS (right('KH'+CONVERT([varchar](7),[id]),(7))) PERSISTED,
	[NgayLap] [date] NOT NULL,
	[TenKhachHang] [nvarchar](100) NOT NULL,
	[TenChuRe] [nvarchar](100) NOT NULL,
	[TenCoDau] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[NgayToChuc] [date] NOT NULL,
	[TienCoc] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINSANH]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINSANH](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiSanh] [nvarchar](100) NULL,
	[TenSanh] [nvarchar](100) NOT NULL,
	[SoLuongBanToiDa] [int] NOT NULL,
	[DonGiaToiThieu] [money] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUCDON]    Script Date: 05/22/2019 9:42:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUCDON](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaThucDon]  AS (right('TD'+CONVERT([varchar](7),[id]),(7))) PERSISTED,
	[MonKhaiVi] [nvarchar](100) NOT NULL,
	[MonChinh1] [nvarchar](100) NOT NULL,
	[MonChinh2] [nvarchar](100) NOT NULL,
	[MonChinh3] [nvarchar](100) NOT NULL,
	[Lau] [nvarchar](100) NOT NULL,
	[TrangMieng] [nvarchar](100) NOT NULL,
	[GiaThucDon] [money] NOT NULL,
 CONSTRAINT [PK__ThucDon__3213E83F126B1047] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BAOCAODOANHTHU] ON 

INSERT [dbo].[BAOCAODOANHTHU] ([id], [Nam], [Thang], [TongTiec], [TongDoanhThu]) VALUES (1, 2019, 5, 5, 418500000)
INSERT [dbo].[BAOCAODOANHTHU] ([id], [Nam], [Thang], [TongTiec], [TongDoanhThu]) VALUES (2, 2019, 6, 1, 222500000)
SET IDENTITY_INSERT [dbo].[BAOCAODOANHTHU] OFF
SET IDENTITY_INSERT [dbo].[CA] ON 

INSERT [dbo].[CA] ([id], [TenCa]) VALUES (2, N'Tối')
INSERT [dbo].[CA] ([id], [TenCa]) VALUES (4, N'Trưa')
SET IDENTITY_INSERT [dbo].[CA] OFF
SET IDENTITY_INSERT [dbo].[CHITIETDICHVU] ON 

INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (11, N'Budweiser                                         ', 100, N'Coca Cola                                         ', 12, N'Bánh kem 5 tầng                                   ', N'MC Hari Won                                       ', N'Ban nhạc                                          ', N'Chi Pu                                            ', 119400000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (12, N'Tiger                                             ', 2, N'Tiger                                             ', 2, N'Bánh kem 2 tầng                                   ', N'MC Trấn Thành                                     ', N'Ban nhạc                                          ', N'Sơn Tùng MTP                                      ', 7200000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (13, N'Tiger                                             ', 1, N'Tiger                                             ', 13, N'Bánh kem 2 tầng                                   ', N'MC Trấn Thành                                     ', N'Ban nhạc                                          ', N'Sơn Tùng MTP                                      ', 11200000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (14, N'Tiger                                             ', 1, N'Tiger                                             ', 1, N'Bánh kem 2 tầng                                   ', N'MC Trấn Thành                                     ', N'Ban nhạc                                          ', N'Sơn Tùng MTP                                      ', 6400000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (15, N'Tiger                                             ', 2, N'Tiger                                             ', 2, N'Bánh kem 2 tầng                                   ', N'MC Trấn Thành                                     ', N'Ban nhạc                                          ', N'Sơn Tùng MTP                                      ', 7200000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (16, N'Tiger                                             ', 25, N'Budweiser                                         ', 25, N'Bánh kem 5 tầng                                   ', N'MC Hari Won                                       ', N'Ban nhạc                                          ', N'SooBin Hoàng Sơn                                  ', 40900000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (17, N'Nước suối                                         ', 15, N'Pepsi                                             ', 15, N'Bánh kem 2 tầng                                   ', N'MC Trấn Thành                                     ', N'Ban nhạc                                          ', N'Sơn Tùng MTP                                      ', 10400000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (18, N'Heineken                                          ', 30, N'Tiger                                             ', 30, N'Bánh kem 5 tầng                                   ', N'MC Trấn Thành                                     ', N'Ban nhạc                                          ', N'SooBin Hoàng Sơn                                  ', 35900000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (1017, N'Pepsi                                             ', 50, N'Coca Cola                                         ', 50, N'Bánh kem 2 tầng                                   ', N'MC Trường Giang                                   ', N'Black Pink                                        ', N'Chi Pu                                            ', 73000000.0000)
INSERT [dbo].[CHITIETDICHVU] ([id], [DoUong1], [SLDoUong1], [DoUong2], [SLDoUong2], [BanhKem], [MC], [BanNhac], [CaSi], [GiaCTDichVu]) VALUES (1018, N'Tiger                                             ', 1, N'Tiger                                             ', 1, N'Bánh kem 2 tầng                                   ', N'MC Trấn Thành                                     ', N'Ban nhạc                                          ', N'Sơn Tùng MTP                                      ', 6400000.0000)
SET IDENTITY_INSERT [dbo].[CHITIETDICHVU] OFF
INSERT [dbo].[CHUCVU] ([id], [ChucVu]) VALUES (1, N'Giám sát')
INSERT [dbo].[CHUCVU] ([id], [ChucVu]) VALUES (4, N'Phục vụ')
INSERT [dbo].[CHUCVU] ([id], [ChucVu]) VALUES (5, N'Quản lý')
SET IDENTITY_INSERT [dbo].[DICHVU] ON 

INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (18, N'Tiger', N'DU', 400000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (19, N'Heineken', N'DU', 600000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (20, N'Budweiser', N'DU', 1000000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (21, N'Coca Cola', N'DU', 300000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (22, N'Pepsi', N'DU', 300000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (23, N'Nước suối', N'DU', 20000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (24, N'Bánh kem 2 tầng', N'BK', 500000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (25, N'Bánh kem 3 tầng', N'BK', 600000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (26, N'Bánh kem 4 tầng', N'BK', 700000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (27, N'Bánh kem 5 tầng', N'BK', 800000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (28, N'MC Trấn Thành', N'MC', 2000000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (29, N'MC Hari Won', N'MC', 2000000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (30, N'MC Trường Giang', N'MC', 2500000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (31, N'Ban nhạc', N'BN', 3000000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (32, N'Sơn Tùng MTP', N'CS', 100000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (33, N'Chi Pu', N'CS', 10000000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (34, N'SooBin Hoàng Sơn', N'CS', 100000.0000)
INSERT [dbo].[DICHVU] ([id], [TenDichVu], [MaLoaiDichVu], [GiaDichVu]) VALUES (35, N'Black Pink', N'BN', 30000000.0000)
SET IDENTITY_INSERT [dbo].[DICHVU] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (1, CAST(N'2019-05-18' AS Date), 6, 5, 4, 18, 23, 0.0000, 114700000.0000, 30000000.0000, 84700000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (2, CAST(N'2019-05-11' AS Date), 5, 4, 1, 17, 22, 501000.0000, 50100000.0000, 10000000.0000, 40601000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (3, CAST(N'2019-05-11' AS Date), 4, 3, 4, 16, 21, 0.0000, 106800000.0000, 50000000.0000, 56800000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (4, CAST(N'2019-05-20' AS Date), 6, 5, 4, 18, 23, 0.0000, 114700000.0000, 30000000.0000, 84700000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (1002, CAST(N'2019-06-06' AS Date), 1005, 1004, 1, 1017, 1022, 0.0000, 222500000.0000, 60000000.0000, 162500000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (1003, CAST(N'2019-05-21' AS Date), 3, 1, 2, 15, 16, 0.0000, 32200000.0000, 100000000.0000, -67800000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (2003, CAST(N'2019-05-22' AS Date), 1005, 1004, 1, 1017, 1022, 0.0000, 221500000.0000, 60000000.0000, 161500000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (2004, CAST(N'2019-05-22' AS Date), 1005, 1004, 1, 1017, 1022, 0.0000, 221500000.0000, 60000000.0000, 161500000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (2005, CAST(N'2019-05-22' AS Date), 1005, 1004, 1, 1017, 1022, 0.0000, 221500000.0000, 60000000.0000, 161500000.0000)
INSERT [dbo].[HOADON] ([id], [NgayLap], [MaDatTiec], [MaThongTinKhachHang], [MaLoaiSanh], [MaChiTietDichVu], [MaThucDon], [TienPhat], [TongTienHoaDon], [TienCoc], [TienConLai]) VALUES (2006, CAST(N'2019-05-22' AS Date), 1005, 1004, 1, 1017, 1022, 0.0000, 221500000.0000, 60000000.0000, 161500000.0000)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[LAPBAOCAO] ON 

INSERT [dbo].[LAPBAOCAO] ([id], [NgayBaoCao], [SoLuongTiec], [DoanhThu], [TiLe]) VALUES (1, CAST(N'2019-05-18' AS Date), 1, 114700000, 27.4)
INSERT [dbo].[LAPBAOCAO] ([id], [NgayBaoCao], [SoLuongTiec], [DoanhThu], [TiLe]) VALUES (33, CAST(N'2019-05-11' AS Date), 2, 156900000, 37.49)
INSERT [dbo].[LAPBAOCAO] ([id], [NgayBaoCao], [SoLuongTiec], [DoanhThu], [TiLe]) VALUES (34, CAST(N'2019-05-20' AS Date), 1, 114700000, 27.4)
INSERT [dbo].[LAPBAOCAO] ([id], [NgayBaoCao], [SoLuongTiec], [DoanhThu], [TiLe]) VALUES (1033, CAST(N'2019-06-06' AS Date), 1, 222500000, NULL)
INSERT [dbo].[LAPBAOCAO] ([id], [NgayBaoCao], [SoLuongTiec], [DoanhThu], [TiLe]) VALUES (1034, CAST(N'2019-05-21' AS Date), 1, 32200000, 7.71)
SET IDENTITY_INSERT [dbo].[LAPBAOCAO] OFF
SET IDENTITY_INSERT [dbo].[LOAIDICHVU] ON 

INSERT [dbo].[LOAIDICHVU] ([id], [MaLoaiDichVu], [TenLoaiDichVu]) VALUES (2, N'BK', N'Bánh Kem')
INSERT [dbo].[LOAIDICHVU] ([id], [MaLoaiDichVu], [TenLoaiDichVu]) VALUES (4, N'BN', N'Ban Nhạc')
INSERT [dbo].[LOAIDICHVU] ([id], [MaLoaiDichVu], [TenLoaiDichVu]) VALUES (5, N'CS', N'Ca Sĩ')
INSERT [dbo].[LOAIDICHVU] ([id], [MaLoaiDichVu], [TenLoaiDichVu]) VALUES (1, N'DU', N'Đồ uống')
INSERT [dbo].[LOAIDICHVU] ([id], [MaLoaiDichVu], [TenLoaiDichVu]) VALUES (3, N'MC', N'MC')
SET IDENTITY_INSERT [dbo].[LOAIDICHVU] OFF
SET IDENTITY_INSERT [dbo].[LOAIMONAN] ON 

INSERT [dbo].[LOAIMONAN] ([id], [MaLoaiMonAn], [TenLoaiMonAn]) VALUES (3, N'KV', N'Khai Vị')
INSERT [dbo].[LOAIMONAN] ([id], [MaLoaiMonAn], [TenLoaiMonAn]) VALUES (4, N'MC', N'Món Chính')
INSERT [dbo].[LOAIMONAN] ([id], [MaLoaiMonAn], [TenLoaiMonAn]) VALUES (5, N'ML', N'Lẩu')
INSERT [dbo].[LOAIMONAN] ([id], [MaLoaiMonAn], [TenLoaiMonAn]) VALUES (6, N'TM', N'Tráng Miệng')
SET IDENTITY_INSERT [dbo].[LOAIMONAN] OFF
SET IDENTITY_INSERT [dbo].[MONAN] ON 

INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (1, N'Gỏi ngó sen', N'KV', 150000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (3, N'Bát bửu thịt nguội', N'KV', 150000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (4, N'Heo quay bánh hỏi', N'KV', 150000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (5, N'Bò lagu', N'MC', 250000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (6, N'Tôm hấp', N'MC', 250000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (7, N'Nai né', N'MC', 250000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (8, N'Gà bó xôi', N'MC', 250000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (9, N'Lẩu thái', N'ML', 300000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (10, N'Lẩu bò', N'ML', 300000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (11, N'Lẩu cá', N'ML', 300000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (1002, N'Chè bắp', N'TM', 90000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (1003, N'Chè hạt sen', N'TM', 90000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (1004, N'Rau câu ngũ sắc', N'TM', 50000.0000)
INSERT [dbo].[MONAN] ([id], [TenMonAn], [MaLoaiMonAn], [GiaMonAn]) VALUES (1005, N'Thịt Đường Tăng', N'MC', 500000.0000)
SET IDENTITY_INSERT [dbo].[MONAN] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([id], [TenNhanVien], [SoDienThoai], [DiaChi], [LoaiSanh], [ChucVu], [Ca]) VALUES (8, N'Hoang Thảo', N'0979765432', N'Tân Bình', N'Loai A', N'Quản lý', N'Tối')
INSERT [dbo].[NHANVIEN] ([id], [TenNhanVien], [SoDienThoai], [DiaChi], [LoaiSanh], [ChucVu], [Ca]) VALUES (9, N'Hoàng Diệu', N'01223456789', N'Kha Vạn Cân', N'Loai D', N'Phục vụ', N'Trưa')
INSERT [dbo].[NHANVIEN] ([id], [TenNhanVien], [SoDienThoai], [DiaChi], [LoaiSanh], [ChucVu], [Ca]) VALUES (10, N'Ngọc Mai', N'01223811235', N'Quang Trung', N'Loai B', N'Giám sát', N'Trưa')
INSERT [dbo].[NHANVIEN] ([id], [TenNhanVien], [SoDienThoai], [DiaChi], [LoaiSanh], [ChucVu], [Ca]) VALUES (11, N'Ngọc', N'01223811236', N'Hoàng Diệu 8', N'Loai C', N'Phục vụ', N'Tối')
INSERT [dbo].[NHANVIEN] ([id], [TenNhanVien], [SoDienThoai], [DiaChi], [LoaiSanh], [ChucVu], [Ca]) VALUES (17, N'Hoang Thảo', N'1234567890', N'Tân Bình', N'Loai A', N'Quản lý', N'Tối')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([id], [TenDangNhap], [MatKhau]) VALUES (6, N'dat', N'dat')
INSERT [dbo].[TAIKHOAN] ([id], [TenDangNhap], [MatKhau]) VALUES (1002, N'bao', N'a')
INSERT [dbo].[TAIKHOAN] ([id], [TenDangNhap], [MatKhau]) VALUES (1003, N'an', N'an')
INSERT [dbo].[TAIKHOAN] ([id], [TenDangNhap], [MatKhau]) VALUES (1004, N'duc', N'duc')
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
SET IDENTITY_INSERT [dbo].[THONGTINDATTIEC] ON 

INSERT [dbo].[THONGTINDATTIEC] ([id], [NgayLap], [MaThongTinKhachHang], [MaLoaiSanh], [MaDichVu], [MaThucDon], [SoLuongNhanVien], [SoLuongBan], [Ca]) VALUES (3, CAST(N'2019-05-18' AS Date), 1, 2, 15, 16, 100, 20, N'Tối')
INSERT [dbo].[THONGTINDATTIEC] ([id], [NgayLap], [MaThongTinKhachHang], [MaLoaiSanh], [MaDichVu], [MaThucDon], [SoLuongNhanVien], [SoLuongBan], [Ca]) VALUES (4, CAST(N'2019-05-18' AS Date), 3, 4, 16, 21, 50, 50, N'Tối')
INSERT [dbo].[THONGTINDATTIEC] ([id], [NgayLap], [MaThongTinKhachHang], [MaLoaiSanh], [MaDichVu], [MaThucDon], [SoLuongNhanVien], [SoLuongBan], [Ca]) VALUES (5, CAST(N'2019-05-01' AS Date), 4, 1, 17, 22, 30, 30, N'Tối')
INSERT [dbo].[THONGTINDATTIEC] ([id], [NgayLap], [MaThongTinKhachHang], [MaLoaiSanh], [MaDichVu], [MaThucDon], [SoLuongNhanVien], [SoLuongBan], [Ca]) VALUES (6, CAST(N'2019-05-08' AS Date), 5, 4, 18, 23, 60, 60, N'Trưa')
INSERT [dbo].[THONGTINDATTIEC] ([id], [NgayLap], [MaThongTinKhachHang], [MaLoaiSanh], [MaDichVu], [MaThucDon], [SoLuongNhanVien], [SoLuongBan], [Ca]) VALUES (1005, CAST(N'2019-05-21' AS Date), 1004, 1, 1017, 1022, 99, 99, N'Tối')
SET IDENTITY_INSERT [dbo].[THONGTINDATTIEC] OFF
SET IDENTITY_INSERT [dbo].[THONGTINKHACHHANG] ON 

INSERT [dbo].[THONGTINKHACHHANG] ([id], [NgayLap], [TenKhachHang], [TenChuRe], [TenCoDau], [DiaChi], [DienThoai], [Email], [NgayToChuc], [TienCoc]) VALUES (1, CAST(N'2019-05-18' AS Date), N'Hoàng Thảo', N'Huỳnh Tiến Đạt', N'Lý Thị Thu An', N'Ký Túc Xá Khu B', N'0907335924', N'hoangthao@gmail.com', CAST(N'2019-05-20' AS Date), 100000000.0000)
INSERT [dbo].[THONGTINKHACHHANG] ([id], [NgayLap], [TenKhachHang], [TenChuRe], [TenCoDau], [DiaChi], [DienThoai], [Email], [NgayToChuc], [TienCoc]) VALUES (2, CAST(N'2019-05-19' AS Date), N'Tiến Đạt', N'Phạm Vũ Thiên Bảo', N'Trần Thị Thùy Trang', N'Phan Huy Ích, Gò Vấp', N'03644987654', N'tiendat@gmail.com', CAST(N'2019-05-25' AS Date), 110000000.0000)
INSERT [dbo].[THONGTINKHACHHANG] ([id], [NgayLap], [TenKhachHang], [TenChuRe], [TenCoDau], [DiaChi], [DienThoai], [Email], [NgayToChuc], [TienCoc]) VALUES (3, CAST(N'2019-05-18' AS Date), N'Ngô Xuân Đức', N'Lâm Tiên Điền An', N'Trần Thị Kim Oanh', N'Dĩ An, Bình Dương', N'0356897150', N'xuanduc@gmail.com', CAST(N'2019-05-30' AS Date), 50000000.0000)
INSERT [dbo].[THONGTINKHACHHANG] ([id], [NgayLap], [TenKhachHang], [TenChuRe], [TenCoDau], [DiaChi], [DienThoai], [Email], [NgayToChuc], [TienCoc]) VALUES (4, CAST(N'2019-05-01' AS Date), N'Lưu Bị', N'Lữ Bố', N'Điêu Thuyền', N'Bắc Kinh', N'3337892456', N'luubi@yahoo.com', CAST(N'2019-05-10' AS Date), 10000000.0000)
INSERT [dbo].[THONGTINKHACHHANG] ([id], [NgayLap], [TenKhachHang], [TenChuRe], [TenCoDau], [DiaChi], [DienThoai], [Email], [NgayToChuc], [TienCoc]) VALUES (5, CAST(N'2019-05-08' AS Date), N'An Dương Vương', N'Trọng Thủy', N'Mị Châu', N'Thành Cổ Loa', N'0908762495', N'anduongvuong@gmail.com', CAST(N'2019-05-18' AS Date), 30000000.0000)
INSERT [dbo].[THONGTINKHACHHANG] ([id], [NgayLap], [TenKhachHang], [TenChuRe], [TenCoDau], [DiaChi], [DienThoai], [Email], [NgayToChuc], [TienCoc]) VALUES (1004, CAST(N'2019-05-21' AS Date), N'Thượng Đế', N'Ngưu Lang', N'Chức Nữ', N'Tầng Mây Thứ 6', N'0000000000', N'thuongde@thiencung.com', CAST(N'2019-06-06' AS Date), 60000000.0000)
SET IDENTITY_INSERT [dbo].[THONGTINKHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[THONGTINSANH] ON 

INSERT [dbo].[THONGTINSANH] ([id], [LoaiSanh], [TenSanh], [SoLuongBanToiDa], [DonGiaToiThieu], [GhiChu]) VALUES (1, N'Loai A', N'Đồng', 50, 10000000.0000, N'Không')
INSERT [dbo].[THONGTINSANH] ([id], [LoaiSanh], [TenSanh], [SoLuongBanToiDa], [DonGiaToiThieu], [GhiChu]) VALUES (2, N'Loai B', N'Bạc', 60, 1100000.0000, N'Không')
INSERT [dbo].[THONGTINSANH] ([id], [LoaiSanh], [TenSanh], [SoLuongBanToiDa], [DonGiaToiThieu], [GhiChu]) VALUES (3, N'Loai C', N'Vàng', 70, 1200000.0000, N'Không')
INSERT [dbo].[THONGTINSANH] ([id], [LoaiSanh], [TenSanh], [SoLuongBanToiDa], [DonGiaToiThieu], [GhiChu]) VALUES (4, N'Loai D', N'Bạch Kim', 85, 1400000.0000, N'Không')
INSERT [dbo].[THONGTINSANH] ([id], [LoaiSanh], [TenSanh], [SoLuongBanToiDa], [DonGiaToiThieu], [GhiChu]) VALUES (5, N'Loai E', N'Kim Cương', 100, 1600000.0000, N'Không')
SET IDENTITY_INSERT [dbo].[THONGTINSANH] OFF
SET IDENTITY_INSERT [dbo].[THUCDON] ON 

INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (16, N'Heo quay bánh hỏi', N'Tôm hấp', N'Nai né', N'Gà bó xôi', N'Lẩu cá', N'Rau câu ngũ sắc', 1250000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (17, N'Gỏi ngó sen', N'Bò lagu', N'Bò lagu', N'Bò lagu', N'Lẩu thái', N'Chè bắp', 1290000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (18, N'Gỏi ngó sen', N'Bò lagu', N'Bò lagu', N'Bò lagu', N'Lẩu thái', N'Chè bắp', 1290000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (19, N'Gỏi ngó sen', N'Bò lagu', N'Bò lagu', N'Bò lagu', N'Lẩu thái', N'Chè bắp', 1290000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (20, N'Gỏi ngó sen', N'Bò lagu', N'Bò lagu', N'Bò lagu', N'Lẩu thái', N'Chè bắp', 1290000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (21, N'Bát bửu thịt nguội', N'Nai né', N'Tôm hấp', N'Gà bó xôi', N'Lẩu bò', N'Chè hạt sen', 1290000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (22, N'Gỏi ngó sen', N'Tôm hấp', N'Nai né', N'Bò lagu', N'Lẩu thái', N'Chè bắp', 1290000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (23, N'Gỏi ngó sen', N'Tôm hấp', N'Gà bó xôi', N'Nai né', N'Lẩu thái', N'Chè bắp', 1290000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (1022, N'Gỏi ngó sen', N'Thịt Đường Tăng', N'Tôm hấp', N'Nai né', N'Lẩu thái', N'Rau câu ngũ sắc', 1500000.0000)
INSERT [dbo].[THUCDON] ([id], [MonKhaiVi], [MonChinh1], [MonChinh2], [MonChinh3], [Lau], [TrangMieng], [GiaThucDon]) VALUES (1023, N'Gỏi ngó sen', N'Bò lagu', N'Bò lagu', N'Bò lagu', N'Lẩu thái', N'Chè bắp', 1290000.0000)
SET IDENTITY_INSERT [dbo].[THUCDON] OFF
ALTER TABLE [dbo].[THONGTINSANH] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [TenSanh]
GO
ALTER TABLE [dbo].[THONGTINSANH] ADD  DEFAULT (N'Trống') FOR [GhiChu]
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD  CONSTRAINT [FK__DICHVU__MaLoaiDi__02FC7413] FOREIGN KEY([MaLoaiDichVu])
REFERENCES [dbo].[LOAIDICHVU] ([MaLoaiDichVu])
GO
ALTER TABLE [dbo].[DICHVU] CHECK CONSTRAINT [FK__DICHVU__MaLoaiDi__02FC7413]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__IdLoaiSa__5165187F] FOREIGN KEY([MaLoaiSanh])
REFERENCES [dbo].[THONGTINSANH] ([id])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HoaDon__IdLoaiSa__5165187F]
GO
ALTER TABLE [dbo].[HOADON]  WITH NOCHECK ADD  CONSTRAINT [FK__HoaDon__IdMaDatT__4F7CD00D] FOREIGN KEY([MaDatTiec])
REFERENCES [dbo].[THONGTINDATTIEC] ([id])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HoaDon__IdMaDatT__4F7CD00D]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__IDThongT__5070F446] FOREIGN KEY([MaThongTinKhachHang])
REFERENCES [dbo].[THONGTINKHACHHANG] ([id])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HoaDon__IDThongT__5070F446]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__IdThucDo__534D60F1] FOREIGN KEY([MaThucDon])
REFERENCES [dbo].[THUCDON] ([id])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HoaDon__IdThucDo__534D60F1]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_CHITIETDICHVU] FOREIGN KEY([MaChiTietDichVu])
REFERENCES [dbo].[CHITIETDICHVU] ([id])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_CHITIETDICHVU]
GO
ALTER TABLE [dbo].[MONAN]  WITH CHECK ADD  CONSTRAINT [FK__MONAN__MaLoaiMon__7D439ABD] FOREIGN KEY([MaLoaiMonAn])
REFERENCES [dbo].[LOAIMONAN] ([MaLoaiMonAn])
GO
ALTER TABLE [dbo].[MONAN] CHECK CONSTRAINT [FK__MONAN__MaLoaiMon__7D439ABD]
GO
