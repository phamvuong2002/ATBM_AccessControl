--------------------------------------------------------
-- Group 08
-- 20127063 - Phan Minh Phuc
-- 20127548 - Dong My Linh
-- 20127570 - Vo Thi Kim Ngan
-- 20127671 - Pham Quoc Vuong
-- Class: 20HTTT1
--------------------------------------------------------
CONN ADMIN_GROUP8/ADMIN_GROUP8;
/
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE QLNV_NHANVIEN';
   EXECUTE IMMEDIATE 'DROP TABLE QLNV_DEAN';
   EXECUTE IMMEDIATE 'DROP TABLE QLNV_PHANCONG';
   EXECUTE IMMEDIATE 'DROP TABLE QLNV_PHONGBAN';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/
--------------------------------------------------------
--  DDL for Table QLNV_NHANVIEN
--------------------------------------------------------

  CREATE TABLE QLNV_NHANVIEN
   (	"MANV" VARCHAR2(20 BYTE), 
	"TENNV" VARCHAR2(30 BYTE), 
	"PHAI" VARCHAR2(10 BYTE), 
	"NGAYSINH" DATE, 
	"DIACHI" VARCHAR2(50 BYTE), 
	"SODT" VARCHAR2(20 BYTE), 
	"LUONG" FLOAT(126), 
	"PHUCAP" FLOAT(126), 
	"VAITRO" VARCHAR2(20 BYTE), 
	"MANQL" VARCHAR2(20 BYTE), 
	"PHG" VARCHAR2(20 BYTE)
   ) 
   /
--------------------------------------------------------
--  DDL for Table QLNV_DEAN
--------------------------------------------------------

  CREATE TABLE QLNV_DEAN 
   (	"MADA" VARCHAR2(20 BYTE), 
	"TENDA" VARCHAR2(30 BYTE), 
	"NGAYBD" DATE, 
	"PHONG" VARCHAR2(20 BYTE)
   )
   /
--------------------------------------------------------
--  DDL for Table QLNV_PHANCONG
--------------------------------------------------------

  CREATE TABLE QLNV_PHANCONG
   (	"MANV" VARCHAR2(20 BYTE), 
	"MADA" VARCHAR2(20 BYTE), 
	"THOIGIAN" DATE
   )
   /
--------------------------------------------------------
--  DDL for Table QLNV_PHONGBAN
--------------------------------------------------------

  CREATE TABLE QLNV_PHONGBAN 
   (	"MAPB" VARCHAR2(20 BYTE), 
	"TENPB" VARCHAR2(30 BYTE), 
	"TRPHG" VARCHAR2(20 BYTE)
   )
/
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV001','Lucretia','Nam',to_date('02-SEP-75','DD-MON-RR'),'227 Nguyen Van Cu, P.4, Q.5, TPHCM','137-708-1256   ',7102,4343,'Ban giam doc',null,'GD');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV002','Bobbi','Nam',to_date('17-FEB-83','DD-MON-RR'),'228 Nguyen Van Cu, P.4, Q.5, TPHCM','943-370-3303   ',6317,3610,'Truong phong',null,'NC');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV003','Adrianne','Nu',to_date('30-APR-92','DD-MON-RR'),'229 Nguyen Van Cu, P.4, Q.5, TPHCM','915-728-3768   ',5741,4156,'Truong phong',null,'KT');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV004','Shantell','Nam',to_date('15-JUN-86','DD-MON-RR'),'230 Nguyen Van Cu, P.4, Q.5, TPHCM','(964) 819-8701 ',8413,3515,'Truong de an',null,'NC');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV005','Joseph','Nam',to_date('13-AUG-95','DD-MON-RR'),'231 Nguyen Van Cu, P.4, Q.5, TPHCM','(573) 298-5955 ',8537,4532,'Truong de an',null,'KT');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV006','Charity','Nam',to_date('30-MAY-94','DD-MON-RR'),'232 Nguyen Van Cu, P.4, Q.5, TPHCM','715-951-0414   ',5473,3578,'Tai chinh',null,'NC');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV007','Sheryl','Nu',to_date('19-APR-70','DD-MON-RR'),'233 Nguyen Van Cu, P.4, Q.5, TPHCM','(910) 616-4849 ',5273,4072,'Nhan su',null,'KT');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV008','Krista','Nu',to_date('16-MAY-90','DD-MON-RR'),'234 Nguyen Van Cu, P.4, Q.5, TPHCM','548-324-4397   ',6187,3858,'QL truc tiep',null,'KT');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV009','Lee','Nam',to_date('09-SEP-88','DD-MON-RR'),'235 Nguyen Van Cu, P.4, Q.5, TPHCM','876-370-3027   ',6846,4148,'Nhan vien','NV008','KT');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV010','Geneva','Nu',to_date('20-OCT-79','DD-MON-RR'),'236 Nguyen Van Cu, P.4, Q.5, TPHCM','(531) 440-9368 ',8469,4326,'Nhan vien','NV011','NC');
Insert into QLNV_NHANVIEN (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) values ('NV011','Adriana','Nu',to_date('25-DEC-90','DD-MON-RR'),'237 Nguyen Van Cu, P.4, Q.5, TPHCM','988-338-0460   ',6274,4217,'QL truc tiep',null,'NC');
/

Insert into QLNV_DEAN (MADA,TENDA,NGAYBD,PHONG) values ('DA001','Tin hoc hoa',to_date('23-FEB-02','DD-MON-RR'),'KT');
Insert into QLNV_DEAN (MADA,TENDA,NGAYBD,PHONG) values ('DA002','User Management',to_date('22-JUN-03','DD-MON-RR'),'NC');
/
Insert into QLNV_PHANCONG (MANV,MADA,THOIGIAN) values ('NV004','DA002',to_date('31-JAN-10','DD-MON-RR'));
Insert into QLNV_PHANCONG (MANV,MADA,THOIGIAN) values ('NV005','DA001',to_date('30-AUG-22','DD-MON-RR'));
Insert into QLNV_PHANCONG (MANV,MADA,THOIGIAN) values ('NV008','DA001',to_date('15-JUL-17','DD-MON-RR'));
Insert into QLNV_PHANCONG (MANV,MADA,THOIGIAN) values ('NV009','DA001',to_date('20-APR-16','DD-MON-RR'));
Insert into QLNV_PHANCONG (MANV,MADA,THOIGIAN) values ('NV010','DA002',to_date('13-AUG-09','DD-MON-RR'));
Insert into QLNV_PHANCONG (MANV,MADA,THOIGIAN) values ('NV011','DA002',to_date('25-JUL-18','DD-MON-RR'));
/

Insert into QLNV_PHONGBAN (MAPB,TENPB,TRPHG) values ('GD','Ban giam doc','NV001');
Insert into QLNV_PHONGBAN (MAPB,TENPB,TRPHG) values ('NC','Nghien cuu','NV002');
Insert into QLNV_PHONGBAN (MAPB,TENPB,TRPHG) values ('KT','Ky thuat','NV003');
