CREATE DATABASE QLBANHANGTHOITRANGTEST
USE QLBANHANGTHOITRANG

/*
Created		03-03-2017
Modified		11-03-2017
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2000 
*/


Create table [KHACHHANG]
(
	[MAKH] Char(10) NOT NULL,
	[TENKH] Nvarchar(50) NULL,
	[DCKH] Nvarchar(100) NULL,
	[DTKH] Varchar(13) NULL,
Primary Key ([MAKH])
) 
go

Create table [SANPHAM]
(
	[MASP] Char(10) NOT NULL,
	[TENSP] Nvarchar(50) NULL,
	[GIAMUA] Integer NULL,
	[GIABAN] Integer NULL,
	[SLTON] Integer NULL,
Primary Key ([MASP])
) 
go

Create table [NHANVIEN]
(
	[MANV] Char(10) NOT NULL,
	[TENNV] Nvarchar(50) NULL,
	[NGAYSINH] Datetime NULL,
	[GIOITINH] Nvarchar(10) NULL,
	[DCNVHIENTAI] Nvarchar(100) NULL,
	[DTNV] Varchar(13) NULL,
	[CMND] Char(9) NULL,
	[NOICAPCMND] Nvarchar(50) NULL,
	[NGAYCAPCMND] Datetime NULL,
	[HOKHAU] Nvarchar(50) NULL,
	[MACV] Char(10) NOT NULL,
	[HINHANH] NVARCHAR(50) ,
Primary Key ([MANV])
) 
go

Create table [HOADON]
(
	[SOHD] Char(10) NOT NULL,
	[NGAYLAPHD] Datetime NULL,
	[MAKH] Char(10) NULL,
	[MANV] Char(10) NOT NULL,
	[TONGTG] Integer NULL,
Primary Key ([SOHD])
) 
go

Create table [CHUCVU]
(
	[MACV] Char(10) NOT NULL,
	[TENCV] Nvarchar(50) NULL,
Primary Key ([MACV])
) 
go

Create table [CTHD]
(
	[SOHD] Char(10) NOT NULL,
	[MASP] Char(10) NOT NULL,
	[SL] Integer NULL,
	[GIABAN] Integer NULL,
Primary Key ([SOHD],[MASP])
) 
go

Create table [TAIKHOAN]
(
	[TAIKHOAN] Varchar(20) NOT NULL,
	[MATKHAU] Varchar(20) NULL,
	[MANV] Char(10) NOT NULL,
Primary Key ([TAIKHOAN])
) 
go

create table [NCC]
(
	[MANCC] Char(10) NOT NULL,
	[TENNCC] Nvarchar(50) NULL,
	[DCNCC] Nvarchar(100) NULL,
	[DTNCC] Varchar(13) NULL,
Primary Key ([MANCC])
)
go
Create table [PHIEUNHAP]
(
	[PHIEUNHAP] Char(10) NOT NULL,
	[NGAYLAPPN] Datetime NULL,
	[MANCC] Char(10) NULL,
	[MANV] Char(10) NOT NULL,
	[TONGTG] Integer NULL,
Primary Key ([PHIEUNHAP])
) 
go
Create table [CTPN]
(
	[PHIEUNHAP] Char(10) NOT NULL,
	[MASP] Char(10) NOT NULL,
	[SL] Integer NULL,
	[GIAMUA] Integer NULL,
Primary Key ([PHIEUNHAP],[MASP])
) 
go

alter table SANPHAM
add GIAMUA int 


Alter table [HOADON] add  foreign key([MAKH]) references [KHACHHANG] ([MAKH])  on update no action on delete no action 
go
Alter table [CTHD] add  foreign key([MASP]) references [SANPHAM] ([MASP])  on update no action on delete no action 
go
Alter table [HOADON] add  foreign key([MANV]) references [NHANVIEN] ([MANV])  on update no action on delete no action 
go
Alter table [TAIKHOAN] add  foreign key([MANV]) references [NHANVIEN] ([MANV])  on update no action on delete no action 
go
Alter table [CTHD] add  foreign key([SOHD]) references [HOADON] ([SOHD])  on update no action on delete no action 
go
Alter table [NHANVIEN] add  foreign key([MACV]) references [CHUCVU] ([MACV])  on update no action on delete no action 
go
Alter table [CTPN] add  foreign key([PHIEUNHAP]) references [PHIEUNHAP] ([PHIEUNHAP])  on update no action on delete no action 
go
Alter table [CTPN] add  foreign key([MASP]) references [SANPHAM] ([MASP])  on update no action on delete no action 
go
Alter table [PHIEUNHAP] add  foreign key([MANCC]) references [NCC] ([MANCC])  on update no action on delete no action 
go
Alter table [PHIEUNHAP] add  foreign key([MANV]) references [NHANVIEN] ([MANV])  on update no action on delete no action 
go




Set quoted_identifier on
go


Set quoted_identifier off
go

CREATE TABLE [PHANQUYEN]
(
	[TAIKHOAN_ADMIN] VARCHAR(20) NOT NULL,
	[MATKHAU_ADMIN] VARCHAR(20) NOT NULL,
	[QUYEN] NVARCHAR(20)
	PRIMARY KEY ([TAIKHOAN_ADMIN])
)






CREATE PROC TABLE_KHACHHANG
AS 
BEGIN
	SELECT *
	FROM KHACHHANG
END

CREATE TABLE CAPMA_TUDONG
(
	STT INT IDENTITY(1,1) PRIMARY KEY,
	KYTU VARCHAR(5) NOT NULL,
	KYSO INT NOT NULL
)


CREATE PROC TANG_MATUDONG(@KYTU VARCHAR(5))
AS
BEGIN
	UPDATE CAPMA_TUDONG
	SET KYSO = KYSO + 1
	WHERE KYTU = @KYTU
END

CREATE FUNCTION RETURN_KYSO(@KYTU VARCHAR(5))
RETURNS INT
AS
BEGIN
	DECLARE @SO INT
	SELECT @SO = KYSO FROM CAPMA_TUDONG WHERE @KYTU = KYTU
	RETURN @SO
END

CREATE PROC TABLE_NHANVIEN
AS
BEGIN
	SELECT *
	FROM NHANVIEN
END

CREATE PROC TABLE_CHUCVU
AS
BEGIN
	SELECT *
	FROM CHUCVU
END

ALTER TABLE CTHD
DROP COLUMN TONGTG

ALTER TABLE CTHD
ADD GIABAN INT

ALTER TABLE HOADON
ADD TONGTG INT