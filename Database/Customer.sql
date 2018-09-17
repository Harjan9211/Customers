/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [Customers]    Script Date: 20/08/2018 9:16:13 AM ******/
CREATE DATABASE [Customers]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Customers', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Customers.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Customers_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Customers_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Customers] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Customers].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Customers] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Customers] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Customers] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Customers] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Customers] SET ARITHABORT OFF 
GO
ALTER DATABASE [Customers] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Customers] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Customers] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Customers] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Customers] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Customers] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Customers] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Customers] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Customers] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Customers] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Customers] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Customers] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Customers] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Customers] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Customers] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Customers] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Customers] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Customers] SET RECOVERY FULL 
GO
ALTER DATABASE [Customers] SET  MULTI_USER 
GO
ALTER DATABASE [Customers] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Customers] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Customers] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Customers] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Customers] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Customers', N'ON'
GO
ALTER DATABASE [Customers] SET QUERY_STORE = OFF
GO
USE [Customers]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Customers]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 20/08/2018 9:16:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CusID] [int] NOT NULL,
	[FName] [nvarchar](255) NULL,
	[LName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](225) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 20/08/2018 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Tittle] [nvarchar](225) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 20/08/2018 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] NOT NULL,
	[MovielDFK] [int] NULL,
	[CustlDFK] [int] NULL,
	[DateRented] [smalldatetime] NULL,
	[DateReturned] [smalldatetime] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (2, N'Malkeet', N'Singh', N'31 Beaumonts way', N'0223456426')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (3, N'Surinder', N'Singh', N'96 beaumonts', N'0343452789')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (4, N'Daljit', N'Malhi', N'11 Hobson Street', N'993536379')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (5, N'Arshpal', N'Singh', N'88 Watson place ', N'236678900')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (6, N'Manpreet', N'Singh', N'876 Omana road', N'012356779')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (7, N'Skattar', N'Singh', N'34 hobsonville', N'02345699')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (8, N'Happy', N'Don', N'15 great south road', N'022451136')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (9, N'Shubam', N'Gill', N'36 albany road', N'099546738')
INSERT [dbo].[Customer] ([CusID], [FName], [LName], [Address], [Phone]) VALUES (10, N'Deep', N'Maan', N'05 queen street', N'077234567')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1, N'05', N'Bodyguard', N'2015', 120.0000, N'4', N'A freedom-craving coed (Kareena Kapoor) hatches a plan to ditch her vigilant bodyguard (Salman Khan), but her scheme soon backfires.', N'Romantic')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (2, N'02', N'Bhag Milkha Bhag', N'2013', 180.0000, N'5', N'The story of runner Milkha Singh (Farhan Akhtar), called "the Flying Sikh," shows his loss in the 400-meter finals at the 1960 Olympics.', N'Olympics ')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (3, N'01', N'Queen', N'2016', 260.0000, N'1', N'A young Delhi woman from a traditional family goes on a solo honeymoon when her wedding is canceled.', N'Comedy')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (4, N'06', N'Rokey Mental', N'2016', 190.0000, N'7', N'It is the story of a star athlete whose belief in his own invincibility makes him disregard the lurking threats posed by his own abrasive personality.', N'Boxing')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (5, N'03', N'Ashqui 2', N'2012', 170.0000, N'3', N'A young woman meets a failing musician who launches her singing career, but their relationship is doomed when people assume he''s with her for her fame and fortune.', N'Love')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (6, N'07', N'Fast and furious 7', N'2015', 300.0000, N'2', N'The eighth edition in the ‘Fast & Furious’ franchise (The Fate of the Furious) revolves around a mysterious hacker Cipher (Charlize Theron) who tries to seduce Dom (Vin Diesel) into the dangerous world of terrorism.', N'About Terrorism')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (7, N'09', N'Sardar ji', N'2016', 260.0000, N'10', N'A ghost hunter traps spirits in bottles.', N'Horror')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (8, N'04', N'Harry Porter', N'2010', 340.0000, N'8', N' Harry Potter, a boy who learns on his eleventh birthday that he is the orphaned son of two powerful wizards and possesses unique magical powers of his own.', N'Magic')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (9, N'08', N'Singham', N'2014', 110.0000, N'9', N'An honest inspector (Ajay Devgan) clashes with a shady politician (Prakash Raj).', N'Honesty')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Tittle], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (10, N'10', N'Wanted', N'2010', 227.0000, N'10', N'Radhe, too, may not be entirely what he seems. Between a kidnapping and a violent shootout, love can be brutal indeed.', N'Control Crime')
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (1, 1, 1, CAST(N'2016-03-09T00:00:00' AS SmallDateTime), CAST(N'2016-09-06T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (2, 2, 2, CAST(N'2015-07-08T00:00:00' AS SmallDateTime), CAST(N'2015-07-16T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (3, 3, 3, CAST(N'2013-01-02T00:00:00' AS SmallDateTime), CAST(N'2013-01-03T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (4, 4, 8, CAST(N'2011-11-11T00:00:00' AS SmallDateTime), CAST(N'2011-12-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (5, 5, 8, CAST(N'2009-02-02T00:00:00' AS SmallDateTime), CAST(N'2009-03-09T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (6, 2, 6, CAST(N'2010-10-10T00:00:00' AS SmallDateTime), CAST(N'2010-11-11T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (7, 7, 7, CAST(N'2004-04-04T00:00:00' AS SmallDateTime), CAST(N'2005-05-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (8, 8, 8, CAST(N'2001-01-01T00:00:00' AS SmallDateTime), CAST(N'2001-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (9, 9, 9, CAST(N'2007-12-12T00:00:00' AS SmallDateTime), CAST(N'2008-12-17T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (10, 10, 10, CAST(N'2006-11-11T00:00:00' AS SmallDateTime), CAST(N'2007-11-11T00:00:00' AS SmallDateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (11, 10, 9, NULL, NULL)
INSERT [dbo].[RentedMovies] ([RMID], [MovielDFK], [CustlDFK], [DateRented], [DateReturned]) VALUES (12, 10, 8, NULL, NULL)
USE [master]
GO
ALTER DATABASE [Customers] SET  READ_WRITE 
GO
