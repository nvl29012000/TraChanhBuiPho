use master
go
create database Trachanhbuipho1
go

use Trachanhbuipho1
go


create table TAIKHOAN
(
	[Username] char(50) primary key,
	[Password] char(500) not null,
	[Admin] bit not null default 0--1 là admin, 0 là staff
)
go
insert into TAIKHOAN values
('loc2909','vietloc2909',1)

create table NHANVIEN
(
	ID int identity(1,1) primary key,
	[Ho Ten] nvarchar(50) not null,
	SDT char(12) not null,
	[Sinh Nhat] datetime not null,
	[Vi Tri] nvarchar(50) not null default N'Phục vụ' , --order hoặc phục vụ
	[Luong/Ngay] money not null default 0,
)
go

create table CHAMCONG
(
	Ngay datetime,
	[ID NV] int,
	[Trang Thai] bit not null default 0, --1 la co lam, 0 la nghi
	constraint fk_CHAMCONG foreign key([ID NV]) references NHANVIEN(ID) on delete cascade on update cascade,
	constraint pk_CHAMCONG  primary key(Ngay,[ID NV])
)
go

create table BAN
(
	ID int identity(1,1) primary key,
	[Ten Ban] nvarchar(20) not null,
	[Trang Thai] bit not null default 0 --1 la co nguoi, 0 la trong
)
go
create table DANHMUCMON
(	
	ID int identity(1,1) primary key,
	[Danh Muc] nvarchar(50) not null,
)

go
create table MON
(
	ID int identity(1,1) primary key,
	Ten nvarchar(100) not null,
	Gia money not null default 0,
	[Danh Muc] int foreign key references DANHMUCMON(ID) on delete cascade on update cascade,
)
go

create table HOADON
(
	ID int identity(1,1) primary key,
	Ngay datetime not null default getdate(),
	[Ten Khach] nvarchar(50),
	[Trang Thai] bit not null default 0, --0 chua thanh toan, 1 da thanh toan
	[Chiet Khau] float not null default 0,
	Ban int foreign key references BAN(ID) on delete cascade on update cascade
)
go

create table CHITIETHOADON
(
	ID int identity(1,1) primary key,
	[Hoa Don] int not null foreign key references HOADON(ID) on delete cascade on update cascade,
	Mon int not null foreign key references  MON(ID) on delete cascade on update cascade,
	[So Luong] int default 0
)

go
create function Fn_ThongKe(@dau datetime, @cuoi datetime)
returns table
as
	return (select hd.ID, hd.Ngay, hd.[Ten Khach], (sum(cthd.[So Luong] * m.Gia)*(1-hd.[Chiet Khau])) as Tổng_Tiền
	from CHITIETHOADON cthd inner join HOADON hd
	on cthd.[Hoa Don] = hd.ID
	inner join MON m
	on cthd.Mon = m.ID
	where hd.Ngay>=@dau and hd.Ngay<=@cuoi
	group by hd.ID, hd.Ngay, hd.[Ten Khach], hd.[Chiet Khau])

go
create function Fn_ThongKeLuong(@dau datetime, @cuoi datetime)
returns table
as
	return (select ck.[ID NV], nv.[Ho Ten], count(ck.Ngay) as So_Ngay_Lam_Viec, nv.[Luong/Ngay]*COUNT(ck.Ngay) as Luong
	from NHANVIEN nv inner join CHAMCONG ck
	on nv.ID = ck.[ID NV]
	where ck.Ngay>=@dau and ck.Ngay<= @cuoi and ck.[Trang Thai]=1
	group by ck.[ID NV], nv.[Ho Ten], nv.[Luong/Ngay])

go
create function Fn_Report(@idbill int)
returns table
as
	return(select m.Ten, m.Gia, cthd.[So Luong] as So_Luong, m.Gia * cthd.[So Luong] as Thanh_Tien
	from CHITIETHOADON cthd inner join MON m
	on cthd.Mon = m.ID
	where cthd.[Hoa Don] = @idbill)
go
create function Fn_TienChuaCK(@idbll int)
returns float
as
	begin
			declare @tien as float
			set @tien = (select sum(cthd.[So Luong] * m.Gia)*(1-hd.[Chiet Khau]+hd.[Chiet Khau])
						from CHITIETHOADON cthd inner join HOADON hd
						on cthd.[Hoa Don] = hd.ID
						inner join MON m
						on cthd.Mon = m.ID
						where cthd.[Hoa Don] = @idbll
						group by hd.[Chiet Khau])
						return @tien
	end
	--drop function Fn_TienChuaCK
	--use master 
	--drop database Trachanhbuipho1
	--drop function Fn_ThongKe
	--drop function Fn_Report
	--select * from CHAMCONG