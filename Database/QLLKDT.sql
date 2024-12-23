create database QL_LinhKienMayTinh
go
USE [QL_LinhKienMayTinh]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDonSuaChua]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuDat]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuGiao]    Script Date: 11/11/2024 9:09:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuGiao](
	[MaPhieuGiao] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuongGiao] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucSanPham]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[HoaDonSuaChua]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[PhieuDat]    Script Date: 11/11/2024 9:09:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDat](
	[MaPhieuDat] [varchar](10) NOT NULL,
	[NgayDat] [datetime] NULL,
	[TongSoLuong] [int] NULL,
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
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 11/11/2024 9:09:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoHang](
	[MaPhieuGiao] [varchar](10) NOT NULL,
	[NgayGiao] [datetime] NULL,
	[LanGiao] [int] NULL,
	[MaPhieuDat] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/11/2024 9:09:08 AM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/11/2024 9:09:08 AM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (N'DM001     ', N'Phần mền')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [SoLuongTon], [ThoiGianBaoHanh], [MaDanhMuc], [Xoa]) VALUES (N'SP001     ', N'Màn Hình Máy Tính', CAST(700000.00 AS Decimal(18, 2)), N'100       ', 6, N'DM001     ', 0)
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
ALTER TABLE [dbo].[ChiTietPhieuGiao]  WITH CHECK ADD  CONSTRAINT [fk_ctpg_pg] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[PhieuGiaoHang] ([MaPhieuGiao])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiao] CHECK CONSTRAINT [fk_ctpg_pg]
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

--------------------------------------------------------------------------------------------------------------

DELETE FROM [dbo].[SanPham]; -- Xóa dữ liệu từ bảng SanPham
DELETE FROM [dbo].[DanhMucSanPham]; -- Xóa dữ liệu từ bảng DanhMucSanPham

