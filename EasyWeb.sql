USE [master]
GO
/****** Object:  Database [Nguyen]    Script Date: 1/12/2020 10:50:42 AM ******/
CREATE DATABASE [Nguyen]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nguyen', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Nguyen.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Nguyen_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Nguyen_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Nguyen] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nguyen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nguyen] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nguyen] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nguyen] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nguyen] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nguyen] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nguyen] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Nguyen] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nguyen] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nguyen] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nguyen] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nguyen] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nguyen] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nguyen] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nguyen] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nguyen] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Nguyen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nguyen] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nguyen] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nguyen] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nguyen] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nguyen] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nguyen] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nguyen] SET RECOVERY FULL 
GO
ALTER DATABASE [Nguyen] SET  MULTI_USER 
GO
ALTER DATABASE [Nguyen] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nguyen] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nguyen] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nguyen] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Nguyen] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Nguyen', N'ON'
GO
ALTER DATABASE [Nguyen] SET QUERY_STORE = OFF
GO
USE [Nguyen]
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
USE [Nguyen]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 1/12/2020 10:50:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountId] [int] NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[Salt] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[AddressId] [int] NOT NULL,
	[UserProfileId] [int] NULL,
	[Address] [nvarchar](max) NULL,
	[CityId] [int] NULL,
	[DistrictId] [int] NULL,
	[WardId] [int] NULL,
	[IsMain] [bit] NULL,
	[IsDelivery] [bit] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attribute]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attribute](
	[AttributeId] [int] NOT NULL,
	[AttributeName] [nvarchar](50) NULL,
	[AttributeTypeId] [int] NULL,
	[AttributeGroupId] [int] NULL,
 CONSTRAINT [PK_Attribute] PRIMARY KEY CLUSTERED 
(
	[AttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributeGroup]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeGroup](
	[AttributeGroupId] [int] NOT NULL,
	[AttributeGroupName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AttributeGroup] PRIMARY KEY CLUSTERED 
(
	[AttributeGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributeGroupDetails]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeGroupDetails](
	[AttributeGroupId] [int] NOT NULL,
	[AttributeId] [int] NOT NULL,
 CONSTRAINT [PK_AttributeGroupDetails] PRIMARY KEY CLUSTERED 
(
	[AttributeGroupId] ASC,
	[AttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributeType]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeType](
	[AttributeTypeId] [int] NOT NULL,
	[AttributeName] [nvarchar](50) NULL,
	[AttributeDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_AttributeType] PRIMARY KEY CLUSTERED 
(
	[AttributeTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityId] [int] NOT NULL,
	[CityName] [nvarchar](50) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DateTime_AttributeValue]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DateTime_AttributeValue](
	[ValueId] [int] NOT NULL,
	[AttributeId] [int] NULL,
	[Value] [datetime] NULL,
 CONSTRAINT [PK_DateTime_AttributeValue] PRIMARY KEY CLUSTERED 
(
	[ValueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Decimal_AttributeValue]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Decimal_AttributeValue](
	[ValueId] [int] NOT NULL,
	[AttributeId] [int] NULL,
	[Value] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Decimal_Attribute] PRIMARY KEY CLUSTERED 
(
	[ValueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[District]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[DistrictId] [int] NOT NULL,
	[DistrictName] [nvarchar](50) NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[DistrictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity](
	[EntityId] [int] NOT NULL,
	[EntityName] [nvarchar](100) NULL,
	[EntitySlug] [nvarchar](max) NULL,
	[CategoryId] [int] NULL,
	[EntityParent] [int] NULL,
	[Created] [datetime] NULL,
	[Modified] [datetime] NULL,
	[Author] [int] NULL,
	[Editor] [int] NULL,
 CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED 
(
	[EntityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntityDetails]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntityDetails](
	[EntityId] [int] NOT NULL,
	[AttributeGroupId] [int] NOT NULL,
 CONSTRAINT [PK_EntityDetails] PRIMARY KEY CLUSTERED 
(
	[EntityId] ASC,
	[AttributeGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Number_AttributeValue]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Number_AttributeValue](
	[ValueId] [int] NOT NULL,
	[AttributeId] [int] NULL,
	[Value] [int] NULL,
 CONSTRAINT [PK_Number_AttributeValue] PRIMARY KEY CLUSTERED 
(
	[ValueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Option_AttributeValue]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Option_AttributeValue](
	[ValueId] [int] NOT NULL,
	[AttributeId] [int] NULL,
	[Source] [int] NULL,
 CONSTRAINT [PK_Option_AttributeValue] PRIMARY KEY CLUSTERED 
(
	[ValueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[String_AttributeValue]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[String_AttributeValue](
	[ValueId] [int] NOT NULL,
	[AttributeId] [int] NULL,
	[Value] [nvarchar](255) NULL,
 CONSTRAINT [PK_String_AttributeValue] PRIMARY KEY CLUSTERED 
(
	[ValueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Text_AttributeValue]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Text_AttributeValue](
	[ValueId] [int] NOT NULL,
	[AttributeId] [int] NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_Text_AttributeValue] PRIMARY KEY CLUSTERED 
(
	[ValueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserProfileId] [int] NOT NULL,
	[AccountId] [int] NULL,
	[FullName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[UserProfileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ward]    Script Date: 1/12/2020 10:50:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ward](
	[WardId] [int] NOT NULL,
	[WardName] [nvarchar](50) NULL,
	[DistrictId] [int] NULL,
 CONSTRAINT [PK_Ward] PRIMARY KEY CLUSTERED 
(
	[WardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Account]    Script Date: 1/12/2020 10:50:43 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Account] ON [dbo].[Account]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([CityId])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_City]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_District] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[District] ([DistrictId])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_District]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_UserProfile] FOREIGN KEY([UserProfileId])
REFERENCES [dbo].[UserProfile] ([UserProfileId])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_UserProfile]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Ward] FOREIGN KEY([WardId])
REFERENCES [dbo].[Ward] ([WardId])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Ward]
GO
ALTER TABLE [dbo].[Attribute]  WITH CHECK ADD  CONSTRAINT [FK_Attribute_AttributeType] FOREIGN KEY([AttributeTypeId])
REFERENCES [dbo].[AttributeType] ([AttributeTypeId])
GO
ALTER TABLE [dbo].[Attribute] CHECK CONSTRAINT [FK_Attribute_AttributeType]
GO
ALTER TABLE [dbo].[AttributeGroupDetails]  WITH CHECK ADD  CONSTRAINT [FK_AttributeGroupDetails_Attribute] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attribute] ([AttributeId])
GO
ALTER TABLE [dbo].[AttributeGroupDetails] CHECK CONSTRAINT [FK_AttributeGroupDetails_Attribute]
GO
ALTER TABLE [dbo].[AttributeGroupDetails]  WITH CHECK ADD  CONSTRAINT [FK_AttributeGroupDetails_AttributeGroup] FOREIGN KEY([AttributeGroupId])
REFERENCES [dbo].[AttributeGroup] ([AttributeGroupId])
GO
ALTER TABLE [dbo].[AttributeGroupDetails] CHECK CONSTRAINT [FK_AttributeGroupDetails_AttributeGroup]
GO
ALTER TABLE [dbo].[DateTime_AttributeValue]  WITH CHECK ADD  CONSTRAINT [FK_DateTime_AttributeValue_Attribute] FOREIGN KEY([ValueId])
REFERENCES [dbo].[Attribute] ([AttributeId])
GO
ALTER TABLE [dbo].[DateTime_AttributeValue] CHECK CONSTRAINT [FK_DateTime_AttributeValue_Attribute]
GO
ALTER TABLE [dbo].[Decimal_AttributeValue]  WITH CHECK ADD  CONSTRAINT [FK_Decimal_Attribute_Attribute] FOREIGN KEY([ValueId])
REFERENCES [dbo].[Attribute] ([AttributeId])
GO
ALTER TABLE [dbo].[Decimal_AttributeValue] CHECK CONSTRAINT [FK_Decimal_Attribute_Attribute]
GO
ALTER TABLE [dbo].[District]  WITH CHECK ADD  CONSTRAINT [FK_District_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([CityId])
GO
ALTER TABLE [dbo].[District] CHECK CONSTRAINT [FK_District_City]
GO
ALTER TABLE [dbo].[Entity]  WITH CHECK ADD  CONSTRAINT [FK_Entity_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Entity] CHECK CONSTRAINT [FK_Entity_Category]
GO
ALTER TABLE [dbo].[EntityDetails]  WITH CHECK ADD  CONSTRAINT [FK_EntityDetails_AttributeGroup] FOREIGN KEY([AttributeGroupId])
REFERENCES [dbo].[AttributeGroup] ([AttributeGroupId])
GO
ALTER TABLE [dbo].[EntityDetails] CHECK CONSTRAINT [FK_EntityDetails_AttributeGroup]
GO
ALTER TABLE [dbo].[EntityDetails]  WITH CHECK ADD  CONSTRAINT [FK_EntityDetails_Entity] FOREIGN KEY([EntityId])
REFERENCES [dbo].[Entity] ([EntityId])
GO
ALTER TABLE [dbo].[EntityDetails] CHECK CONSTRAINT [FK_EntityDetails_Entity]
GO
ALTER TABLE [dbo].[Number_AttributeValue]  WITH CHECK ADD  CONSTRAINT [FK_Number_AttributeValue_Attribute] FOREIGN KEY([ValueId])
REFERENCES [dbo].[Attribute] ([AttributeId])
GO
ALTER TABLE [dbo].[Number_AttributeValue] CHECK CONSTRAINT [FK_Number_AttributeValue_Attribute]
GO
ALTER TABLE [dbo].[Option_AttributeValue]  WITH CHECK ADD  CONSTRAINT [FK_Option_AttributeValue_Attribute] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attribute] ([AttributeId])
GO
ALTER TABLE [dbo].[Option_AttributeValue] CHECK CONSTRAINT [FK_Option_AttributeValue_Attribute]
GO
ALTER TABLE [dbo].[String_AttributeValue]  WITH CHECK ADD  CONSTRAINT [FK_String_AttributeValue_Attribute] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attribute] ([AttributeId])
GO
ALTER TABLE [dbo].[String_AttributeValue] CHECK CONSTRAINT [FK_String_AttributeValue_Attribute]
GO
ALTER TABLE [dbo].[Text_AttributeValue]  WITH CHECK ADD  CONSTRAINT [FK_Text_AttributeValue_Attribute] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attribute] ([AttributeId])
GO
ALTER TABLE [dbo].[Text_AttributeValue] CHECK CONSTRAINT [FK_Text_AttributeValue_Attribute]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_Account]
GO
ALTER TABLE [dbo].[Ward]  WITH CHECK ADD  CONSTRAINT [FK_Ward_District] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[District] ([DistrictId])
GO
ALTER TABLE [dbo].[Ward] CHECK CONSTRAINT [FK_Ward_District]
GO
USE [master]
GO
ALTER DATABASE [Nguyen] SET  READ_WRITE 
GO
