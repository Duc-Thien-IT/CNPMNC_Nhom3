use master
go
create database QL_LinhKienMayTinh
go
use QL_LinhKienMayTinh
go

create table TaiKhoan
(
	MaTK char(10) primary key not null,
	TenDangNhap varchar(200),
	MatKhau varchar(200),
	VaiTro nvarchar(10),
	Xoa bit
)

create table NhanVien
(
	MaNV char(10) primary key not null,
	TenNV nvarchar(200),
	Email varchar(200),
	SDT nvarchar(11),
	DiaChi nvarchar(200),
	Xoa bit,
	MaTK char(10),
	constraint fk_nv_tk foreign key (MaTK) references TaiKhoan(MaTK)
)

create table KhachHang
(
	MaKH char(10) primary key not null,
	TenKH nvarchar(200) not null,
	Email nvarchar(200), 
	SDT decimal(18,2),
	DiaChi nvarchar(200)
)

create table NhaCungCap
(
	MaNCC char(10) primary key not null,
	TenNCC nvarchar(50) not null,
	Email varchar(200) not null,
	SDT nvarchar(11) not null,
	DiaChi nvarchar(200) not null,
	Xoa bit
)

create table DanhMucSanPham
(
	MaDanhMuc char(10) primary key not null,
	TenDanhMuc nvarchar(50)
)

create table SanPham
(
	MaSP char(10) primary key not null,
	TenSP nvarchar(50) not null,
	Gia decimal(18,2) not null,
	ThoiGianBaoHanh datetime not null,
	Xoa bit not null,
	MaDanhMuc char(10),
	constraint fk_sp_dmsp foreign key (MaSP) references DanhMucSanPham(MaDanhMuc)
)

create table PhieuDat
(
	MaPhieuDat char(10) primary key not null,
	NgayDat Datetime,
	TongSoLuong int,
	GhiChu nvarchar(200),
	ThoiGianTao datetime,
	ThoiGianCapNhat datetime, 
	MaNCC char(10),
	constraint fk_pd_ncc foreign key (MaNCC) references NhaCungCap(MaNCC)
)

create table ChiTietPhieuDat
(
	MaChiTietPhieuDat char(10) primary key not null,
	MaPhieuDat char(10),
	MaSP char(10),
	SoLuongDat int,
	DonGia decimal(18,2),
	constraint fk_ctpd_pd foreign key (MaPhieuDat) references PhieuDat(MaPhieuDat)
)

create table PhieuGiaoHang
(
	MaPhieuGiao char(10) primary key not null,
	NgayGiao datetime,
	LanGiao int,
	MaPhieuDat char(10),
	constraint fk_pgh_pd foreign key (MaPhieuDat) references PhieuDat(MaPhieuDat)
)

create table ChiTietPhieuGiao
(
	MaChiTietPhieuGiao char(10) primary key not null,
	MaPhieuGiao char(10),
	MaSP char(10),
	SoLuongGiao int,
	constraint fk_ctpg_pg foreign key (MaPhieuGiao) references PhieuGiaoHang(MaPhieuGiao),
	constraint fk_ctpg_sp foreign key (MaSP) references SanPham(MaSP)
)

create table HoaDon
(
	MaHoaDon char(10) primary key not null,
	NgayLap datetime,
	MaNV char(10),
	MaKH char(10),
	constraint fk_hd_nv foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_hd_kh foreign key (MaKH) references KhachHang(MaKH)
)

create table ChiTietHoaDon
(
	MaChiTietHoaDon char(10) primary key not null,
	MaSP char(10),
	MaHoaDon char(10),
	TongThanhTien decimal(18,2),
	constraint fk_cthd_sp foreign key (MaSP) references SanPham(MaSP),
	constraint fk_cthd_hd foreign key (MaHoaDon) references HoaDon(MaHoaDon)
)

