create database QLyDiem
go
use QLyDiem
go

create table tblLopHoc
(
	sMaLop varchar(20) primary key,
	sTenLopHoc nvarchar(50),
	iKhoiHoc int
)
go

---Bảng Học sinh
create table tblHocSinh
(
	sMaHS varchar(20) primary key,
	sTenHS nvarchar(100),
	dNgaySinh date,
	sGioiTinh nvarchar(5),
	sDiaChi nvarchar(100),
	sMalop varchar(20) constraint FK_HocSinh_Lop foreign key (sMalop) references tblLopHoc(SMalop)
	)
 go

 ----Bảng Nhóm môn học
 create table tblNhomMonHoc
(
	sMaNhomMon varchar(20) primary key,
	sNhomMon nvarchar(100),
	sLoaiMonHoc nvarchar(100)						
)
go

---Bảng giáo viên
create table tblGiaoVien
(
  sMaGV varchar(20),
  sTenGiaoVien nvarchar(100),
  sGioiTinh nvarchar(5),
  dNgaySinh date,
  primary key (sMaGV)
)
go
---Môn học
create table tblMonHoc
(
	sMaMonHoc varchar(30) primary key,
	sTenMonHoc nvarchar(100),
	sKihieuMonHoc nvarchar(10),
	sMaGV varchar(20) foreign key(sMaGV) references tblGiaoVien(sMaGV),
	sMaNhomMon varchar(20) constraint FK_MonHoc_NhomMonHoc foreign key(sMaNhomMon) references tblNhomMonHoc(sMaNhomMon),
	sMaLop varchar(20) constraint FK_monhoc_Lophoc foreign key (sMaLop) references tblLopHoc(sMaLop)
)
go
---bảng điểm
create table tblDiem
(
	sMaHS varchar(20) constraint FK_SinhVien_Diem foreign key (sMaHS) references tblHocSinh(sMaHS),
	sMaMonHoc varchar(30) constraint FK_MonHoc_Diem foreign key (sMaMonHoc) references tblMonHoc(sMaMonHoc),
	fDiemCC float,
	fDiemGK float,
	fDiemThi float,
	fDiemTBMon float,
	sDanhHieu nvarchar(40)
	primary key (sMaHS,sMaMonHoc)
)
go 
----Bảng tài khoản
create table tblTaiKhoan 
(
	iMaTK int identity(1,1)primary key,
	sTenNguoiDung nvarchar(30),
	sTenTK varchar(50),
    sMatKhau varchar(50),
	iLoaiTK int ,
	Maxx varchar (20)
	--0 admin Hieu trưởng
	--1 Giao vien
	--2 sinh vien
)
go

insert into tblTaiKhoan
values
					---HIỆU TRƯỞNG---
	  (N'Phạm Xuân Tiến','phamxuantien','tien123',0,'HT01'),
	  (N'Phạm Văn Quốc Huy','phamvanquochuy','huy123',0,'HT02'),
	  (N'Lê Tiến Đạt','letiendat','dat123',0,'HT03'),
					---GV KHỐI 6
	  (N'Trương Ngọc Dương','ngocduong','duong123',1,'GV01'),
	  (N'Diệu Ái','dieuai','ai123',1,'GV02'),
	  (N'Khả Ái','khaai','ai123',1,'GV03'),
	  (N'Ngọc Ái','ngocai','ai123',1,'GV04'),
					---GV KHỐI 7
	  (N'Hoài An','hoaian','an123',1,'GV05'),
	  (N'Huệ An','huean','an123',1,'GVH6'),
	  (N'Minh An','minhan','an123',1,'GV07'),
	  (N'Phương An','phuongan','an123',1,'GV08'),


					---GV KHỐI 8
	  (N'Thanh An','thanhan','an123',1,'GV09'),
	  (N'Hải Ân','haian','an123',1,'GV10'),
	  (N'Bảo Anh','baoanh','anh123',1,'GV11'),
	  (N'Diệp Anh','diepanh','anh123',1,'GV12')
go

	insert into tblGiaoVien values
					('HT01',N'Phạm Xuân Tiến',N'Nam','10-07-2003'),
					('HT02',N'Phạm Văn Quốc Huy',N'Nam','12-02-2003'),
					('HT03',N'Lê Tiến Đạt',N'Nam','02-02-2003'),
					 ('GV01',N'Trương Ngọc Dương','Nam','11-11-2003'),
					 ('GV02',N'Diệu Ái',N'Nữ','11-24-2003'),
					 ('GV03',N'Khả Ái','Nam','03-20-2003'),
					 ('GV04',N'Ngọc Ái',N'Nữ','03-01-2003'),
					 ('GV05',N'Hoài An','Nam','11-01-2003'),
					 ('GV06',N'Huệ An',N'Nữ','09-23-2003'),
					 ('GV07',N'Minh An','Nam','05-11-2003'),
					 ('GV08',N'Phương An',N'Nữ','04-23-2003'),
					 ('GV09',N'Thanh An','Nam','03-17-2003'),
					 ('GV10',N'Hải Ân','Nam','04-19-2003'),
					 ('GV11',N'Bảo Anh',N'Nữ','07-23-2003'),
					 ('GV12',N'Diệp Anh','Nam','05-28-2003')
go
create or alter proc prDangNhap(@tk varchar(50), @mk varchar(50))
as
begin
	select * from tblTaiKhoan 
	where sTenTK = @tk collate SQL_Latin1_General_CP1_CS_AS
	and sMatKhau = @mk collate SQL_Latin1_General_CP1_CS_AS
end
go
exec prDangNhap'ngocduong', 'duong123'
---------------insert du lieu
insert into tblLopHoc values
							---Lớp 6A---
							('LH6A',N'Lớp 6A',6),
							---Lớp 6B---
							('LH6B',N'Lớp 6B',6),
							---Lớp 7A---
							('LH7A',N'Lớp 7A',7),
							---Lớp 7B---
							('LH7B',N'Lớp 7B',7),
							---Lớp 8A---
							('LH8A',N'Lớp 8A',8),
							---Lớp 8B---
							('LH8B',N'Lớp 8B',8),
							---Lớp 9A--
							('LH9A',N'Lớp 9A',9),
							---Lớp 9B--
							('LH9B',N'Lớp 9B',9)
go
	---insert bảng nhóm môn học
	insert into tblNhomMonHoc values('NM01',N'Toán',N'KHTN Toán'),
									('NM02',N'Lý',N'KHTN Lý'),
									('NM03',N'Hóa',N'KHTN Hóa'),
									('NM04',N'Sinh',N'KHTN Sinh')
	go

insert into tblMonhoc values('MH01',N'Toán 6','T6','GV01','NM01','LH6A'),
								('MH02',N'Toán 6','T6','GV05','NM01','LH6B'),
								('MH03',N'Toán 7','T7','GV01','NM01','LH7A'),
								('MH04',N'Toán 7','T7','GV05','NM01','LH7B'),
								('MH05',N'Toán 8','T8','GV11','NM01','LH8A'),
								('MH06',N'Toán 8','T8','GV01','NM01','LH8B'),
								('MH07',N'Toán 9','T9','GV04','NM01','LH9A'),
								('MH08',N'Toán 9','T9','GV01','NM01','LH9B'),

								('MH09',N'Lý 6','L6','GV09','NM02','LH6A'),
								('MH10',N'Lý 6','L6','GV10','NM02','LH6B'),
								('MH11',N'Lý 7','L7','GV02','NM02','LH7A'),
								('MH12',N'Lý 7','L7','GV12','NM02','LH7B'),
								('MH13',N'Lý 8','L8','GV03','NM02','LH8A'),
								('MH14',N'Lý 8','L8','GV02','NM02','LH8B'),
								('MH15',N'Lý 6','L9','GV02','NM02','LH9A'),
								('MH16',N'Lý 6','L9','GV04','NM02','LH9B'),

								('MH17',N'Hóa 6','H6','GV07','NM03','LH6A'),
								('MH18',N'Hóa 6','H6','GV03','NM03','LH6B'),
								('MH19',N'Hóa 7','H7','GV09','NM03','LH7A'),
								('MH20',N'Hóa 7','H7','GV12','NM03','LH7B'),
								('MH21',N'Hóa 8','H8','GV03','NM03','LH8A'),
								('MH22',N'Hóa 8','H8','GV07','NM03','LH8B'),
								('MH23',N'Hóa 9','H9','GV12','NM03','LH9A'),
								('MH24',N'Hóa 9','H9','GV02','NM03','LH9B'),

								('MH25',N'Sinh 6','T6','GV12','NM04','LH6A'),
								('MH26',N'Sinh 6','T6','GV10','NM04','LH6B'),
								('MH27',N'Sinh 7','T6','GV04','NM04','LH7A'),
								('MH28',N'Sinh 7','T6','GV05','NM04','LH7B'),
								('MH29',N'Sinh 8','T6','GV11','NM04','LH8A'),
								('MH30',N'Sinh 8','T6','GV12','NM04','LH8B'),
								('MH31',N'Sinh 9','T6','GV09','NM04','LH9A'),
								('MH32',N'Sinh 9','T6','GV08','NM04','LH9B')
go

insert into tblTaiKhoan 
values
		------Lớp 6A si số 5;
		(N'Bảo Vy','baovy','vy123',2,'HS01'),
		(N'Cát Tường','cattuong','tuong123',2,'HS02'),
		(N'Gia Hân','giahan','han123',2,'HS03'),
		(N'Khả Hân','khahan','han123',2,'HS04'),
		(N'Linh Chi','linhchi','chi123',2,'HS05'),
		------Lớp 6B si số 5;
		(N'Thanh Hà','thanhha','ha123',2,'HS06'),
		(N'Bích Hà','bichha','ha123',2,'HS07'),
		(N'Thanh Thúy','thanhthuy','thuy123',2,'HS08'),
		(N'Tú Uyên','tuuyen','uyen123',2,'HS09'),
		(N'Minh Tuệ','minhtue','tue123',2,'HS10'),
		------Lớp 7A si số 5;
		(N'Bảo Ngọc','baongoc','ngoc123',2,'HS11'),
		(N'Ái Nhi','ainhi','nhi123',2,'HS12'),
		(N'Đức Tài','ductai','tai123',2,'HS13'),
		(N'Bảo Đức','baoduc','duc123',2,'HS14'),
		(N'Đức Việt','ducviet','viet123',2,'HS15'),
		-------Lớp 7B si số 5;
		(N'Đức Uy','ducuy','uy123',2,'HS16'),
		(N'Hữu Đức','huuduc','duc123',2,'HS17'),
		(N'Hữu Nghĩa','huunghia','nghia123',2,'HS18'),
		(N'Hữu Tâm','huutam','tam123',2,'HS19'),
		(N'Khoa Đăng','khoadang','khoa123',2,'HS20'),
		--------Lớp 8A si số 5
		(N'Đăng Khoa','dangkhoa','khoa123',2,'HS21'),
		(N'Anh Minh','anhminh','minh123',2,'HS22'),
		(N'Minh Quang','minhquang','quang123',2,'HS23'),
		(N'Quang Khải','quangkhai','khai123',2,'HS24'),
		(N'Chí Thanh','chithanh','thanh123',2,'HS25'),
		-------Lớp 8B si số 5
		(N'Hải Đăng','haidang','dang123',2,'HS26'),
		(N'Thái Hưng','thaihung','thai123',2,'HS27'),
		(N'Khải Quang','Khải Quang','Quang123',2,'HS28'),
		(N'Huy Hoàng','huyhoang','hoang123',2,'HS29'),
		(N'Thành Công','thanhcong','cong123',2,'HS30'),
		------Lớp 9A si số 5
		(N'Mạnh Đức','manhduc','duc123',2,'HS31'),
		(N'Quang Mạnh','quangmanh','manh123',2,'HS32'),
		(N'Chí Kiên','chikien','kien123',2,'HS33'),
		(N'Lâm Dũng','lamdung','dung123',2,'HS34'),
		(N'Anh Dũng','anhdung','dung123',2,'HS35'),
		---------Lớp 9B si số 5
		(N'Trọng Nam','trongnam','nam123',2,'HS36'),
		(N'Thanh Tùng','thanhtung','tung123',2,'HS37'),
		(N'Chiến Thắng','chienthang','thang123',2,'HS38'),
		(N'Cao Cường','caocuong','cuong123',2,'HS39'),
		(N'Hùng Cường','hungcuong','hung123',2,'HS40')
go

insert into tblHocsinh
values
				--Lớp 6A
			('HS39',N'Cao Cường','12-11-2009','Nam',N'Hà Nội','LH6A'),
			('HS05',N'Linh Chi','11-11-2009',N'Nữ',N'Thanh Hóa','LH6A'),
			('HS06',N'Thanh Hà','12-08-2009',N'Nữ',N'Nam Định','LH6A'),
			('HS22',N'Anh Minh','10-08-2009',N'Nữ',N'Hà Tây','LH6A'),
			('HS26',N'Hải Đăng','03-02-2009',N'Nữ',N'Bắc Ninh','LH6A'),

			------Lớp 6B
			('HS32',N'Quang Mạnh','11-09-2009',N'Nữ',N'Hà Nội','LH6B'),
			('HS12',N'Ái Nhi','02-02-2009',N'Nam',N'Thanh Hóa','LH6B'),
			('HS27',N'Thái Hưng','06-05-2009',N'Nam',N'Bắc Ninh','LH6B'),
			('HS19',N'Hữu Tâm','01-01-2009',N'Nam',N'Bắc Ninh','LH6B'),
			('HS36',N'Trọng Nam','11-02-2009',N'Nữ',N'Bắc Ninh','LH6B'),
			----Lớp 7A
			('HS35',N'Anh Dũng','09-07-2008',N'Nam',N'Bắc Ninh','LH7A'),
			('HS30',N'Thành Công','03-02-2008',N'Nam',N'Bắc Ninh','LH7A'),
			('HS24',N'Quang Khải','09-12-2008',N'Nữ',N'Bắc Ninh','LH7A'),
			('HS15',N'Đức Việt','11-11-2008',N'Nữ',N'Bắc Ninh','LH7A'),
			('HS13',N'Đức Tài','11-02-2008',N'Nữ',N'Bắc Ninh','LH7A'),
			---Lớp 7B
			('HS31',N'Mạnh Đức','10-10-2008',N'Nam',N'Hà Nội','LH7B'),
			('HS03',N'Gia Hân','11-10-2008',N'Nữ',N'Nam Định','LH7B'),
			('HS07',N'Bích Hà','01-02-2008',N'Nam',N'Nam Định','LH7B'),
			('HS23',N'Minh Quang','12-01-2008',N'Nữ',N'Nam Định','LH7B'),
			('HS29',N'Huy Hoàng','11-03-2008',N'Nam',N'Bắc Giang','LH7B'),
			---Lớp 8A
			('HS28',N'Khải Quang','11-03-2007',N'Nam',N'Bắc Giang','LH8A'),
			('HS01',N'Bảo Vy','01-03-2007',N'Nam',N'Bắc Giang','LH8A'),
			('HS04',N'Khả Hân','02-03-2007',N'Nam',N'Nam Định','LH8A'),
			('HS25',N'Chí Thanh','10-03-2007',N'Nam',N'Hà Nội','LH8A'),
			('HS21',N'Đăng Khoa','11-07-2007',N'Nam',N'Bắc Giang','LH8A'),
			---Lớp 8B
			('HS16',N'Đức Uy','10-07-2007',N'Nam',N'Hà Nội','LH8B'),
			('HS02',N'Cát Tường','11-08-2007',N'Nữ',N'Hà Nội','LH8B'),
			('HS08',N'Thanh Thúy','12-07-2007',N'Nữ',N'Hà Nội','LH8B'),
			('HS09',N'Tú Uyên','11-11-2007',N'Nữ',N'Hà Nội','LH8B'),
			('HS10',N'Minh Tuệ','10-12-2007',N'Nam',N'Hà Nội','LH8B'),
			---Lớp 9A
			('HS11',N'Bảo Ngọc','10-10-2006',N'Nam',N'Hà Nội','LH9A'),
			('HS14',N'Bảo Đức','12-04-2006',N'Nữ',N'Hà Nội','LH9A'),
			('HS17',N'Hữu Đức','10-07-2006',N'Nam',N'Hà Nội','LH9A'),
			('HS18',N'Hữu Nghĩa','03-10-2006',N'Nam',N'Hà Nội','LH9A'),
			('HS20',N'Khoa Đăng','10-01-2006',N'Nam',N'Hà Nội','LH9A'),
			--Lớp 9B
			('HS33',N'Chí Kiên','01-01-2006',N'Nam',N'Thanh hóa','LH9B'),
			('HS34',N'Lâm Dũng','02-11-2006',N'Nữ',N'Thanh hóa','LH9B'),
			('HS37',N'Thanh Tùng','10-06-2006',N'Nữ',N'Thanh hóa','LH9B'),
			('HS38',N'Chiến Thắng','11-01-2006',N'Nữ',N'Thanh hóa','LH9B'),
			('HS40',N'Hùng Cường','08-12-2006',N'Nam',N'Thanh hóa','LH9B')
go


insert into tblDiem 
values 
				---Mã HS01
	('HS01','MH05',4,1,2,0,''),
	('HS01','MH13',6,6,6,0,''),---Lớp 8A
	('HS01','MH21',7,10,8,0,''),
	('HS01','MH29',6,4,4,0,''),
				---Maz HS02
	('HS02','MH06',2,4,4,0,''),
	('HS02','MH14',8,3,7,0,''),
	('HS02','MH22',9,6,2,0,''),---Lớp 8B
	('HS02','MH30',1,3,6,0,''),
				---Mã HS03
	('HS03','MH04',8,10,7,0,''),
	('HS03','MH12',6,5,6,0,''),---Lớp 7B
	('HS03','MH20',7,10,8,0,''),
	('HS03','MH28',6,6,4,0,''),
				---Mã HS04
	('HS04','MH05',10,7,9,0,''),
	('HS04','MH13',6,10,6,0,''),---Lớp 8A
	('HS04','MH21',10,10,9,0,''),
	('HS04','MH29',10,10,8,0,''),
				---Mã HS05
	('HS05','MH01',10,3,10,0,''),
	('HS05','MH09',10,7,3,0,''),---Lớp 6A
	('HS05','MH17',10,3,10,0,''),
	('HS05','MH25',10,7,3,0,''),
				---Mã HS06
	('HS06','MH01',10,9,8,0,''),
	('HS06','MH09',10,10,8,0,''),---Lớp 6A
	('HS06','MH17',10,10,10,0,''),
	('HS06','MH25',10,9,8,0,''),
				--Mã HS07
	('HS07','MH04',10,10,8,0,''),
	('HS07','MH12',10,10,10,0,''),---Lớp 7B
	('HS07','MH20',10,7,3,0,''),
	('HS07','MH28',6,6,4,0,''),
				--Mã HS08
	('HS08','MH06',10,10,8,0,''),
	('HS08','MH14',10,10,8,0,''),
	('HS08','MH22',10,10,10,0,''),---Lớp 8B
	('HS08','MH30',10,9,8,0,''),
				---Mã HS09
	('HS09','MH06',4,3,2,0,''),
	('HS09','MH14',4,1,2,0,''),
	('HS09','MH22',4,3,2,0,''),---Lớp 8B
	('HS09','MH30',10,10,8,0,''),
				--Mã HS10
	('HS10','MH06',4,1,2,0,''),
	('HS10','MH14',4,3,2,0,''),
	('HS10','MH22',4,3,1,0,''),---Lớp 8B
	('HS10','MH30',10,10,8,0,''),
				--mã HS11
	('HS11','MH07',4,3,2,0,''),
	('HS11','MH15',4,3,1,0,''),
	('HS11','MH23',4,1,2,0,''),---Lớp 9A
	('HS11','MH31',10,9,8,0,''),
				--mÃ HS12
	('HS12','MH02',10,7,3,0,''),
	('HS12','MH10',10,9,8,0,''),---Lớp 6B
	('HS12','MH18',10,10,8,0,''),
	('HS12','MH26',10,10,10,0,''),
			---Mã HS13
	('HS13','MH03',10,9,8,0,''),
	('HS13','MH11',10,10,8,0,''),---Lớp 7A
	('HS13','MH19',10,3,10,0,''),
	('HS13','MH27',6,4,4,0,''),
			--Mã HS14
	('HS14','MH07',10,10,8,0,''),
	('HS14','MH15',10,10,10,0,''),
	('HS14','MH23',10,10,10,0,''),---Lớp 9A
	('HS14','MH31',10,9,8,0,''),
			--MÃ HS 15
	('HS15','MH03',10,9,8,0,''),
	('HS15','MH11',10,10,8,0,''),---Lớp 7A
	('HS15','MH19',10,7,3,0,''),
	('HS15','MH27',9,2,3,0,''),
			---MÃ HS16
	('HS16','MH06',2,4,4,0,''),
	('HS16','MH14',8,10,7,0,''),
	('HS16','MH22',2,7,2,0,''),---Lớp 8B
	('HS16','MH30',6,5,3,0,''),
			--Mã HS17
	('HS17','MH07',6,5,6,0,''),
	('HS17','MH15',5,6,4,0,''),
	('HS17','MH23',6,7,8,0,''),---Lớp 9A
	('HS17','MH31',10,10,8,0,''),
			--MÃ HS18
	('HS18','MH07',6,5,6,0,''),
	('HS18','MH15',5,6,8,0,''),
	('HS18','MH23',6,7,8,0,''),---Lớp 9A
	('HS18','MH31',10,9,8,0,''),
			---Mã HS19
	('HS19','MH02',5,6,8,0,''),
	('HS19','MH10',5,7,8,0,''),---Lớp 6B
	('HS19','MH18',5,6,8,0,''),
	('HS19','MH26',5,6,8,0,''),
			---Mã HS20
	('HS20','MH07',10,10,10,0,''),
	('HS20','MH15',10,9,8,0,''),
	('HS20','MH23',10,9,8,0,''),---Lớp 9A
	('HS20','MH31',10,10,8,0,''),
			---Mã HS21
	('HS21','MH05',10,9,9,0,''),
	('HS21','MH13',6,10,6,0,''),---Lớp 8A
	('HS21','MH21',10,6,9,0,''),
	('HS21','MH29',6,10,6,0,''),
			---Mã HS22
	('HS22','MH01',6,10,6,0,''),
	('HS22','MH09',6,10,6,0,''),---Lớp 6A
	('HS22','MH17',6,10,6,0,''),
	('HS22','MH25',10,3,3,0,''),
			--Mã HS23
	('HS23','MH04',10,9,8,0,''),
	('HS23','MH12',6,10,6,0,''),---Lớp 7B
	('HS23','MH20',10,7,3,0,''),
	('HS23','MH28',6,6,5,0,''),
			---MÃ HS24
	('HS24','MH03',6,6,4,0,''),
	('HS24','MH11',10,10,8,0,''),---Lớp 7A
	('HS24','MH19',6,6,4,0,''),
	('HS24','MH27',9,2,3,0,''),
			--MÃ HS25
	('HS25','MH05',6,6,5,0,''),
	('HS25','MH13',6,10,6,0,''),---Lớp 8A
	('HS25','MH21',10,10,9,0,''),
	('HS25','MH29',6,10,6,0,''),
			--Mã HS26
	---Mã HS22
	('HS26','MH01',6,10,6,0,''),
	('HS26','MH09',10,10,9,0,''),---Lớp 6A
	('HS26','MH17',6,10,6,0,''),
	('HS26','MH25',10,7,3,0,''),
			--MÃ Hs27
	('HS27','MH02',10,10,9,0,''),
	('HS27','MH10',10,10,10,0,''),---Lớp 6B
	('HS27','MH18',10,3,10,0,''),
	('HS27','MH26',10,10,10,0,''),
			--Mã HS28
	('HS28','MH05',6,6,5,0,''),
	('HS28','MH13',10,3,10,0,''),---Lớp 8A
	('HS28','MH21',10,10,9,0,''),
	('HS28','MH29',6,10,6,0,''),
			--Mã HS29
	('HS29','MH04',10,10,10,0,''),
	('HS29','MH12',10,10,10,0,''),---Lớp 7B
	('HS29','MH20',10,3,10,0,''),
	('HS29','MH28',6,6,4,0,''),
			--Mã HS30
	('HS30','MH03',10,10,10,0,''),
	('HS30','MH11',6,6,5,0,''),---Lớp 7A
	('HS30','MH19',10,3,3,0,''),
	('HS30','MH27',9,3,3,0,''),
			--Mã HS31
	('HS31','MH04',10,10,10,0,''),
	('HS31','MH12',6,10,6,0,''),---Lớp 7B
	('HS31','MH20',9,3,1,0,''),
	('HS31','MH28',6,6,5,0,''),
			--mã HS32
	('HS32','MH02',10,10,10,0,''),
	('HS32','MH10',9,3,1,0,''),---Lớp 6B
	('HS32','MH18',10,9,8,0,''),
	('HS32','MH26',6,6,4,0,''),
			--Mã HS33
	('HS33','MH02',10,10,8,0,''),
	('HS33','MH16',10,10,8,0,''),
	('HS33','MH24',10,10,8,0,''),---Lớp 9B
	('HS33','MH32',10,10,8,0,''),
			---Mã HS34
	('HS34','MH02',10,9,8,0,''),
	('HS34','MH16',9,3,3,0,''),
	('HS34','MH24',10,9,8,0,''),---Lớp 9B
	('HS34','MH32',9,3,1,0,''),
			---Mã HS35
	('HS35','MH03',10,10,10,0,''),
	('HS35','MH11',9,3,1,0,''),---Lớp 7A
	('HS35','MH19',10,3,10,0,''),
	('HS35','MH27',9,3,1,0,''),
			--Mã HS36
	('HS36','MH02',5,6,4,0,''),
	('HS36','MH10',10,3,10,0,''),---Lớp 6B
	('HS36','MH18',5,6,8,0,''),
	('HS36','MH26',9,3,3,0,''),
			--Mã HS37
	('HS37','MH02',10,10,10,0,''),
	('HS37','MH16',9,3,3,0,''),
	('HS37','MH24',10,3,10,0,''),---Lớp 9B
	('HS37','MH32',9,3,1,0,''),
			--Mã HS38
	('HS38','MH02',10,10,10,0,''),
	('HS38','MH16',10,3,10,0,''),
	('HS38','MH24',10,3,10,0,''),---Lớp 9B
	('HS38','MH32',9,3,1,0,''),
			--Mã HS39
	('HS39','MH01',6,10,6,0,''),
	('HS39','MH09',10,10,9,0,''),---Lớp 6A
	('HS39','MH17',9,3,3,0,''),
	('HS39','MH25',10,3,10,0,''),
			--Mã HS40
	('HS40','MH02',10,10,10,0,''),
	('HS40','MH16',10,3,10,0,''),
	('HS40','MH24',6,10,6,0,''),---Lớp 9B
	('HS40','MH32',9,3,8,0,'')
go

	update tblDiem set fDiemTBMon=ROUND((fDiemCC*0.1 + fDiemGK*0.2 + fDiemThi*0.7),1)
go
	update tblDiem set sDanhHieu =N'Giỏi' where fDiemTBMon>=8
	update tblDiem set sDanhHieu=N'Khá' where fDiemTBMon>=6.5 and fDiemTBMon<8
	update tblDiem set sDanhHieu=N'TB' where fDiemTBMon>=5 and fDiemTBMon<6.5
	update tblDiem set sDanhHieu =N'Yếu' where fDiemTBMon<5
go

-------------------------
--PROC THÔNG TIN TÀI KHOẢN
create or alter proc prThongTinTaiKhoan
(@ten nvarchar(40))
as
begin
	declare @loaitaikhoan int;
	select @loaitaikhoan=iLoaiTK from tblTaiKhoan where sTenNguoiDung=@ten;
	if(@loaitaikhoan=1)
	begin
	select * from tblTaikhoan join tblGiaovien on tblTaikhoan.Maxx=tblGiaovien.sMaGV where @ten=sTenNguoiDung
	end
	else if(@loaitaikhoan=2)
	begin
	select * from tblTaikhoan join tblHocSinh on tblTaikhoan.Maxx=tblHocsinh.sMaHS where @ten=sTenNguoiDung
	end
	else if(@loaitaikhoan=0)
	begin
	select * from tblTaikhoan join tblGiaovien on tblTaikhoan.Maxx=tblGiaovien.sMaGV where @ten=sTenNguoiDung
	end
	end
go

------------------ insert GIao VIen 
create or alter proc prInsert_GiaoVien(@magv varchar(20), @tengv varchar(50), @gioitinh nvarchar(5), @ngaysinh date)
as
begin
	insert into tblGiaovien values(@magv,@tengv,@gioitinh,@ngaysinh)
	insert into tblTaiKhoan values(@tengv,@magv+'.edu',@magv,1,@magv)
end
go

------------------ infor GIao VIen 
create or alter proc prInfor_GiaoVien
as
begin
	select sMaGV, sTenGiaoVien, sGioiTinh, dNgaySinh
	from tblGiaoVien
	where sMaGV like '%GV%'
end
go
---------------tim kiem GIAO VIEN
create or alter proc prSearch_GiaoVien(@magv varchar(20), @tengv varchar(50), @gioitinh nvarchar(5), @ngay int, @thang int, @nam int)
	as
	begin
	select sMaGV,sTenGiaoVien,sGioiTinh,dNgaysinh
	from tblGiaovien
	where (sMaGV like '%' + @magv + '%' or @magv = '')
	and (sTenGiaoVien like  N'%' + @tengv + '%' or @tengv = '')
	and (sGioiTinh like  N'%' + @gioitinh + '%' or @gioitinh = '')
	and Day(dNgaysinh) =
			case 
			WHEN @Ngay =0 THEN  Day(dNgaysinh)
		    ELSE  @Ngay
			end
		and MONTH(dNgaysinh) =
			case
			WHEN @Thang =0 THEN MONTH(dNgaysinh)
		    ELSE @Thang
			end
		and YEAR(dNgaysinh) =
			case
			WHEN @Nam =0 THEN YEAR(dNgaysinh)
		    ELSE @Nam
			end
	and sMaGV not like '%HT%'
	end
go

------------tim du lieu gv
create or alter proc prAdapter_Giaovien(@ma varchar(30))
	as
	begin
	select sMaGV,sTenGiaoVien,sGioiTinh,dNgaysinh
	from tblGiaoVien 
	where sMaGV =@ma
	end
	go
	--------------------
-------------delete GIAO VIEN
create or alter proc prDelete_GiaoVien(@magv varchar(30))
as
	begin
	delete tblGiaovien where sMaGV = @magv
	delete tblTaiKhoan where Maxx=@magv
	end
go

-------------update GIAO VIEN----------
create or alter proc prUpdate_GiaoVien(@magv varchar(20), @tengv nvarchar(50), @gioitinh nvarchar(5),@ngaysinh date)
as
begin
	update tblGiaoVien
	set sMaGV = @magv, sTenGiaoVien = @tengv, sGioiTinh = @gioitinh, dNgaySinh = @ngaysinh
	where sMaGV = @magv
end
go



------------infor Lop Hoc
create or alter  proc prInfor_AllLopHoc
as
begin
	select tblLopHoc.sMaLop , sTenLopHoc , iKhoiHoc, COUNT(sMaHS)as[siSo]
	from tblLopHoc
	join tblHocSinh on tblLopHoc.sMaLop = tblHocSinh.sMalop
	where tblLopHoc.sMaLop like '%LH%'
	group by tblLopHoc.sMaLop , sTenLopHoc , iKhoiHoc
end
go

------------------------
create or alter  proc prInfor_LopHoc(@khoihoc int)
as
begin
	select tblLopHoc.sMaLop , sTenLopHoc , iKhoiHoc, COUNT(sMaHS)as[siSo]
	from tblLopHoc
	join tblHocSinh on tblLopHoc.sMaLop = tblHocSinh.sMalop
	where tblLopHoc.sMaLop like '%LH%'
	and iKhoiHoc = @khoihoc
	group by tblLopHoc.sMaLop , sTenLopHoc , iKhoiHoc
end
go

-------------Insert Lop Hoc
create or alter proc prInsert_LopHoc(@malop varchar(20), @tenlop nvarchar(50), @khoihoc int)
as
begin
	insert into tblLopHoc
	values(@malop, @tenlop, @khoihoc)
end
go

------------delete lớp học
create or alter proc prDelete_LopHoc(@malop varchar(30))
	as
	begin
	delete tblLopHoc where sMaLop = @malop
	end
go
------------tim kiem lop hoc
CREATE or alter PROCEDURE prSearch_LopHoc
   @malop varchar(50),
   @tenlop varchar(50),
   @khoihoc int
AS
BEGIN
   SELECT sMaLop as [Mã Lớp Học], sTenLopHoc as [Tên Lớp Học], iKhoiHoc as [Khối Học]
   FROM tblLopHoc
   WHERE
      (sMaLop LIKE '%' + @malop + '%' OR @malop = '') AND
      (sTenLopHoc LIKE '%' + @tenlop + '%' OR @tenlop = '') AND
      (iKhoiHoc = @khoihoc OR @khoihoc = '')
END
go

--------------tim du lieu lop hoc
create or alter proc prAdapter_LopHoc(@ma varchar(30))
as
begin
	select * from tblLopHoc
	where sMaLop = @ma
end
go
-------------------update lop hoc
create or alter proc prUpdate_LopHoc
   @malop varchar(50),
   @tenlop varchar(50),
   @khoihoc int
AS
BEGIN
   update tblLopHoc
   set sMaLop = @malop, sTenLopHoc = @tenlop, iKhoiHoc = @khoihoc
   where sMaLop = @malop
END
go

------------infor Hoc Sinh
create or alter proc prInfor_HocSinh
as
begin
	select sMaHS as [Mã Học Sinh], sTenHS as [Họ Và Tên], dNgaySinh as [Ngày Sinh],sGioiTinh as [Giới Tính], sDiaChi as [Địa Chỉ], sMalop as [Mã Lớp]
	from tblHocSinh
	where sMaHS like '%HS%'
end
go

------------insert Hoc Sinh
create or alter proc prInsert_HocSinh(@mahs varchar(20), @ten nvarchar(50), @ngaysinh date,@gioitinh nvarchar(5), @diachi nvarchar(50), @malop varchar(10))
as
begin
	insert into tblHocSinh values(@mahs,@ten,@ngaysinh,@gioitinh, @diachi, @malop)
	insert into tblTaiKhoan values(@ten, @mahs + '.edu',@mahs,2,@mahs )
	if(@malop='LH6A' )
		begin 
		insert into tblDiem values(@mahs,'MH01','','','','',''),
								  (@mahs,'MH09','','','','',''),
								  (@mahs,'MH17','','','','',''),
								  (@mahs,'MH25','','','','','')
		end
	else if(@malop='LH6B')
		begin
	    insert into tblDiem values(@mahs,'MH02','','','','',''),
								  (@mahs,'MH10','','','','',''),
								  (@mahs,'MH18','','','','',''),
								  (@mahs,'MH26','','','','','')
		end
	else if(@malop='LH7A')
		begin 
		 insert into tblDiem values(@mahs,'MH03','','','','',''),
								   (@mahs,'MH11','','','','',''),
								   (@mahs,'MH19','','','','',''),
								   (@mahs,'MH27','','','','','')
		end
	else if(@malop='LH7B')
		begin
		 insert into tblDiem values(@mahs,'MH04','','','','',''),
								   (@mahs,'MH12','','','','',''),
								   (@mahs,'MH20','','','','',''),
								   (@mahs,'MH28','','','','','')
		end
	else if(@malop='LH8A')
		begin
	     insert into tblDiem values(@mahs,'MH05','','','','',''),
								   (@mahs,'MH13','','','','',''),
								   (@mahs,'MH21','','','','',''),
								   (@mahs,'MH29','','','','','')
		end
	else if(@malop='LH8B')
		begin
	     insert into tblDiem values(@mahs,'MH06','','','','',''),
								   (@mahs,'MH14','','','','',''),
								   (@mahs,'MH22','','','','',''),
								   (@mahs,'MH30','','','','','')
		end
	else if(@malop='LH9A')
		begin
	     insert into tblDiem values(@mahs,'MH07','','','','',''),
								   (@mahs,'MH15','','','','',''),
								   (@mahs,'MH23','','','','',''),
								   (@mahs,'MH31','','','','','')
		end
	else
		begin
	     insert into tblDiem values(@mahs,'MH08','','','','',''),
								   (@mahs,'MH16','','','','',''),
								   (@mahs,'MH24','','','','',''),
								   (@mahs,'MH32','','','','','')
		end
end
go

exec prInsert_HocSinh 'HS03', N'Phạm Thị Lương','20221012','Nữ',N'Nam Định','LH6A'
go


---------------tim kiem Hoc Sinh
create or alter proc prSearch_HocSinh(@mahs varchar(20), @tenhs varchar(50), @diachi varchar(50),
	@malop varchar(20), @gioitinh nvarchar(5), @ngay int, @thang int, @nam int)
	as
	begin
	select sMaHS,sTenHS,sDiaChi,sMalop,sGioiTinh,dNgaysinh
	from tblHocSinh
	where (sMaHS like '%' + @mahs + '%' or @mahs = '')
	and (sTenHS like  N'%' + @tenhs + '%' or @tenhs = '')
	and (sDiaChi like  N'%' + @diachi + '%' or @diachi = '')
	and (sMalop like  N'%' + @malop + '%' or @malop = '')
	and (sGioiTinh like  N'%' + @gioitinh + '%' or @gioitinh = '')
	and Day(dNgaysinh) =
			case 
			WHEN @Ngay =0 THEN  Day(dNgaysinh)
		    ELSE  @Ngay
			end
		and MONTH(dNgaysinh) =
			case
			WHEN @Thang =0 THEN MONTH(dNgaysinh)
		    ELSE @Thang
			end
		and YEAR(dNgaysinh) =
			case
			WHEN @Nam =0 THEN YEAR(dNgaysinh)
		    ELSE @Nam
			end
	and sMaHS not like '%HT%'
	end
go

--------------delete hoc sinh
create or alter proc prDelete_HocSinh(@ma varchar(30))
	as
	begin
	delete tblDiem where sMaHS=@ma
	delete tblHocSinh where sMaHS = @ma
	end
go

-------------update HOCSINh
create or alter proc  prUpdate_HocSinh(@mahs varchar(30),@ten nvarchar(50),@ngaysinh date,@gioitinh nvarchar(5),@diachi nvarchar(50),@malop varchar(20))
as
begin
	update tblHocsinh set sMaHS = @mahs ,sTenHS=@ten ,dNgaysinh=@ngaysinh,sDiaChi=@diachi,sGioiTinh=@gioitinh,sMalop=@malop  where sMaHS=@mahs
end
GO

------------tim du lieu Hoc Sinh
create or alter proc prAdapter_HocSinh(@ma varchar(30))
	as
	begin
	select sMaHS,sTenHS,sDiaChi,sGioiTinh,dNgaysinh, sMalop
	from tblHocSinh
	where sMaHS =@ma
	end
	go

---PROC THÔNG TIN ĐIỂM TOÁN CỦA SINH VIÊN
create or alter proc prInfor_DiemToan
as
begin
	select sTenHS,sTenMonHoc,fDiemCC, fDiemGK, fDiemThi
	from tblDiem join tblHocSinh on tblDiem.sMaHS=tblHocSinh.sMaHS
	join tblMonhoc on tblMonhoc.sMaMonHoc=tblDiem.sMaMonHoc
	join tblNhomMonHoc on tblNhomMonHoc.sMaNhomMon=tblMonhoc.sMaNhomMon
	where sNhomMon=N'Toán'
	end
go

	--- proc điểm môn học dạy 
	create or alter proc prInfor_Diem(@ma nvarchar(30))
as
begin
	select sTenGiaoVien, tblHocSinh.sMaHS,sTenHS,sTenMonHoc,fDiemCC,fDiemGK,fDiemThi
	from tblDiem join tblHocsinh on tblDiem.sMaHS=tblHocsinh.sMaHS
	join tblMonHoc on tblMonHoc.sMaMonHoc=tblDiem.sMaMonHoc
	join tblNhomMonHoc on tblNhomMonHoc.sMaNhomMon=tblMonHoc.sMaNhomMon
	join tblGiaoVien on tblGiaoVien.sMaGV = tblMonHoc.sMaGV
	where  tblMonHoc.sMaGV=@ma
end
go

---------hien thi So Hoc Sinh cua GIAo VIEN
create or alter proc prInfor_HSofGV(@magv varchar(20), @malop varchar(20))
as
begin
	select distinct  sMaHS, sTenHS,tblHocSinh.dNgaySinh, tblHocSinh.sGioiTinh,sDiaChi,tblHocSinh.sMalop
	from tblHocSinh
	join tblLopHoc on tblLopHoc.sMaLop = tblHocSinh.sMalop
	join tblMonHoc on tblMonHoc.sMaLop = tblLopHoc.sMaLop
	where sMaGV = @magv
	and tblHocSinh.sMalop = @malop;
end
go

--------hien thi so lop hoc cua GIAO VIEN
create or alter proc prInfor_LOPofGV(@magv varchar(30))
as
begin
		select tblLophoc.sMaLop,sTenLopHoc,sTenMonHoc,COUNT(sMaHS) as [slsv]
		from tblLophoc join tblHocsinh 
		on tblLophoc.sMaLop=tblHocsinh.sMalop
		join tblMonhoc on tblMonhoc.sMaLop=tblLophoc.sMaLop 
		join tblGiaovien on tblMonhoc.sMaGV=tblGiaovien.sMaGV
		where tblGiaovien.sMaGV=@magv
		group by tblLophoc.sMaLop,sTenLopHoc,sTenMonHoc
end
go

----------- hien thi dshs cua giao vien
create or alter proc prInfor_DSHSofGV(@magv varchar(20))
as
begin
	select distinct sMaHS, sTenHS,tblHocSinh.dNgaySinh, tblHocSinh.sGioiTinh,sDiaChi,tblHocSinh.sMalop
	from tblHocSinh
	join tblLopHoc on tblLopHoc.sMaLop = tblHocSinh.sMalop
	join tblMonHoc on tblMonHoc.sMaLop = tblLopHoc.sMaLop
	where sMaGV = @magv
end
go

	---proc search điểm môn dạy học
create or alter proc prSearch_DiemMonHoc(@magv nvarchar(30),@mahs varchar(30))
	as
	begin
	select tblHocsinh.sMaHS,tblMonhoc.sMaMonHoc,sTenHS,sTenMonHoc,fDiemCC,fDiemGK,fDiemThi,fDiemTBMon
	from tblDiem join tblHocsinh on tblDiem.sMaHS=tblHocsinh.sMaHS 
	join tblMonhoc on tblMonhoc.sMaMonHoc=tblDiem.sMaMonHoc
	join tblNhommonhoc on tblNhommonhoc.sMaNhomMon=tblMonhoc.sMaNhomMon
	where sMaGV=@magv  and @mahs=tblHocsinh.sMaHS 
	end
go

--proc tìm điểm acc Giao Vien
create proc prSearch_DiemAccGiaoVien (@magv varchar(10),@mahs nvarchar(10),@tenhs nvarchar(50))
as
begin
select tblHocsinh.sMaHS,sTenHS,sTenMonHoc,fDiemCC,fDiemGK,fDiemThi,fDiemTBMon
	from tblDiem join tblHocsinh on tblDiem.sMaHS=tblHocsinh.sMaHS
	join tblMonhoc on tblMonhoc.sMaMonHoc=tblDiem.sMaMonHoc
	join tblNhommonhoc on tblNhommonhoc.sMaNhomMon=tblMonhoc.sMaNhomMon
	where sMaGV=@magv
	and tblHocsinh.sMaHS like N''+@mahs+'%'
	and sTenHS like N''+@tenhs+'%'

end
go

---proc update điểm
create or alter proc prUpdate_Diem
	(@ma varchar(30),@mamon varchar(30),
	@diemcc float, @diemgk float,@diemthi float)
	as
	begin
	begin
	begin
	update tblDiem set fDiemCC=@diemcc, fDiemGK=@diemgk, fDiemThi=@diemthi
	where sMaHS=@ma and sMaMonHoc=@mamon;
	end
	update tblDiem set fDiemTBMon=ROUND(((fDiemCC+fDiemGK*2+fDiemThi*3+fDiemThi*3)/10),1)
	end
	update tblDiem set sDanhHieu =N'Giỏi' where fDiemTBMon>=8
	update tblDiem set sDanhHieu=N'Khá' where fDiemTBMon>=6.5 and fDiemTBMon<8
	update tblDiem set sDanhHieu=N'TB' where fDiemTBMon>=5 and fDiemTBMon<6.5
	update tblDiem set sDanhHieu =N'Yếu' where fDiemTBMon<5
	end
go