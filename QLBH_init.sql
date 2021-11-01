--USE master
IF DB_ID('QLBH') IS NOT NULL 
	DROP DATABASE QLBH
GO
CREATE DATABASE QLBH
GO
USE QLBH
GO
CREATE TABLE KHACHHANG
(
MAKH CHAR(15),
HO NVARCHAR(50),
TEN NVARCHAR(50),
NGSINH DATE,
SONHA CHAR(15),
DUONG NVARCHAR(50),
PHUONG NVARCHAR(50),
QUAN NVARCHAR(50),
TPHO NVARCHAR(50),
DIENTHOAI CHAR(15)

CONSTRAINT PK_KH
PRIMARY KEY (MAKH)
)
GO

CREATE TABLE HOADON
(
MAHD CHAR(15),
MAKH_HD CHAR(15),
NGAYLAP DATE,
TONGTIEN INT

CONSTRAINT PK_HD
PRIMARY KEY (MAHD)
)
GO

CREATE TABLE CT_HOADON
(
MAHD_CT CHAR(15),
MASP_CT CHAR(15),
SOLUONG INT,
GIABAN INT,
GIAGIAM INT,
THANHTIEN INT

CONSTRAINT PK_CTHD
PRIMARY KEY (MAHD_CT, MASP_CT)
)
GO

CREATE TABLE SANPHAM
(
MASP CHAR(15),
TENSP NVARCHAR(50),
SOLUONGTON INT,
MOTA NVARCHAR(100),
GIA INT

CONSTRAINT PK_SP
PRIMARY KEY (MASP)
)
GO

ALTER TABLE HOADON
ADD
	CONSTRAINT FK_HD_KH
	FOREIGN KEY (MAKH_HD)
	REFERENCES KHACHHANG
GO

ALTER TABLE CT_HOADON
ADD 
	CONSTRAINT FK_HD_CT
	FOREIGN KEY (MAHD_CT)
	REFERENCES HOADON,

	CONSTRAINT FK_HD_SP
	FOREIGN KEY (MASP_CT)
	REFERENCES SANPHAM
GO


Create trigger Insert_CT_HoaDon_ThanhTien_TongTien
    on CT_HoaDon
    for insert
    as
    begin
       begin
       -- update thanh tien
    	update CT_HoaDon
    	set thanhtien = I.SOLUONG * (I.GIABAN - I.GIAGIAM)
    	from inserted I, 
    		 CT_HoaDon CTHD,
    		 HOADON HD,
    		 SANPHAM SP
        --Chi tiết hóa đơn mới thêm vào phải tồn tại sản phẩm, và mã hóa đơn
    	where SP.MASP=I.MASP_CT and SP.MASP=CTHD.MASP_CT and HD.MAHD=I.MAHD_CT and HD.MAHD=CTHD.MAHD_CT
       end
       -- update tong tien 
       begin
       update HOADON
        set TONGTIEN = TONGTIEN + (select CTHD.THANHTIEN  
                                  from inserted I,CT_HOADON CTHD
                                  where MAHD=CTHD.MAHD_CT and CTHD.MAHD_CT=I.MAHD_CT and I.MASP_CT=CTHD.MASP_CT)
       from HOADON HD, inserted
       where HD.MAHD=inserted.MAHD_CT
       end 
    end 
  
GO
--select  CT. from CT_HOADON CT
Create trigger update_CT_HoaDon_ThanhTien_TongTien
    on CT_HoaDon 
    for update
    as
    begin
    --update mã hóa đơn ở chi tiết hóa đơn
    if UPDATE(MAHD_CT)
       begin
       -- cập nhật lại tổng tiền khi update CT hóa đơn
       update HOADON
       set TONGTIEN=TONGTIEN - (select deleted.THANHTIEN from deleted where MAHD=deleted.MAHD_CT)	
       from deleted
       where HOADON.MAHD=deleted.MAHD_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN + (select CTHD.THANHTIEN  
                                  from inserted I,CT_HOADON CTHD
                                  where MAHD=CTHD.MAHD_CT and CTHD.MAHD_CT=I.MAHD_CT and I.MASP_CT=CTHD.MASP_CT)
       from HOADON HD, inserted
       where HD.MAHD=inserted.MAHD_CT
       end 
       --update số lượng ở chi tiết hóa đơn
    if UPDATE(SOLUONG)
       begin
       update CT_HOADON
       set THANHTIEN= I.SOLUONG*(I.GIABAN-I.GIAGIAM)
       from inserted I
       where I.MAHD_CT=CT_HOADON.MAHD_CT and I.MASP_CT=CT_HOADON.MASP_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D, CT_HOADON CTHD where MAHD=D.MAHD_CT and CTHD.MAHD_CT=MAHD)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
       end
       --update giá bán ở bản chi tiết hóa đơn
    if UPDATE(GIABAN)
       begin
       update CT_HOADON
       set THANHTIEN= I.SOLUONG*(I.GIABAN-I.GIAGIAM)
       from inserted I
       where I.MAHD_CT=CT_HOADON.MAHD_CT and I.MASP_CT=CT_HOADON.MASP_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D, CT_HOADON CTHD where MAHD=D.MAHD_CT and CTHD.MAHD_CT=MAHD)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
       end
       --update giá giảm ở bản chi tiết hóa đươn
    if UPDATE(GIAGIAM)
       begin
       update CT_HOADON
       set THANHTIEN= I.SOLUONG*(I.GIABAN-I.GIAGIAM)
       from inserted I
       where I.MAHD_CT=CT_HOADON.MAHD_CT and I.MASP_CT=CT_HOADON.MASP_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D where MAHD=D.MAHD_CT)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
       end
    end 
  
GO


Create trigger delete_CT_HoaDon_TongTien
    on CT_HoaDon
    for delete
    as
    begin
       -- cập nhật lại tổng tiền khi xóa CT hóa đơn
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D where MAHD=D.MAHD_CT)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
    end 
  
GO


GO
SELECT * FROM dbo.KHACHHANG
SELECT * FROM dbo.HOADON
SELECT * FROM dbo.CT_HOADON