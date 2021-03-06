USE [master]
GO
/****** Object:  Database [PCBuilder]    Script Date: 8/30/2018 11:18:49 AM ******/
CREATE DATABASE [PCBuilder]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PCBuilder', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PCBuilder.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PCBuilder_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PCBuilder_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PCBuilder] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PCBuilder].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PCBuilder] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PCBuilder] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PCBuilder] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PCBuilder] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PCBuilder] SET ARITHABORT OFF 
GO
ALTER DATABASE [PCBuilder] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PCBuilder] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PCBuilder] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PCBuilder] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PCBuilder] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PCBuilder] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PCBuilder] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PCBuilder] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PCBuilder] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PCBuilder] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PCBuilder] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PCBuilder] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PCBuilder] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PCBuilder] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PCBuilder] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PCBuilder] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PCBuilder] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PCBuilder] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PCBuilder] SET  MULTI_USER 
GO
ALTER DATABASE [PCBuilder] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PCBuilder] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PCBuilder] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PCBuilder] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PCBuilder] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PCBuilder] SET QUERY_STORE = OFF
GO
USE [PCBuilder]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
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
USE [PCBuilder]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/30/2018 11:18:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 8/30/2018 11:18:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 8/30/2018 11:18:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 8/30/2018 11:18:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 8/30/2018 11:18:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 8/30/2018 11:18:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[AccessFailedCount] [int] NOT NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cases]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[FormFactor] [nvarchar](100) NOT NULL,
	[NumberOfVents] [int] NOT NULL,
	[CaseType] [nvarchar](100) NOT NULL,
	[NumberOfPorts] [int] NOT NULL,
	[Weight] [float] NOT NULL,
	[Size] [nvarchar](100) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GraphicsCards]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GraphicsCards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Architecture] [nvarchar](100) NOT NULL,
	[Socket] [nvarchar](100) NOT NULL,
	[Pipelines] [int] NOT NULL,
	[CoreSpeed] [int] NOT NULL,
	[MemorySpeed] [nvarchar](max) NOT NULL,
	[MemoryType] [nvarchar](100) NOT NULL,
	[MemoryAmount] [int] NOT NULL,
	[MaxPower] [int] NOT NULL,
	[DirectX] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_GraphicsCards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HardDiskDrives]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HardDiskDrives](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Rpm] [int] NOT NULL,
	[ReadSpeed] [int] NOT NULL,
	[WriteSpeed] [int] NOT NULL,
	[Cache] [int] NOT NULL,
	[Interface] [nvarchar](100) NOT NULL,
	[MemoryCapacity] [float] NOT NULL,
 CONSTRAINT [PK_HardDiskDrives] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Memory]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Memory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Amount] [int] NOT NULL,
	[Type] [nvarchar](100) NOT NULL,
	[Frequency] [int] NOT NULL,
	[ModulesType] [nvarchar](100) NOT NULL,
	[Socket] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Memory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motherboards]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motherboards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ProcessorSocketNumber] [nvarchar](100) NOT NULL,
	[Chipset] [nvarchar](100) NOT NULL,
	[MemoryType] [nvarchar](100) NOT NULL,
	[MemorySocketNumber] [nvarchar](100) NOT NULL,
	[MaxMemory] [int] NOT NULL,
	[NumberOfMemorySlots] [int] NOT NULL,
	[PowerConnector] [nvarchar](100) NOT NULL,
	[HDDInterface] [nvarchar](100) NOT NULL,
	[SSDInterface] [nvarchar](100) NOT NULL,
	[FormFactor] [nvarchar](100) NOT NULL,
	[GraphicsCardSocketNumber] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Motherboards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PCs]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[CaseId] [int] NOT NULL,
	[ProcessorId] [int] NOT NULL,
	[GraphicsCardId] [int] NOT NULL,
	[MotherboardId] [int] NOT NULL,
	[PowerSupplyId] [int] NOT NULL,
	[HardDiskDriveId] [int] NULL,
	[SolidStateDriveId] [int] NULL,
	[TotalPrice] [decimal](18, 2) NOT NULL,
	[BuildName] [nvarchar](100) NOT NULL,
	[MemoryId] [int] NOT NULL,
	[NumberOfMemorySticks] [int] NOT NULL,
	[SystemRating] [float] NOT NULL,
	[SystemSummary] [nvarchar](max) NULL,
	[UserRating] [float] NOT NULL,
	[MaxSystemRating] [float] NOT NULL,
	[UsersRatedIds] [nvarchar](max) NULL,
	[UsersRatedCount] [int] NOT NULL,
 CONSTRAINT [PK_PCs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PowerSupplies]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PowerSupplies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Connector] [nvarchar](100) NOT NULL,
	[NumberOfCoolingVents] [int] NOT NULL,
	[Pfc] [nvarchar](100) NOT NULL,
	[Effectiveness] [int] NOT NULL,
	[Power] [float] NOT NULL,
 CONSTRAINT [PK_PowerSupplies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Processors]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Processors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[Architecture] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Socket] [nvarchar](100) NOT NULL,
	[NumberOfCores] [int] NOT NULL,
	[Frequency] [float] NOT NULL,
	[Cache] [float] NOT NULL,
	[Power] [float] NOT NULL,
	[MaxMemorySize] [int] NOT NULL,
 CONSTRAINT [PK_Processors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SolidStateDrives]    Script Date: 8/30/2018 11:18:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SolidStateDrives](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](100) NOT NULL,
	[ModelName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ReadSpeed] [int] NOT NULL,
	[WriteSpeed] [int] NOT NULL,
	[Interface] [nvarchar](100) NOT NULL,
	[MemoryCapacity] [float] NOT NULL,
 CONSTRAINT [PK_SolidStateDrives] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Cases_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Cases_ModelName] ON [dbo].[Cases]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_GraphicsCards_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_GraphicsCards_ModelName] ON [dbo].[GraphicsCards]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_HardDiskDrives_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_HardDiskDrives_ModelName] ON [dbo].[HardDiskDrives]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Memory_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Memory_ModelName] ON [dbo].[Memory]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Motherboards_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Motherboards_ModelName] ON [dbo].[Motherboards]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PCs_BuildName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PCs_BuildName] ON [dbo].[PCs]
(
	[BuildName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_CaseId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_CaseId] ON [dbo].[PCs]
(
	[CaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_GraphicsCardId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_GraphicsCardId] ON [dbo].[PCs]
(
	[GraphicsCardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_HardDiskDriveId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_HardDiskDriveId] ON [dbo].[PCs]
(
	[HardDiskDriveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_MemoryId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_MemoryId] ON [dbo].[PCs]
(
	[MemoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_MotherboardId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_MotherboardId] ON [dbo].[PCs]
(
	[MotherboardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_PowerSupplyId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_PowerSupplyId] ON [dbo].[PCs]
(
	[PowerSupplyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_ProcessorId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_ProcessorId] ON [dbo].[PCs]
(
	[ProcessorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PCs_SolidStateDriveId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_SolidStateDriveId] ON [dbo].[PCs]
(
	[SolidStateDriveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PCs_UserId]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_PCs_UserId] ON [dbo].[PCs]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PowerSupplies_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PowerSupplies_ModelName] ON [dbo].[PowerSupplies]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Processors_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Processors_ModelName] ON [dbo].[Processors]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SolidStateDrives_ModelName]    Script Date: 8/30/2018 11:18:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SolidStateDrives_ModelName] ON [dbo].[SolidStateDrives]
(
	[ModelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HardDiskDrives] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [MemoryCapacity]
GO
ALTER TABLE [dbo].[Memory] ADD  DEFAULT (N'') FOR [Socket]
GO
ALTER TABLE [dbo].[Motherboards] ADD  DEFAULT (N'') FOR [GraphicsCardSocketNumber]
GO
ALTER TABLE [dbo].[PCs] ADD  DEFAULT (N'') FOR [BuildName]
GO
ALTER TABLE [dbo].[PCs] ADD  DEFAULT ((0)) FOR [MemoryId]
GO
ALTER TABLE [dbo].[PCs] ADD  DEFAULT ((0)) FOR [NumberOfMemorySticks]
GO
ALTER TABLE [dbo].[PCs] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [SystemRating]
GO
ALTER TABLE [dbo].[PCs] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [UserRating]
GO
ALTER TABLE [dbo].[PCs] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [MaxSystemRating]
GO
ALTER TABLE [dbo].[PCs] ADD  DEFAULT ((0)) FOR [UsersRatedCount]
GO
ALTER TABLE [dbo].[PowerSupplies] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Power]
GO
ALTER TABLE [dbo].[SolidStateDrives] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [MemoryCapacity]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_Cases_CaseId] FOREIGN KEY([CaseId])
REFERENCES [dbo].[Cases] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_Cases_CaseId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_GraphicsCards_GraphicsCardId] FOREIGN KEY([GraphicsCardId])
REFERENCES [dbo].[GraphicsCards] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_GraphicsCards_GraphicsCardId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_HardDiskDrives_HardDiskDriveId] FOREIGN KEY([HardDiskDriveId])
REFERENCES [dbo].[HardDiskDrives] ([Id])
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_HardDiskDrives_HardDiskDriveId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_Memory_MemoryId] FOREIGN KEY([MemoryId])
REFERENCES [dbo].[Memory] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_Memory_MemoryId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_Motherboards_MotherboardId] FOREIGN KEY([MotherboardId])
REFERENCES [dbo].[Motherboards] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_Motherboards_MotherboardId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_PowerSupplies_PowerSupplyId] FOREIGN KEY([PowerSupplyId])
REFERENCES [dbo].[PowerSupplies] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_PowerSupplies_PowerSupplyId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_Processors_ProcessorId] FOREIGN KEY([ProcessorId])
REFERENCES [dbo].[Processors] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_Processors_ProcessorId]
GO
ALTER TABLE [dbo].[PCs]  WITH CHECK ADD  CONSTRAINT [FK_PCs_SolidStateDrives_SolidStateDriveId] FOREIGN KEY([SolidStateDriveId])
REFERENCES [dbo].[SolidStateDrives] ([Id])
GO
ALTER TABLE [dbo].[PCs] CHECK CONSTRAINT [FK_PCs_SolidStateDrives_SolidStateDriveId]
GO
USE [master]
GO
ALTER DATABASE [PCBuilder] SET  READ_WRITE 
GO
