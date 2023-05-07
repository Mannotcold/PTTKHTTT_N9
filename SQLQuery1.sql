CREATE DATABASE PTTKHTTT
go

use PTTKHTTT

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

insert into PHIEUDATPHONG (MaPhieuDP, TinhTrangDuyet,NgayLap,NgayDen,NgayDi,SoDemLuuTru, CacYeuCauDacBiet,MaKHDaiDien,TenKHDaiDien,CMNDKHDaiDien, SĐTKHDaiDien, LoaiKH) values ('PH002', 'Chưa duyệt','2023-05-07','2023-05-07','2023-05-07',2,'KH001','Man','4114478448','4114478448', 'fefdedfsfsdfsdfd', 'Doan');
select * from PHIEUDATPHONG;
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
