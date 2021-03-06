USE [master]
GO
/****** Object:  Database [Trachanhbuipho1]    Script Date: 25/12/2020 8:40:09 PM ******/
CREATE DATABASE [Trachanhbuipho1]
GO
ALTER DATABASE [Trachanhbuipho1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Trachanhbuipho1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Trachanhbuipho1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Trachanhbuipho1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Trachanhbuipho1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Trachanhbuipho1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Trachanhbuipho1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET RECOVERY FULL 
GO
ALTER DATABASE [Trachanhbuipho1] SET  MULTI_USER 
GO
ALTER DATABASE [Trachanhbuipho1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Trachanhbuipho1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Trachanhbuipho1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Trachanhbuipho1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Trachanhbuipho1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Trachanhbuipho1', N'ON'
GO
ALTER DATABASE [Trachanhbuipho1] SET QUERY_STORE = OFF
GO
USE [Trachanhbuipho1]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_TienChuaCK]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Fn_TienChuaCK](@idbll int)
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
	--select * from TAIKHOAN
GO
/****** Object:  Table [dbo].[MON]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[Gia] [money] NOT NULL,
	[Danh Muc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[Ten Khach] [nvarchar](50) NULL,
	[Trang Thai] [bit] NOT NULL,
	[Chiet Khau] [float] NOT NULL,
	[Ban] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Hoa Don] [int] NOT NULL,
	[Mon] [int] NOT NULL,
	[So Luong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ThongKe]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Fn_ThongKe](@dau datetime, @cuoi datetime)
returns table
as
	return (select hd.ID, hd.Ngay, hd.[Ten Khach], (sum(cthd.[So Luong] * m.Gia)*(1-hd.[Chiet Khau])) as Tổng_Tiền
	from CHITIETHOADON cthd inner join HOADON hd
	on cthd.[Hoa Don] = hd.ID
	inner join MON m
	on cthd.Mon = m.ID
	where hd.Ngay>=@dau and hd.Ngay<=@cuoi
	group by hd.ID, hd.Ngay, hd.[Ten Khach], hd.[Chiet Khau])

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ho Ten] [nvarchar](50) NOT NULL,
	[SDT] [char](12) NOT NULL,
	[Sinh Nhat] [datetime] NOT NULL,
	[Vi Tri] [nvarchar](50) NOT NULL,
	[Luong/Ngay] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHAMCONG]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHAMCONG](
	[Ngay] [datetime] NOT NULL,
	[ID NV] [int] NOT NULL,
	[Trang Thai] [bit] NOT NULL,
 CONSTRAINT [pk_CHAMCONG] PRIMARY KEY CLUSTERED 
(
	[Ngay] ASC,
	[ID NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ThongKeLuong]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Fn_ThongKeLuong](@dau datetime, @cuoi datetime)
returns table
as
	return (select ck.[ID NV], nv.[Ho Ten], count(ck.Ngay) as So_Ngay_Lam_Viec, nv.[Luong/Ngay]*COUNT(ck.Ngay) as Luong
	from NHANVIEN nv inner join CHAMCONG ck
	on nv.ID = ck.[ID NV]
	where ck.Ngay>=@dau and ck.Ngay<= @cuoi and ck.[Trang Thai]=1
	group by ck.[ID NV], nv.[Ho Ten], nv.[Luong/Ngay])

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Report]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Fn_Report](@idbill int)
returns table
as
	return(select m.Ten, m.Gia, cthd.[So Luong] as So_Luong, m.Gia * cthd.[So Luong] as Thanh_Tien
	from CHITIETHOADON cthd inner join MON m
	on cthd.Mon = m.ID
	where cthd.[Hoa Don] = @idbill)
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten Ban] [nvarchar](20) NOT NULL,
	[Trang Thai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHMUCMON]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCMON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Danh Muc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 25/12/2020 8:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[Username] [char](50) NOT NULL,
	[Password] [char](500) NOT NULL,
	[Admin] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BAN] ON 

INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (1, N'Bàn 1', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (2, N'Bàn 2', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (3, N'Bàn 3', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (4, N'Bàn 4', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (5, N'Bàn 5', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (6, N'Bàn 6', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (7, N'Bàn 7', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (8, N'Bàn 8', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (9, N'Bàn 9', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (10, N'Bàn 10', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (11, N'Bàn 11', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (12, N'Bàn 12', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (13, N'Bàn 13', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (14, N'Bàn 14', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (15, N'Bàn 15', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (16, N'Bàn 16', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (17, N'Bàn 17', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (18, N'Bàn 18', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (19, N'Bàn 19', 0)
INSERT [dbo].[BAN] ([ID], [Ten Ban], [Trang Thai]) VALUES (20, N'Bàn 20', 0)
SET IDENTITY_INSERT [dbo].[BAN] OFF
GO
SET IDENTITY_INSERT [dbo].[DANHMUCMON] ON 

INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (1, N'Truyền thống')
INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (2, N'Hot Bụi phố')
INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (3, N'Trà đào')
INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (4, N'Nước Ép Hoa Quả')
INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (5, N'COFFEE')
INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (6, N'Topping')
INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (7, N'Đồ nóng')
INSERT [dbo].[DANHMUCMON] ([ID], [Danh Muc]) VALUES (8, N'Đồ ăn vặt')
SET IDENTITY_INSERT [dbo].[DANHMUCMON] OFF
GO
SET IDENTITY_INSERT [dbo].[MON] ON 

INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (1, N'Trà chanh Bụi Phố', 10000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (2, N'Trà quất nha đam', 15000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (3, N'Trà quất xí muội', 20000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (4, N'Chanh leo lắc sữa', 25000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (5, N'Sữa dừa nhiệt đới', 25000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (6, N'Chanh đào nhiệt đới', 20000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (7, N'Trà quất lắc sữa', 20000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (8, N'Trà quất lắc bạc hà', 25000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (9, N'Chanh leo bưởi đào', 25000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (10, N'Trà việt quất lắc sữa', 25000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (11, N'Trà ổi hồng', 20000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (12, N'Trà cam quế mật nhiệt đới', 25000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (13, N'Trà vải', 20000.0000, 1)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (14, N'Sữa chua sốt dâu', 25000.0000, 2)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (15, N'Sữa chua sốt xoài', 25000.0000, 2)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (16, N'Sữa chua sốt việt quất', 25000.0000, 2)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (17, N'Sữa tươi sốt xoài', 25000.0000, 2)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (18, N'Sữa tươi sốt việt quất', 25000.0000, 2)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (19, N'Trà đào cam sả', 25000.0000, 3)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (20, N'Trà đào thạch sữa', 25000.0000, 3)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (21, N'Trà đào nhài', 20000.0000, 3)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (22, N'Chanh tươi', 10000.0000, 4)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (23, N'Quất tươi', 10000.0000, 4)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (24, N'Cam tươi', 25000.0000, 4)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (25, N'Nước ép chanh leo', 20000.0000, 4)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (26, N'Nước ép dưa hấu', 20000.0000, 4)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (27, N'Nước ép dứa', 20000.0000, 4)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (28, N'Nha đam', 5000.0000, 6)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (29, N'Trân châu trắng', 5000.0000, 6)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (30, N'Thạch dừa', 5000.0000, 6)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (31, N'Coffee cốt dừa', 25000.0000, 5)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (32, N'Coffee đen đá', 15000.0000, 5)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (33, N'Coffee nâu lắc', 20000.0000, 5)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (34, N'Coffee bạc sỉu', 25000.0000, 5)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (35, N'Cacao nóng', 20000.0000, 7)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (36, N'Cacao Coffee nóng', 25000.0000, 7)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (37, N'Cacao cốt dừa nóng', 25000.0000, 7)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (38, N'Trà cam quế nóng', 25000.0000, 7)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (39, N'Trà đào cam xả nóng', 25000.0000, 7)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (40, N'Cam nóng', 25000.0000, 7)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (41, N'Hướng dương truyền thống', 12000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (42, N'Hướng dương vị óc chó', 12000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (43, N'Heo khô cháy tỏi', 35000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (44, N'Khô gà lá chanh', 35000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (45, N'Bò khô', 30000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (47, N'Phô mai que', 35000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (48, N'Đùi gà KFC', 28000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (49, N'Cánh gà KFC', 28000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (50, N'Gà lắc trân châu', 35000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (51, N'Xúc xích lốc xoáy dài', 15000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (52, N'Xúc xích', 10000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (53, N'Khoai tây lắc', 30000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (54, N'Khoai lang kén', 25000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (55, N'Nem chua rán', 25000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (56, N'Combo mẹt 1', 55000.0000, 8)
INSERT [dbo].[MON] ([ID], [Ten], [Gia], [Danh Muc]) VALUES (58, N'Combo mẹt 2', 85000.0000, 8)
SET IDENTITY_INSERT [dbo].[MON] OFF
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([ID], [Ho Ten], [SDT], [Sinh Nhat], [Vi Tri], [Luong/Ngay]) VALUES (1, N'Nguyễn Viết Lộc', N'0987149416  ', CAST(N'2000-01-29T10:02:23.000' AS DateTime), N'Thu Ngân', 100000.0000)
INSERT [dbo].[NHANVIEN] ([ID], [Ho Ten], [SDT], [Sinh Nhat], [Vi Tri], [Luong/Ngay]) VALUES (2, N'Nguyễn Đức Hưng', N'0983579084  ', CAST(N'2000-09-19T10:02:47.000' AS DateTime), N'Pha Chế', 95000.0000)
INSERT [dbo].[NHANVIEN] ([ID], [Ho Ten], [SDT], [Sinh Nhat], [Vi Tri], [Luong/Ngay]) VALUES (3, N'Bùi Thị Nhung', N'0123456789  ', CAST(N'1999-12-12T10:03:07.000' AS DateTime), N'Phục Vụ', 90000.0000)
INSERT [dbo].[NHANVIEN] ([ID], [Ho Ten], [SDT], [Sinh Nhat], [Vi Tri], [Luong/Ngay]) VALUES (4, N'Bùi Xuân Bách', N'0987654321  ', CAST(N'1998-02-11T10:03:30.000' AS DateTime), N'Bảo Vệ', 90000.0000)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
GO
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Admin], [Active]) VALUES (N'Admin                                             ', N'admin                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ', 1, 1)
INSERT [dbo].[TAIKHOAN] ([Username], [Password], [Admin], [Active]) VALUES (N'loc123                                            ', N'123456                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', 0, 1)
GO
ALTER TABLE [dbo].[BAN] ADD  DEFAULT ((0)) FOR [Trang Thai]
GO
ALTER TABLE [dbo].[CHAMCONG] ADD  DEFAULT ((0)) FOR [Trang Thai]
GO
ALTER TABLE [dbo].[CHITIETHOADON] ADD  DEFAULT ((0)) FOR [So Luong]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT (getdate()) FOR [Ngay]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT ((0)) FOR [Trang Thai]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT ((0)) FOR [Chiet Khau]
GO
ALTER TABLE [dbo].[MON] ADD  DEFAULT ((0)) FOR [Gia]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  DEFAULT (N'Phục vụ') FOR [Vi Tri]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  DEFAULT ((0)) FOR [Luong/Ngay]
GO
ALTER TABLE [dbo].[TAIKHOAN] ADD  DEFAULT ((0)) FOR [Admin]
GO
ALTER TABLE [dbo].[TAIKHOAN] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[CHAMCONG]  WITH CHECK ADD  CONSTRAINT [fk_CHAMCONG] FOREIGN KEY([ID NV])
REFERENCES [dbo].[NHANVIEN] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHAMCONG] CHECK CONSTRAINT [fk_CHAMCONG]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([Hoa Don])
REFERENCES [dbo].[HOADON] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([Mon])
REFERENCES [dbo].[MON] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([Ban])
REFERENCES [dbo].[BAN] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MON]  WITH CHECK ADD FOREIGN KEY([Danh Muc])
REFERENCES [dbo].[DANHMUCMON] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [Trachanhbuipho1] SET  READ_WRITE 
GO
