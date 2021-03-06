USE [master]
GO
/****** Object:  Database [AccountNumberDemo]    Script Date: 6/28/2020 9:24:05 AM ******/
CREATE DATABASE [AccountNumberDemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AccountNumberDemo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AccountNumberDemo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AccountNumberDemo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AccountNumberDemo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AccountNumberDemo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AccountNumberDemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AccountNumberDemo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET ARITHABORT OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AccountNumberDemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AccountNumberDemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AccountNumberDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AccountNumberDemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AccountNumberDemo] SET  MULTI_USER 
GO
ALTER DATABASE [AccountNumberDemo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AccountNumberDemo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AccountNumberDemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AccountNumberDemo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AccountNumberDemo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AccountNumberDemo] SET QUERY_STORE = OFF
GO
USE [AccountNumberDemo]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/28/2020 9:24:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[City] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerSequence]    Script Date: 6/28/2020 9:24:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerSequence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerIdentifier] [int] NULL,
	[CurrentSequenceValue] [nvarchar](max) NULL,
	[SequencePreFix] [nchar](2) NULL,
 CONSTRAINT [PK_CustomerSequence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/28/2020 9:24:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerIdentifier] [int] NULL,
	[InvoiceNumber] [nvarchar](max) NULL,
	[OrderDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [City], [PostalCode], [Country]) VALUES (1, N'Alfreds Futterkiste', N'Maria Anders', N'Sales Representative', N'Berlin', N'12209', N'Germany')
GO
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [City], [PostalCode], [Country]) VALUES (2, N'Ana Trujillo Emparedados y helados', N'Ana Trujillo', N'Owner', N'México D.F.', N'05021', N'Mexico')
GO
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [City], [PostalCode], [Country]) VALUES (3, N'Antonio Moreno Taquería', N'Antonio Moreno', N'Owner', N'México D.F.', N'05023', N'Mexico')
GO
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [City], [PostalCode], [Country]) VALUES (4, N'Around the Horn', N'Thomas Hardy', N'Sales Representative', N'London', N'WA1 1DP', N'UK')
GO
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [City], [PostalCode], [Country]) VALUES (5, N'Berglunds snabbköp', N'Christina Berglund', N'Order Administrator', N'Luleå', N'S-958 22', N'Sweden')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerSequence] ON 
GO
INSERT [dbo].[CustomerSequence] ([Id], [CustomerIdentifier], [CurrentSequenceValue], [SequencePreFix]) VALUES (1, 1, NULL, N'AA')
GO
INSERT [dbo].[CustomerSequence] ([Id], [CustomerIdentifier], [CurrentSequenceValue], [SequencePreFix]) VALUES (2, 2, NULL, N'BB')
GO
INSERT [dbo].[CustomerSequence] ([Id], [CustomerIdentifier], [CurrentSequenceValue], [SequencePreFix]) VALUES (3, 3, NULL, N'CC')
GO
INSERT [dbo].[CustomerSequence] ([Id], [CustomerIdentifier], [CurrentSequenceValue], [SequencePreFix]) VALUES (4, 4, NULL, N'DD')
GO
INSERT [dbo].[CustomerSequence] ([Id], [CustomerIdentifier], [CurrentSequenceValue], [SequencePreFix]) VALUES (5, 5, NULL, N'EE')
GO
SET IDENTITY_INSERT [dbo].[CustomerSequence] OFF
GO
ALTER TABLE [dbo].[CustomerSequence]  WITH CHECK ADD  CONSTRAINT [FK_CustomerSequence_Customers] FOREIGN KEY([CustomerIdentifier])
REFERENCES [dbo].[Customers] ([CustomerIdentifier])
GO
ALTER TABLE [dbo].[CustomerSequence] CHECK CONSTRAINT [FK_CustomerSequence_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerIdentifier])
REFERENCES [dbo].[Customers] ([CustomerIdentifier])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
USE [master]
GO
ALTER DATABASE [AccountNumberDemo] SET  READ_WRITE 
GO
