USE [master]
GO
/****** Object:  Database [SinemaOtomasyonuDB]    Script Date: 7.08.2024 21:22:04 ******/
CREATE DATABASE [SinemaOtomasyonuDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SinemaOtomasyonuDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SinemaOtomasyonuDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SinemaOtomasyonuDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SinemaOtomasyonuDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SinemaOtomasyonuDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET  MULTI_USER 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SinemaOtomasyonuDB', N'ON'
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SinemaOtomasyonuDB]
GO
/****** Object:  Table [dbo].[Biletler]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biletler](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Bkod] [char](10) NULL,
	[AdveSoyad] [nvarchar](50) NULL,
	[Telno] [char](10) NULL,
	[Koltukno] [nvarchar](50) NULL,
	[Film] [nvarchar](50) NULL,
	[Tarih] [nvarchar](20) NULL,
	[Saat] [nvarchar](10) NULL,
	[Salon] [nvarchar](10) NULL,
	[Tur] [nvarchar](20) NULL,
	[IslemSaatı] [nvarchar](50) NULL,
 CONSTRAINT [PK_Biletler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filmler]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filmler](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Adı] [nvarchar](50) NULL,
	[Turu] [nvarchar](100) NULL,
	[Özellik] [nvarchar](100) NULL,
	[Bicimi] [nvarchar](100) NULL,
	[Yonetmen] [nvarchar](100) NULL,
	[Oyuncu] [nvarchar](200) NULL,
	[Detay] [nvarchar](300) NULL,
	[Puan] [char](2) NULL,
	[Afis] [nvarchar](max) NULL,
	[Tarih] [date] NOT NULL,
	[Durum] [char](1) NULL,
 CONSTRAINT [PK_Filmler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kontrol]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kontrol](
	[Filmadı] [nvarchar](50) NULL,
	[Tarih] [nvarchar](10) NULL,
	[Saat] [char](10) NULL,
	[Salonadi] [nvarchar](10) NULL,
	[Koltuklar] [nvarchar](80) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[KullaniciSifre] [nvarchar](50) NULL,
	[AdveSoyad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oyuncular]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oyuncular](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[AdveSoyad] [nvarchar](50) NULL,
	[Cinsiyet] [char](1) NULL,
	[Yas] [char](2) NULL,
	[Biyografi] [nvarchar](300) NULL,
	[Resim] [nvarchar](max) NULL,
 CONSTRAINT [PK_Oyuncular] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salonlar]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salonlar](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Salonadi] [nvarchar](30) NULL,
	[KoltukSayisi] [nchar](20) NULL,
 CONSTRAINT [PK_Salonlar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Secilenler]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Secilenler](
	[KISI] [nvarchar](50) NULL,
	[TUR] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetmenler]    Script Date: 7.08.2024 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetmenler](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[AdveSoyad] [nvarchar](50) NULL,
	[Cinsiyet] [char](1) NULL,
	[Yas] [char](2) NULL,
	[Biyografi] [nvarchar](110) NULL,
	[Resim] [nvarchar](max) NULL,
 CONSTRAINT [PK_Yonetmenler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SinemaOtomasyonuDB] SET  READ_WRITE 
GO
