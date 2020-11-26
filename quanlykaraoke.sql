create database QuanLyKARAOKE
use QuanLyKARAOKE
go

create table NHANVIEN(
	tenDN varchar not NULL,
	matKhau varchar not NULL,
	hoTen nvarchar not NULL,
	gioiTinh bit not NULL,
	ngaySinh date,
	sdt varchar not NULL,
	cmnd int not NULL,
	chucVu nvarchar,
	primary key (tenDN)
)

create table PHONG(
	tinhTrang nvarchar,
	loaiPhong nvarchar not NULL,
	giaPhong int not NULL,
	maPhong varchar not NULL,
	primary key (maPhong)
)

create table DICHVU(
	loaiDV nvarchar not NULL,
	tenDV nvarchar not NULL,
	donViTinh nvarchar not NULL,
	giaDV int not NULL,
	soLuongDV int,
	maDV varchar not NULL,
	primary key (maDV)
)

create table PHIEUDAT(
	maPhong varchar not NULL,
	ngayGioDat datetime not NULL,
	tenNguoiDat nvarchar not NULL,
	sdtNguoiDat varchar not NULL,
	cmnd int,
	tienCoc int,
	hinhThuc varchar,
	maPD varchar not NULL,
	primary key (maPD),
	foreign key (maPhong) references PHONG(maPhong) 
)

create table HOADON(
	maHD varchar,
	maPhong varchar not NULL,
	maPD varchar not NULL,
	thanhTien int,
	primary key (maHD),
	foreign key (maPhong) references PHONG(maPhong),
	foreign key (maPD) references PHIEUDAT(maPD)
)

create table CHITIETHOADON(
	maCTHD varchar not NULL,
	maDV varchar not NULL,
	tenDV nvarchar not NULL,
	soluongDV int,
	donGia int not NULL,
	thanhGia int,
	tinhTrang nvarchar not NULL,
	primary key (maCTHD),
	foreign key (maDV) references DICHVU(maDV)
)

create table HDCTHD(
	maHD varchar not NULL,
	maCTHD varchar not NULL.
	primary key (maHD, maCTHD),
	foreign key (maHD) references HOADON(maHD),
	foreign key (maCTHD) references HOADON(maCTHD)
)
