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
insert into PHIEUDATPHONG (MaPhieuDP, TinhTrangDuyet,NgayLap,NgayDen,NgayDi,SoDemLuuTru, CacYeuCauDacBiet,MaKHDaiDien,TenKHDaiDien,CMNDKHDaiDien, SĐTKHDaiDien, LoaiKH) 
values 
('PH001', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH001','DANH','12345','4114478448', 'DOAN'),
('PH002', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH001','MAN','12345','5444365657', 'LE'),
('PH003', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH001','LAM','12345','5565476556', 'LE'),
('PH004', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH001','TRACH','12345','56556565556', 'LE'),
('PH005', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH001','KHANH','12345','56565656565', 'LE');
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


insert into NHANVIEN (MANV, TENNV, SDT, CMND, VAITRO) values ('NV001', 'Le Van Duan', '0123456789', '7684346018', 'Le Tan');
insert into TAIKHOAN (TEN_TK, MATKHAU) values ('NV001', 'NV001');

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

CREATE TABLE PHANHOI
(
   PhanHoi nvarchar(50),
   TrangThai nvarchar(50)
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
---DU LIEU DEMO CUA BANH DANH SACH SAN PHAM VA DI VU
insert into DanhSachSanPhamVaDichVu(MaDV,TenDV,DonGiaDV,ThoiGianMo,ThoiGianDong)
values
('DV001','AN UONG',150000,0,24),
('DV002','SPA',300000,0,24),
('DV003','GYM',100000,0,24),
('DV004','KARAOKE',100000,0,24),
('DV005','BI-A',100000,0,24);


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

-- insert
INSERT INTO HoaDon(MaHoaDon, NgayLap, TongTien, TrangThaiThanhToan, MaPhieuDP)
VALUES ('HD001', '2023-09-23', 1225000,'Chua thanh toan', 'PH001');
INSERT INTO HoaDon(MaHoaDon, NgayLap, TongTien, TrangThaiThanhToan, MaPhieuDP)
VALUES ('HD002', '2023-05-05', 850000,'Da thanh toan', 'PH002');

INSERT INTO LienPhieuDichVu(MaLienPhieuDV, TenDV, LoaiDV, GiaTien, SoLuong, MaDV, MaPhieuDangKiDichVu)
VALUES ('LP001', 'Do an uong', 'An uong', 25000, 5, 'DV001', 'PDV013');
INSERT INTO LienPhieuDichVu(MaLienPhieuDV, TenDV, LoaiDV, GiaTien, SoLuong, MaDV, MaPhieuDangKiDichVu)
VALUES ('LP002', 'Xong hoi', 'Spa', 100000, 1, 'DV002', 'PDV011');

INSERT INTO CheckoutCard(MaCheckoutCard, ThoiGianCheckOut)
VALUES ('CK001', '2023-09-25 09:10:00');
INSERT INTO CheckoutCard(MaCheckoutCard, ThoiGianCheckOut)
VALUES ('CK002', '2023-09-26 12:10:00');

INSERT INTO HoSoThanhToan( MaHSThanhToan, MaLienPhieuDV)
VALUES ('HS001', 'LP001');
INSERT INTO HoSoThanhToan( MaHSThanhToan, MaLienPhieuDV)
VALUES ('HS002', 'LP002');

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
insert into DanhSachPhong(MaPhong,LoaiPhong,DonGiaPhong,TinhTrangTrong,TinhTrangVeSinh,TinhTrangHuHong,MoTa,MaPhieuThuePhong)
values
('PHG001','PHONG DON',500000,'Con Trong ','Sach se ','Khong', 'Phong thoang mat sach se','NULL'),
('PHG002','PHONG DOI',1000000,'Da Duoc Thue ','Sach se ','Khong', 'Phong thoang mat sach se','P001'),
('PHG003','PHONG DON',1000000,'Con Trong ','Sach se ','Khong', 'Phong thoang mat sach se','NULL'),
('PHG004','PHONG DON',500000,'Da Duoc Thue ','Sach se ','Khong', 'Phong thoang mat sach se','P003'),
('PHG005','PHONG BON',2000000,'Da Duoc Thue ','Sach se ','Khong', 'Phong thoang mat sach se','P004');
Drop table QuyDinhKhachSan;
Create table QuyDinhKhachSan
(
STT int,
TenQuyDinh varchar(20),
NoiDungQuyDinh varchar(80),
PRIMARY KEY (STT)
);
insert into QuyDinhKhachSan(STT,TenQuyDinh,NoiDungQuyDinh)
values
(1,'Do dung va Vat tu','Tu Bao quan do dac cua minh '),
(2,'Thu cung ','Khong duoc tha rong '),
(3,'Hang Cam ','Khong duoc mang hang cam trong khach san '),
(4,'Thu tuc tra phong ','Phai kem CMND '),
(5,'Anh va video ','Nghiem cam viec chup anh trong khach san ');
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
insert into DanhSachKhuyenMai(MaKhuyenMai,TenKhuyenMai,ThongTinKhuyenMai,ThoiGianBatDau,ThoiGianKetThuc)
values
('KM001','Cafe mien phi','Quy khach se duoc mot ly cafe mien phi vao moi buoi sang ','2022-08-04', '2022-08-04'),
('KM002','Tra mien phi','Quy khach se duoc mot ly tra mien phi vao moi buoi sang ','2022-08-04', '2022-08-04'),
('KM003','View an sang dep','Quy khach se duoc lua chon cho ngoi mien phi vao moi buoi sang ','2022-08-04', '2022-08-04'),
('KM004','Banh my Phap mien phi','Quy khach se duoc mot banh my Phap mien phi vao moi buoi sang ','2022-08-04', '2022-08-04'),
('KM005','Ve vao be boi mien phi ','Quy khach se duoc mot ve vao ho boi mien phi vao moi buoi chieu ','2022-08-04', '2022-08-04');
