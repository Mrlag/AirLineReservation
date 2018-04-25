USE [master]
GO
/****** Object:  Database [AirLineReservation]    Script Date: 2018/4/24 下午 05:43:51 ******/
CREATE DATABASE [AirLineReservation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AirLineReservation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AirLineReservation.mdf' , SIZE = 20480KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AirLineReservation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AirLineReservation_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AirLineReservation] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AirLineReservation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AirLineReservation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AirLineReservation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AirLineReservation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AirLineReservation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AirLineReservation] SET ARITHABORT OFF 
GO
ALTER DATABASE [AirLineReservation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AirLineReservation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AirLineReservation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AirLineReservation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AirLineReservation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AirLineReservation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AirLineReservation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AirLineReservation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AirLineReservation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AirLineReservation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AirLineReservation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AirLineReservation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AirLineReservation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AirLineReservation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AirLineReservation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AirLineReservation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AirLineReservation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AirLineReservation] SET RECOVERY FULL 
GO
ALTER DATABASE [AirLineReservation] SET  MULTI_USER 
GO
ALTER DATABASE [AirLineReservation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AirLineReservation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AirLineReservation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AirLineReservation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AirLineReservation] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AirLineReservation', N'ON'
GO
--ALTER DATABASE [AirLineReservation] SET QUERY_STORE = OFF
--GO
USE [AirLineReservation]
GO
--ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
--GO
USE [AirLineReservation]
GO
/****** Object:  Table [dbo].[AirLine]    Script Date: 2018/4/24 下午 05:43:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AirLine](
	[AirLineID] [int] IDENTITY(1,1) NOT NULL,
	[AirLineName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AirLineName] PRIMARY KEY CLUSTERED 
(
	[AirLineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](20) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_CountyName] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coupon]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coupon](
	[CouponID] [int] IDENTITY(1,1) NOT NULL,
	[CouponCode] [varchar](10) NOT NULL,
	[AirLineID] [int] NULL,
	[UniformNo] [int] NULL,
	[Stock] [int] NOT NULL,
	[Discount] [float] NULL,
	[Description] [nvarchar](100) NULL,
	[CouponStartDate] [date] NOT NULL,
	[CouponEndDate] [date] NOT NULL,
 CONSTRAINT [PK_Coupon] PRIMARY KEY CLUSTERED 
(
	[CouponID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberAccount]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberAccount](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[MemberEmail] [varchar](50) NOT NULL,
	[MemberPassword] [varchar](20) NOT NULL,
	[MemberPoint] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberFeedback]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberFeedback](
	[MemberFeedbackID] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[MemberRating] [int] NOT NULL,
	[Comment] [nvarchar](100) NOT NULL,
	[CommentDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberFeedbackID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Newsletter]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Newsletter](
	[NewsletterID] [int] IDENTITY(1,1) NOT NULL,
	[MailDetail] [varchar](max) NOT NULL,
	[MailDate] [date] NOT NULL,
 CONSTRAINT [PK_Newsletter] PRIMARY KEY CLUSTERED 
(
	[NewsletterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[AirLineID] [int] NOT NULL,
	[UniformNo] [int] NULL,
	[DeparturePlace] [int] NOT NULL,
	[ArrivalPlace] [int] NOT NULL,
	[TravalClassID] [int] NOT NULL,
	[MemberID] [int] NULL,
	[DepartureDate] [date] NOT NULL,
	[DepartureTime] [time](7) NOT NULL,
	[ArrivalDate] [date] NOT NULL,
	[ArrivalTime] [time](7) NOT NULL,
	[CouponID] [int] NULL,
	[FlightRoute] [int] NULL,
	[OrderStatusID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[PaymentMethodID] [int] NOT NULL,
	[AdultCount] [int] NOT NULL,
	[AdultPrice] [money] NOT NULL,
	[ChildCount] [int] NOT NULL,
	[ChildPrice] [money] NOT NULL,
	[ServiceFee] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[PassengerID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[OrderStatusID] [int] IDENTITY(1,1) NOT NULL,
	[OrderStatusName] [nvarchar](10) NULL,
 CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED 
(
	[OrderStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[PassengerID] [int] NOT NULL,
	[PassportNo] [varchar](10) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[ContactNumber] [varchar](12) NOT NULL,
	[PassengerEmail] [varchar](50) NOT NULL,
	[BornDate] [date] NOT NULL,
	[PassportExpiredDate] [date] NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Passenger] PRIMARY KEY CLUSTERED 
(
	[PassengerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[PaymentMethodID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentMethod] [nvarchar](50) NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[PaymentMethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ProductCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryName] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxFreeProduct]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxFreeProduct](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
	[AirLineID] [int] NOT NULL,
	[ProductName] [varchar](max) NOT NULL,
	[ProductPrice] [money] NOT NULL,
	[ProductInStock] [int] NOT NULL,
	[ProductDescription] [varchar](max) NULL,
	[ProductPhoto] [varchar](max) NULL,
	[ProductPoint] [int] NOT NULL,
	[ProductPhotoBinary] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxFreeProductOrder]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxFreeProductOrder](
	[TaxFreeProductOrderID] [int] IDENTITY(1,1) NOT NULL,
	[CouponID] [int] NULL,
	[PaymentMethodID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[PassengerID] [int] NOT NULL,
 CONSTRAINT [PK__TaxFreeP__AE1B1B348870C346] PRIMARY KEY CLUSTERED 
(
	[TaxFreeProductOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxFreeProductOrderDetail]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxFreeProductOrderDetail](
	[TaxFreeProductOrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[TaxFreeProductOrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TaxFreeProductOrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TravelAgency]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TravelAgency](
	[UniformNo] [int] NOT NULL,
	[TravelAgencyName] [nvarchar](50) NOT NULL,
	[TravelAgencyEmail] [varchar](50) NOT NULL,
	[TravelAgencyPassword] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TravelAgency] PRIMARY KEY CLUSTERED 
(
	[UniformNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TravelClass]    Script Date: 2018/4/24 下午 05:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TravelClass](
	[TravalClassID] [int] IDENTITY(1,1) NOT NULL,
	[TravalClassName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TravalClass] PRIMARY KEY CLUSTERED 
(
	[TravalClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AirLine] ON 

INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (1, N'Tigerair Taiwan')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (2, N'Far Eastern Air Transport')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (3, N'EVA AIR')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (4, N'Cathay Pacific Airways')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (5, N'Air Macau')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (6, N'All Nippon Airways')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (7, N'Vanilla Air')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (8, N'Hong Kong Airways')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (9, N'United Airlines')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (10, N'Air Canada')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (11, N'Korean Air Lines')
INSERT [dbo].[AirLine] ([AirLineID], [AirLineName]) VALUES (12, N'Asiana Airlines')
SET IDENTITY_INSERT [dbo].[AirLine] OFF
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (1, N'台北(松山機場)', 1)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (2, N'桃園(桃園機場)', 1)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (3, N'台中(清泉崗機場)', 1)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (4, N'東京(羽田機場)', 2)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (5, N'千葉縣(成田機場)', 2)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (6, N'愛知縣(中部機場)', 2)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (7, N'兵庫縣(伊丹機場)', 2)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (8, N'大阪府(關西機場)', 2)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (9, N'福岡縣(福岡機場)', 2)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (10, N'洛杉磯(洛杉磯國際機場)', 3)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (11, N'夏威夷(希洛國際機場)', 3)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (12, N'紐約(約翰·甘迺迪國際機場)', 3)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (13, N'舊金山(舊金山國際機場)', 3)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (14, N'西雅圖(塔科馬國際機場)', 3)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (15, N'北京市(北京首都國際機場)', 4)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (16, N'上海市(上海虹橋國際機場)', 4)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (17, N'重慶市(重慶江北國際機場)', 4)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (18, N'天津市(天津濱海國際機場)', 4)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (19, N'廣州市(廣州白雲國際機場)', 4)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (20, N'清邁(清邁國際機場)', 5)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (21, N'曼谷(蘇凡納布國際機場)', 5)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (22, N'普吉(普吉國際機場)', 5)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (23, N'烏隆他尼(烏隆他尼國際機場)', 5)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (24, N'合艾(合艾國際機場)', 5)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (25, N'仁川廣域市(仁川國際機場)', 6)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (26, N'釜山廣域市(金海國際機場)', 6)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (27, N'大邱廣域市(大邱國際機場)', 6)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (28, N'首爾特別市(金浦國際機場)', 6)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (29, N'濟州(濟州國際機場)', 6)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (30, N'倫敦(希斯洛機場)', 7)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (31, N'大多倫多地區(多倫多皮爾遜國際機場)', 8)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (32, N'溫哥華市(溫哥華國際機場)', 8)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (33, N'亞伯達卡加利(卡加利國際機場)', 8)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (34, N'魁北克蒙特婁(特魯多國際機場)', 8)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (35, N'亞伯達艾德蒙頓(艾德蒙頓國際機場)', 8)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (36, N'新加坡(樟宜機場)', 9)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (37, N'巴黎(戴高樂機場)', 10)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (38, N'尼斯(尼斯藍色海岸機場)', 10)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (39, N'里昂(里昂聖埃克絮佩里機場)', 10)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (40, N'馬賽(馬賽普羅旺斯機場)', 10)
INSERT [dbo].[City] ([CityID], [CityName], [CountryID]) VALUES (41, N'土魯斯(布拉尼亞克機場)', 10)
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (1, N'台灣')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (2, N'日本')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (3, N'美國')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (4, N'大陸')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (5, N'泰國')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (6, N'南韓')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (7, N'英國')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (8, N'加拿大')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (9, N'新加坡')
INSERT [dbo].[Country] ([CountryID], [CountryName]) VALUES (10, N'法國')
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Coupon] ON 

INSERT [dbo].[Coupon] ([CouponID], [CouponCode], [AirLineID], [UniformNo], [Stock], [Discount], [Description], [CouponStartDate], [CouponEndDate]) VALUES (2, N'1357924680', 1, 32097801, 10, 0.7, N'活動期間持優惠券打七折', CAST(N'2019-02-01' AS Date), CAST(N'2019-02-27' AS Date))
SET IDENTITY_INSERT [dbo].[Coupon] OFF
SET IDENTITY_INSERT [dbo].[MemberAccount] ON 

INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (1, N'msit118sabre@gmail.com', N'iii15f', 118)
INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (2, N'ChesterCMartin@armyspy.com', N'ps428462785', 200)
INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (3, N'SamuelADobbins@rhyta.com', N'ps619532789', 300)
INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (4, N'JuanWang@rhyta.com', N'ps134684627', 400)
INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (5, N'TingChin@jourrapide.com', N'ps172851965', 500)
INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (6, N'LiMeiTeng@dayrep.com', N'ps032548621', 600)
INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (7, N'HoHou@teleworm.us', N'ps398057150', 700)
INSERT [dbo].[MemberAccount] ([MemberID], [MemberEmail], [MemberPassword], [MemberPoint]) VALUES (8, N'ZhenJuanTsao@armyspy.com', N'ps908730680', 800)
SET IDENTITY_INSERT [dbo].[MemberAccount] OFF
SET IDENTITY_INSERT [dbo].[MemberFeedback] ON 

INSERT [dbo].[MemberFeedback] ([MemberFeedbackID], [MemberID], [OrderID], [MemberRating], [Comment], [CommentDate]) VALUES (1, 1, 2, 5, N'艙內空間寬廣舒適', CAST(N'2019-01-02' AS Date))
INSERT [dbo].[MemberFeedback] ([MemberFeedbackID], [MemberID], [OrderID], [MemberRating], [Comment], [CommentDate]) VALUES (2, 2, 2, 4, N'機上服務真的是沒話說，但一段長程加一不算短的航程我覺得坐起來相對比較累', CAST(N'2019-01-02' AS Date))
INSERT [dbo].[MemberFeedback] ([MemberFeedbackID], [MemberID], [OrderID], [MemberRating], [Comment], [CommentDate]) VALUES (3, 3, 2, 3, N'自己覺得還不錯，空服員不像一些xx航空公司皮笑肉不笑，照規定來態度都挺好的', CAST(N'2019-01-02' AS Date))
SET IDENTITY_INSERT [dbo].[MemberFeedback] OFF
SET IDENTITY_INSERT [dbo].[Newsletter] ON 

INSERT [dbo].[Newsletter] ([NewsletterID], [MailDetail], [MailDate]) VALUES (1, N'信件內容', CAST(N'2018-04-16' AS Date))
INSERT [dbo].[Newsletter] ([NewsletterID], [MailDetail], [MailDate]) VALUES (2, N'信件內容1', CAST(N'2018-04-10' AS Date))
INSERT [dbo].[Newsletter] ([NewsletterID], [MailDetail], [MailDate]) VALUES (3, N'信件內容1', CAST(N'2018-04-11' AS Date))
SET IDENTITY_INSERT [dbo].[Newsletter] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [AirLineID], [UniformNo], [DeparturePlace], [ArrivalPlace], [TravalClassID], [MemberID], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivalTime], [CouponID], [FlightRoute], [OrderStatusID], [OrderDate], [PaymentMethodID], [AdultCount], [AdultPrice], [ChildCount], [ChildPrice], [ServiceFee]) VALUES (2, 8, 32097801, 5, 30, 1, NULL, CAST(N'2018-10-09' AS Date), CAST(N'00:08:09' AS Time), CAST(N'2018-10-10' AS Date), CAST(N'00:08:12' AS Time), NULL, 1, 1, CAST(N'1900-07-21T00:00:00.000' AS DateTime), 1, 2, 5000.0000, 2, 3000.0000, 140.0000)
INSERT [dbo].[Order] ([OrderID], [AirLineID], [UniformNo], [DeparturePlace], [ArrivalPlace], [TravalClassID], [MemberID], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivalTime], [CouponID], [FlightRoute], [OrderStatusID], [OrderDate], [PaymentMethodID], [AdultCount], [AdultPrice], [ChildCount], [ChildPrice], [ServiceFee]) VALUES (4, 11, 70692302, 1, 15, 2, NULL, CAST(N'2018-11-12' AS Date), CAST(N'00:12:15' AS Time), CAST(N'2018-11-13' AS Date), CAST(N'00:02:01' AS Time), NULL, 2, 2, CAST(N'1900-04-02T00:00:00.000' AS DateTime), 2, 6, 18000.0000, 0, 0.0000, 260.0000)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (1, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (2, 2, 2)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (3, 2, 3)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (4, 2, 4)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (5, 2, 5)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (6, 4, 6)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (7, 4, 7)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (8, 4, 8)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (9, 4, 9)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [PassengerID]) VALUES (10, 4, 10)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[OrderStatus] ON 

INSERT [dbo].[OrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (1, N'已出票')
INSERT [dbo].[OrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (2, N'已取票')
INSERT [dbo].[OrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (3, N'已退票')
SET IDENTITY_INSERT [dbo].[OrderStatus] OFF
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (1, N'678413597', N'YANG', N'YA-YUN', N'F', N'0919119180', N'ShenShih@dayrep.com', CAST(N'1988-11-25' AS Date), CAST(N'2018-12-13' AS Date), 1)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (2, N'428462785', N'WU', N'NING-LYU', N'M', N'0911475612', N'ChesterCMartin@armyspy.com', CAST(N'1977-10-01' AS Date), CAST(N'2022-01-02' AS Date), 1)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (3, N'619532789', N'LI', N'PEI-SYUE', N'F', N'0921645387', N'SamuelADobbins@rhyta.com', CAST(N'1967-02-04' AS Date), CAST(N'2050-12-07' AS Date), 3)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (4, N'134684627', N'CAI', N'SYUAN-YONG', N'M', N'0978462851', N'JuanWang@rhyta.com', CAST(N'1955-03-07' AS Date), CAST(N'2050-06-07' AS Date), 2)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (5, N'134684627', N'CAI', N'SYUAN-YONG', N'M', N'0978462851', N'JuanWang@rhyta.com', CAST(N'1955-03-07' AS Date), CAST(N'2050-06-07' AS Date), 2)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (6, N'172851965', N'GAO', N'SHAN-HUEI', N'M', N'0900216523', N'TingChin@jourrapide.com', CAST(N'1975-06-21' AS Date), CAST(N'2050-07-26' AS Date), 1)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (7, N'032548621', N'LAI', N'JIA-YING', N'F', N'0955487632', N'LiMeiTeng@dayrep.com', CAST(N'1945-12-01' AS Date), CAST(N'2050-11-13' AS Date), 5)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (8, N'103509750', N'HUANG', N'JIA-SHU', N'F', N'0934687150', N'GuoYuan@jourrapide.com', CAST(N'1985-02-21' AS Date), CAST(N'2050-08-12' AS Date), 6)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (9, N'398057150', N'WANG', N'SHOU-DING', N'M', N'09784652300', N'HoHou@teleworm.us', CAST(N'1975-10-10' AS Date), CAST(N'2050-03-01' AS Date), 4)
INSERT [dbo].[Passenger] ([PassengerID], [PassportNo], [FirstName], [LastName], [Gender], [ContactNumber], [PassengerEmail], [BornDate], [PassportExpiredDate], [CountryID]) VALUES (10, N'908730680', N'SYU', N'YA-WUN', N'F', N'0933658705', N'ZhenJuanTsao@armyspy.com', CAST(N'1975-05-06' AS Date), CAST(N'2050-01-29' AS Date), 3)
SET IDENTITY_INSERT [dbo].[PaymentMethod] ON 

INSERT [dbo].[PaymentMethod] ([PaymentMethodID], [PaymentMethod]) VALUES (1, N'VISA')
INSERT [dbo].[PaymentMethod] ([PaymentMethodID], [PaymentMethod]) VALUES (2, N'MasterCard')
INSERT [dbo].[PaymentMethod] ([PaymentMethodID], [PaymentMethod]) VALUES (3, N'JCB')
INSERT [dbo].[PaymentMethod] ([PaymentMethodID], [PaymentMethod]) VALUES (4, N'American Express')
SET IDENTITY_INSERT [dbo].[PaymentMethod] OFF
SET IDENTITY_INSERT [dbo].[ProductCategory] ON 

INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (1, N'Jewelry')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (2, N'Beauty')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (3, N'Accessory')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (4, N'Liquor')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (5, N'Gourmet')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (6, N'Gift&Kids')
SET IDENTITY_INSERT [dbo].[ProductCategory] OFF
SET IDENTITY_INSERT [dbo].[TaxFreeProduct] ON 

INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (1, 3, 1, N'WAVE MONOSPALLA MINI 手提包', 49800.0000, 10, N'尺寸 22X29X12(CM)  材質 GRAIN CALF  顏色 LILAC', N'https://img.everrich.com/img/p/4/4/5/3/3/44533-large_retina.jpg', 2000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (2, 3, 2, N'DOUBLE T BISACCIA 肩背包', 46200.0000, 7, N'尺寸 20X22X8.5(CM) 材質 SMOOTH CALF 顏色 FLAN', N'https://img.everrich.com/img/p/4/4/5/4/6/44546-large_retina.jpg', 2000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (3, 3, 1, N'DOUBLE T PICCOLA SATCHEL 手提包', 61000.0000, 2, N'尺寸 22X27X14.5(CM) 材質 FLORIDA GRAIN 顏色 WHTIE', N'https://img.everrich.com/img/p/4/4/5/3/3/44533-large_retina.jpg', 4000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (4, 3, 1, N'XS MSGR BACKPACK 後背包', 12150.0000, 4, N'尺寸 17X20X10(CM) 材質 100% COW LEATHER 顏色 ADMIRAL/OPWT', N'https://img.everrich.com/img/p/4/5/3/1/2/45312-large_retina.jpg', 1000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (5, 3, 5, N'LG DOME CROSSBODY 小皮件', 8200.0000, 5, N'尺寸 25X18X8(CM) 材質 100% COW LEATHER 顏色 ULTRA PINK', N'https://img.everrich.com/img/p/4/5/4/3/7/45437-large_retina.jpg', 1000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (6, 3, 4, N'MICHAEL KORS SATCHEL MICHAEL KORS 側肩包', 14600.0000, 7, N'尺寸 28.5*20*10.5(ML) 材質 SAFFIANO LEATHER 顏色 深藍色', N'https://img.everrich.com/img/p/3/2/2/7/1/32271-large_default.jpg', 1000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (7, 3, 4, N'MICHAEL KORS CROSSBODY MICHAEL KORS 小皮件', 7300.0000, 3, N'尺寸 23*19*10(ML) 材質 LEATHER 顏色 紫色', N'https://img.everrich.com/img/p/3/2/1/1/5/32115-large_retina.jpg', 1000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (8, 3, 5, N'WALLET ON A CHAIN 小皮件', 8200.0000, 3, N'尺寸 20X12X4(CM) 材質 100% COW LEATHER 顏色 PALE BLUE', N'https://img.everrich.com/img/p/4/5/4/4/4/45444-large_retina.jpg', 1000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (9, 3, 3, N'LG CONV TOTE 肩背包', 14600.0000, 10, N'尺寸 31.75X25.4X14.605+15.24+44.45(CM) 材質 100% COW LEATHER 顏色 BTRD/SPK/UPK', N'https://img.everrich.com/img/p/4/5/2/4/6/45246-large_retina.jpg', 1000, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (10, 5, 3, N'ASSORTED PRALINES ?合巧克力禮盒', 800.0000, 26, N' 1盒*14入', N'https://img.everrich.com/img/p/2/2/9/2/0/22920-large_default.jpg', 100, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (11, 5, 3, N'RAFFAELLO COFFRET T20 義大利雪莎椰子甜點', 420.0000, 18, N'1盒*20入', N'https://img.everrich.com/img/p/7/9/0/1/7901-large_default.jpg', 100, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (12, 5, 2, N'GOLDEN GALLERY T22 綜合巧克力', 480.0000, 17, N'1盒*22入', N'https://img.everrich.com/img/p/4/4/5/1/4/44514-large_default.jpg', 100, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (13, 5, 5, N'LOTTE ALMOND PEPERO BIG PACK Pepero杏仁碎巧克力棒', 250.0000, 22, N' 1盒*32G / 共8盒', N'https://img.everrich.com/img/p/1/2/7/7/9/12779-large_default.jpg', 100, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (14, 5, 4, N'ASSORTED NAPOLITAINS ?合巧克力薄片', 890.0000, 22, N'1盒*500G', N'https://img.everrich.com/img/p/1/2/5/8/7/12587-large_default.jpg', 100, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (15, 5, 2, N'LINDOR BALL TUBE DARK 60% 黑巧克力球', 780.0000, 11, N'1盒*32入', N'https://img.everrich.com/img/p/1/2/5/8/9/12589-large_default.jpg', 100, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (16, 5, 2, N'LINDOR TUBE 綜合巧克力球', 780.0000, 9, N'1盒*32入', N'https://img.everrich.com/img/p/1/2/5/8/8/12588-large_default.jpg', 100, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (17, 5, 2, N'CARRE FULL RANGE 片裝黑巧克力禮盒', 2270.0000, 19, N'1盒*60入', N'https://img.everrich.com/img/p/4/1/8/4/0/41840-large_default.jpg', 500, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (18, 5, 4, N'CARRE MILK 片裝牛奶巧克力禮盒', 1380.0000, 10, N'1盒*36入', N'https://img.everrich.com/img/p/4/1/8/3/8/41838-large_default.jpg', 300, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (19, 5, 1, N'CARRE DARK 72% 片裝72%黑巧克力禮盒', 1380.0000, 10, N'1盒*36入', N'https://img.everrich.com/img/p/4/1/8/3/9/41839-large_default.jpg', 300, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (20, 4, 1, N'麥卡倫威士忌Boutique Collection II', 6200.0000, 7, N'產地 蘇格蘭 容量 700(ML) 規格 單瓶 台灣獨賣限量酒款，2017限定版，包裝以優雅的麥卡倫精神莊園插畫呈現，口感滑順飽滿，象徵麥卡倫單一麥芽威士忌傳承世紀的經典之作。', N'https://img.everrich.com/img/p/4/2/7/9/4/42794-large_default.jpg', 900, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (21, 4, 1, N'INGVAR CASK STRENGTH SPECIAL EDITION 神槍單一麥芽蘇格蘭威士忌', 3600.0000, 5, N'產地 蘇格蘭 容量 700 (L) 前所未有的高原騎士原酒。僅限量18000瓶，推出即備受好評。 精選自陳年的美國白橡木雪莉桶，以接近40%的新桶原酒勾兌，呈現10YO~15YO的原酒工藝。帶有濃郁果香、香料、煙燻木頭、乾燥果皮和香甜糖漿的香氣，入口後表現出煙燻、香草與豐富的柑橘風味，口感厚實長久。', N'https://img.everrich.com/img/p/1/7/5/1/8/17518-large_default.jpg', 900, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (22, 4, 5, N'AULTMORE 21YO SINGLE MALT WHISKY 雅墨21年單ㄧ純麥威士忌', 5470.0000, 10, N'產地 蘇格蘭 容量 700(ML) 規格 單瓶 年份 21 香氣如同夏夜黃昏，空氣中帶有水果、橄欖油和迷迭香的芬芳，口感如天鵝絨般順滑甜美，帶有一絲蜜瓜和穀物的口感，餘韻悠長清澈。', N'https://img.everrich.com/img/p/1/4/9/4/7/14947-large_default.jpg', 900, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (23, 6, 4, N'NINTENDO SWITCH 任天堂Switch-超級瑪利歐奧德賽同捆組', 11670.0000, 12, N'可攜式的電視遊戲機 三種遊戲模式：TV模式、桌上模式、手提模式 一次連線8台主機，進行對戰或協力遊戲 同捆內容物 台灣公司貨一年保固', N'https://img.everrich.com/img/p/4/4/6/7/8/44678-large_default.jpg', 1500, NULL)
INSERT [dbo].[TaxFreeProduct] ([ProductID], [ProductCategoryID], [AirLineID], [ProductName], [ProductPrice], [ProductInStock], [ProductDescription], [ProductPhoto], [ProductPoint], [ProductPhotoBinary]) VALUES (24, 6, 5, N'EOS M100 KIT EF-M15-45 《送SD 64G高速記憶卡+原廠電池》EOS M100 15-45單眼數位相機', 17000.0000, 12, N'1. 迷你單眼/時尚簡約風格 2. 強化自動追焦技術 3. 準ISO範圍至ISO 25600 4. 最高每秒6.1張高速連拍 5. 180度上掀式螢幕自拍 6. 支援Wi-Fi/NFC/藍牙', N'https://img.everrich.com/img/p/4/2/8/6/8/42868-large_default.jpg', 1500, NULL)
SET IDENTITY_INSERT [dbo].[TaxFreeProduct] OFF
SET IDENTITY_INSERT [dbo].[TaxFreeProductOrder] ON 

INSERT [dbo].[TaxFreeProductOrder] ([TaxFreeProductOrderID], [CouponID], [PaymentMethodID], [OrderDate], [PassengerID]) VALUES (9, 2, 1, CAST(N'2018-01-04T00:00:00.000' AS DateTime), 9)
SET IDENTITY_INSERT [dbo].[TaxFreeProductOrder] OFF
SET IDENTITY_INSERT [dbo].[TaxFreeProductOrderDetail] ON 

INSERT [dbo].[TaxFreeProductOrderDetail] ([TaxFreeProductOrderDetailID], [TaxFreeProductOrderID], [ProductID], [Quantity]) VALUES (1, 9, 1, 10)
INSERT [dbo].[TaxFreeProductOrderDetail] ([TaxFreeProductOrderDetailID], [TaxFreeProductOrderID], [ProductID], [Quantity]) VALUES (2, 9, 2, 20)
INSERT [dbo].[TaxFreeProductOrderDetail] ([TaxFreeProductOrderDetailID], [TaxFreeProductOrderID], [ProductID], [Quantity]) VALUES (3, 9, 3, 30)
INSERT [dbo].[TaxFreeProductOrderDetail] ([TaxFreeProductOrderDetailID], [TaxFreeProductOrderID], [ProductID], [Quantity]) VALUES (4, 9, 4, 40)
SET IDENTITY_INSERT [dbo].[TaxFreeProductOrderDetail] OFF
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (20387057, N'古爾丹旅行社', N'merandarichardsonfmw@teleosaurs.xyz', N'F4edyFSrQ4Wxdc2')
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (32097801, N'芭娜娜旅行社', N'annetteewingmFx@teleosaurs.xyz', N'Dabk9drUVsntcC4')
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (46781304, N'蓮霧旅行社', N'kaleighpitts2Xy@teleosaurs.xyz', N'AYs2WuNCgRGcKP6')
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (47605815, N'瓦甘達旅行社', N'kentmarshY6Z@teleosaurs.xyz', N'GSGABY2TXSyGKME')
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (54781620, N'國華旅行社', N'camronlangDgm@teleosaurs.xyz', N'Y854tgdTZZxkezQ')
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (70692302, N'普羅旺斯旅行社', N'salvadorgallagherxrW@teleosaurs.xyz', N'w6h2Tneua3HSJAN')
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (96378160, N'賽德克旅行社', N'natashastokesQTn@teleosaurs.xyz', N'5SbSAqV3Ch4h8Jb')
INSERT [dbo].[TravelAgency] ([UniformNo], [TravelAgencyName], [TravelAgencyEmail], [TravelAgencyPassword]) VALUES (97380348, N'海獅旅行社', N'charitycamposJwP@teleosaurs.xyz', N'sHCYmKqMMRZvEHu')
SET IDENTITY_INSERT [dbo].[TravelClass] ON 

INSERT [dbo].[TravelClass] ([TravalClassID], [TravalClassName]) VALUES (1, N'商務艙')
INSERT [dbo].[TravelClass] ([TravalClassID], [TravalClassName]) VALUES (2, N'頭等艙')
INSERT [dbo].[TravelClass] ([TravalClassID], [TravalClassName]) VALUES (3, N'經濟艙')
SET IDENTITY_INSERT [dbo].[TravelClass] OFF
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country1] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([CountryID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Country1]
GO
ALTER TABLE [dbo].[Coupon]  WITH CHECK ADD  CONSTRAINT [FK_Coupon_AirLine] FOREIGN KEY([AirLineID])
REFERENCES [dbo].[AirLine] ([AirLineID])
GO
ALTER TABLE [dbo].[Coupon] CHECK CONSTRAINT [FK_Coupon_AirLine]
GO
ALTER TABLE [dbo].[Coupon]  WITH CHECK ADD  CONSTRAINT [FK_Coupon_TravelAgency] FOREIGN KEY([UniformNo])
REFERENCES [dbo].[TravelAgency] ([UniformNo])
GO
ALTER TABLE [dbo].[Coupon] CHECK CONSTRAINT [FK_Coupon_TravelAgency]
GO
ALTER TABLE [dbo].[Coupon]  WITH CHECK ADD  CONSTRAINT [FK_Coupon_TravelAgency1] FOREIGN KEY([UniformNo])
REFERENCES [dbo].[TravelAgency] ([UniformNo])
GO
ALTER TABLE [dbo].[Coupon] CHECK CONSTRAINT [FK_Coupon_TravelAgency1]
GO
ALTER TABLE [dbo].[MemberAccount]  WITH CHECK ADD  CONSTRAINT [FK_MemberAccount_Passenger] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Passenger] ([PassengerID])
GO
ALTER TABLE [dbo].[MemberAccount] CHECK CONSTRAINT [FK_MemberAccount_Passenger]
GO
ALTER TABLE [dbo].[MemberFeedback]  WITH CHECK ADD  CONSTRAINT [FK_MemberFeedback_MemberAccount] FOREIGN KEY([MemberID])
REFERENCES [dbo].[MemberAccount] ([MemberID])
GO
ALTER TABLE [dbo].[MemberFeedback] CHECK CONSTRAINT [FK_MemberFeedback_MemberAccount]
GO
ALTER TABLE [dbo].[MemberFeedback]  WITH CHECK ADD  CONSTRAINT [FK_MemberFeedback_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[MemberFeedback] CHECK CONSTRAINT [FK_MemberFeedback_Order]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_AirLine] FOREIGN KEY([AirLineID])
REFERENCES [dbo].[AirLine] ([AirLineID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_AirLine]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_City] FOREIGN KEY([DeparturePlace])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_City]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_City1] FOREIGN KEY([ArrivalPlace])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_City1]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Coupon] FOREIGN KEY([CouponID])
REFERENCES [dbo].[Coupon] ([CouponID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Coupon]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_MemberAccount] FOREIGN KEY([MemberID])
REFERENCES [dbo].[MemberAccount] ([MemberID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_MemberAccount]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_OrderStatus] FOREIGN KEY([OrderStatusID])
REFERENCES [dbo].[OrderStatus] ([OrderStatusID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_OrderStatus]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_PaymentMethod] FOREIGN KEY([PaymentMethodID])
REFERENCES [dbo].[PaymentMethod] ([PaymentMethodID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_PaymentMethod]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_TravelAgency] FOREIGN KEY([UniformNo])
REFERENCES [dbo].[TravelAgency] ([UniformNo])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_TravelAgency]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_TravelClass] FOREIGN KEY([TravalClassID])
REFERENCES [dbo].[TravelClass] ([TravalClassID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_TravelClass]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Passenger] FOREIGN KEY([PassengerID])
REFERENCES [dbo].[Passenger] ([PassengerID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Passenger]
GO
ALTER TABLE [dbo].[Passenger]  WITH CHECK ADD  CONSTRAINT [FK_Passenger_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([CountryID])
GO
ALTER TABLE [dbo].[Passenger] CHECK CONSTRAINT [FK_Passenger_Country]
GO
ALTER TABLE [dbo].[TaxFreeProduct]  WITH CHECK ADD  CONSTRAINT [FK_TaxFreeProduct_AirLine] FOREIGN KEY([AirLineID])
REFERENCES [dbo].[AirLine] ([AirLineID])
GO
ALTER TABLE [dbo].[TaxFreeProduct] CHECK CONSTRAINT [FK_TaxFreeProduct_AirLine]
GO
ALTER TABLE [dbo].[TaxFreeProduct]  WITH CHECK ADD  CONSTRAINT [FK_TaxFreeProduct_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategory] ([ProductCategoryID])
GO
ALTER TABLE [dbo].[TaxFreeProduct] CHECK CONSTRAINT [FK_TaxFreeProduct_ProductCategory]
GO
ALTER TABLE [dbo].[TaxFreeProductOrder]  WITH CHECK ADD  CONSTRAINT [FK_TaxFreeProductOrder_Coupon] FOREIGN KEY([CouponID])
REFERENCES [dbo].[Coupon] ([CouponID])
GO
ALTER TABLE [dbo].[TaxFreeProductOrder] CHECK CONSTRAINT [FK_TaxFreeProductOrder_Coupon]
GO
ALTER TABLE [dbo].[TaxFreeProductOrder]  WITH CHECK ADD  CONSTRAINT [FK_TaxFreeProductOrder_Passenger] FOREIGN KEY([PassengerID])
REFERENCES [dbo].[Passenger] ([PassengerID])
GO
ALTER TABLE [dbo].[TaxFreeProductOrder] CHECK CONSTRAINT [FK_TaxFreeProductOrder_Passenger]
GO
ALTER TABLE [dbo].[TaxFreeProductOrder]  WITH CHECK ADD  CONSTRAINT [FK_TaxFreeProductOrder_PaymentMethod] FOREIGN KEY([PaymentMethodID])
REFERENCES [dbo].[PaymentMethod] ([PaymentMethodID])
GO
ALTER TABLE [dbo].[TaxFreeProductOrder] CHECK CONSTRAINT [FK_TaxFreeProductOrder_PaymentMethod]
GO
ALTER TABLE [dbo].[TaxFreeProductOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_TaxFreeProductOrderDetail_TaxFreeProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[TaxFreeProduct] ([ProductID])
GO
ALTER TABLE [dbo].[TaxFreeProductOrderDetail] CHECK CONSTRAINT [FK_TaxFreeProductOrderDetail_TaxFreeProduct]
GO
ALTER TABLE [dbo].[TaxFreeProductOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_TaxFreeProductOrderDetail_TaxFreeProductOrder] FOREIGN KEY([TaxFreeProductOrderID])
REFERENCES [dbo].[TaxFreeProductOrder] ([TaxFreeProductOrderID])
GO
ALTER TABLE [dbo].[TaxFreeProductOrderDetail] CHECK CONSTRAINT [FK_TaxFreeProductOrderDetail_TaxFreeProductOrder]
GO
USE [master]
GO
ALTER DATABASE [AirLineReservation] SET  READ_WRITE 
GO
