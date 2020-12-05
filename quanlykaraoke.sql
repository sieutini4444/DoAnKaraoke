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
	maChucVu int,
	primary key (tenDN)
)

insert into NHANVIEN values ('asd', 'asd', 'Nguyen Van A', 1, '12/12/2001', '123456789', '987654321',N'Nhân Viên', 0)
insert into NHANVIEN values ('asdf', 'asdf', 'Nguyen Van B', 1, '12/11/2001', '123456889', '997654321',N'Quản Lý', 1)
insert into NHANVIEN values ('asdfg', 'asdfg', 'Nguyen Van C', 1, '12/10/2001', '123556789', '87634321',N'Nhân Viên', 0)
insert into NHANVIEN values ('asdfgh', 'asdfgh', 'Nguyen Van D', 0, '12/10/2001', '12556789', '8763321',N'Nhân Viên', 1)
select * from NHANVIEN


create table PHONG(
	tinhTrang nvarchar(256),
	maTinhTrang int,
	loaiPhong nvarchar(256) not NULL,
	giaPhong int not NULL,
	maPhong varchar(256) not NULL,
	primary key (maPhong)
)

insert into PHONG values (N'Đang Dùng', 1, N'Thường', 100000, 'P001')
insert into PHONG values (N'Đang Sửa Chữa', 2, N'Thường', 100000, 'P002')
insert into PHONG values (N'Trống', 0, N'VIP', 500000, 'P003')
insert into PHONG values (N'Trống', 0, N'Thường', 100000, 'P004')
insert into PHONG values (N'Đang Dùng', 1, N'Thường', 100000, 'P005')
select * from PHONG

create table DICHVU(
	loaiDV nvarchar(256) not NULL,
	tenDV nvarchar(256) not NULL,
	donViTinh nvarchar(256) not NULL,
	giaDV int not NULL,
	soLuongDV int,
	maDV varchar(256) not NULL,
	primary key (maDV)
)


insert into DICHVU values (N'Thức ăn', N'Bánh mì', N'Ổ', 20000, 101, 'F0001')
insert into DICHVU values (N'Thức ăn', N'Chả giò', N'Đĩa', 195000, 50, 'F0002')
insert into DICHVU values (N'Thức ăn', N'Cá ngừ', N'Đĩa', 205000, 50, 'F0003')
insert into DICHVU values (N'Thức ăn', N'Khô cá sặc', N'Đĩa', 205000, 50, 'F0004')
insert into DICHVU values (N'Thức ăn', N'Khô Mực', N'Đĩa', 535000, 50, 'F0005')
insert into DICHVU values (N'Nước uống', N'Nước khoáng Lavie', N'Lon', 20000, 50, 'D0001')
insert into DICHVU values (N'Nước uống', N'Bia 333', N'Lon', 20000, 100, 'D0002')
insert into DICHVU values (N'Nước uống', N'Bia Heineken', N'Lon', 20000, 100, 'D0003')
insert into DICHVU values (N'Nước uống', N'Bia Tiger', N'Lon', 20000, 100, 'D0004')
insert into DICHVU values (N'Nước uống', N'Bia Sapporo', N'Lon', 20000, 100, 'D0005')
insert into DICHVU values (N'Nước uống', N'Bia Larue', N'Lon', 20000, 100, 'D0006')
insert into DICHVU values (N'Nước uống', N'Bia Sài Gòn', N'Lon', 20000, 100, 'D0007')
select * from DICHVU


create table PHIEUDAT(
	maPhong varchar(256) not NULL,
	ngayGioDat datetime not NULL,
	tenNguoiDat nvarchar(256) not NULL,
	sdtNguoiDat varchar(256) not NULL,
	cmnd int,
	maPD int not NULL,
	primary key (maPD),
	foreign key (maPhong) references PHONG(maPhong) 
)
select * from PHIEUDAT


create table HOADON(
	maHD int,
	maPhong varchar(256) not NULL,
	maPD int not NULL,
	thanhTien int,
	primary key (maHD),
	foreign key (maPhong) references PHONG(maPhong),
	foreign key (maPD) references PHIEUDAT(maPD)
)
select * from HOADON


create table CHITIETHOADON(
	maCTHD int not NULL,
	maDV varchar(256) not NULL,
	tenDV nvarchar(256) not NULL,
	soluongDV int,
	donGia int not NULL,
	thanhGia int,
	tinhTrang nvarchar(256) not NULL,
	maPD int,
	primary key (maCTHD),
	foreign key (maDV) references DICHVU(maDV),
	foreign key (maPD) references PHIEUDAT(maPD)
)
select * from CHITIETHOADON
