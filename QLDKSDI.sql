CREATE DATABASE QLDKSDI

USE QLDKSDI

CREATE TABLE KhachHang (
	MaKH VARCHAR(10) PRIMARY KEY,
	HoTen VARCHAR(20),
	DiaChi VARCHAR(50),
	CMND VARCHAR(10),
	LoaiKH VARCHAR(10),
	SoDT INT
);

CREATE TABLE HopDong (
	MaHD VARCHAR(10) PRIMARY KEY,
	MaKH VARCHAR(10) FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
	NgayDK SMALLDATETIME,
	TongTK varchar(15),
	ChiPhi INT,
	NgayKyHD SMALLDATETIME	
);

CREATE TABLE TaiKhoan (
	TenTruyCap VARCHAR(15) PRIMARY KEY,
	MatKhau VARCHAR(20),
	Email VARCHAR(20),
	MaHD VARCHAR(10) FOREIGN KEY (MaHD) REFERENCES HopDong(MaHD),
	DiaChiCaiDat VARCHAR(50),
	DiaChiThanhToan VARCHAR(50),
	TrangThai BIT,
);

CREATE TABLE PhieuBao (
	MaPhieu VARCHAR(10) PRIMARY KEY,
	TenTruyCap VARCHAR(15) FOREIGN KEY (TenTruyCap) REFERENCES TaiKhoan(TenTruyCap),
	NgayLap SMALLDATETIME,
	ThangLap VARCHAR(10),
	TongTien INT,
	TinhTrang BIT,
	NgayTT SMALLDATETIME,
	HinhThucTT VARCHAR(10),
	TongTienTT INT
);

CREATE TABLE LoaiTG_TruyCap (
	MaLoai VARCHAR(10) PRIMARY KEY,
	TenLoai VARCHAR(10),
	Gia INT,
	GioBD TIME,
	GioKT TIME
);

CREATE TABLE ChiTiet_TruyCap (
	MaLoai VARCHAR(10) FOREIGN KEY (MaLoai) REFERENCES LoaiTG_TruyCap(MaLoai),
	TenTruyCap VARCHAR(15) FOREIGN KEY (TenTruyCap) REFERENCES TaiKhoan(TenTruyCap),
	Ngay SMALLDATETIME,
	TongSoPhut INT,
	CONSTRAINT PK_TK_CHITIET PRIMARY KEY (MaLoai,TenTruyCap)
);
CREATE TABLE NhanVien (
	MaNhanVien VARCHAR(10) PRIMARY KEY,
	HoTen VARCHAR(20),
	DiaChi VARCHAR(50),
	CMND VARCHAR(10),
	TenTruyCap VARCHAR(15),
	MatKhau VARCHAR(20),
	QuyenHan BIT
)

--- Thêm dữ liệu admin 
insert into NhanVien values  ('NV0001', 'Đoàn Nam Minh', 'Bình Thuận', '25262323','namminhlp','3071997',1);

--- Thêm dữ liệu cho loại thời gian truy cập
insert into LoaiTG_TruyCap values ('1','Thuong',80,'07 AM','11 PM');
insert into LoaiTG_TruyCap values ('2','Dac biet',40,'11 PM','07 AM')

--- Thêm dữ liệu khách hàng
insert into KhachHang values ('KH0002', 'Nam Minh','Thu Duc - TPHCM','2561271','Vip',0123456789);

--- Them dữ liệu hợp đồng tương ứng với khách hàng
insert into HopDong values ('HD0002','KH0002','05-12-2016',4,100000,'05-16-2016');

--- Thêm dữ liệu về Tài khoản được cung cấp
insert into TaiKhoan values ('namminh','3071997','namminh@gmail.com','HD0002','TPHCM','TPHCM',1);
insert into TaiKhoan values ('namminh2','3071997','namminh@gmail.com','HD002','TPHCM','TPHCM',0);

--- Thêm dữ liệu chi tiết truy cập
insert into ChiTiet_TruyCap values ('1','namminh2','06-12-2016',30);
insert into ChiTiet_TruyCap values ('2','namminh','06-13-2016',90);
insert into ChiTiet_TruyCap values ('1', 'namminh','06-15-2016',60);