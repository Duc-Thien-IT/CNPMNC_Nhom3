USE [QL_LinhKienMayTinh]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaSP] [varchar](10) NOT NULL,
	[MaHoaDon] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[TongTien] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonSuaChua]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonSuaChua](
	[MaCTSC] [varchar](10) NOT NULL,
	[MaHD] [varchar](10) NOT NULL,
	[GiaTienCong] [decimal](18, 2) NULL,
	[ThoiGianBaoHanh] [date] NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_ChiTietHoaDonSuaChua] PRIMARY KEY CLUSTERED 
(
	[MaCTSC] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuDat]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuDat](
	[MaPhieuDat] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuongDat] [int] NULL,
	[DonGia] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ChiTietPhieuDat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuGiao]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuGiao](
	[MaPhieuGiao] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuongGiao] [int] NULL,
	[Gia] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ChiTietPhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucSanPham]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucSanPham](
	[MaDanhMuc] [varchar](10) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](10) NOT NULL,
	[NgayLap] [datetime] NULL,
	[ThanhTien] [decimal](18, 2) NULL,
	[PhuongThucThanhToan] [nvarchar](50) NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
 CONSTRAINT [PK__HoaDon__835ED13BF3B6559D] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonSuaChua]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonSuaChua](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[LoaiLinhKien] [nvarchar](200) NULL,
	[MoTa] [nvarchar](500) NULL,
	[TongTien] [decimal](18, 2) NULL,
	[PhuongThucThanhToan] [nvarchar](50) NULL,
	[MaKH] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
 CONSTRAINT [PK_HoaDonSuaChua] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](200) NULL,
	[SDT] [decimal](18, 2) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Xoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[SDT] [nvarchar](11) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[Xoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](200) NULL,
	[Email] [varchar](200) NULL,
	[SDT] [nvarchar](11) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaTK] [varchar](10) NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK__NhanVien__2725D70ACCF9E61C] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDat]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDat](
	[MaPhieuDat] [varchar](10) NOT NULL,
	[NgayDat] [datetime] NULL,
	[ThanhTien] [decimal](18, 2) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[ThoiGianTao] [datetime] NULL,
	[ThoiGianCapNhat] [datetime] NULL,
	[MaNCC] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK__PhieuDat__01EA0D2B1A1A6226] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoHang](
	[MaPhieuGiao] [varchar](10) NOT NULL,
	[NgayGiao] [datetime] NULL,
	[LanGiao] [int] NOT NULL,
	[MaPhieuDat] [varchar](10) NULL,
	[ThanhTien] [decimal](18, 2) NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_PhieuGiaoHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[Gia] [decimal](18, 2) NOT NULL,
	[SoLuongTon] [int] NULL,
	[ThoiGianBaoHanh] [int] NOT NULL,
	[MaDanhMuc] [varchar](10) NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK__SanPham__2725081C5FF15DB5] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/18/2024 9:14:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [varchar](10) NOT NULL,
	[TenDangNhap] [varchar](200) NULL,
	[MatKhau] [varchar](200) NULL,
	[VaiTro] [nvarchar](10) NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK__TaiKhoan__272500701B38FB41] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP001', N'HD001', 1, CAST(11000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP001', N'HD004', 1, CAST(11000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP002', N'HD008', 1, CAST(15000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP003', N'HD004', 1, CAST(7000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP003', N'HD007', 1, CAST(7000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP004', N'HD001', 2, CAST(5000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP004', N'HD006', 2, CAST(5000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP004', N'HD007', 2, CAST(5000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP005', N'HD002', 1, CAST(6000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP005', N'HD005', 1, CAST(6000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP006', N'HD003', 1, CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP006', N'HD005', 1, CAST(300000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP006', N'HD006', 1, CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaSP], [MaHoaDon], [SoLuong], [TongTien]) VALUES (N'SP006', N'HD008', 2, CAST(900000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[ChiTietHoaDonSuaChua] ([MaCTSC], [MaHD], [GiaTienCong], [ThoiGianBaoHanh], [GhiChu]) VALUES (N'CTSC001', N'HD_SC001', CAST(300000.00 AS Decimal(18, 2)), CAST(N'2025-10-15' AS Date), N'Nâng cấp bộ nhớ')
INSERT [dbo].[ChiTietHoaDonSuaChua] ([MaCTSC], [MaHD], [GiaTienCong], [ThoiGianBaoHanh], [GhiChu]) VALUES (N'CTSC002', N'HD_SC002', CAST(500000.00 AS Decimal(18, 2)), CAST(N'2025-10-20' AS Date), N'Thay mới ổ cứng')
GO
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD001', N'SP001', 10, CAST(10000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD001', N'SP002', 5, CAST(15000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD002', N'SP005', 20, CAST(6000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD002', N'SP006', 50, CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD003', N'SP001', 5, CAST(11000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD003', N'SP002', 3, CAST(15000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD004', N'SP002', 4, CAST(15000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD004', N'SP003', 7, CAST(7000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD005', N'SP004', 10, CAST(2500000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD005', N'SP005', 5, CAST(6000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD006', N'SP006', 15, CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD007', N'SP001', 2, CAST(11000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietPhieuDat] ([MaPhieuDat], [MaSP], [SoLuongDat], [DonGia]) VALUES (N'PD007', N'SP003', 4, CAST(7000000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG001', N'SP001', 5, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG001', N'SP002', 2, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG002', N'SP005', 10, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG002', N'SP006', 25, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG003', N'SP001', 2, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG003', N'SP002', 1, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG004', N'SP002', 2, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG004', N'SP003', 2, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG005', N'SP004', 4, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG005', N'SP005', 1, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG006', N'SP006', 10, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG007', N'SP001', 1, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG007', N'SP003', 2, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG008', N'SP001', 1, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG008', N'SP002', 1, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG009', N'SP002', 2, NULL)
INSERT [dbo].[ChiTietPhieuGiao] ([MaPhieuGiao], [MaSP], [SoLuongGiao], [Gia]) VALUES (N'PG009', N'SP003', 3, NULL)
GO
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM001', N'Linh Kiện Máy Tính')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM002', N'Thiết Bị Văn Phòng')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM003', N'Phụ Kiện Điện Thoại')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM004', N'Thẻ Nhớ & Ổ Cứng')
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD001', CAST(N'2024-11-05T00:00:00.000' AS DateTime), CAST(11500000.00 AS Decimal(18, 2)), N'Tiền mặt', N'NV001', N'KH001')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD002', CAST(N'2024-11-07T00:00:00.000' AS DateTime), CAST(2600000.00 AS Decimal(18, 2)), N'Chuyển khoản', N'NV002', N'KH002')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD003', CAST(N'2024-11-10T00:00:00.000' AS DateTime), CAST(450000.00 AS Decimal(18, 2)), N'Tiền mặt', N'NV003', N'KH003')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD004', CAST(N'2024-11-02T00:00:00.000' AS DateTime), CAST(17500000.00 AS Decimal(18, 2)), N'Tiền mặt', N'NV001', N'KH002')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD005', CAST(N'2024-11-05T00:00:00.000' AS DateTime), CAST(6300000.00 AS Decimal(18, 2)), N'Chuyển khoản', N'NV002', N'KH001')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD006', CAST(N'2024-11-07T00:00:00.000' AS DateTime), CAST(4950000.00 AS Decimal(18, 2)), N'Tiền mặt', N'NV003', N'KH003')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD007', CAST(N'2024-11-08T00:00:00.000' AS DateTime), CAST(2400000.00 AS Decimal(18, 2)), N'Chuyển khoản', N'NV001', N'KH002')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [ThanhTien], [PhuongThucThanhToan], [MaNV], [MaKH]) VALUES (N'HD008', CAST(N'2024-11-09T00:00:00.000' AS DateTime), CAST(8300000.00 AS Decimal(18, 2)), N'Tiền mặt', N'NV002', N'KH003')
GO
INSERT [dbo].[HoaDonSuaChua] ([MaHD], [NgayLap], [LoaiLinhKien], [MoTa], [TongTien], [PhuongThucThanhToan], [MaKH], [MaNV]) VALUES (N'HD_SC001', CAST(N'2024-10-15' AS Date), N'RAM', N'Nâng cấp RAM 16GB', CAST(1200000.00 AS Decimal(18, 2)), N'Tiền mặt', N'KH001', N'NV001')
INSERT [dbo].[HoaDonSuaChua] ([MaHD], [NgayLap], [LoaiLinhKien], [MoTa], [TongTien], [PhuongThucThanhToan], [MaKH], [MaNV]) VALUES (N'HD_SC002', CAST(N'2024-10-20' AS Date), N'Ổ Cứng SSD', N'Thay mới SSD 500GB', CAST(1500000.00 AS Decimal(18, 2)), N'Chuyển khoản', N'KH002', N'NV002')
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'KH001', N'Lê Minh Hải', N'leminhhai@gmail.com', CAST(912345678.00 AS Decimal(18, 2)), N'12 Nguyễn Thị Minh Khai, Q.1, TP.HCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'KH002', N'Phạm Hoài Anh', N'phamhoai.anh@outlook.com', CAST(908765432.00 AS Decimal(18, 2)), N'100 Lý Tự Trọng, Q.3, TP.HCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'KH003', N'Trần Thanh Tú', N'tranthtu@example.com', CAST(901234567.00 AS Decimal(18, 2)), N'56 Bà Huyện Thanh Quan, Q.10, TP.HCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'KH004', N'Nguyễn Văn Phú', N'phu.nguyen@gmail.com', CAST(915456767.00 AS Decimal(18, 2)), N'72 Trần Hưng Đạo, Q.5, TP.HCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'KH005', N'Đỗ Thị Lan', N'lan.do@example.com', CAST(935671234.00 AS Decimal(18, 2)), N'88 Lê Lợi, Q.1, TP.HCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'KH006', N'Tran Minh Triet', N'triet.minh@example.com', CAST(947654321.00 AS Decimal(18, 2)), N'18 Nguyễn Văn Linh, Q.7, TP.HCM', 1)
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC001', N'Công Ty TNHH Việt An', N'info@vietan.com.vn', N'0903123456', N'123 Đường Nguyễn Văn Cừ, Quận 5, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC002', N'Công Ty Cổ Phần Minh Long', N'contact@minhlong.com.vn', N'0903987654', N'456 Đường Trần Hưng Đạo, Quận 1, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC003', N'Công Ty TNHH Thái Hòa', N'sales@thaihoa.com.vn', N'0903234987', N'789 Đường Lý Thường Kiệt, Quận Tân Bình, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC004', N'Công Ty Cổ Phần Kim Phát', N'support@kimphat.com.vn', N'0903123789', N'101 Đường Lê Văn Việt, Quận 9, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC005', N'Công Ty TNHH Thanh Sơn', N'info@thanhson.com.vn', N'0903654321', N'202 Đường Phan Đình Phùng, Quận Phú Nhuận, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC006', N'Công Ty Cổ Phần Đại Dương', N'sales@daiduong.com.vn', N'0903765432', N'303 Đường Nguyễn Trãi, Quận 10, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC007', N'Công Ty TNHH Vĩnh Hưng', N'contact@vinhhung.com.vn', N'0903876543', N'404 Đường Hai Bà Trưng, Quận 3, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Email], [SDT], [DiaChi], [Xoa]) VALUES (N'NCC008', N'Công Ty Cổ Phần Phương Nam', N'info@phuongnam.com.vn', N'0903987432', N'505 Đường Cộng Hòa, Quận Tân Bình, TP.HCM', 1)
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [SDT], [DiaChi], [MaTK], [Xoa]) VALUES (N'NV001', N'Nguyễn Văn Nam', N'namnguyen@company.com', N'0932456789', N'234 Lý Chính Thắng, Q.3, TP.HCM', N'TK001', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [SDT], [DiaChi], [MaTK], [Xoa]) VALUES (N'NV002', N'Võ Thị Bích Hạnh', N'bichhanh@company.com', N'0945678123', N'78 Nguyễn Văn Cừ, Q.5, TP.HCM', N'TK002', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [SDT], [DiaChi], [MaTK], [Xoa]) VALUES (N'NV003', N'Trần Quốc Toản', N'quoctoan@company.com', N'0923456789', N'56 Trường Chinh, Q.12, TP.HCM', N'TK003', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [SDT], [DiaChi], [MaTK], [Xoa]) VALUES (N'NV004', N'Bùi Thị Mai', N'maibui@company.com', N'0937654321', N'102 Lạc Long Quân, Q.11, TP.HCM', N'TK004', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [SDT], [DiaChi], [MaTK], [Xoa]) VALUES (N'NV005', N'Phạm Văn Long', N'longpham@company.com', N'0921345678', N'45 Trần Bình Trọng, Q.10, TP.HCM', N'TK005', 1)
GO
INSERT [dbo].[PhieuDat] ([MaPhieuDat], [NgayDat], [ThanhTien], [GhiChu], [ThoiGianTao], [ThoiGianCapNhat], [MaNCC], [MaNV]) VALUES (N'PD001', CAST(N'2024-09-01T00:00:00.000' AS DateTime), CAST(15000000.00 AS Decimal(18, 2)), N'Đặt hàng linh kiện máy tính', CAST(N'2024-09-01T08:30:00.000' AS DateTime), CAST(N'2024-09-01T08:30:00.000' AS DateTime), N'NCC001', N'NV001')
INSERT [dbo].[PhieuDat] ([MaPhieuDat], [NgayDat], [ThanhTien], [GhiChu], [ThoiGianTao], [ThoiGianCapNhat], [MaNCC], [MaNV]) VALUES (N'PD002', CAST(N'2024-09-05T00:00:00.000' AS DateTime), CAST(8500000.00 AS Decimal(18, 2)), N'Đặt hàng phụ kiện điện thoại', CAST(N'2024-09-05T09:00:00.000' AS DateTime), CAST(N'2024-09-05T09:00:00.000' AS DateTime), N'NCC002', N'NV002')
INSERT [dbo].[PhieuDat] ([MaPhieuDat], [NgayDat], [ThanhTien], [GhiChu], [ThoiGianTao], [ThoiGianCapNhat], [MaNCC], [MaNV]) VALUES (N'PD003', CAST(N'2024-10-01T00:00:00.000' AS DateTime), CAST(21000000.00 AS Decimal(18, 2)), N'Đặt hàng CPU và RAM cho cửa hàng', CAST(N'2024-10-01T09:15:00.000' AS DateTime), CAST(N'2024-10-01T09:15:00.000' AS DateTime), N'NCC003', N'NV001')
INSERT [dbo].[PhieuDat] ([MaPhieuDat], [NgayDat], [ThanhTien], [GhiChu], [ThoiGianTao], [ThoiGianCapNhat], [MaNCC], [MaNV]) VALUES (N'PD004', CAST(N'2024-10-05T00:00:00.000' AS DateTime), CAST(30000000.00 AS Decimal(18, 2)), N'Đặt các loại card đồ họa mới', CAST(N'2024-10-05T10:20:00.000' AS DateTime), CAST(N'2024-10-05T10:20:00.000' AS DateTime), N'NCC004', N'NV002')
INSERT [dbo].[PhieuDat] ([MaPhieuDat], [NgayDat], [ThanhTien], [GhiChu], [ThoiGianTao], [ThoiGianCapNhat], [MaNCC], [MaNV]) VALUES (N'PD005', CAST(N'2024-10-10T00:00:00.000' AS DateTime), CAST(12000000.00 AS Decimal(18, 2)), N'Mua thêm bàn phím và chuột gaming', CAST(N'2024-10-10T14:00:00.000' AS DateTime), CAST(N'2024-10-10T14:00:00.000' AS DateTime), N'NCC002', N'NV003')
INSERT [dbo].[PhieuDat] ([MaPhieuDat], [NgayDat], [ThanhTien], [GhiChu], [ThoiGianTao], [ThoiGianCapNhat], [MaNCC], [MaNV]) VALUES (N'PD006', CAST(N'2024-10-12T00:00:00.000' AS DateTime), CAST(5000000.00 AS Decimal(18, 2)), N'Thẻ nhớ và các phụ kiện điện thoại', CAST(N'2024-10-12T16:30:00.000' AS DateTime), CAST(N'2024-10-12T16:30:00.000' AS DateTime), N'NCC001', N'NV001')
INSERT [dbo].[PhieuDat] ([MaPhieuDat], [NgayDat], [ThanhTien], [GhiChu], [ThoiGianTao], [ThoiGianCapNhat], [MaNCC], [MaNV]) VALUES (N'PD007', CAST(N'2024-10-18T00:00:00.000' AS DateTime), CAST(18000000.00 AS Decimal(18, 2)), N'Màn hình và linh kiện máy tính', CAST(N'2024-10-18T11:45:00.000' AS DateTime), CAST(N'2024-10-18T11:45:00.000' AS DateTime), N'NCC003', N'NV002')
GO
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG001', CAST(N'2024-09-10T00:00:00.000' AS DateTime), 1, N'PD001', CAST(7500000.00 AS Decimal(18, 2)), N'NV001')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG002', CAST(N'2024-09-15T00:00:00.000' AS DateTime), 1, N'PD002', CAST(10000000.00 AS Decimal(18, 2)), N'NV002')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG003', CAST(N'2024-10-15T00:00:00.000' AS DateTime), 1, N'PD003', CAST(5500000.00 AS Decimal(18, 2)), N'NV001')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG004', CAST(N'2024-10-20T00:00:00.000' AS DateTime), 1, N'PD004', CAST(7500000.00 AS Decimal(18, 2)), N'NV002')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG005', CAST(N'2024-10-22T00:00:00.000' AS DateTime), 1, N'PD005', CAST(3000000.00 AS Decimal(18, 2)), N'NV003')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG006', CAST(N'2024-10-25T00:00:00.000' AS DateTime), 1, N'PD006', CAST(2000000.00 AS Decimal(18, 2)), N'NV001')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG007', CAST(N'2024-10-28T00:00:00.000' AS DateTime), 1, N'PD007', CAST(4000000.00 AS Decimal(18, 2)), N'NV002')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG008', CAST(N'2024-11-01T00:00:00.000' AS DateTime), 2, N'PD003', CAST(1500000.00 AS Decimal(18, 2)), N'NV001')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiao], [NgayGiao], [LanGiao], [MaPhieuDat], [ThanhTien], [MaNV]) VALUES (N'PG009', CAST(N'2024-11-02T00:00:00.000' AS DateTime), 2, N'PD004', CAST(8000000.00 AS Decimal(18, 2)), N'NV002')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [ThoiGianBaoHanh], [MaDanhMuc], [Xoa]) VALUES (N'SP001', N'CPU Intel Core i9-11900K', CAST(11000000.00 AS Decimal(18, 2)), 20, 36, N'DM001', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [ThoiGianBaoHanh], [MaDanhMuc], [Xoa]) VALUES (N'SP002', N'Card Đồ Họa NVIDIA GeForce RTX 3060', CAST(15000000.00 AS Decimal(18, 2)), 15, 24, N'DM001', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [ThoiGianBaoHanh], [MaDanhMuc], [Xoa]) VALUES (N'SP003', N'Màn Hình LG UltraGear 27GL850', CAST(7000000.00 AS Decimal(18, 2)), 10, 24, N'DM002', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [ThoiGianBaoHanh], [MaDanhMuc], [Xoa]) VALUES (N'SP004', N'Bàn Phím Cơ Logitech G Pro', CAST(2500000.00 AS Decimal(18, 2)), 30, 12, N'DM002', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [ThoiGianBaoHanh], [MaDanhMuc], [Xoa]) VALUES (N'SP005', N'Tai Nghe Bluetooth Sony WH-1000XM4', CAST(6000000.00 AS Decimal(18, 2)), 25, 12, N'DM003', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [ThoiGianBaoHanh], [MaDanhMuc], [Xoa]) VALUES (N'SP006', N'Thẻ Nhớ Samsung 128GB', CAST(450000.00 AS Decimal(18, 2)), 50, 12, N'DM004', 1)
GO
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDangNhap], [MatKhau], [VaiTro], [Xoa]) VALUES (N'TK001', N'admin01', N'password123', N'Quản lý', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDangNhap], [MatKhau], [VaiTro], [Xoa]) VALUES (N'TK002', N'nguyenvanb', N'securepass456', N'Nhân viên', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDangNhap], [MatKhau], [VaiTro], [Xoa]) VALUES (N'TK003', N'phanthia', N'mypassword789', N'Nhân viên', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDangNhap], [MatKhau], [VaiTro], [Xoa]) VALUES (N'TK004', N'buithimai', N'strongpass001', N'Nhân viên', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDangNhap], [MatKhau], [VaiTro], [Xoa]) VALUES (N'TK005', N'phamlong', N'longpass002', N'Nhân viên', 1)
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_cthd_hd] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_cthd_hd]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_cthd_sp] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_cthd_sp]
GO
ALTER TABLE [dbo].[ChiTietHoaDonSuaChua]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonSuaChua_HoaDonSuaChua] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonSuaChua] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDonSuaChua] CHECK CONSTRAINT [FK_ChiTietHoaDonSuaChua_HoaDonSuaChua]
GO
ALTER TABLE [dbo].[ChiTietPhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDat_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuDat] CHECK CONSTRAINT [FK_ChiTietPhieuDat_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuDat]  WITH CHECK ADD  CONSTRAINT [fk_ctpd_pd] FOREIGN KEY([MaPhieuDat])
REFERENCES [dbo].[PhieuDat] ([MaPhieuDat])
GO
ALTER TABLE [dbo].[ChiTietPhieuDat] CHECK CONSTRAINT [fk_ctpd_pd]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiao_PhieuGiaoHang] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[PhieuGiaoHang] ([MaPhieuGiao])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiao] CHECK CONSTRAINT [FK_ChiTietPhieuGiao_PhieuGiaoHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiao]  WITH CHECK ADD  CONSTRAINT [fk_ctpg_sp] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiao] CHECK CONSTRAINT [fk_ctpg_sp]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_hd_kh] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_hd_kh]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_hd_nv] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_hd_nv]
GO
ALTER TABLE [dbo].[HoaDonSuaChua]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonSuaChua_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonSuaChua] CHECK CONSTRAINT [FK_HoaDonSuaChua_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonSuaChua]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonSuaChua_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonSuaChua] CHECK CONSTRAINT [FK_HoaDonSuaChua_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_nv_tk] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_nv_tk]
GO
ALTER TABLE [dbo].[PhieuDat]  WITH CHECK ADD  CONSTRAINT [fk_pd_ncc] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuDat] CHECK CONSTRAINT [fk_pd_ncc]
GO
ALTER TABLE [dbo].[PhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuDat] CHECK CONSTRAINT [FK_PhieuDat_NhanVien]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [fk_pgh_pd] FOREIGN KEY([MaPhieuDat])
REFERENCES [dbo].[PhieuDat] ([MaPhieuDat])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [fk_pgh_pd]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DanhMucSanPham] FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMucSanPham] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DanhMucSanPham]
GO
