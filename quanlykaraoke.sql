create database QuanLyKARAOKE
use QuanLyKARAOKE
go

create table NHANVIEN(
	tenDN varchar(256) not NULL,
	matKhau varchar(256) not NULL,
	hoTen nvarchar(256) not NULL,
	gioiTinh bit not NULL,
	ngaySinh date,
	sdt varchar(32) not NULL,
	cmnd varchar(256) not NULL,
	chucVu nvarchar(256),
	primary key (tenDN)
)

insert into NHANVIEN values ('asd', 'asd', 'Nguyen Van A', 1, '12/12/2001', '123456789', '987654321',N'Nhân Viên')
insert into NHANVIEN values ('asdf', 'asdf', 'Nguyen Van B', 1, '12/11/2001', '123456889', '997654321',N'Quản Lý')
insert into NHANVIEN values ('asdfg', 'asdfg', 'Nguyen Van C', 1, '12/10/2001', '123556789', '87634321',N'Nhân Viên')
insert into NHANVIEN values ('asdfgh', 'asdfgh', 'Nguyen Van D', 0, '12/10/2001', '12556789', '8763321',N'Nhân Viên')
select * from NHANVIEN

create table PHONG(
	tinhTrang nvarchar,
	maTinhTrang int,
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
