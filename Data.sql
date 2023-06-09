﻿--create database PTTKHTTT;
--use PTTKHTTT;
--go

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



insert into PHIEUDATPHONG (MaPhieuDP, TinhTrangDuyet,NgayLap,NgayDen,NgayDi,SoDemLuuTru, CacYeuCauDacBiet,MaKHDaiDien,TenKHDaiDien,CMNDKHDaiDien, SĐTKHDaiDien, LoaiKH) 
values 
('PH001', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH001','DANH','12345','4114478448', 'DOAN'),
('PH002', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH002','MAN','12345','5444365657', 'LE'),
('PH003', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH003','LAM','12345','5565476556', 'LE'),
('PH004', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH004','TRACH','12345','56556565556', 'LE'),
('PH005', 'DA DUYET','2023-05-07','2023-05-07','2023-05-07',2,'KHONG CO','KH005','KHANH','12345','56565656565', 'LE');
----------------------------
/*SELECT PDP.MAPHIEUDP AS MAPHIEU, P.MAPHONG AS MAPHONG
FROM PHIEUDATPHONG PDP JOIN DANHSACHPHONG P ON PDP.MAPHIEUDP = P.MAPHIEUTHUEPHONG
WHERE PDP.TenKHDaiDien = 'LAM' */


CREATE TABLE TAIKHOAN
(
   TEN_TK varchar(5) NOT NULL,
   MATKHAU char(30),
);

insert into TAIKHOAN (TEN_TK, MATKHAU) 
values 
('NV001', 'NV001'),
('NV002', 'NV002'),
('NV003', 'NV003'),
('NV004', 'NV004');


CREATE TABLE NHANVIEN
(
   MANV varchar(5) NOT NULL,
   TENNV nvarchar(50) NOT NULL,
   SDT VARCHAR(10),
   CMND varchar(50),
   VAITRO varchar(13),
   PRIMARY KEY (MANV)
);

insert into NHANVIEN (MANV, TENNV,SDT,CMND,VAITRO) 
values 
('NV001', 'Nguyen Van A','8542885554','145544117544','NVBELLMAN'),
('NV002', 'Nguyen Van B','8542885554','145544117544','NVBUONGPHONG'),
('NV003', 'Nguyen Van B','8542885554','145544117544','NVKETOAN'),
('NV004', 'Nguyen Van C','8542885554','145544117544','NVLETAN');



CREATE TABLE NVBELLMAN(
	MANV VARCHAR(5),
	CATRUC VARCHAR(5), --NGAY, DEM
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

insert into NVBELLMAN (MANV,CATRUC) 
values 
('NV001', 'Ngay');

CREATE TABLE NVBUONGPHONG(
	MANV VARCHAR(5),
	KHUVUCQL VARCHAR(5), --TANG1, TANG2
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

insert into NVBUONGPHONG (MANV,KHUVUCQL) 
values 
('NV002', 'Tang5');

CREATE TABLE NVKETOAN(
	MANV VARCHAR(5),
	SLHOSOTHANHTOAN INT,
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

insert into NVKETOAN (MANV,SLHOSOTHANHTOAN) 
values 
('NV003', 5);

CREATE TABLE NVLETAN(
	MANV VARCHAR(5),
	VITRI VARCHAR(5), --BAN1, BAN2
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

insert into NVLETAN (MANV,VITRI) 
values 
('NV003', 'BAN1');


insert into TAIKHOAN (TEN_TK, MATKHAU) values ('NV001', 'NV001');

select * from NHANVIEN JOIN TAIKHOAN on MANV = Ten_TK Where MANV = '" + username + "' AND MATKHAU = '" + password + "'
select * from NHANVIEN JOIN TAIKHOAN on MANV = Ten_TK Where MANV = 'NV001' AND MATKHAU = 'NV001'

drop table khachhang
CREATE TABLE KHACHHANG
(
   MAKH char(10) NOT NULL,
   TENTK char(40) NOT NULL,
   SDT varchar(13) ,
   CMND nvarchar(50),
   MAPHIEUDP CHAR(10),
   PRIMARY KEY (MAKH)
);

insert into KHACHHANG (MAKH, TENTK,SDT, CMND, MAPHIEUDP ) values ('KH001','DANH','12345','4114478448','PH001');
insert into KHACHHANG (MAKH, TENTK,SDT, CMND, MAPHIEUDP ) values ('KH002','MAN','12345','5444365657','PH002');
insert into KHACHHANG (MAKH, TENTK,SDT, CMND, MAPHIEUDP ) values ('KH003','LAM','12345','5565476556','PH003');
insert into KHACHHANG (MAKH, TENTK,SDT, CMND, MAPHIEUDP ) values ('KH004','TRACH','12345','56556565556', 'PH004');
insert into KHACHHANG (MAKH, TENTK,SDT, CMND, MAPHIEUDP ) values ('KH005','KHANH','12345','56565656565', 'PH005');
insert into KHACHHANG (MAKH, TENTK,SDT, CMND, MAPHIEUDP ) values ('KH006','BEBE','12345','56568556565', 'PH001');

----------------
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
insert into PhieuDangKiDichVu(MaPhieuDangKiDichVu,ThoiGianSuDung,CacYeuCauDacBiet)
values
('PDV003','12:00','Khong co'),
('PDV004','14:00','Khong co');

create table DanhSachSanPhamVaDichVu  (
	MaDV CHAR(10) PRIMARY KEY,
	TenDV VARCHAR(50),
	DonGiaDV FLOAT,
	ThoiGianMo INT,
	ThoiGianDong INT
);

---DU LIEU DEMO CUA BANH DANH SACH SAN PHAM VA DI VU
insert into DanhSachSanPhamVaDichVu(MaDV,TenDV,DonGiaDV,ThoiGianMo,ThoiGianDong)
values
('DV001','AN UONG',150000,0,24),
('DV002','SPA',300000,0,24),
('DV003','GYM',100000,0,24),
('DV004','KARAOKE',100000,0,24),
('DV005','BI-A',100000,0,24);


-- create----------------------------------------------------

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
);

CREATE TABLE HoSoThanhToan (
  MaHSThanhToan char(10) PRIMARY KEY,
  MaLienPhieuDV char(10),
  FOREIGN KEY (MaLienPhieuDV) REFERENCES LienPhieuDichVu(MaLienPhieuDV)
);




--dang loi o day ne

CREATE TABLE PHANHOIDICHVU
(
	PH_NhanVien char(15),
	PH_Phong char(15),
	PH_DoAnNuocUong char(15),
	PH_DichVuKhac char(15),
    PhanHoiKhac varchar(50),
	MaKHDaiDien  char(10),
	SĐTKHDaiDien nvarchar(50),
	TrangThai nvarchar(50)
);

-- insert
INSERT INTO PHANHOIDICHVU(PH_NhanVien, PH_Phong, PH_DoAnNuocUong, PH_DichVuKhac, PhanHoiKhac, MaKHDaiDien, SĐTKHDaiDien, TrangThai)
VALUES ('Tot', 'Trung binh', 'Tot','Tot', 'Khong co', 'KH001', '4114478448', 'Da duyet');
INSERT INTO PHANHOIDICHVU(PH_NhanVien, PH_Phong, PH_DoAnNuocUong, PH_DichVuKhac, PhanHoiKhac, MaKHDaiDien, SĐTKHDaiDien, TrangThai)
VALUES ('Tot', 'Tot', 'Khong tot','Tot', 'Khong co', 'KH001', '4114478448', 'Da duyet');

INSERT INTO HoaDon(MaHoaDon, NgayLap, TongTien, TrangThaiThanhToan, MaPhieuDP)
VALUES ('HD001', '2023-09-23', 1225000,'Chua thanh toan', 'PH001');
INSERT INTO HoaDon(MaHoaDon, NgayLap, TongTien, TrangThaiThanhToan, MaPhieuDP)
VALUES ('HD002', '2023-05-05', 850000,'Da thanh toan', 'PH002');

INSERT INTO LienPhieuDichVu(MaLienPhieuDV, TenDV, LoaiDV, GiaTien, SoLuong, MaDV, MaPhieuDangKiDichVu)
VALUES ('LP001', 'Do an uong', 'An uong', 25000, 5, 'DV001', 'PDV003');
INSERT INTO LienPhieuDichVu(MaLienPhieuDV, TenDV, LoaiDV, GiaTien, SoLuong, MaDV, MaPhieuDangKiDichVu)
VALUES ('LP002', 'Xong hoi', 'Spa', 100000, 1, 'DV002', 'PDV004');

INSERT INTO CheckoutCard(MaCheckoutCard, ThoiGianCheckOut)
VALUES ('CK001', '2023-09-25 09:10:00');
INSERT INTO CheckoutCard(MaCheckoutCard, ThoiGianCheckOut)
VALUES ('CK002', '2023-09-26 12:10:00');

INSERT INTO HoSoThanhToan( MaHSThanhToan, MaLienPhieuDV)
VALUES ('HS001', 'LP001');
INSERT INTO HoSoThanhToan( MaHSThanhToan, MaLienPhieuDV)
VALUES ('HS002', 'LP002');

-- fetch 



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
('PHG002','PHONG DOI',1000000,'Da Duoc Thue ','Sach se ','Khong', 'Phong thoang mat sach se','PH001'),
('PHG003','PHONG DON',1000000,'Con Trong ','Sach se ','Khong', 'Phong thoang mat sach se','NULL'),
('PHG004','PHONG DON',500000,'Da Duoc Thue ','Sach se ','Khong', 'Phong thoang mat sach se','PH003'),
('PHG005','PHONG BON',2000000,'Da Duoc Thue ','Sach se ','Khong', 'Phong thoang mat sach se','PH004');

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

Create table DanhSachKhuyenMai
(
	MaKhuyenMai varchar(8),
	TenKhuyenMai varchar(80),
	ThongTinKhuyenMai varchar(80),
	ThoiGianBatDau date,
	ThoiGianKetThuc date,
	MaPhong varchar(8),
	PRIMARY KEY (MaKhuyenMai)
);
insert into DanhSachKhuyenMai(MaKhuyenMai,TenKhuyenMai,ThongTinKhuyenMai,ThoiGianBatDau,ThoiGianKetThuc, MaPhong)
values
('KM001','Cafe mien phi','Quy khach se duoc mot ly cafe mien phi vao moi buoi sang ','2022-08-04', '2022-08-04', 'PHG001'),
('KM002','Tra mien phi','Quy khach se duoc mot ly tra mien phi vao moi buoi sang ','2022-08-04', '2022-08-04', 'PHG002'),
('KM003','View an sang dep','Quy khach se duoc lua chon cho ngoi mien phi vao moi buoi sang ','2022-08-04', '2022-08-04', 'PHG003'),
('KM004','Banh my Phap mien phi','Quy khach se duoc mot banh my Phap mien phi vao moi buoi sang ','2022-08-04', '2022-08-04', 'PHG004'),
('KM005','Ve vao be boi mien phi ','Quy khach se duoc mot ve vao ho boi mien phi vao moi buoi chieu ','2022-08-04', '2022-08-04', 'PHG005');

CREATE TABLE PHIEUVANCHUYENHANHLY(
	MAPHIEUVANCHUYENHANHLY VARCHAR(10),
	MAPHONG	VARCHAR(10),
	SLHANHLY INT
);

INSERT INTO PHIEUVANCHUYENHANHLY(MAPHIEUVANCHUYENHANHLY, MAPHONG, SLHANHLY)
VALUES
('PH001', 'PHG002', 5),
('PH002', 'PHG004', 2);