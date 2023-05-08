create database PTTKHTTT;
use PTTKHTTT;
go
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
	MaPhieuDangKiDichVu INT PRIMARY KEY,
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
   TEN_TK char(10) NOT NULL,
   MATKHAU char(30),
);

CREATE TABLE NHANVIEN
(
   MANV char(10) NOT NULL,
   TENNV nvarchar(50) NOT NULL,
   ViTri varchar(13) ,
   CMND varchar(50),
   PRIMARY KEY (MANV)
);

insert into NHANVIEN (MANV, TENNV, ViTri,CMND) values ('NV001', 'Le Van Duan', 'Le Tan', '7684346018');
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
