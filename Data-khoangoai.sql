create database PTTKHTTT;
use PTTKHTTT;
go

CREATE TABLE PHIEUDATPHONG
(
   MaPhieuDP char(10) NOT NULL,
   TinhTrangDuyet nvarchar(50),
   NgayLap date,
   NgayDen date,
   NgayDi date,
   SoDemLuuTru int,
   CacYeuCauDacBiet nvarchar(50),
   MaKHDaiDien  char(10),
   TenKHDaiDien nvarchar(50),
   CMNDKHDaiDien nvarchar(50),
   SĐTKHDaiDien nvarchar(50),
   LoaiKH nvarchar(50),
   PRIMARY KEY (MaPhieuDP)
);

DELETE FROM PHIEUDATPHONG
WHERE MaPhieuDP = 'PH001';
DELETE FROM PHIEUDATPHONG
WHERE MaPhieuDP = 'PH002';
SELECT * FROM PHIEUDATPHONG;

CREATE TABLE TAIKHOAN
(
   TEN_TK varchar(5) NOT NULL,
   MATKHAU char(30),
);

--drop TABLE NHANVIEN
CREATE TABLE NHANVIEN
(
   MANV varchar(5) NOT NULL,
   TENNV nvarchar(50) NOT NULL,
   SDT VARCHAR(10),
   CMND varchar(50),
   VAITRO varchar(13),
   PRIMARY KEY (MANV)
);


CREATE TABLE NVBELLMAN(
	MANV VARCHAR(5),
	CATRUC VARCHAR(5), --NGAY, DEM
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

CREATE TABLE NVBUONGPHONG(
	MANV VARCHAR(5),
	KHUVUCQL VARCHAR(5), --TANG1, TANG2
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

CREATE TABLE NVKETOAN(
	MANV VARCHAR(5),
	SLHOSOTHANHTOAN INT,
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

CREATE TABLE NVLETAN(
	MANV VARCHAR(5),
	VITRI VARCHAR(5), --BAN1, BAN2
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

select * from NHANVIEN JOIN TAIKHOAN on MANV = Ten_TK Where MANV = '" + username + "' AND MATKHAU = '" + password + "'
select * from NHANVIEN JOIN TAIKHOAN on MANV = Ten_TK Where MANV = 'NV001' AND MATKHAU = 'NV001'

CREATE TABLE KHACHHANG
(
   MAKH char(10) NOT NULL,
   TENTK char(40) NOT NULL,
   SDT varchar(13) ,
   CMND nvarchar(50),
   PRIMARY KEY (MAKH)
);

CREATE TABLE DOAN
(
   TenDoanKhach nvarchar(50),
   TenNguoiDaiDienDangKy nvarchar(50),
   SoLuongNguoiDangKy int,
);

create table PhieuDangKiDatTour (
	MaPhieuDangKiDatTour CHAR(10) PRIMARY KEY,
	MaTour CHAR(10),
	MaKH CHAR(10),
	TenKH VARCHAR(50),
	ThoiGianKhoiHanh VARCHAR(50),
	SoNguoiThamGia INT,
	ThongTinNguoiThamGia VARCHAR(50),
	PhuongThucDiChuyen  VARCHAR(20),
	CacNhuCauDacBiet VARCHAR(50)
);
create table DanhSachTourDuLich (
	MaTour CHAR(10) PRIMARY KEY,
	TenTour CHAR(10),
	DonGiaTour FLOAT,
	TenDVLH VARCHAR(50)
);
create table DonViLuHanh (
	MaDVLH CHAR(10) PRIMARY KEY,
	TenDVLH VARCHAR(50),
	EmailDVLH VARCHAR(50),
	SoDienThoaiDVLH VARCHAR(15)
);
create table PhieuDangKiDichVu (
	MaPhieuDangKiDichVu CHAR(10) PRIMARY KEY,
	ThoiGianSuDung VARCHAR(50),
	CacYeuCauDacBiet VARCHAR(50)
);

create table DanhSachSanPhamVaDichVu  (
	MaDV CHAR(10) PRIMARY KEY,
	TenDV VARCHAR(50),
	DonGiaDV FLOAT,
	ThoiGianMo INT,
	ThoiGianDong INT
);
DELETE FROM DanhSachSanPhamVaDichVu
WHERE MaDV = 'DV001';

-- create----------------------------------------------------
--DROP TABLE HoaDon
CREATE TABLE HoaDon (
  MaHoaDon char(10) PRIMARY KEY,
  NgayLap DATE,
  TongTien DECIMAL(18,2),
  TrangThaiThanhToan VARCHAR(15),
  MaPhieuDP char(10) NOT NULL,
  FOREIGN KEY (MaPhieuDP) REFERENCES PhieuDatPhong(MaPhieuDP)
);

CREATE TABLE LienPhieuDichVu (
  MaLienPhieuDV char(10) PRIMARY KEY,
  TenDV VARCHAR(50),
  LoaiDV VARCHAR(50),
  GiaTien DECIMAL(18,2),
  SoLuong INT,
  MaDV CHAR(10),
  MaPhieuDangKiDichVu CHAR(10),
  FOREIGN KEY (MaDV) REFERENCES DanhSachSanPhamVaDichVu(MaDV),
  FOREIGN KEY (MaPhieuDangKiDichVu) REFERENCES PhieuDangKiDichVu(MaPhieuDangKiDichVu)
);

CREATE TABLE CheckoutCard (
  MaCheckoutCard char(10) PRIMARY KEY,
  ThoiGianCheckOut DATETIME 
  -- ThoiGianCheckOut TIMESTAMP
);

CREATE TABLE HoSoThanhToan (
  MaHSThanhToan char(10) PRIMARY KEY,
  MaLienPhieuDV char(10),
  FOREIGN KEY (MaLienPhieuDV) REFERENCES LienPhieuDichVu(MaLienPhieuDV)
);

CREATE TABLE PHANHOIDICHVU
(
	PH_NhanVien char(15),
	PH_Phong char(15),
	PH_DoAnNuocUong char(15),
	PH_DichVuKhac char(15),
    PhanHoiKhac varchar(50),
	MaKHDaiDien  char(10),
	SĐTKHDaiDien nvarchar(50),
	TrangThai nvarchar(50),
	FOREIGN KEY (MaKHDaiDien) REFERENCES PHIEUDATPHONG(MaKHDaiDien)
);
-- fetch 
SELECT * FROM HoaDon;
GO

Drop table DanhSachPhong;
Create table DanhSachPhong
(
	MaPhong varchar(8),
	LoaiPhong varchar(50),
	DonGiaPhong varchar(15),
	TinhTrangTrong varchar(50),
	TinhTrangVeSinh varchar(50),
	TinhTrangHuHong varchar(50),
	MoTa varchar(80),
	MaPhieuThuePhong varchar(8),
	PRIMARY KEY (MaPhong)
);

Drop table QuyDinhKhachSan;
Create table QuyDinhKhachSan
(
	STT int,
	TenQuyDinh varchar(20),
	NoiDungQuyDinh varchar(80),
	PRIMARY KEY (STT)
);

Drop table DanhSachKhuyenMai;
Create table DanhSachKhuyenMai
(
	MaKhuyenMai varchar(8),
	TenKhuyenMai varchar(80),
	ThongTinKhuyenMai varchar(80),
	ThoiGianBatDau date,
	ThoiGianKetThuc date,
	PRIMARY KEY (MaKhuyenMai)
);

CREATE TABLE PHIEUVANCHUYENHANHLY(
	MAPHIEUVANCHUYENHANHLY VARCHAR(10) PRIMARY KEY,
	MAPHONG	VARCHAR(8),
	SLHANHLY INT,
	FOREIGN KEY (MAPHONG) REFERENCES DANHSACHPHONG(MAPHONG)
);