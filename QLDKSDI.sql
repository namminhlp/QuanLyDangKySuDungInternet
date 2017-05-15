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
	MaPhieu VARCHAR(10) FOREIGN KEY (MaPhieu) REFERENCES PhieuBao(MaPhieu),
	Ngay SMALLDATETIME,
	TongSoPhut INT,
	CONSTRAINT PK_MA_CHITIET PRIMARY KEY (MaLoai,MaPhieu)
);
ALTER TABLE ChiTiet_TruyCap 
	ADD CHECK (Ngay < GETDATE())
CREATE TABLE NhanVien (
	MaNhanVien VARCHAR(10) PRIMARY KEY,
	HoTen VARCHAR(20),
	DiaChi VARCHAR(50),
	CMND VARCHAR(10),
	TenTruyCap VARCHAR(15),
	MatKhau VARCHAR(20),
	QuyenHan BIT
)
insert into NhanVien values  ('NV0001', 'Đoàn Nam Minh', 'Bình Thuận', '25262323','namminhlp','3071997',1);
--- Thêm chi tiết truy cập
insert into ChiTiet_TruyCap values ('1','namminh','2017-04-17',60);
insert into ChiTiet_TruyCap values ('2','namminh','2017-04-18', 90);