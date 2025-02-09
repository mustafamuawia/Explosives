USE [master]
GO
/****** Object:  Database [Explosives]    Script Date: 03/31/2023 07:03:25 ******/
CREATE DATABASE [Explosives] ON  PRIMARY 
( NAME = N'Explosives', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Explosives.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Explosives_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Explosives_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Explosives] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Explosives].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Explosives] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Explosives] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Explosives] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Explosives] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Explosives] SET ARITHABORT OFF
GO
ALTER DATABASE [Explosives] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Explosives] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Explosives] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Explosives] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Explosives] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Explosives] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Explosives] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Explosives] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Explosives] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Explosives] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Explosives] SET  DISABLE_BROKER
GO
ALTER DATABASE [Explosives] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Explosives] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Explosives] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Explosives] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Explosives] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Explosives] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Explosives] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Explosives] SET  READ_WRITE
GO
ALTER DATABASE [Explosives] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Explosives] SET  MULTI_USER
GO
ALTER DATABASE [Explosives] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Explosives] SET DB_CHAINING OFF
GO
USE [Explosives]
GO
/****** Object:  Schema [o2ss]    Script Date: 03/31/2023 07:03:25 ******/
CREATE SCHEMA [o2ss] AUTHORIZATION [dbo]
GO
/****** Object:  Table [dbo].[WORKPERMISSIONS]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKPERMISSIONS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FDATE] [date] NULL,
	[FSIDENAME] [nvarchar](50) NULL,
	[SID] [int] NULL,
	[SDATE] [date] NULL,
	[PURPOSE] [nvarchar](50) NULL,
	[SSIDENAME] [nvarchar](50) NULL,
	[STATE] [nvarchar](50) NULL,
	[LOCATION] [nvarchar](50) NULL,
	[RANK] [nvarchar](20) NULL,
	[CLASS] [nvarchar](50) NULL,
	[NAME] [nvarchar](80) NULL,
	[POSITION] [nvarchar](70) NULL,
	[FINANCEID] [nvarchar](10) NULL,
	[VALID] [nvarchar](60) NULL,
	[OWNER] [nvarchar](100) NULL,
	[WorkPermissionNo] [int] NULL,
 CONSTRAINT [PK_WORKPERMISSIONS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WORKPERMISSIONS] ON
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (1, CAST(0x02420B00 AS Date), N'شركة اليانس للتعدين', NULL, CAST(0x09420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N' الياسمين / الكليس', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 1)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (2, CAST(0x02420B00 AS Date), N'شركة مانوب للتعدين', NULL, CAST(0x02420B00 AS Date), N'تعدين الذهب', N'', N'نهر النيل', N'قبقبة', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 2)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (3, CAST(0x07420B00 AS Date), N'أعمال ودالمصطفي للرخام', NULL, CAST(0x07420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل ', N'وادي الكرمت', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 3)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (4, CAST(0x08420B00 AS Date), N'محجر انس ابراهيم للجبص', NULL, CAST(0x08420B00 AS Date), N'انتج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 4)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (5, CAST(0x08420B00 AS Date), N'محجر مصعب ابراهيم للجبص', NULL, CAST(0x08420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 5)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (6, CAST(0x0B420B00 AS Date), N'محجر عبدالقادر ابوشمال الفادني', NULL, CAST(0x0B420B00 AS Date), N'انتج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 6)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (7, CAST(0x08420B00 AS Date), N'أعمال ويف لخدمات التحجير والمناجم', NULL, CAST(0x08420B00 AS Date), N'تكسير الصخور', N'', N'الخرطوم', N'قري', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 7)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (8, CAST(0x09420B00 AS Date), N'شركة هوا كان حمادي ريسورس المحدودة', NULL, CAST(0x09420B00 AS Date), N'تعدين الذهب', N'', N'نهر النيل', N'العبيدية', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 8)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (9, CAST(0x0B420B00 AS Date), N'شركة فاروس لتعدين الذهب المحدودة', NULL, CAST(0x0B420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N'نورايا', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 9)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (10, CAST(0x09420B00 AS Date), N'شركة أريــاب للتعدين المحدودة', NULL, CAST(0x09420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N'هيا', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 10)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (11, CAST(0x0B420B00 AS Date), N'أعمال محمد احمد الحاج', NULL, CAST(0x0B420B00 AS Date), N'انتاج الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 11)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (12, CAST(0x0B420B00 AS Date), N'شركة الحاجاب للتعدين', NULL, CAST(0x0B420B00 AS Date), N'انتاج الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 12)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (13, CAST(0x0B420B00 AS Date), N'محجر محمد النور محمد جمعة', NULL, CAST(0x0B420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 13)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (14, CAST(0x0B420B00 AS Date), N'محجر الهادي النور محمد جمعة', NULL, CAST(0x0B420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 14)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (15, CAST(0x0B420B00 AS Date), N'محجر ياسر احمد تاج السر', NULL, CAST(0x0B420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 15)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (16, CAST(0x0B420B00 AS Date), N'محجر محمد يوسف حسن ابورزيقة', NULL, CAST(0x0B420B00 AS Date), N'انتج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 16)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (17, CAST(0x0B420B00 AS Date), N'محجر جعفر حسن ادم بلل', NULL, CAST(0x0B420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 17)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (18, CAST(0x0B420B00 AS Date), N'محجر عثمان شوقي عثمان للجبص', NULL, CAST(0x0B420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 18)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (19, CAST(0x0E420B00 AS Date), N'شركة الشمال لانتاج الاسمنت المحدودة', NULL, CAST(0x0E420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب بربر', N'عميد ركن', N'', N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 19)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (20, CAST(0x11420B00 AS Date), N'شركة حجاجية لتعدين الذهب المحدودة', NULL, CAST(0x11420B00 AS Date), N'تعدين الذهب', N'', N'', N'الحجاجية', N'عميد ركن', N'', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 20)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (21, CAST(0x12420B00 AS Date), N'شركة اعمال التعدين المتقدمة المحدودة', NULL, CAST(0x12420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 21)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (22, CAST(0x12420B00 AS Date), N'شركة اعمال التعدين المتقدمة المحدودة', NULL, CAST(0x12420B00 AS Date), N'أعمال إستراتيجية', N'', N'الخرطوم', N'قري', N'عميد ركن', N'', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 22)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (23, CAST(0x12420B00 AS Date), N'شركة ايه أر سي  ', NULL, CAST(0x12420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديم حامد تبري كبدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 23)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (24, CAST(0x12420B00 AS Date), N'اعمال الفريحي للمقاولات ', NULL, CAST(0x12420B00 AS Date), N'استخراج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديم حامد تبري كبدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 24)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (25, CAST(0x12420B00 AS Date), N'محجر الشاهين للتعدين', NULL, CAST(0x12420B00 AS Date), N'استخراج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديم حامد تبري كبـــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 25)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (26, CAST(0x12420B00 AS Date), N'شركة سيلين للاعمال المتقدمة المحدودة', NULL, CAST(0x12420B00 AS Date), N'انتاج الخرصانة', N'', N'القضارف', N'الفاو', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 26)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (27, CAST(0x12420B00 AS Date), N'شر كة  الصادق جمعه محمد للانشطة المتعددة المحدودة ', NULL, CAST(0x12420B00 AS Date), N'تكسير الصخور ( لانتاج الجبص)', N'', N'البحر الأحمر', N'جبيت المعادن ', N'عميد ركن', N'', N'نديم حامد تبري كبـــــــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 27)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (28, CAST(0x12420B00 AS Date), N'محجر ناصر حمد نورين للجرانيت', NULL, CAST(0x12420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'جنوب كردفان', N'التضامن', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 28)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (29, CAST(0x15420B00 AS Date), N'محجر عبد القادر سليمان عبدالقادر قسم السيد', NULL, CAST(0x15420B00 AS Date), N'انتاج الخرصانة', N'', N'نهر النيل', N'شندي / العوتيب', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 29)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (30, CAST(0x15420B00 AS Date), N'مصنع القدس لصناعة والجبص والكربونات', NULL, CAST(0x15420B00 AS Date), N'انتاج الجبص', N'', N'نهر النيل', N'الشريك', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 30)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (31, CAST(0x15420B00 AS Date), N'محجر عبد الله عبد الباري للجرانيت', NULL, CAST(0x15420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'جنوب كردفان', N'التضامن', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 31)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (32, CAST(0x15420B00 AS Date), N'أعمال  سلوة للتعدين الصغير', NULL, CAST(0x15420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 32)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (33, CAST(0x15420B00 AS Date), N'أعمال ندي الشمس للتعدين الصغير', NULL, CAST(0x15420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 33)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (34, CAST(0x15420B00 AS Date), N'أعمال فلاي قولد للتعدين الصغير', NULL, CAST(0x15420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 34)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (35, CAST(0x15420B00 AS Date), N'شركة سروتي للانشطة المتعددة', NULL, CAST(0x15420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 35)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (36, CAST(0x15420B00 AS Date), N'شركة ايات للطرق والجسور ', NULL, CAST(0x15420B00 AS Date), N'تكسير الصخور', N'', N'سنار', N'جبل موية', N'عميد ركن', N'', N'نديـم حامـد تبرـي كبـدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 36)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (37, CAST(0x16420B00 AS Date), N'هبايل للتعدين', NULL, CAST(0x16420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'جنوب كردفان', N'الليري ', N'عميد ركن', N'', N'نديـم حامـد تبرـي كبـدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 37)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (38, CAST(0x16420B00 AS Date), N'ابو المغيرة للتعدين', NULL, CAST(0x16420B00 AS Date), N'تكسير الصخور', N'', N'جنوب كردفان', N'كلوقي', N'عميد ركن', N'', N'نديـم حامـد تبرـي كبـدان', N'مفتش عـــــام مفرقعـــــــــات السودان ', N'', N'نعم', N'', 38)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (39, CAST(0x16420B00 AS Date), N'محجر متوكل عبد المعروف بشير', NULL, CAST(0x16420B00 AS Date), N'استخراج حجر الجرانيت', N'', N'نهر النيل', N'غرب الفاضلاب', N'عميد ركن', N'', N'نديـــــــــــم حامــــــــــــــد تبـــــــــــري كبــــــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 39)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (40, CAST(0x16420B00 AS Date), N'شركة سودان بايل للطرق والجسور ', NULL, CAST(0x16420B00 AS Date), N'تكسير الصخور', N'', N'النيل الازرق', N'جبل الرمه', N'عميد ركن', N'', N'نديـــــــــــم حامـــــــد تبــــــــري كبــــــــــــــدن', N'مفتش عـــــام مفرقعـــــــــــــات السودان ', N'', N'نعم', N'', 40)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (41, CAST(0x17420B00 AS Date), N'شركة بوهيات المهندس', NULL, CAST(0x17420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'الشريك', N'عميد ركن', N'', N'نديـــــــــــم حامـــــــد تبــــــــري كبــــــــــــــدن', N'مفتش عـــــام مفرقعـــــــــــــات السودان ', N'', N'نعم', N'', 41)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (42, CAST(0x17420B00 AS Date), N'محجر القريب لتصنيع الجبص وكربونات الكالسيوم', NULL, CAST(0x17420B00 AS Date), N'انتاج الجبص', N'', N'البحر الأحمر', N'جبيت المعادن ', N'عميد ركن', N'', N'نديـــــــــــم حامـــــــد تبــــــــري كبــــــــــــــدن', N'مفتش عـــــام مفرقعـــــــــــــات السودان ', N'', N'نعم', N'', 42)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (43, CAST(0x17420B00 AS Date), N'شركة اروشاب لتعدين الذهب المحدودة', NULL, CAST(0x17420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N'ابير كاتيب', N'عميد ركن', N'', N'نديـــــــــــم حامـــــــد تبــــــــري كبــــــــــــــدن', N'مفتش عـــــام مفرقعـــــــــــــات السودان ', N'', N'نعم', N'', 43)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (44, CAST(0x17420B00 AS Date), N'شركة سيد عبد القادر الخبير للانشطة المتعددة', NULL, CAST(0x17420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'السويكتاب', N'عميد ركن', N'', N'نديـــــــــــم حامـــــــد تبــــــــري كبــــــــــــــدن', N'مفتش عـــــام مفرقعـــــــــــــات السودان ', N'', N'نعم', N'', 44)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (45, CAST(0x17420B00 AS Date), N'شركة مالك سيد احمد للتنمية المحدودة', NULL, CAST(0x17420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديـــــــــــم حامـــــــد تبــــــــري كبــــــــــــــدن', N'مفتش عـــــام مفرقعـــــــــــــات السودان ', N'', N'نعم', N'', 45)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (46, CAST(0x17420B00 AS Date), N'شركة الولاء  للاستخدام والاستثمار المحدودة', NULL, CAST(0x17420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'سقوم', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 46)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (47, CAST(0x17420B00 AS Date), N'أعمال الرفعة للتعدين', NULL, CAST(0x17420B00 AS Date), N'استخراج حجر الجرانت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 47)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (48, CAST(0x17420B00 AS Date), N'محجر روكي للرخام', NULL, CAST(0x17420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل ', N'وادي الكرمت', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 48)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (49, CAST(0x17420B00 AS Date), N'محجر محمد علي الخليفة الحسن', NULL, CAST(0x17420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'الشريك', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 49)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (50, CAST(0x17420B00 AS Date), N'شركة النواتي الذهب والنحاس المحدودة', NULL, CAST(0x17420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N'جبيت', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 50)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (51, CAST(0x17420B00 AS Date), N'محجر محمد الامين كبه للجرانيت', NULL, CAST(0x17420B00 AS Date), N'استخراج حجر الجرانيت', N'', N'جنوب كردفان', N'التضامن', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 51)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (52, CAST(0x1C420B00 AS Date), N'شركة اسمنت بربر المحدودة', NULL, CAST(0x1C420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 52)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (53, CAST(0x1C420B00 AS Date), N'محجر احمد عبد الرحمن علي للجرانيت', NULL, CAST(0x1C420B00 AS Date), N'انتاج الجرانيت', N'', N'جنوب كردفان', N'التضامن', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 53)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (54, CAST(0x1C420B00 AS Date), N'شركة ادلهف للتعدين ', NULL, CAST(0x1C420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N'هيا', N'عميد ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 54)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (55, CAST(0x1C420B00 AS Date), N'باعشر لمحاجر الجبص', NULL, CAST(0x1C420B00 AS Date), N'انتاج الجبص', N'', N'البحر الأحمر', N'جبيت المعادن (ايت)', N'عميد ركن', N'', N'نــــديــم حــــــــامد تبـــــــــري كبـــــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 55)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (56, CAST(0x1C420B00 AS Date), N'أعمال جبل يثرب للجرانيت', NULL, CAST(0x1C420B00 AS Date), N'استخراج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 56)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (57, CAST(0x1C420B00 AS Date), N'شركة دلقو للتعدين المحدودة', NULL, CAST(0x1C420B00 AS Date), N'تعدين الذهب', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 57)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (58, CAST(0x1C420B00 AS Date), N'أعمال مخمخ التجارية', NULL, CAST(0x1C420B00 AS Date), N'انتاج الخرصانة', N'', N'الخرطوم', N'الجيلي', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 58)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (59, CAST(0x1C420B00 AS Date), N'شركة حمدي للتعدين والاستثمار المحدودة', NULL, CAST(0x1C420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'جنوب كردفان', N'حجيرات', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 59)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (60, CAST(0x1C420B00 AS Date), N'أعمال حسن عطية للحفريات', NULL, CAST(0x1C420B00 AS Date), N'الحفريات', N'', N'القضارف', N'القضارف', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 60)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (61, CAST(0x1C420B00 AS Date), N'أعمال تاتة للمقاولات', NULL, CAST(0x1C420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'جنوب كردفان', N'كلوقي', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 61)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (62, CAST(0x1C420B00 AS Date), N'محجر ابو الباقر للجرانيت', NULL, CAST(0x1C420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'الشمالية', N'ابوحراز غرب', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 62)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (63, CAST(0x1C420B00 AS Date), N'محاجر درويش', NULL, CAST(0x1C420B00 AS Date), N'استخراج كربونات الكالسيوم', N'', N'نهر النيل', N'بربر', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 63)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (64, CAST(0x1D420B00 AS Date), N'محجر ودالمقدم للرخام', NULL, CAST(0x1D420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'الفاضلاب جنوب', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 64)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (65, CAST(0x1D420B00 AS Date), N'شركة ابورشيرش للاعمال والمشروعات المحدودة', NULL, CAST(0x1D420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N'جبل العلاق', N'عميد ركن', N'', N'نديـــم حامـــــد تبـــــــــري كبـــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 65)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (66, CAST(0x1E420B00 AS Date), N'اعمال محجر السبعات', NULL, CAST(0x1E420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'كسلا', N'جبال السبعات', N'عميد ركن', N'', N'نديــــم حامـــــــد تبـــــري كبـــــــــدان', N'مفتش عام مفرقعات السودان', N'', N'نعم', N'', 67)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (67, CAST(0x1E420B00 AS Date), N'شركة اسمنت عطبرة المحدودة', NULL, CAST(0x1E420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 68)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (68, CAST(0x1E420B00 AS Date), N'محجر الشيخ مصطفي الشيخ', NULL, CAST(0x1E420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'سقوم', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 69)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (69, CAST(0x24420B00 AS Date), N'أعمال برناب لمحاجر الجرانيت', NULL, CAST(0x24420B00 AS Date), N'انتاج حجر لجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 70)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (70, CAST(0x24420B00 AS Date), N'عبدالحفيظ سيد صالح للتعدين', NULL, CAST(0x24420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'', N'دلقو', N'لواء ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 71)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (71, CAST(0x24420B00 AS Date), N'أعمال علاء الدين حامد حمد للمحاجر', NULL, CAST(0x24420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل ', N'وادي الكرمت', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 72)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (72, CAST(0x24420B00 AS Date), N'محاجر الادريسي للحجر الطبيعي', NULL, CAST(0x24420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'سقوم', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 73)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (73, CAST(0x24420B00 AS Date), N'محاجر الادريسي للحجر الطبيعي', NULL, CAST(0x24420B00 AS Date), N'انتاج الجبص', N'', N'نهر النيل', N'الشريك', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 74)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (74, CAST(0x24420B00 AS Date), N'شركة الهواء السائل السودانية', NULL, CAST(0x24420B00 AS Date), N'انتاج غاز البنج', N'', N'الخرطوم', N'المنطقة الصناعية', N'عميد ركن', N'', N'نديـــــــــــم حامـــــــــــد تبــــــــري كبـــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 75)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (75, CAST(0x24420B00 AS Date), N'شركة تفاؤل المتحدة المحدودة', NULL, CAST(0x24420B00 AS Date), N'استخراج الحجر الجيري', N'', N'البحر الأحمر', N'جبيت المعادن (ايت)', N'عميد ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 76)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (76, CAST(0x24420B00 AS Date), N'ابوالعباس للمعادن', NULL, CAST(0x24420B00 AS Date), N'تعدين الذهب', N'', N'البحر الأحمر', N'دورديب', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 77)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (77, CAST(0x24420B00 AS Date), N'محجر ابوالعباس للمعادن', NULL, CAST(0x24420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 78)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (78, CAST(0x27420B00 AS Date), N' شركة التكامل للاسمنت المحدودة', NULL, CAST(0x27420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 79)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (79, CAST(0x27420B00 AS Date), N'شركة رانيا للانشطة المتعددة المحدودة', NULL, CAST(0x27420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N'هيا', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 80)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (80, CAST(0x27420B00 AS Date), N'شركة ريد روك للتعدين', NULL, CAST(0x27420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 81)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (81, CAST(0x27420B00 AS Date), N'محجر الهديل للرخام', NULL, CAST(0x27420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'الكربة ', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 82)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (82, CAST(0x32420B00 AS Date), N'أعمال ابوبكر حامد التجارية', NULL, CAST(0x32420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 83)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (83, CAST(0x32420B00 AS Date), N'شركة شط العرب للتجارة والخدمات', NULL, CAST(0x32420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 84)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (84, CAST(0x32420B00 AS Date), N'شركة امييو للجيلوجيا', NULL, CAST(0x32420B00 AS Date), N'تفتيت الصخور', N'', N'جنوب كردفان', N'تلودي', N'عميد ركن', N'', N'نديـــــم حامـــــــد تبـــــــري كبــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 85)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (85, CAST(0x32420B00 AS Date), N'شركة حمزة بابكر للحلول المتكاملة', NULL, CAST(0x32420B00 AS Date), N'استخراج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'عميد ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 86)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (86, CAST(0x35420B00 AS Date), N'شركة السلام لانتاج الاسمنت المحدودة', NULL, CAST(0x35420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب بربر', N'عميد ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 87)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (87, CAST(0x3F420B00 AS Date), N'شركة الخرطوم للسكك الحديدية', NULL, CAST(0x3F420B00 AS Date), N'تكسير الصخور', N'', N'جنوب دارفور', N'تور طعان', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 88)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (88, CAST(0x40420B00 AS Date), N'اعمال الصقر للجبص', NULL, CAST(0x40420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 89)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (89, CAST(0x40420B00 AS Date), N'اعمال ابوبكر محمد علي للحفريات', NULL, CAST(0x40420B00 AS Date), N'تكسير الصخور', N'', N'القضارف', N'البطانة', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 90)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (90, CAST(0x43420B00 AS Date), N'محجر الزرياب للرخام', NULL, CAST(0x43420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'بربر / ابو فصوص', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 91)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (91, CAST(0x43420B00 AS Date), N'اعمال ويف لخدمات التحجير والمناجم', NULL, CAST(0x43420B00 AS Date), N'تكسير الصخور', N'', N'النيل الأبيض', N'الجبلين', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 92)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (92, CAST(0x47420B00 AS Date), N'اعمال جبصيكو للجبص', NULL, CAST(0x47420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 93)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (93, CAST(0x47420B00 AS Date), N'محجر عبق للجبص', NULL, CAST(0x47420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 94)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (94, CAST(0x47420B00 AS Date), N'اعمال الدابورابي للجبص', NULL, CAST(0x47420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 95)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (95, CAST(0x47420B00 AS Date), N'اعمال وضاح صالح للتعدين', NULL, CAST(0x47420B00 AS Date), N'انتاج حجر الجرانيت', N'', N'الشمالية', N'دلقو', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 96)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (96, CAST(0x48420B00 AS Date), N'محجر الثلاثي للتسوق التجاري', NULL, CAST(0x48420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل ', N'وادي الكرمت', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 97)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (97, CAST(0x4A420B00 AS Date), N'محجر حسين علي موسي عيسي ', NULL, CAST(0x4A420B00 AS Date), N'انتاج الجبص', N'', N'البحر الأحمر', N'جبيت المعادن (ايت)', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 98)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (98, CAST(0x50420B00 AS Date), N'شركة سلمنتود للتعدين والخدمات المحدودة  ', NULL, CAST(0x50420B00 AS Date), N'انتاج حجر الجرانيت ', N'', N'الشمالية', N'القعب', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 99)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (99, CAST(0x54420B00 AS Date), N' الرضاء للانشطة المتعددة', NULL, CAST(0x54420B00 AS Date), N'تكسير الصخور', N'', N'جنوب كردفان', N'كلوقي', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 100)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (100, CAST(0x57420B00 AS Date), N'محجر عبدالمنعم محمد علي عبدالمطلب عبدالله', NULL, CAST(0x57420B00 AS Date), N'إستخراج الرخام', N'', N'نهر النيل', N'الكربة ', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 101)
GO
print 'Processed 100 total records'
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (101, CAST(0x57420B00 AS Date), N'شركة امدرمان للتعدين المحدودة', NULL, CAST(0x57420B00 AS Date), N'تعدين الذهب', N'', N'نهر النيل', N'العبيدية', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 102)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (102, CAST(0x57420B00 AS Date), N'محجر مزمل محمد علي للجبص', NULL, CAST(0x57420B00 AS Date), N'لاستخراج الجبص', N'', N'البحر الأحمر', N'جبيت المعادن ', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 103)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (103, CAST(0x5B420B00 AS Date), N'محجر عبد الرحمن ابراهيم معلم  للجبص', NULL, CAST(0x5B420B00 AS Date), N'انتاج الجبص', N'', N'البحر الأحمر', N'جبيت المعادن ', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 104)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (104, CAST(0x5F420B00 AS Date), N'محجر حامد أحمد بشير سعيد', NULL, CAST(0x5F420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب شندي', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 105)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (105, CAST(0x62420B00 AS Date), N'محجر ود جادات للجبص', NULL, CAST(0x62420B00 AS Date), N'انتاج الجبص', N'', N'البحر الاحمر', N'جبيت المعادن / شنعاب', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 106)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (106, CAST(0x64420B00 AS Date), N'مصنع محمد علي خليفة', NULL, CAST(0x64420B00 AS Date), N'انتاج الرخام', N'', N'نهر النيل', N'بربر / ابو فصوص', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 107)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (107, CAST(0x64420B00 AS Date), N'شركة تنحتون للانشطة المتعددة', NULL, CAST(0x64420B00 AS Date), N'تكسير صخور', N'', N'الخرطوم ', N'عدالدلجه', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 108)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (108, CAST(0x66420B00 AS Date), N'شركة أوهاف للتعدين', NULL, CAST(0x66420B00 AS Date), N'تعدين الذهب', N'', N'البحر الاحمر', N' الياسمين / الكليس', N'لواء ركن', N'', N'نديـــم حامــــــــد تبـــــــري كبــــــــدان', N'مفتش عـــــام مفرقعــــــــــــــــات السودان ', N'', N'نعم', N'', 109)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (109, CAST(0x6A420B00 AS Date), N'شركة هوادونق للتعدين والصناعة المحدودة', NULL, CAST(0x6A420B00 AS Date), N'تعدين الذهب', N'', N'الشمالية', N'القعب', N'لواء ركن', NULL, N'نديـم حامــد تبـــري كبـــــدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'', 110)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (110, CAST(0x6A420B00 AS Date), N'العليف للتعدين', NULL, CAST(0x6A420B00 AS Date), N'انتاج الرخام', N'', N'البحر الأحمر', N'جبل المعقل', N'لواء ركن', NULL, N'نديــم حامـد تبـــــري كبـــــدان', N'مفتش عام مفرقعات السـودان', NULL, NULL, N'', 111)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (111, CAST(0x6C420B00 AS Date), N'شركة نبتة للجيلوجيا والتعدين المحدودة', NULL, CAST(0x6C420B00 AS Date), N'تكسير الصخور', N'', N'نهر النيل', N'غرب عطبرة / أم الطيور', N'عميد ركن', NULL, N'نديـــم حامــد تبــــري كبــــــدان', N'مفتش عام مفرقعــات السـودان', NULL, NULL, N'', 112)
INSERT [dbo].[WORKPERMISSIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [PURPOSE], [SSIDENAME], [STATE], [LOCATION], [RANK], [CLASS], [NAME], [POSITION], [FINANCEID], [VALID], [OWNER], [WorkPermissionNo]) VALUES (112, CAST(0x6D420B00 AS Date), N'يسشيش', NULL, CAST(0x6D420B00 AS Date), N'يسشيشس', N'يسشيش', N'الجزيرة', N'الباقير', N'عميد ركن', NULL, N'نديــــم حامـــد تبـــــــــري كبــــــــــدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'', 113)
SET IDENTITY_INSERT [dbo].[WORKPERMISSIONS] OFF
/****** Object:  Table [dbo].[WorkCopiesDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkCopiesDetails](
	[WorkCopySirsID] [int] IDENTITY(1,1) NOT NULL,
	[Sirs] [nvarchar](150) NULL,
	[WorkCopyID] [int] NULL,
 CONSTRAINT [PK_WorkCopiesDetails] PRIMARY KEY CLUSTERED 
(
	[WorkCopySirsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WorkCopiesDetails] ON
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (1, N'السيد/ مدير شرطة ولاية كسلا', 93)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (2, N'السيد/ مدير وحدة امن كسلا', 93)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (3, N'السيد/ مدير شرطة ولاية نهر النيل', 118)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (7, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 23)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (8, N'السيد/ قائد الفرقة 101 مشاة عمليات', 23)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (9, N'السيد/ قائد الفرقة 101 مشاة أ.س', 23)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (10, N'السيد/ مدير شرطة ولاية البحر الأحمر', 23)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (11, N'السيد/ مدير جهاز الأمن ولاية البحر الأحمر', 23)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (12, N'السيد/ مدير وحدة أمن جبيت', 23)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (13, N'السيد/ مدير شرطة جبيت', 23)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (14, N'السيد/ ركن أ.سلاح الأسلحة والذخائر', 92)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (15, N'السيد/ قائد اللواء 41 مشاة عمليات', 92)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (16, N'السيد/ قائد اللواء 41 مشاة أ.س', 92)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (17, N'السيد/ مدير شرطة ولاية كسلا', 92)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (18, N'السيد/ مدير وحدة أمن كسلا', 92)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (19, N'السيد/ قائد الفرقة 19 عمليات', 55)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (20, N'السيد/ قائد الفرقة 19 أ.س', 55)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (21, N'السيد/ ركن أ. س سلاح الأسلحة والذخائر', 55)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (22, N'السيد/ مدير شرطة الولاية الشمالية', 55)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (23, N'السيد/ مدير وحدة أمن عبري', 55)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (24, N'السيد/ رئيس قسم  شرطة منطقة عبري', 55)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (25, N'السيد/ ركن أ0س سلاح الأسلحة و الذخائر', 94)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (26, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 94)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (27, N'السيد/ قائد سلاح المدفعية عطبرة أ0س', 94)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (28, N'السيد/ مدير شرطة أبو حمد', 94)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (29, N'السيد/ مدير وحدة أمن أبو حمد', 94)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (31, N'السيد/ ركن سلاح الاسلحة أ.س', 34)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (32, N'السيد/ قائد الفرقة 101 مشاة أ.س', 34)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (33, N'السيد/ مدير الفرقة 101 مشاة عمليات', 34)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (34, N'السيد/ مدير جهاز الامن ولاية البحر الاحمر', 34)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (35, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 111)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (36, N'السيد/ قائد سلاح المدفعية عطبرة / أ0س', 111)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (37, N'السيد/ مدير شرطة ولاية نهر النيل', 111)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (38, N'السيد/ مدير وحدة أمن جبل جاري', 111)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (39, N'السيد/ دير جهاز الأمن و المخابرات الوطني', 111)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (40, N'السيد/ مدير شرطة ولاية البحر الاحمر', 34)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (41, N'السيد/ ركن أس سلاح الالسحة والذخائر', 98)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (42, N'السيد/ قائد الفرقة الثالتة مشاة عمليات', 98)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (43, N'السيد/ قائد الفرقة الثالة مشاه أ.س', 98)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (44, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 98)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (45, N'السيد/ مدير شرطة ولاية نهر النيل', 98)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (46, N'السيد/ مديرة وحدة أمن عطبرة', 98)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (47, N'السيد/ مدير شرطة ولاية نهر النيل', 116)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (48, N'السيد/ مدير وحدة أمن شندي', 116)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (49, N'السيد/ مفتش عام مفرقعات السودان', 75)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (50, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 75)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (51, N'السيد/ قائد الفرقة الثالثة مشاه عمليات', 116)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (52, N'السيد/ قائد الفرقة الثالثة مشاه أ0س', 116)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (53, N'السيد/ قائد الفرقة الرابعة مشاة عمليات', 75)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (54, N'السيد/ قائد الفرقة الرابعة مشاة أ.س', 75)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (55, N'السيد/ مدير شرطة ولاية النيل الازرق', 75)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (56, N'السيد/ مدير وحدة أمن ولاية النيل الازرق', 75)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (57, N'السيد/ قائد سلاح الاسلحة أ.س', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (58, N'السيد/ قائد الفرقة 19 أ.س', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (59, N'السيد/ قائد الفرقة 19 عمليات', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (60, N'السيد/ مدير وحدة امن مروي', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (61, N'السيد/ مدير شرطة مروي', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (62, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 54)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (63, N'السيد/ قائد الفرقة 19 مشاة عمليات', 54)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (64, N'السيد/ قائد الفرقة 19 مشاة أ.س', 54)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (65, N'السيد/ مدير شرطة الولاية الشمالية', 54)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (66, N'السيد/ وحدة امن دنقلا', 54)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (67, N'السيد/ ركن أ0س سلاح الأسلحة و الذخائر', 67)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (68, N'السيد/ قائد منطقة الفاو العسكرية عمليات', 67)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (69, N'السيد/ قائد منطقة الفاو العسكرية أ0س', 67)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (70, N'السيد/ مدير شرطة ولاية القضارف', 67)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (71, N'السيد/ مدير وحدة أمن القضارف', 67)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (72, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 126)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (73, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 126)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (74, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 126)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (75, N'السيد/ مدير وحدة امن عطبرة ', 126)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (76, N'السيد/ مدير شرطة ولاية نهر النيل', 126)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (77, N'السيد/ مدير ادارة العمليات البرية', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (78, N'السيد/ مدير ادارة الاستخبارات البرية', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (79, N'السيد/ مدير ادارة الامن الوقائي', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (80, N'السيد/ قائد المنطقة العسكرية المركزية', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (81, N'السيد/ مدير الادارة العامة للادلة الجنائية', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (82, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (83, N'السيد/ قائد منطقة بحري العسكرية أ.س', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (84, N'السيد/ مدير شرطة ولاية الجزيرة', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (85, N'السيد/ قائد الفرقة الاولي مشاة عمليات', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (86, N'السيد/ قائد الفرقة الثانية أ.س', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (87, N'السيد/ قائد الفرقة الثالثة عمليات', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (88, N'السيد/ مدير شرطة ولاية القضارف ', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (89, N'السيد/ مدير وحدة امن القضارف', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (90, N'السيد/ مدير شركة رويال نوبيان قولد', 68)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (91, N'السيد/ قائد سلاح المدفعية / عمليات', 83)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (92, N'السيد/ قائد سلاح المدفعية أ.س', 83)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (93, N'السيد/ ركن أ.س سلاح الاسلحة', 83)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (94, N'السيد/ مدير شرطة ولاية نهر النيل', 83)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (95, N'السيد/ وحدة امن عطبرة', 83)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (97, N'السيد/ قائد الفرقة 16 مشاة / أ.س', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (99, N'السيد/ قائد الفرقة 16 مشاة / عمليات', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (101, N'السيد/ مدير جهاز الامن الوطني', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (103, N'السيد/ مدير عام قوات الشرطة', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (105, N'السيد/ مدير المباحث الجنائية الاتحادية', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (107, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (109, N'السيد/ مدير وحدة امن نيالا', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (111, N'السيد/ مدير شرطة نيالا', 79)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (112, N'السيد/ ركن أ0س سلاح الأسلحة', 73)
GO
print 'Processed 100 total records'
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (113, N'السيد/ قائد الفرقة 18 مشاة عمليات', 73)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (114, N'السيد/ قائد الفرقة 18 مشاة أ.س', 73)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (115, N'السيد/ مدير شرطة ولاية النيل الأبيض', 73)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (116, N'السيد/ مدير وحدة أمن ربك', 73)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (117, N'السيد/ قائد الفرقة 101 مشاه عمليات', 6)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (118, N'السيد/ قائد الفرقة 101 مشاه أ0س', 6)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (119, N'السيد/ مدير شرطة ولاية البحر الأحمر', 6)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (120, N'السيد/ مدير وحدة أمن دورديب', 6)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (121, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 31)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (122, N'السيد/ قائد الفرقة 101 مشاة عمليات', 31)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (123, N'السيد/ قائد الفرقة 101 مشاة أ.س', 31)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (124, N'السيد/ مدير جهاز الامن ولاية البحر الاحمر', 31)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (125, N'السيد/ مدير شرطة ولاية البحر الاحمر', 31)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (126, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 63)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (127, N'السيد/ قائد الفرقة الثانية مشاه عمليات', 63)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (128, N'السيد/ قائد الفرقة الثانية مشاه أ.س', 63)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (129, N'السيد/ مدير شرطة ولاية القضارف', 63)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (130, N'السيد/ مدير وحدة أمن القضارف', 63)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (131, N'السيد/ مدير ادارة العمليات البرية', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (132, N'السيد/ مدير ادارة الاستخبارات العسكرية', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (133, N'السيد/ مدير الامن الوقائي', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (134, N'السيد/ قائد المنطقة العسكرية المركزية', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (135, N'السيد/ مدير ادارة الادلة الجنائية', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (136, N'السيد/ قائد منطقة بحري العسكرية', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (137, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (138, N'السيد/ قائد الفرقة الاولي مشاة أ.س', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (139, N'السيد/ قائد الفرقة الاولي مشاة عمليات', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (140, N'السيد/ مدير شرطة ولاية سنار', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (141, N'السيد/ مدير وحدة امن سنار', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (142, N'السيد/ قائد الفرقة 17 مشاة عمليات', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (143, N'السيد/ ركن ا.س الفرقة 17 مشاة', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (144, N'السيد/ قائد الفرقة الرابعة مشاة أ.س', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (145, N'السيد/ مدير شرطة ولاية النيل الازرق', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (146, N'السيد/ مدير وحدة أمن الدمازين', 71)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (147, N'السيد/ ركن ازس سلاح الاسلحة والذخائر', 99)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (148, N'السيد/ قائد الفرقة الثالثة مشاة عمليات', 99)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (149, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 99)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (150, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 99)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (151, N'السيد/ مدير شرطة ولاية نهر النيل', 99)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (152, N'السيد/ وحدة امن ابوحمد', 99)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (153, N'السيد/ ركن أ0س سلاح الأسلحة و الذخائر', 95)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (154, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 95)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (155, N'السيد/ قائد سلاح المدفعية عطبرة أ0س', 95)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (156, N'السيد/ مدير شرطة أبو حمد', 95)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (157, N'السيد/ مدير وحدة أمن أبو حمد', 95)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (158, N'السيد/ ركن أ0س سلاح الأسلحة و الذخائر', 96)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (159, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 96)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (160, N'السيد/ قائد سلاح المدفعية عطبرة أ0س', 96)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (161, N'السيد/ مدير شرطة أبو حمد', 96)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (162, N'السيد/ مدير وحدة أمن أبو حمد', 96)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (163, N'السيد/ ركن سلاح الاسلحة أ.س', 35)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (164, N'السيد/ قائد الفرقة 101 مشاة أ.س', 35)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (165, N'السيد/ مدير الفرقة 101 مشاة عمليات', 35)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (166, N'السيد/ مدير جهاز الامن ولاية البحر الاحمر', 35)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (167, N'السيد/ مدير شرطة هيا', 35)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (168, N'السيد/ مدير وحدة أمن هيا', 35)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (169, N'السيد/ ركن ا.س سلاح الاسلحة ', 53)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (170, N'السيد/ قائد الفرقة 19مشاة عمليات', 53)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (171, N'السيد/ قائد اللواء 75 مشاه', 53)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (178, N'السيد/ قائد الفرقة 101 مشاه / عمليات', 5)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (179, N'السيد/ قائد الفرقة 101 مشاه / أ0س', 5)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (184, N'السيد/ مدير شرطة نيالا', 78)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (185, N'السيد/ مدير وحدة أمن نيالا', 78)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (186, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 78)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (187, N'السيد/ مدير شرطة الولاية الشمالية', 53)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (188, N'السيد/ ركن عمليات الفرقة 16 مشاة', 78)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (189, N'السيد/ ركن أ.س الفرقة 16 مشاة', 78)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (190, N'السيد/ مدير وحدة امن دلقو', 53)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (191, N'السيد/ مدير شرطة ولاية البحر الحمر', 5)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (192, N'السيد/ مدير وحدة أمن جبيت المعادن ', 5)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (193, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 5)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (194, N'السيد/ قائد الفرقة 101 مشاة عمليات', 27)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (195, N'السيد/ قائد الفرقة 101 مشاة أ.س', 27)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (196, N'السيد/ مدير شرطة ولاية البحر الاحمر', 27)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (197, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 27)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (198, N'السيد/ مدير وحدة امن ولاية البحر الاحمر', 27)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (199, N'السيد/ قائد الفرقة 101 مشاة عمليات', 36)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (200, N'السيد/ قائد الفرقة 101 مشاة أ.س', 36)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (201, N'السيد/ مدير شرطة البحر الاحمر ', 36)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (202, N'السيد/ مدير وحدة امن هيا', 36)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (203, N'السيد/ ركن سلاح الاسلحة أ.س', 36)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (204, N'السيد/ قائد الفرقة الثانية مشاه / عمليات', 62)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (205, N'السيد/ قائد الفرقة الثانية مشاه / أ0س', 62)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (206, N'السيد/ مدير شرطة ولاية القضارف', 62)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (207, N'السيد/ مدير وحدة أمن القضارف', 62)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (208, N'السيد/ ركن أ0س سلاح الأسلحة و الذخائر', 62)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (209, N'السيد/ قائد الفرقة الثانية مشاة /عمليات', 65)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (210, N'السيد/ قائد الفرقة الثانية مشاة /أ.س', 65)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (211, N'السيد/ مدير شرطة ولاية القضارف', 65)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (212, N'السيد/ وحدة امن ولاية القضارف', 65)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (213, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 65)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (214, N'السيد/ ركن سلاح الأسلحة والذخائر أ.س', 109)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (215, N'السيد/ قائد سلاح المدفعية أ.س', 109)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (216, N'السيد/ قائد سلاح المدفعية / عمليات', 109)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (217, N'السيد/ قائد سلاح المدفعية عطبرة', 115)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (218, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 115)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (219, N'السيد/ مدير شرطة ولاية نهر النيل', 115)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (220, N'السيد/ وحدة أمن بربر', 115)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (221, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 115)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (222, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 97)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (223, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 97)
GO
print 'Processed 200 total records'
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (224, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 97)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (225, N'السيد/ مدير شرطة ولاية نهر النيل', 97)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (226, N'السيد/ مدير وحدة امن عطبرة', 97)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (231, N'السيد/ قائد سلاح المدفعية عمليات', 122)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (232, N'السيد/ قائد سلاح المدفعية أ.س', 122)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (233, N'السيد/ مدير شرطة ولاية نهر النيل', 122)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (234, N'السيد/ وحدة امن ابوحمد', 122)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (235, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 122)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (236, N'السيد/ قائد سلاح المدفعية عمليات', 123)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (237, N'السيد/ قائد سلاح المدفعية أ.س', 123)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (238, N'السيد/ مدير شرطة ولاية نهر النيل', 123)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (239, N'السيد/ وحدة امن ابوحمد', 123)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (240, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 123)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (241, N'السيد/ قائد سلاح المدفعية عمليات', 124)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (242, N'السيد/ قائد سلاح المدفعية أ.س', 124)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (243, N'السيد/ مدير شرطة ولاية نهر النيل', 124)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (244, N'السيد/ وحدة امن ابوحمد', 124)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (245, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 124)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (246, N'السيد/ قائد سلاح المدفعية عمليات', 125)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (247, N'السيد/ قائد سلاح المدفعية أ.س', 125)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (248, N'السيد/ مدير شرطة ولاية نهر النيل', 125)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (249, N'السيد/ وحدة امن ابوحمد', 125)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (250, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 125)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (251, N'السيد/ قائد الفرقة 101مشاة عمليات', 21)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (252, N'السيد/ قائد الفرقة 101مشاة أ.س', 21)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (253, N'السيد/ مدير شرطة ولاية البحر الاحمر', 21)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (254, N'السيد/ مدير وحدة امن ولاية البحر الاحمر', 21)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (255, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 21)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (256, N'السيد/ قائد الفرقة 19 مشاة عمليات', 60)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (257, N'السيد/ قائد الفرقة 19 مشاة ا.س', 60)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (258, N'السيد/ مدير شرظة الولاية الشمالية', 60)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (259, N'السيد/ مدير شرطة دلقو', 60)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (260, N'السيد/ وحدة امن دلقو', 60)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (261, N'السيد/ ركن ا.س سلاح الاسلحة', 60)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (262, N'السيد/ مدير شرطة ولاية البحر الاحمر ', 25)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (263, N'السيد/ مدير وحدة امن ولاية البحر الاحمر', 25)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (264, N'السيد/ ركن ا.س سلاح الاسلحة', 25)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (265, N'السيد/ قائد الفرثقة 101مشاة عمليات', 28)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (266, N'السيد/ قائد الفرثقة 101مشاة ا.س', 28)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (267, N'السيد/ قائد الفرقة101مشاة عمليات', 25)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (268, N'السيد/ قائد الفرقة101مشاة ا.س', 25)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (269, N'السيد/ مدير شرطة ولاية البحر الاحمر', 28)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (270, N'السيد/ مدير وحدة امن ولاية البحر الاحمر', 28)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (271, N'السيد/ ركن ا.س سلاح الاسلحة', 28)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (272, N'السيد/ قائد منطقة الخرطوم العسكرية أ.س', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (273, N'السيد/ مدير شرطة ولاية الخرطوم', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (274, N'السيد/ مدير وحدة امن ولاية الخرطوم', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (275, N'السيد/ قائد الفرقة  الاولي مشاة عمليات', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (276, N'السيد/ قائد الفرقة  الاولي مشاة ا.س', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (277, N'السيد/ مدير شرطة ولاية الجزيرة', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (278, N'السيد/ مدير وحدة امن ولاية الجزيرة', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (279, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 46)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (285, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 107)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (286, N'السيد/ قائد سلاح المدفعية عطبرة ا.س', 107)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (287, N'السيد/ مدير شرطة ولاية نهر النيل', 107)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (288, N'السيد/ مدير شرط ابوحمد', 107)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (289, N'السيد/ وحدة امن ابوحمد', 107)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (290, N'السيد/ ركن ا.س سلاح الاسلحة ', 107)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (291, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 66)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (292, N'السيد/ قائد الفرقة الثانية عمليات', 66)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (293, N'السيد/ قائد الفرقة الثانية عمليات أ.س', 66)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (294, N'السيد/ مدير شرطة القضارف', 66)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (295, N'السيد/ وحدة امن القضارف', 66)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (296, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 16)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (297, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 85)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (298, N'السيد/ قائد الفرقة الاولي مشاة أ.س', 85)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (299, N'السيد/ قائد الفرقة 17 مشاة عمليات', 85)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (300, N'السيد/ قائد الفرقة 17 مشاة أ.س', 85)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (301, N'السيد/ مدير شرطة ولاية سنار', 85)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (302, N'السيد/ مدير وحدة أمن سنار', 85)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (303, N'السيد/ قائد الفرقة 101 مشاة عمليات', 16)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (304, N'السيد/ قائد الفرقة 101 مشاة أ.س', 16)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (305, N'السيد/ مدير شرطة البحر الاحمر', 16)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (306, N'السيد/ مدير جهاز الامن ولاية البحر الاحمر', 16)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (307, N'السيد/ ركن أ.س سلاح الاسلحة الذخائر', 120)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (308, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 120)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (309, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 120)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (310, N'السيد/ مدير شرطة ابوحمد', 120)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (311, N'السيد/ مدير وحدة امن ابوحمد', 120)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (312, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 61)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (313, N'السيد/ قائد الفرقة19 مشاة عمليات', 61)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (314, N'السيد/ قائد الفرقة19 مشاة أ.س', 61)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (315, N'السيد/ مدير شرطة دنقلا', 61)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (316, N'السيد/ مدير وحدة امن دنقلا', 61)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (317, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 127)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (318, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 127)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (319, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 127)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (320, N'السيد/ مدير شرطة ولاية نهر النيل', 127)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (321, N'السيد/ وحدة امن ولاية نهر النيل', 127)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (322, N'السيد/ مدير شرطة ابوحمد', 127)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (323, N'السيد/ وحدة امن ابوحمد', 127)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (324, N'السيد/ قائد منطقة بحري العسكرية أ.س', 43)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (325, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 43)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (326, N'السيد/ مدير شرطة السليت', 43)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (327, N'السيد/ مدير شرطة ولاية الخرطوم', 43)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (333, N'السيد/ مدير شرطة كريمة', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (334, N'السيد/ مدير وحدة أمن كريمة', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (335, N'السيد/ مدير شركة أوميستو للتعدين المحدودة', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (336, N'السيد/ مدير وحدة أمن عطبرة', 118)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (337, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 118)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (338, N'السيد/ قائد سلاح المدفعية / عمليات', 118)
GO
print 'Processed 300 total records'
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (339, N'السيد/ ركن عمليات الفرقة 19 مشاه', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (340, N'السيد/ ركن أ0س الفرقة 19 مشاه', 56)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (342, N'السيد/ قائد سلاح المدفعية / أ.س', 118)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (343, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 113)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (344, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 113)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (345, N'السيد/ قائد سلاح المدفعيةعطبرة أ.س', 113)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (346, N'السيد/ مدير ادارة العمليات البرية', 113)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (347, N'السيد/ مدير شرطة عطبرة', 113)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (348, N'السيد/ مدير وحدة امن عطبرة', 113)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (349, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 93)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (350, N'السيد/ قائد اللواء 41 عمليات', 93)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (351, N'السيد/ قائد اللواء 41 مشاة أ.س', 93)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (352, N'السيد/ ركن سلاح الأسلحة والذخائر أ.س', 24)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (353, N'السيد/ قائد الفرقة 101 مشاة عمليات ', 24)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (354, N'السيد/ قائد الفرقة 101 مشاة أ.س', 24)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (355, N'السيد/ مدير شرطة ولاية البحر الأحمر', 24)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (356, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر', 24)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (357, N'السيد/ قائد الفرقة 101 مشاة عمليات', 20)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (358, N'السيد/ قائد الفرقة 101 مشاة أ0س', 20)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (359, N'السيد/ مدير شرطة ولاية البحر الأحمر', 20)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (360, N'السيد/ مدير وحدة امن ولاية البحر الاحمر', 20)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (361, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 20)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (362, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 70)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (363, N'السيد/ قائد الفرقة الرابعة مشاة أ.س', 70)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (364, N'السيد/ مدير شرطة ولاية النيل الازرق', 70)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (365, N'السيد/ مدير وحدة أمن الدمازين', 70)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (366, N'السيد/ الشركة السودانية للموارد المعدنية', 70)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (367, N'السيد/ قائد المدفعية مشاة عطبرة أ.س', 105)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (368, N'السيد/ مدير شرطة ولاية نهر النيل', 105)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (369, N'السيد/ وحدة امن ولاية نهر النيل', 105)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (370, N'السيد/ ركن أ0س سلاح الاسلحة والذخائر ', 72)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (371, N'السيد/ قائد الفرقة 18 مشاة أ0س', 72)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (372, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 105)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (373, N'السيد/ قائد المدفعية مشاة عطبرة عمليات ', 105)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (374, N'السيد/ قائد الفرقة 18 عمليات ', 72)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (375, N'السيد/ مدير شرطة ولاية النيل الابيض', 72)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (376, N'السيد/ قائد حامية الروات ', 72)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (377, N'السيد/ مدير شرطة الروات ', 72)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (378, N'السيد/ مدير وحدة امن الروات ', 72)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (379, N'السيد/ قائد سلاح المدفعية عطبرة / أ.س', 102)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (380, N'السيد/ مدير شرطة ولاية نهر النيل', 102)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (381, N'السيد/ مدير وحدة أمن عطبرة', 102)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (382, N'السيد/ قائد سلاح الاسلحة والذخائر ا.س ', 58)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (383, N'السيد/ قائد الفرقة 19 عمليات', 58)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (384, N'السيد/ قائد الفرقة 19 أ.س', 58)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (385, N'السيد/ مدير وحدة امن دلقو', 58)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (386, N'السيد/ مدير شرطة دلقو', 58)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (387, N'السيد/ مدير شركة الحاجاب للتعدين المحدودة ', 58)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (388, N'السيد/ قائد سلاح الاسلحة والذخائر ا.س ', 102)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (389, N'السيد/ قائد سلاح المدفعية / عمليات', 102)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (390, N'السيد/ ركن  سلاح الأسلحة والذخائر  أ.س', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (391, N'السيد/ قائد الفرقة 101 مشاة أ.س', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (392, N'السيد/ قائد الفرقة 101 مشاة عمليات', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (393, N'السيد/ مدير شرطة البحر الاحمر', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (394, N'السيد/ مدير جهاز الأمن ولاية البحر الأحمر', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (395, N'السيد/ مدير شرطة درديب ', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (396, N'السيد/ مدير وحدة امن درديب ', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (397, N'السيد/ مدير محجر ابو العباس ', 8)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (398, N'السيد/ مفتش عام مفرقعات السودان', 29)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (399, N'السيد/ ركن أ. سلاح الاسلحة والذخائر', 29)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (400, N'السيد/ قائد الفرقة 101 مشاة عمليات', 29)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (401, N'السيد/ قائد الفرقة 101 مشاة أ.س', 29)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (402, N'السيد/ مدير جهاز الامن ولاية البحر الاحمر', 29)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (403, N'السيد/ مدير شرطة ولاية البحر الاحمر', 29)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (404, N'السيد/ مدير السودانية للموارد المعدنية', 29)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (405, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 104)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (406, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 104)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (407, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 104)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (408, N'السيد/ مدير شرطة ولاية نهر النيل', 104)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (409, N'السيد/ وحدة امن ولاية نهر النيل', 104)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (410, N'السيد/ مدير شرطة ابوحمد', 104)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (411, N'السيد/ وحدة امن ابوحمد', 104)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (412, N'السيد/ قائد الفرقة الثالة مشاه أ.س', 112)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (413, N'السيد/ مدير شرطة نهر النيل', 112)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (414, N'السيد/ مدير شرطة العوتيب', 112)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (415, N'السيد/ مدير وحدة امن العوتيب', 112)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (416, N'السيد/ ركن  أ.س سلاح الاسلحة والذخائر', 112)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (417, N'السيد/ قائد الفرقة 101 عمليات', 2)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (418, N'السيد/ قائد الفرقة 101 أ.س', 2)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (419, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر', 2)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (420, N'السيد/ مدير شرطة ولاية البحر الأحمر', 2)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (421, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 2)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (422, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 86)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (423, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 86)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (424, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 86)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (425, N'السيد/ قائد منطقة امدرمان أ.س', 86)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (426, N'السيد/ مدير شرطة ولاية شمال كردفان', 86)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (427, N'السيد/ وحدة امن بارا', 86)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (428, N'السيد/ مدير ادارة العمليات برية ', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (429, N'السيد/ مدير ادارة الامن الوقائي', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (430, N'السيد/ مدير عام قوات الشرطة', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (431, N'السيد/ مدير عام هيئة الامن والمخابرات ', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (432, N'السيد/ قائد سلاح الاسلحة ا.س', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (433, N'السيد/ قائد منطقة هجليج ا.س', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (434, N'السيد/ قائد منطقة هجليج عمليات ', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (435, N'السيد/ مدير جهاز الامن والمخابرات هجليج', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (436, N'السيد/ مدير شركة تارقت للانشطة المتعددة ', 91)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (437, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 82)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (438, N'السيد/ قائد منطقة امدرمان أ.س', 82)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (439, N'السيد/ مدير شرطة ولاية شمال كردفان', 82)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (440, N'السيد/ وحدة امن بارا', 82)
GO
print 'Processed 400 total records'
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (441, N'السيد/ الشركة السودانية للموارد المعدنية', 82)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (442, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 87)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (443, N'السيد/ قائد منطقة امدرمان أ.س', 87)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (444, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 82)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (445, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 82)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (446, N'السيد/ مدير شرطة ولاية شمال كردفان', 87)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (447, N'السيد/ وحدة امن بارا', 87)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (448, N'السيد/ الشركة السودانية للموارد المعدنية', 87)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (449, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 87)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (450, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 87)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (451, N'السيد/ قائد الفرقة 101 مشاة / عمليات ', 26)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (452, N'السيد/ قائد الفرقة 101 مشاة أ.س', 26)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (453, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 26)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (454, N'السيد/ مدير شرطة ولاية البحر الأحمر', 26)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (455, N'السيد/ مدير وحدة أمن جبيت ', 26)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (456, N'السيد/ قائد الفرقة الثالثة مشاة عمليات', 112)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (457, N'السيد/ قائد الفرقة 18 مشاه', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (458, N'السيد/ الفرقة 18 مشاة أ.س', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (459, N'السيد/ الفرقة 18 مشاة عمليات', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (460, N'السيد/ قائد الفرقة الخامسة مشاة ', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (461, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (462, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (463, N'السيد/ مدير شرطة غرب كردفان', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (464, N'السيد/ قائد حامية الفولة', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (465, N'السيد/ مدير أمن الفولة', 89)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (466, N'السيد/ مدير شرطة محلية سوبا', 40)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (467, N'السيد/ الشركة السودانية للموارد المعدنية', 40)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (468, N'السيد/ ركن أس سلاح الاسلحة والذخائر', 40)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (469, N'السيد/ قائد الحرس الجمهوري أ.س', 40)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (475, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 57)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (476, N'السيد/ قائد الفرقة 19 مشاة عمليات', 57)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (477, N'السيد/ قائد الفرقة 19 مشاة / أ.س', 57)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (478, N'السيد/ مدير ادارة العمليات برية', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (479, N'السيد/ مدير ادارة الامن الوقائي ', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (480, N'السيد/ مدير شرطة مروي', 57)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (481, N'السيد/ مدير وحدة أمن مروي', 57)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (482, N'السيد/ مدير عام قوات الشرظة ', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (483, N'السيد/ مدير عام هيئة الامن والمخابرات ', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (484, N'السيد/ قائد سلاح الاسلحة أ.س', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (485, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (486, N'السيد/ قائد الفرقة الخامسة مشاة ', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (487, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (488, N'السيد/ مدير شرطة غرب كردفان', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (489, N'السيد/ قائد حامية الفولة', 88)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (490, N'السيد/ قائد سلاح المدفعية عطبره عمليات', 114)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (491, N'السيد/ قائد سلاح المدفعيه عطبره أ س', 114)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (492, N'السيد/ مدير شرطة ولاية نهر النيل', 114)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (493, N'السيد/ مدير وحدة امن عطبرة', 114)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (494, N'السيد/ ركن سلاح الاسلحة والذخائر أ س', 114)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (495, N'السيد/ قائد الفرقة 19 مشاة عمليات', 48)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (496, N'السيد/ قائد الفرقة 19 مشاة أ.س', 48)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (497, N'السيد/ ركن أ. س سلاح الأسلحة والذخائر', 48)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (498, N'السيد/ مدير شرطة وادي حلفا', 48)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (499, N'السيد/ مدير وحدة أمن وادي حلفا', 48)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (501, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 103)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (502, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 103)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (503, N'السيد/ قائد سلاح المدفعية عطبرة / أ.س', 103)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (504, N'السيد/ مدير شرطة ولاية نهر النيل', 103)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (505, N'السيد/ مدير وحدة أمن عطبرة', 103)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (506, N'السيد/ ركن  سلاح الأسلحة والذخائر  أ.س', 108)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (507, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 108)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (508, N'السيد/ قائد سلاح المدفعية عطبرة / أ0س', 108)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (509, N'السيد/ مدير وحدة امن عطبرة', 108)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (510, N'السيد/ مدير شرطة ولاية نهر النيل', 108)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (511, N'السيد/ مدير ادارة الامن الوقائي', 108)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (518, N'السيد/ مدير شرطة الولاية الشمالية', 59)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (519, N'السيد/ مدير وحدة امن كريمة', 59)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (520, N'السيد/ ركن ا.س سلاح الاسلحة الذخائر', 59)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (521, N'السيد/ قائد الفرقة 19 مشاة عمليات', 59)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (522, N'السيد/ قائد الفرقة 19 مشاة أ.س', 59)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (523, N'السيد/ ركن سلاح الأسلحة والذخائر أ.س', 119)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (524, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 119)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (525, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 119)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (526, N'السيد/ مدير شرطة ولاية نهر النيل ', 119)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (527, N'السيد/ مدير وحدة أمن ولاية نهر النيل', 119)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (528, N'السيد/ قائد الفرقة 101 مشاة عمليات', 11)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (529, N'السيد/ قائد الفرقة 101 مشاة أ.س', 11)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (530, N'السيد/ مدير شرطة ولاية البحر الأحمر', 11)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (531, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر', 11)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (537, N'السيد/ قائد الفرقة 101مشاة عمليات', 18)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (538, N'السيد/ قائد الفرقة 101مشاة أ.س', 18)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (539, N'السيد/ مدير شرطة ولاية البحر الاحمر', 18)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (540, N'السيد/ مدير وحدة امن ولاية البحر الاحمر', 18)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (541, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 18)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (542, N'السيد/ ركن  سلاح الأسلحة والذخائر  أ.س', 50)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (543, N'السيد/ قائد الفرقة 19 مشاة عمليات', 50)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (544, N'السيد/ قائد الفرقة 19 مشاة أ.س', 50)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (545, N'السيد/ مدير شرطة الولاية الشمالية', 50)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (546, N'السيد/ مدير وحدة أمن الولاية الشمالية', 50)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (547, N'السيد/ مدير ادارة العمليات البرية', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (548, N'السيد/ مدير ادارة الاستخبارات البرية', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (549, N'السيد/ مدير الامن الوقائي', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (550, N'السيد/ قائد المنطقة العسكرية المركزية', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (551, N'السيد/ مدير الادارة العامة للادلة الجنائية', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (552, N'السيد/ قائد منطقة بحري العسكرية أ.س', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (553, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (554, N'السيد/ قائد الفرقة الاولي مشاة أ.س', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (555, N'السيد/ مدير شرطة سنار', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (556, N'السيد/ وحدة امن سنار', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (557, N'السيد/ ركن عمليات الفرقة 17 عمليات', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (558, N'السيد/ ركن أ.س الفرقة 17 مشاة', 74)
GO
print 'Processed 500 total records'
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (559, N'السيد/ قائد الفرقة الرابعة أ.س', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (560, N'السيد/ مدير شرطة الدمازين', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (561, N'السيد/ وحدة امن الدمازين', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (562, N'السيد/ الشركة السودانية للموارد المعدنية', 74)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (563, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 121)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (564, N'السيد/ مدير وحدة امن عطبرة', 121)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (565, N'السيد/ مدير شرطة ولاية نهر النيل', 121)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (571, N'السيد/ قائد سلاح المدفعية عمليات', 121)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (572, N'السيد/ ركن  أ.س سلاح الاسلحة والذخائر', 121)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (577, N'السيد/ قائد الفرقة 101 مشاه / عمليات', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (578, N'السيد/ قائد الفرقة 101 مشاه / أ0س', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (579, N'السيد/ مدير شرطة ولاية البحر الحمر', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (580, N'السيد/ مدير وحدة امن ولاية البحر الاحمر', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (581, N'السيد/ قائد الفرقة 19 عمليات', 52)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (582, N'السيد/ قاد الفرقة 19 أ.س', 52)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (583, N'السيد/ مدير شرطة الولاية الشمالية', 52)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (584, N'السيد/ مدير وحدة امن الولاية الشمالية', 52)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (585, N'السيد/ ركن استخبارات سلاح الاسلحة', 52)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (586, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 110)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (587, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 110)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (588, N'السيد/ مدير شرطة ولاية نهر النيل', 110)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (589, N'السيد/ مدير وحدة أمن ولاية نهر النيل', 110)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (590, N'السيد/ مدير شرطة ولاية البحر الاحمر', 15)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (591, N'السيد/ مدير وحدة امن جبيت', 15)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (592, N'السيد/ ركن سلاح الاسلحة ا.س', 15)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (593, N'السيد/ ركن سلاح الأسلحة والذخائر أ.س', 110)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (594, N'السيد/ قائد الفرقة 101مشاة عمليات', 15)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (595, N'السيد/ قائد الفرقة 101مشاة ا.س', 15)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (596, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 100)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (597, N'السيد/ مدير شرطة ولاية نهر النيل', 100)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (598, N'السيد/ وحدة امن بربر', 100)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (599, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 100)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (600, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 100)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (611, N'السيد/ مدير جهاز الامن ولاية جنوب دارفور', 77)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (612, N'السيد/ مدير شرطة نيالا', 77)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (613, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 77)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (614, N'السيد/ قائد الفرقة 101 مشاة عمليات', 33)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (615, N'السيد/ قائد الفرقة 101 مشاة ا.س', 33)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (616, N'السيد/ قائد الفرقة 16 مشاة عمليات', 77)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (617, N'السيد/ قائد الفرقة 16 مشاة أ.س', 77)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (618, N'السيد/ مدير شرطة ولاية البحر الاحمر', 33)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (619, N'السيد/ مدير وحدة امن جبيت', 33)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (620, N'السيد/ ركن  سلاح الأسلحة والذخائر  أ.س', 106)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (621, N'السيد/ قائد سلاح المدفعية / عمليات', 106)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (622, N'السيد/ قائد سلاح المدفعية عطبرة ا.س', 106)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (623, N'السيد/ مدير شرطة ولاية نهر النيل', 106)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (624, N'السيد/ مدير وحدة أمن عطبرة', 106)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (625, N'السيد/ مدير محجر الهديل ', 106)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (631, N'السيد/ مدير شرطة ولاية الخرطوم', 45)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (632, N'السيد/ مدير وحدة امن قري', 45)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (633, N'السيد/ قائد منطقة بحري العسكرية', 45)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (634, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 45)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (635, N'السيد/ قائد الفرقة 101 مشاة عمليات', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (636, N'السيد/ قائد الفرقة 101 مشاة أ.س', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (637, N'السيد/ مدير شرطة ولاية البحر الأحمر', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (638, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (639, N'السيد/ مدير الشركة السودانية للمعادن', 13)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (640, N'السيد/ قائد الفرقة 101 مشاة عمليات', 3)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (641, N'السيد/ قائد الفرقة 101 مشاة أ.س', 3)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (642, N'السيد/ مدير شرطة ولاية البحر الأحمر', 3)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (643, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر', 3)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (644, N'السيد/ ركن أ. س سلاح الأسلحة والذخائر', 22)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (645, N'السيد/ قائد الفرقة 101 مشاة عمليات', 22)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (646, N'السيد/ قائد الفرقة 101 مشاة أ.س', 22)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (647, N'السيد/ مدير شرطة ولاية البحر الأحمر', 22)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (648, N'السيد/ مدير جهاز الأمن ولاية البحر الأحمر', 22)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (649, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 101)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (650, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 101)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (651, N'السيد/ مدير شرطة ولاية نهر النيل', 109)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (652, N'السيد/ مدير امن ولاية نهر النيل', 109)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (653, N'السيد/ مدير شرطة ولاية نهر النيل', 101)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (654, N'السيد/ مدير وحدة امن عطبرة', 101)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (655, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 101)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (656, N'السيد/ مدير وحدة امن بربر', 109)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (657, N'السيد/ قائد الفرقة 19مشاة أ.س', 53)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (663, N'السيد/ قائد الفرقة الثانية مشاة عمليات', 69)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (664, N'السيد/ قائد الفرقة الثانية مشاة أ.س', 69)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (665, N'السيد/ مدير شرطة ولاية القضارف', 69)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (666, N'السيد/ مدير وحدة امن القضارف', 69)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (667, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 69)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (668, N'السيد/ قائد حامية بليلة عمليات', 90)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (669, N'السيد/ قائد حامية بليلة ا.س', 90)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (670, N'السيد/ مدير جهاز الامن والمخابرات بليلة', 90)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (671, N'السيد/ ركن اس سلاح الاسلحة والذخائر', 90)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (672, N'السيد/ قائد الفرقة الثانية مشاه عمليات', 64)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (673, N'السيد/ قائد الفرقة الثانية مشاه أ.س', 64)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (674, N'السيد/ مدير شرطة ولاية القضارف', 64)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (675, N'السيد/ مدير وحدة أمن القضارف', 64)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (676, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 64)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (677, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 47)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (678, N'السيد/ قائد الفرقة 19 مشاة عمليات', 47)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (679, N'السيد/ قائد الفرقة 19 مشاة أ.س', 47)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (680, N'السيد/ مدير شرطة الولاية الشمالية', 47)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (681, N'السيد/ مدير وحدة أمن دنقلا', 47)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (682, N'السيد/ قائد الفرقة 101مشاة عمليات', 37)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (683, N'السيد/ قائد الفرقة 101مشاة ا.س', 37)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (684, N'السيد/ مدير شرطة ولاية البحر الاحمر ', 37)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (685, N'السيد/ مدير وحدة امن جبيت المعادن', 37)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (686, N'السيد/ الشركة السودانية للموارد المعدنية', 37)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (687, N'السيد/ قائد الفرقة 101 مشاة عمليات', 9)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (688, N'السيد/ قائد الفرقة 101 مشاة أ.س', 9)
GO
print 'Processed 600 total records'
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (689, N'السيد/ مدير شرطة بورتسودان', 9)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (690, N'السيد/ مدير وحدة أمن جبيت', 9)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (691, N'السيد/ الشركة السودانية للموارد المعدنية', 9)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (697, N'السيد/ قائد الفرقة 101 مشاة عمليات', 19)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (698, N'السيد/ قائد الفرقة 101 مشاة أ.س', 19)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (699, N'السيد/ مدير شرطة ولاية البحر الاحمر', 19)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (700, N'السيد/ مدير وحدة امن البحر الاحمر', 19)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (701, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 19)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (706, N'السيد/ ركن سلاح الأسلحة والذخائر أ.س', 44)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (707, N'السيد/ قائد المنطقة العسكرية الخرطوم', 44)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (708, N'السيد/ مدير شرطة ولاية الخرطوم', 44)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (709, N'السيد/ مدير وحدة أمن ولاية الخرطوم', 44)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (710, N'السيد/ ركن سلاح الأسلحة والذخائر أ.س', 12)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (711, N'السيد/ قائد الفرقة 101 مشاة عمليات', 12)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (712, N'السيد/ قائ الفرقة 101 مشاة أ.س', 12)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (713, N'السيد/ مدير شرطة ولاية البحر الأحمر', 12)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (714, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر', 12)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (715, N'السيد/ قائد الفرقة 101 مشاة عمليات', 30)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (716, N'السيد/ قائد الفرقة 101 مشاة ا.س', 30)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (717, N'السيد/ مدير شرطة ولاية البحر الاحمر', 30)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (718, N'السيد/ مدير وحدة امن البحر الاحمر', 30)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (719, N'السيد/ ركن سلاح الأسلحة والذخائر أ س', 33)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (720, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 129)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (721, N'السيد/ قائد الفرقة 101 / أ.س', 129)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (722, N'السيد/ قائد الفرقة 101 / عمليات', 129)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (723, N'السيد/ مدير شرطة ولاية البحر الأحمر', 129)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (724, N'السيد/ قائد الفرقة 14 مشاه عمليات', 81)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (725, N'السيد/ قائد الفرقه 14 مشاه أ.س', 81)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (726, N'السيد/ قائد اللواء 53 مشاه عمليات', 81)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (727, N'السيد/ قائد اللواء 53 مشاه أ.س', 81)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (728, N'السيد/ مدير شرطة ولاية جنوب كردفان', 81)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (729, N'السيد/ مدير شرطة التضامن', 81)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (730, N'السيد/ مدير وحدة امن التضامن', 81)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (732, N'السيد/ قائد الفرقة 14 مشاه عمليات', 130)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (733, N'السيد/ قائد الفرقة 14 مشاه أ.س', 130)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (734, N'السيد/ قائد اللواء 53 مشاه', 130)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (735, N'السيد/ قائد اللواء 56 مشاه', 130)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (736, N'السيد/ مدير شرطة ولاية جنوب كردفان', 130)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (737, N'السيد/ مدير جهاز المخابرات العامة ولاية جنوب كردفان', 130)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (738, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 130)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (743, N'السيد/ قائد الفرقة 101 مشاة عمليات', 17)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (744, N'السيد/ قائد الفرقة 101 مشاة أ.س', 17)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (745, N'السيد/ مدير شرطة ولاية البحر الاحمر', 17)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (746, N'السيد/ وحدة امن ولاية البحر الاحمر', 17)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (747, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 17)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (748, N'السيد/ تجربة', 17)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (749, N'السيد/ ', 131)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (750, N'السيد/ مدير شرطة نيالا', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (751, N'السيد/ مدير وحدة امن نيالا', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (752, N'السيد/ قائد الفرقة 16 مشاة / أ.س', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (753, N'السيد/ قائد الفرقة 16 مشاة / عمليات', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (754, N'السيد/ مدير جهاز الامن الوطني', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (755, N'السيد/ مدير عام قوات الشرطة', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (756, N'السيد/ مدير المباحث الجنائية الاتحادية', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (757, N'السيد/ ركن سلاح الاسلحة والذخائر أ.س', 1)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (766, N'السيد/ a', 7)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (768, N'السيد/ fsds', 132)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (770, N'السيد/ احد', 0)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (771, N'السيد/ dsds', 133)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (772, N'السيد/ 2', 133)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (773, N'السيد/ قائد الفرقة 101 مشاة عمليات', 4)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (774, N'السيد/ قائد الفرقة 101 مشاة أ.س', 4)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (775, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر', 4)
INSERT [dbo].[WorkCopiesDetails] ([WorkCopySirsID], [Sirs], [WorkCopyID]) VALUES (776, N'السيد/ مدير شرطة ولاية البحر الأحمر', 4)
SET IDENTITY_INSERT [dbo].[WorkCopiesDetails] OFF
/****** Object:  Table [dbo].[WorkCopies1]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkCopies1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[sirs] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
 CONSTRAINT [PK_WorkCopies1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkCopies]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkCopies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
 CONSTRAINT [PK_WorkCopies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WorkCopies] ON
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (1, N'البحر الاحمر', N' الياسمين / الكليس')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (2, N'البحر الأحمر', N'أويو')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (3, N'البحر الأحمر', N'جبال نمر (العلاق)')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (4, N'البحر الأحمر', N'جبيت المعادن ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (5, N'البحر الأحمر', N'جبيت المعادن (ايت)')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (6, N'البحر الأحمر', N'دورديب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (7, N'البحر الأحمر', N'سنكات')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (8, N'البحر الأحمر', N'شاقروم ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (9, N'البحر الأحمر', N'شرق قبقبة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (11, N'البحر الأحمر', N'نصب الحصان ــ أم سرح')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (12, N'البحر الأحمر', N'وادي الدوم')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (13, N'البحر الأحمر', N'وادي العلاق/ جبال نمر')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (15, N'البحر الاحمر', N'ابير كاتيب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (16, N'البحر الاحمر', N'ارياب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (17, N'البحر الاحمر', N'الكليس / قرد')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (18, N'البحر الاحمر', N'جبال الانصاري')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (19, N'البحر الاحمر', N'جبال الياسمين')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (20, N'البحر الاحمر', N'جبال نمر')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (21, N'البحر الاحمر', N'جبال نمر/ العلاق')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (22, N'البحر الاحمر', N'جبل العلاق')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (23, N'البحر الاحمر', N'جبيت')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (24, N'البحر الاحمر', N'جبيت / جبال الهمسانا')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (25, N'البحر الاحمر', N'جبيت /وادي الدومة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (26, N'البحر الاحمر', N'جبيت المعادن / شنعاب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (27, N'البحر الاحمر', N'جبيت المعادن /شقر')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (28, N'البحر الاحمر', N'جبيت/ وادي الدومة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (29, N'البحر الاحمر', N'حلايب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (30, N'البحر الاحمر', N'خورايت')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (31, N'البحر الاحمر', N'سقوم')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (33, N'البحر الاحمر', N'نورايا')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (34, N'البحر الاحمر', N'هيا')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (35, N'البحر الاحمر', N'هيا / الياسمين / الكليس')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (36, N'البحر الاحمر', N'هيا جبل الزهتيب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (37, N'البحر الاحمر', N'وادي الطويل')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (40, N'الجزيرة', N'الباقير')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (43, N'الخرطوم', N'السليت')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (44, N'الخرطوم', N'المنطقة الصناعية')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (45, N'الخرطوم', N'قري')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (46, N'الخرطوم', N'مدني')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (47, N'الشمالية', N'البرقيق')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (48, N'الشمالية', N'الدويشات')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (50, N'الشمالية', N'جبل أبو غزالة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (52, N'الشمالية', N'جبل البوم الهمري')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (53, N'الشمالية', N'دلقو')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (54, N'الشمالية', N'دنقلا ابوصاري')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (55, N'الشمالية', N'عبري')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (56, N'الشمالية', N'كريمة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (57, N'الشمالية', N'كريمة / ابوحراز')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (58, N'الشمالية', N'كويا ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (59, N'الشمالية كريمة', N'النمر')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (60, N'الشمالية/ دلقو', N'جبل البوم ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (61, N'الشمالية/دنقلا', N'القعب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (62, N'القضارف', N' البطانة منطقة الصباغ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (63, N'القضارف', N'البريس')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (64, N'القضارف', N'البطانة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (65, N'القضارف', N'البطانة الصباع')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (66, N'القضارف', N'الشوك')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (67, N'القضارف', N'الفاو')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (68, N'القضارف', N'القضارف')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (69, N'القضارف', N'سمسم')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (70, N'النيل االازرق', N'باو')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (71, N'النيل االازرق', N'باو/ قادمية')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (72, N'النيل الأبيض', N'الروات')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (73, N'النيل الأبيض', N'ربك')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (74, N'النيل الازرق', N'الدمازين')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (75, N'النيل الازرق', N'جبل الرمه')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (77, N'جنوب دارفور', N'تور طعان')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (78, N'جنوب دارفور', N'محلية كأس')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (79, N'جنوب دارفور', N'نيالا')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (81, N'جنوب كردفان', N'التضامن')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (82, N'حجر العسل', N'جبل ودعيسي ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (83, N'حجر العسل', N'غرب عطبرة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (85, N'سنار', N'جبل موية')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (86, N'شمال كردفان', N'بارا')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (87, N'شمال كردفان', N'جبل ودعيسى')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (88, N'غرب كردفان', N'ابوجابرة ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (89, N'غرب كردفان', N'الفولة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (90, N'غرب كردفان', N'بليلة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (91, N'غرب كردفان', N'هجليج')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (92, N'كسلا', N'جبل مكرام وكلكلت')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (93, N'كسلا', N'كسلا')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (94, N'نهر النيل', N'أبو حمد')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (95, N'نهر النيل', N'أبو حمد/ المرات')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (96, N'نهر النيل', N'أبو حمد/ الياسمين')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (97, N'نهر النيل', N'ابو حراز')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (98, N'نهر النيل', N'ابوحمد .جبل المقدود')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (99, N'نهر النيل', N'ابوحمد /جبال اللوبي')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (100, N'نهر النيل', N'الحجاجية')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (101, N'نهر النيل', N'السويكتاب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (102, N'نهر النيل', N'الشباشية ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (103, N'نهر النيل', N'الشريك')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (104, N'نهر النيل ', N'الشريك /ام سرح')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (105, N'نهر النيل', N'العبيدية')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (106, N'نهر النيل', N'الكربة ')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (107, N'نهر النيل', N'ام سرح')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (108, N'نهر النيل', N'بربر')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (109, N'نهر النيل', N'بربر / ابو فصوص')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (110, N'نهر النيل', N'جبال اللوبي')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (111, N'نهر النيل', N'جبل جاري')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (112, N'نهر النيل', N'شندي / العوتيب')
GO
print 'Processed 100 total records'
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (113, N'نهر النيل', N'عطبرة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (114, N'نهر النيل', N'غرب الفاضلاب')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (115, N'نهر النيل', N'غرب بربر')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (116, N'نهر النيل', N'غرب شندي')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (118, N'نهر النيل', N'غرب عطبرة / أم الطيور')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (119, N'نهر النيل', N'قبقبة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (120, N'نهر النيل', N'قبقبة الجبل المقدود')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (121, N'نهر النيل', N'مربع 16 شمال النجيم')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (122, N'نهر النيل', N'نصب الحصان')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (123, N'نهر النيل', N'نصب الحصان./ك الرشايدة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (124, N'نهر النيل ', N'نصب الحصان/ الرشايدة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (125, N'نهر النيل ', N'نصب الحصان/ ماسورة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (126, N'نهر النيل ', N'وادي الكرمت')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (127, N'نهر النيل / ابوحمد', N'الشريك /ام سرح/ الكرو')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (129, N'البحر الأحمر', N'جبل المعقل')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (130, N'جنوب كردفان', N'الدلنج')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (131, N'البحر الاحمر', N'الياسمين / الكليس')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (132, N'sdsdsd', N'dsdsds')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (133, N'fdsafda', N'المعدلة')
INSERT [dbo].[WorkCopies] ([ID], [State], [Region]) VALUES (134, N'دبي', N'المطينة')
SET IDENTITY_INSERT [dbo].[WorkCopies] OFF
/****** Object:  Table [dbo].[WORKALLOWED]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKALLOWED](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SIDENAME] [nvarchar](50) NULL,
	[ADDRESS] [nvarchar](100) NULL,
	[TEL1] [nvarchar](15) NULL,
	[TEL2] [nvarchar](15) NULL,
	[TEL3] [nvarchar](15) NULL,
	[E_MAIL] [nvarchar](100) NULL,
	[FAX] [nvarchar](15) NULL,
	[POB] [nvarchar](20) NULL,
	[OTHER] [nvarchar](1000) NULL,
	[FDATE] [date] NULL,
	[SIGHT1] [nvarchar](50) NULL,
	[SIGHT2] [nvarchar](50) NULL,
	[OTHERSIGHTS] [nvarchar](1000) NULL,
	[OWNER] [nvarchar](100) NULL,
 CONSTRAINT [PK_WORKALLOWED] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WORKALLOWED] ON
INSERT [dbo].[WORKALLOWED] ([ID], [SIDENAME], [ADDRESS], [TEL1], [TEL2], [TEL3], [E_MAIL], [FAX], [POB], [OTHER], [FDATE], [SIGHT1], [SIGHT2], [OTHERSIGHTS], [OWNER]) VALUES (1, N'شركة هوادونق للتعدين والصناعة المحدودة', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'القعب', NULL, NULL, NULL)
INSERT [dbo].[WORKALLOWED] ([ID], [SIDENAME], [ADDRESS], [TEL1], [TEL2], [TEL3], [E_MAIL], [FAX], [POB], [OTHER], [FDATE], [SIGHT1], [SIGHT2], [OTHERSIGHTS], [OWNER]) VALUES (2, N'العليف للتعدين', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'نورايا', NULL, NULL, NULL)
INSERT [dbo].[WORKALLOWED] ([ID], [SIDENAME], [ADDRESS], [TEL1], [TEL2], [TEL3], [E_MAIL], [FAX], [POB], [OTHER], [FDATE], [SIGHT1], [SIGHT2], [OTHERSIGHTS], [OWNER]) VALUES (3, N'شركة نبتة للجيلوجيا والتعدين المحدودة', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'غرب عطبرة / أم الطيور', NULL, NULL, NULL)
INSERT [dbo].[WORKALLOWED] ([ID], [SIDENAME], [ADDRESS], [TEL1], [TEL2], [TEL3], [E_MAIL], [FAX], [POB], [OTHER], [FDATE], [SIGHT1], [SIGHT2], [OTHERSIGHTS], [OWNER]) VALUES (4, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'الياسمين / الكليس', NULL, NULL, NULL)
INSERT [dbo].[WORKALLOWED] ([ID], [SIDENAME], [ADDRESS], [TEL1], [TEL2], [TEL3], [E_MAIL], [FAX], [POB], [OTHER], [FDATE], [SIGHT1], [SIGHT2], [OTHERSIGHTS], [OWNER]) VALUES (5, N'شركة اليانس للتعدين', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'الدلنج', NULL, NULL, NULL)
INSERT [dbo].[WORKALLOWED] ([ID], [SIDENAME], [ADDRESS], [TEL1], [TEL2], [TEL3], [E_MAIL], [FAX], [POB], [OTHER], [FDATE], [SIGHT1], [SIGHT2], [OTHERSIGHTS], [OWNER]) VALUES (6, N'يسشيش', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'الدلنج', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[WORKALLOWED] OFF
/****** Object:  Table [dbo].[Townships]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Townships](
	[TownshipID] [int] IDENTITY(1,1) NOT NULL,
	[Township] [nvarchar](50) NULL,
	[StateID] [int] NULL,
 CONSTRAINT [PK_Townships] PRIMARY KEY CLUSTERED 
(
	[TownshipID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeamNo] [int] NULL,
	[Rank] [nvarchar](50) NULL,
	[Name] [nvarchar](150) NULL,
	[Unit] [nvarchar](50) NULL,
	[CommissionDate] [date] NULL,
	[BirthDate] [date] NULL,
	[Roots] [nvarchar](50) NULL,
	[SideName] [nvarchar](150) NULL,
	[WorkRegion] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](50) NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Security]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Security](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Rank] [nvarchar](50) NULL,
	[FullName] [nvarchar](100) NULL,
	[Unit] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Security] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Security] ON
INSERT [dbo].[Security] ([ID], [Username], [Password], [Rank], [FullName], [Unit], [Type]) VALUES (1, N'exp', N'123', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Security] OFF
/****** Object:  Table [dbo].[PermissionsCopies]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionsCopies](
	[PermissionsCopyID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionCopy] [nvarchar](500) NULL,
	[PermissionNameID] [int] NULL,
 CONSTRAINT [PK_PermissionsCopies] PRIMARY KEY CLUSTERED 
(
	[PermissionsCopyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISSIONS]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISSIONS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FID] [nvarchar](20) NULL,
	[PLACE] [nvarchar](20) NULL,
	[FDATE] [date] NULL,
	[LICENSEID] [nvarchar](20) NULL,
	[SENDER] [nvarchar](200) NULL,
	[SENDERADDRESS] [nvarchar](200) NULL,
	[RECEIVERADDRESS] [nvarchar](200) NULL,
	[POINT1] [nvarchar](30) NULL,
	[POINT2] [nvarchar](30) NULL,
	[POINT3] [nvarchar](30) NULL,
	[TRANSPORTEDBY] [nvarchar](15) NULL,
	[TOSTORE] [nvarchar](120) NULL,
	[STOREID] [nvarchar](20) NULL,
	[FFROM] [date] NULL,
	[FTO] [date] NULL,
	[STOREDATE] [date] NULL,
	[CLASS] [nvarchar](max) NULL,
	[RECEIVER] [nvarchar](250) NULL,
	[AMMOUNT] [nvarchar](max) NULL,
	[UNIT] [nvarchar](max) NULL,
	[RANK] [nvarchar](20) NULL,
	[NAME] [nvarchar](80) NULL,
	[POSITION] [nvarchar](60) NULL,
	[FINANCEID] [nvarchar](10) NULL,
	[FYEAR] [nvarchar](4) NULL,
	[PURPOSE] [nvarchar](50) NULL,
	[WORKPERMISSION] [nvarchar](30) NULL,
	[PassPermissionNo] [int] NULL,
	[IsImport] [nvarchar](30) NULL,
	[IsDistruct] [nvarchar](30) NULL,
 CONSTRAINT [PK_PERMISSIONS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PERMISSIONS] ON
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (1, NULL, NULL, CAST(0x6A420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'حجر العسل', N'جبيت', N'حجر العسل', N' التضامن', N'تلودي', NULL, N'مخازن شركة النواتي', N'50', CAST(0x6A420B00 AS Date), CAST(0x88420B00 AS Date), CAST(0x6A420B00 AS Date), NULL, N'شركة النواتي الذهب والنحاس المحدودة', NULL, NULL, N'لواء ركن', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'تعدين الذهب', NULL, 117, NULL, N'True')
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (2, NULL, NULL, CAST(0x6B420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'حجر العسل', N'قبقبة', N'حجر العسل', N'عطبرة', N'أبو حراز', N'بالبر', N'شركة مانوب للتعدين', N'2', CAST(0x6B420B00 AS Date), CAST(0x89420B00 AS Date), CAST(0x02420B00 AS Date), NULL, N'شركة مانوب للتعدين', NULL, NULL, N'لواء ركن', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'تعدين الذهب', NULL, 118, NULL, NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (3, NULL, NULL, CAST(0x6C420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'حجر العسل', N'دنقلا', N'حجر العسل', N'الملتقي', N'دلقو', N'بالبر', N'نقطة المفرقعات المتقدمة اللواء 75', N'25', CAST(0x6C420B00 AS Date), CAST(0x8A420B00 AS Date), CAST(0x12420B00 AS Date), NULL, N'محجر الشاهين للتعدين', NULL, NULL, N'لواء ركن', N'نديم حامـــد تبري كبـــــدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'استخراج حجر الجرانيت', NULL, 119, NULL, NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (4, NULL, NULL, CAST(0x6C420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'حجرالعسل', N'دلقو', N'حجر العسل', N'الملتقي', N'دلقو', N'بالبر', N'نقطة المفرقعات المتقدمة  ــ دنقلا', N'47', CAST(0x6C420B00 AS Date), CAST(0x89420B00 AS Date), CAST(0x17420B00 AS Date), NULL, N'أعمال الرفعة للتعدين', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'استخراج حجر الجرانت', NULL, 120, NULL, NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (5, NULL, NULL, CAST(0x6C420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'حجر العسل', N'سقوم', N'حجر العسل', N'عطبرة', N'أبو حراز', N'بالبر', N'نقطة المفرقعات المتقدمة  ــ بورتسودان', N'73', CAST(0x6C420B00 AS Date), CAST(0x8A420B00 AS Date), CAST(0x24420B00 AS Date), NULL, N'محاجر الادريسي للحجر الطبيعي', NULL, NULL, N'لواء ركن', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'انتاج الجبص', NULL, 121, NULL, NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (6, NULL, NULL, CAST(0x6D420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'حجر العسل ', N'جبيت المعادن / شنعاب', N'حجر العسل', N' التضامن', N'تلودي', N'البر', N'مخزن', N'106', CAST(0x6D420B00 AS Date), CAST(0x8B420B00 AS Date), CAST(0x62420B00 AS Date), NULL, N'محجر ود جادات للجبص', NULL, NULL, N'لواء ركن', N'نديــم حامــد تبــري كبــــدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'انتاج الجبص', NULL, 122, NULL, NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (18, NULL, NULL, CAST(0x74420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'جبيت المعادن / شنعاب', N'الخرطوم', N'الجيلي', N'قري', NULL, NULL, N'106', CAST(0x74420B00 AS Date), CAST(0x92420B00 AS Date), CAST(0x62420B00 AS Date), NULL, N'محجر ود جادات للجبص', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'انتاج الجبص', NULL, 123, N'True', N'False')
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (19, NULL, NULL, CAST(0x74420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', NULL, NULL, N'الكدرو', N'بحري', N'العيلفون', NULL, NULL, NULL, CAST(0x74420B00 AS Date), CAST(0x91420B00 AS Date), CAST(0x74420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 124, N'IsImport', NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (20, NULL, NULL, CAST(0x74420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'جبيت المعادن / شنعاب', N'الخرطوم', N'الجيلي', N'قري', NULL, NULL, N'106', CAST(0x74420B00 AS Date), CAST(0x92420B00 AS Date), CAST(0x62420B00 AS Date), NULL, N'محجر ود جادات للجبص', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'انتاج الجبص', NULL, 125, N'IsDistract', NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (21, NULL, NULL, CAST(0x74420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', NULL, NULL, N'', NULL, NULL, NULL, NULL, NULL, CAST(0x74420B00 AS Date), CAST(0x92420B00 AS Date), CAST(0x74420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 126, N'IsDistract', NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (22, NULL, NULL, CAST(0x74420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'جبيت المعادن / شنعاب', NULL, NULL, NULL, NULL, NULL, N'106', CAST(0x74420B00 AS Date), CAST(0x91420B00 AS Date), CAST(0x62420B00 AS Date), NULL, N'محجر ود جادات للجبص', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'انتاج الجبص', NULL, 127, N'IsDistract', NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (23, NULL, NULL, CAST(0x7A420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'حجر العسل', N'قبقبة', N'الخرطوم', N'الجيلي', N'قري', N'البر', N'شركة مانوب للتعدين', N'2', CAST(0x7A420B00 AS Date), CAST(0x98420B00 AS Date), CAST(0x02420B00 AS Date), NULL, N'شركة مانوب للتعدين', NULL, NULL, N'لواء ركن', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', NULL, NULL, N'تعدين الذهب', NULL, 128, NULL, NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (24, NULL, NULL, CAST(0x96420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', N'حجر العسل', N'حجر العسل', N'الخرطوم', N'الجيلي', N'قري', N'البر', N'شركة مانوب للتعدين', N'24
', CAST(0x96420B00 AS Date), CAST(0xB4420B00 AS Date), CAST(0x96420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', NULL, NULL, N'لواء ركن', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', NULL, NULL, NULL, NULL, 129, NULL, NULL)
INSERT [dbo].[PERMISSIONS] ([ID], [FID], [PLACE], [FDATE], [LICENSEID], [SENDER], [SENDERADDRESS], [RECEIVERADDRESS], [POINT1], [POINT2], [POINT3], [TRANSPORTEDBY], [TOSTORE], [STOREID], [FFROM], [FTO], [STOREDATE], [CLASS], [RECEIVER], [AMMOUNT], [UNIT], [RANK], [NAME], [POSITION], [FINANCEID], [FYEAR], [PURPOSE], [WORKPERMISSION], [PassPermissionNo], [IsImport], [IsDistruct]) VALUES (25, NULL, NULL, CAST(0x96420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', N'حجر العسل', N'حجر العسل', N'الخرطوم', N'الجيلي', N'قري', N'البر', N'نقطة المفرقعات المتقدمة  ــ بورتسودان', NULL, CAST(0x96420B00 AS Date), CAST(0xB3420B00 AS Date), CAST(0x96420B00 AS Date), NULL, N'شركة تارقيت للأنشطة المتعددة', NULL, NULL, N'لواء ركن', N'نديم حامد تبري كبدان', N'مفتش عام مفرقعات السودان', NULL, NULL, NULL, NULL, 130, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PERMISSIONS] OFF
/****** Object:  Table [dbo].[PermissionNames]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionNames](
	[PermissionNameID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [nvarchar](150) NULL,
 CONSTRAINT [PK_PermissionNames] PRIMARY KEY CLUSTERED 
(
	[PermissionNameID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PermissionNames] ON
INSERT [dbo].[PermissionNames] ([PermissionNameID], [PermissionName]) VALUES (1, N'منح إذن استخدام')
INSERT [dbo].[PermissionNames] ([PermissionNameID], [PermissionName]) VALUES (2, N'منح إذن استيراد')
INSERT [dbo].[PermissionNames] ([PermissionNameID], [PermissionName]) VALUES (3, N'منح إذن الخروج')
INSERT [dbo].[PermissionNames] ([PermissionNameID], [PermissionName]) VALUES (4, N'منح عدم ممانعة')
SET IDENTITY_INSERT [dbo].[PermissionNames] OFF
/****** Object:  Table [dbo].[PermissionDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionDetails](
	[PermissionDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionID] [int] NULL,
	[Description] [nvarchar](150) NULL,
	[Unit] [nvarchar](15) NULL,
	[Quanitity] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PermissionDetails] PRIMARY KEY CLUSTERED 
(
	[PermissionDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PermissionDetails] ON
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (4, 1, N'نترات امونيوم ', N'كجم', CAST(3000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (5, 1, N'كبسولة كهربائية تاخيرية 4 متر', N'قطعة', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (6, 1, N'املشن 30مم', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (9, 2, N'نترات أمونيوم', N'كجم', CAST(25000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (34, 4, N'كورتكس', N'متر', CAST(5000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (35, 4, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(250.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (36, 4, N'نترات أمونيوم', N'كجم', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (37, 4, N'املشن 30مم', N'كجم', CAST(350.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (50, 5, N'كورتكس', N'متر', CAST(5000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (51, 5, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (52, 5, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (53, 5, N'كبسولة عادية', N'قطعة', CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (57, 3, N'كورتكس', N'متر', CAST(5000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (58, 3, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(250.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (59, 3, N'نترات أمونيوم', N'كجم', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (138, 6, N'كورتكس', N'متر', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (139, 6, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (140, 6, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (141, 6, N'كبسولة عادية', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (142, 6, N'نترات امونيوم ', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (143, 6, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (146, 9, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (147, 8, N'نترات امونيوم ', N'كجم', CAST(3000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (148, 8, N'كبسولة كهربائية تاخيرية 4 متر', N'قطعة', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (149, 8, N'املشن 30مم', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (157, 11, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (158, 12, N'كورتكس', N'متر', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (159, 12, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (160, 12, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (161, 12, N'كبسولة عادية', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (162, 12, N'نترات امونيوم ', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (163, 12, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (170, 14, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (171, 15, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (178, 16, N'كورتكس', N'متر', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (179, 16, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (180, 16, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (181, 16, N'كبسولة عادية', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (182, 16, N'نترات امونيوم ', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (183, 16, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (196, 17, N'كورتكس', N'متر', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (197, 17, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (198, 17, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (199, 17, N'كبسولة عادية', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (200, 17, N'نترات امونيوم ', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (201, 17, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (202, 7, N'كورتكس', N'متر', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (203, 7, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (204, 7, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (205, 7, N'كبسولة عادية', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (206, 7, N'نترات امونيوم ', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (207, 7, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (208, 19, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (209, 20, N'كورتكس', N'متر', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (210, 20, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (211, 20, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (212, 20, N'كبسولة عادية', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (213, 20, N'نترات امونيوم ', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (214, 20, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (215, 21, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (216, 22, N'كورتكس', N'متر', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (217, 22, N'شريط أمان', N'متر', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (218, 22, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (219, 22, N'كبسولة عادية', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (220, 22, N'نترات امونيوم ', N'كجم', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (221, 22, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (222, 21, N'كبسولة نونيل 3.6 متر', N'قطعة', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (223, 23, N'نترات أمونيوم', N'كجم', CAST(25000.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (224, 24, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (225, 25, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (227, 26, N'حاوية', N'40 قدم', CAST(16.00 AS Decimal(18, 2)))
INSERT [dbo].[PermissionDetails] ([PermissionDetailsID], [PermissionID], [Description], [Unit], [Quanitity]) VALUES (228, 27, N'نترات أمونيوم', N'كجم', CAST(25000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[PermissionDetails] OFF
/****** Object:  Table [dbo].[PassCopiesDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassCopiesDetails](
	[PassCopySirsID] [int] IDENTITY(1,1) NOT NULL,
	[Sirs] [nvarchar](150) NULL,
	[PassCopyID] [int] NULL,
 CONSTRAINT [PK_PassCopiesDetails] PRIMARY KEY CLUSTERED 
(
	[PassCopySirsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PassCopiesDetails] ON
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1, N'السيد/ مدير ادراة العمليات البرية', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (2, N'السيد/ مدير ادارة الاستخبارات البرية', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (3, N'السيد/ مدير ادارة الامن الوقائي', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (4, N'السيد/ قائد المنطقة  العسكرية المركزية', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (5, N'السيد/ مدير عام الادارة العامة للادلة الجنائية', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (6, N'السيد/ قائد منطقة بحري العسكرية أ.س', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (7, N'السيد/ قائد منطقة امدرمان العسكرية أ.س', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (8, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (9, N'السيد/ قائد الفرقة 19 أ.س', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (10, N'السيد/ قائد الفرقة 19 عمليات', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (11, N'السيد/ مدير شرطة الولاية الشمالية', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (12, N'السيد/ مدير وحدة أمن كريمة', 41)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (13, N'السيد/ قائد الفرقة 19 مشاة أ.س', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (14, N'السيد/ قائد الفرقة 19 مشاة عمليات', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (15, N'السيد/ مدير شرطة الولاية الشمالية', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (16, N'السيد/ وحدة امن دلقو', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (17, N'السيد/ مدير شرطة ولاية نهر النيل', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (18, N'السيد/ مدير وحدة أمن ولاية نهر النيل', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (19, N'السيد/ مدير إدارة العلميات البرية', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (20, N'السيد/ مدير إدارة الاستخبارات البرية', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (21, N'السيد/ مدير إدارة الأمن الوقائي', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (22, N'السيد/ قائد المنطقة العسكرية المركزية', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (23, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (24, N'السيد/ قائد منطقة بحري العسكرية أ.س', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (25, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (26, N'السيد/ السيد قائد الفرقة الثالثة مشاة عمليات', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (27, N'السيد/ مدير ادارة العمليات البرية', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (28, N'السيد/ مدير ادارة الاستخبارات العسكرية', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (29, N'السيد/ مدير الامن الوقائي', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (30, N'السيد/ قائد المنطقة العسكرية المركزية', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (31, N'السيد/ مدير عام الادارة العامة للادلة الجنائية', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (32, N'السيد/ قائد منطقة بحري العسكرية أ.س', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (33, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (34, N'السيد/ قائد الفرقة الاولي مشاة أ.س', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (35, N'السيد/ قائد الفرقة الاولي عمليات', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (36, N'السيد/ قائد الفرقة الثانية مشاة أ.س', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (37, N'السيد/ قائد الفرقة الثانية مشاة', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (38, N'السيد/ مدير ادرة العمليات برية', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (39, N'السيد/ مدير ادارة الاستخبارات البرية', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (40, N'السيد/ مدير الامن الوقائي', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (41, N'السيد/ مدير عام الادارة العامة للادلة الجنائية', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (42, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (43, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (44, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (45, N'السيد/ مدير شرطة عطبرة', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (46, N'السيد/ مدير وحدة امن ابوحمد', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (47, N'السيد/ مدير شرطة ابوحمد', 43)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (48, N'السيد/ قائد الفرقة 11 مشاة أ.س', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (49, N'السيد/ قائد الفرقة 11 مشاة عمليات', 86)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (50, N'السيد/ مدير ادارة العمليات البرية', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (51, N'السيد/ مدير ادارة الاستخبارات العسكرية', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (52, N'السيد/ مدير الامن الوقائي', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (53, N'السيد/ قائد المنطقة العسكرية المركزية', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (54, N'السيد/ مدير الادارة العامة للادلة الجنائية', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (55, N'السيد/ قائد منطقة بحري العسكرية', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (56, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (57, N'السيد/ قائد الفرقة الاولي مشاة أ.س', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (58, N'السيد/ مدير شرطة سنار', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (59, N'السيد/ مدير وحدة امن سنار', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (60, N'السيد/ ركن عمليات الفرقة 17 مشاة', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (61, N'السيد/ ركن أ.س الفرقة 17 مشاة', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (62, N'السيد/ قائد الفرقة الرابعة أ.س', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (63, N'السيد/ مدير شرطة الدمازين', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (64, N'السيد/ وحدة امن الدمازين', 42)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (65, N'السيد/ مدير إدارة العمليات البرية', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (66, N'السيد/ مدير إدارة الاستخبارات البرية', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (67, N'السيد/ مدير إدارة الأمن الوقائي', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (68, N'السيد/ قائد المنطقة  العسكرية المركزية', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (69, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (70, N'السيد/ قائد منطقة بحري العسكرية أ.س', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (71, N'السيد/ ركن أ.س سلاح ا|لأسلحة والذخائر', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (72, N'السيد/ قائد الفرقة الثالثة أ.س', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (73, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (74, N'السيد/ قائد منطقة هيا أ.س', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (75, N'السيد/ مدير وحدة أمن هيا', 36)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (76, N'السيد/ مدير إدارة العمليات البرية .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (77, N'السيد/ مدير إدارة الاستخبارات البرية .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (78, N'السيد/ مدير إدارة الامن الوقائي .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (79, N'السيد/ قائد المنطقة العسكرية المركزية .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (80, N'السيد/ مدير الادارة العامة للادلة والتحقيقات الجنائية .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (81, N'السيد/ قائد منطقة بحري العسكرية أ.س .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (82, N'السيد/ ركن أ0س سلاح الأسلحة .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (83, N'السيد/ قائد الفرقة الثالثة مشاه أ0س . ', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (84, N'السيد/ قائد سلاح المدفعية عطبرة إ.س .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (85, N'السيد/ قائد سلاح المدفعية عمليات .', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (86, N'السيد/ مدير وحدة امن ولاية نهر النيل', 50)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (87, N'السيد/ مدير إدارة العلميات البرية', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (88, N'السيد/ مدير إدارة الاستخبارات البرية', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (89, N'السيد/ مدير إدارة الأمن الوقائي', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (90, N'السيد/ قائد المنطقة العسكرية المركزية', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (91, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (92, N'السيد/ قائد منطقة بحري العسكرية أ.س', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (93, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (94, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (95, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (96, N'السيد/ قائد منطقة البحر الاحمر أ.س', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (97, N'السيد/ مدير شرطة ولاية البحر الاحمر', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (98, N'السيد/ وحدة امن حلايب', 73)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (99, N'السيد/ مدير إدارة العلميات البرية', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (100, N'السيد/ مدير إدارة الاستخبارات البرية', 19)
GO
print 'Processed 100 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (101, N'السيد/ مدير إدارة الأمن الوقائي', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (102, N'السيد/ قائد المنطقة العسكرية المركزية', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (103, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (104, N'السيد/ مدير إدارة العلميات البرية', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (105, N'السيد/ مدير إدارة الاستخبارات البرية', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (106, N'السيد/ مدير إدارة الأمن الوقائي', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (107, N'السيد/ قائد المنطقة العسكرية المركزية', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (108, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (109, N'السيد/ قائد منطقة بحري العسكرية أ.س', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (110, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (111, N'السيد/ ركن أ0س منطقة أمدرمان العسكرية', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (112, N'السيد/ قائد الفرقة 19 مشاه عمليات', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (113, N'السيد/ قائد الفرقة 19 مشاه أ0س', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (114, N'السيد/ مدير شرطة الولاية الشمالية', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (115, N'السيد/ مدير وحدة أمن دنقلا', 22)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (116, N'السيد/ مدير إدارة العلميات البرية', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (117, N'السيد/ مدير إدارة الاستخبارات البرية', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (118, N'السيد/ مدير إدارة الأمن الوقائي', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (119, N'السيد/ قائد المنطقة العسكرية المركزية', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (120, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (121, N'السيد/ قائد منطقة بحري العسكرية أ.س', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (122, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (123, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (124, N'السيد/ قائد سلاح المدفعية عطبرة / أ0س', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (125, N'السيد/ مدير شرطة أبو حمد', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (126, N'السيد/ مدير وحدة أمن الشريك', 54)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (127, N'السيد/ مدير إدارة العمليات البرية', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (128, N'السيد/ مدير إدارة الاستخبارات البرية', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (129, N'السيد/ مدير إدارة الأمن الوقائي', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (130, N'السيد/ قائد المنطقة العسكرية المركزية', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (131, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (132, N'السيد/ قائد منطقة بحري العسكرية أ.س', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (133, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (134, N'السيد/ قائد الفرقة الثالثة أ.س', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (135, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (136, N'السيد/ قائد الفرقة 19 مشاه عمليات', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (137, N'السيد/ قائد الفرقة 19 مشاه أ0س', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (138, N'السيد/ مدير وحدة أمن دنقلا', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (139, N'السيد/ مدير شرطة دنقلا', 67)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (140, N'السيد/ مدير إدارة العلميات البرية', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (141, N'السيد/ مدير إدارة الاستخبارات البرية', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (142, N'السيد/ مدير إدارة الأمن الوقائي', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (143, N'السيد/ قائد المنطقة العسكرية المركزية', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (144, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (145, N'السيد/ قائد منطقة بحري العسكرية أ.س', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (146, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (147, N'السيد/ ركن أ0س الفرقة الثالثة مشاه', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (148, N'السيد/ ركن عمليات سلاح المدفعية عطبرة ', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (149, N'السيد/ ركن أ0س سلاح المدفعية عطبرة ', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (150, N'السيد/ مدير شرطة شندي', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (151, N'السيد/ مدير وحدة أمن شندي', 49)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (152, N'السيد/ مدير إدارة العلميات البرية', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (153, N'السيد/ مدير إدارة الاستخبارات البرية', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (154, N'السيد/ مدير إدارة الأمن الوقائي', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (155, N'السيد/ قائد المنطقة العسكرية المركزية', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (156, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (157, N'السيد/ قائد منطقة بحري العسكرية أ.س', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (158, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (159, N'السيد/ قائد الفرقة الاولي عمليات', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (160, N'السيد/ ائد الفرقة الاولي أ.س', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (161, N'السيد/ قائد الفرقة الثانية عمليات', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (162, N'السيد/ قائد الفرقة الثانية أ.س', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (163, N'السيد/ مدير شرطة ولاية القضارف', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (164, N'السيد/ وحدة امن القضارف', 83)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (165, N'السيد/ مدير إدارة العلميات البرية', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (166, N'السيد/ مدير إدارة الاستخبارات البرية', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (167, N'السيد/ مدير إدارة الأمن الوقائي', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (168, N'السيد/ قائد المنطقة العسكرية المركزية', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (169, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (170, N'السيد/ قائد منطقة بحري العسكرية أ.س', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (171, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (172, N'السيد/ قائد منطقة امدرمان العسكرية أ.س', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (173, N'السيد/ مدير شرطة امدرمان', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (174, N'السيد/ وحدة امن امدرمان', 87)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (175, N'السيد/ مدير إدارة العلميات البرية', 90)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (176, N'السيد/ مدير إدارة الاستخبارات البرية', 90)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (177, N'السيد/ مدير إدارة الأمن الوقائي', 90)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (178, N'السيد/ قائد المنطقة العسكرية المركزية', 90)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (179, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 90)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (180, N'السيد/ قائد منطقة بحري العسكرية أ.س', 90)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (181, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 90)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (182, N'السيد/ مدير إدارة العلميات البرية', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (183, N'السيد/ مدير إدارة الاستخبارات البرية', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (184, N'السيد/ مدير إدارة الأمن الوقائي', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (185, N'السيد/ مدير إدارة العلميات البرية', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (186, N'السيد/ مدير إدارة الاستخبارات البرية', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (187, N'السيد/ مدير إدارة الأمن الوقائي', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (188, N'السيد/ قائد المنطقة العسكرية المركزية', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (189, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (190, N'السيد/ قائد منطقة بحري العسكرية أ.س', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (191, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (192, N'السيد/ قائد الفرقة الاولي عمليات', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (193, N'السيد/ قائد الفرقة الاولي أ.س', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (194, N'السيد/ قائد الفرقة الثانيةعمليات', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (195, N'السيد/ قائد الفرقة الثانية أ.س', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (196, N'السيد/ مدير شرطة ولاية القضارف', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (197, N'السيد/ وحدة امن القضارف', 80)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (198, N'السيد/ قائد منطقة بحري العسكرية أ.س', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (199, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (200, N'السيد/ ركن أ0س الفرقة الأولي مشاه', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (201, N'السيد/ ركن عمليات الفرقة الثانية مشاه', 19)
GO
print 'Processed 200 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (202, N'السيد/ ركن أ0س الفرقة الثانية مشاه', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (203, N'السيد/ مدير شرطة ولاية القضارف', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (204, N'السيد/ مدير وحدة أمن الفاو', 19)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (205, N'السيد/ مدير إدارة العلميات البرية', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (206, N'السيد/ مدير إدارة الاستخبارات البرية', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (207, N'السيد/ مدير إدارة الأمن الوقائي', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (208, N'السيد/ قائد المنطقة العسكرية المركزية', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (209, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (210, N'السيد/ قائد منطقة بحري العسكرية أ.س', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (211, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (212, N'السيد/ قائد الفرقة الثالثة مشاة عمليات', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (213, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (214, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (215, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (216, N'السيد/ مدير شرطة ولاية نهر النيل', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (217, N'السيد/ مدير أمن ولاية نهر النيل', 17)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (218, N'السيد/ مدير إدارة العلميات البرية', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (219, N'السيد/ مدير إدارة الاستخبارات البرية', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (220, N'السيد/ مدير إدارة الأمن الوقائي', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (221, N'السيد/ قائد المنطقة العسكرية المركزية', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (222, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (223, N'السيد/ قائد منطقة بحري العسكرية أ.س', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (224, N'السيد/ ركن أ0س منطقة الخرطوم العسكرية', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (225, N'السيد/ ركن عمليات الفرقة 18 كوستي', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (226, N'السيد/ ركن أ0س الفرقة 18 مشاه', 20)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (227, N'السيد/ مدير إدارة العلميات البرية', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (228, N'السيد/ مدير إدارة الاستخبارات البرية', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (229, N'السيد/ مدير إدارة الأمن الوقائي', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (230, N'السيد/ قائد المنطقة العسكرية المركزية', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (231, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (232, N'السيد/ قائد منطقة بحري العسكرية أ.س', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (233, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (234, N'السيد/ ركن أ0س منطقة الخرطوم العسكرية', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (235, N'السيد/ ركن أ0س الفرقة 18 مشاه', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (236, N'السيد/ ركن أ0س الفرقة الخامسة مشاه', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (237, N'السيد/ ركن عمليات الفرقة 16 مشاه', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (238, N'السيد/ ركن أ0س الفرقة 16 مشاه', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (239, N'السيد/ مدير شرطة نيالا', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (240, N'السيد/ مدير وحدة أمن نيالا', 8)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (241, N'السيد/ ركن أ0س الفرقة 19 مشاه', 37)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (242, N'السيد/ مدير شرطة دلقو', 37)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (243, N'السيد/ مدير وحدة أمن دلقو', 37)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (244, N'السيد/ مدير إدارة العلميات البرية', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (245, N'السيد/ مدير إدارة الاستخبارات البرية', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (246, N'السيد/ مدير إدارة الأمن الوقائي', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (247, N'السيد/ قائد المنطقة العسكرية المركزية', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (248, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (249, N'السيد/ قائد منطقة بحري العسكرية أ.س', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (250, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (251, N'السيد/ ركن أ0س منطقة أمدرمان العسكرية', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (252, N'السيد/ قائد الفرقة 19 مشاه / عمليات', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (253, N'السيد/ قائد الفرقة 19 مشاه / أ0س', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (254, N'السيد/ مدير شرطة الولاية الشمالية', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (255, N'السيد/ مدير وحدة أمن دلقو', 21)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (256, N'السيد/ مدير إدارة العلميات البرية', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (257, N'السيد/ مدير إدارة الاستخبارات البرية', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (258, N'السيد/ مدير إدارة الأمن الوقائي', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (259, N'السيد/ قائد المنطقة العسكرية المركزية', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (260, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (261, N'السيد/ قائد منطقة بحري العسكرية أ.س', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (262, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (263, N'السيد/ قائد الفرقة 101 مشاه عمليات', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (264, N'السيد/ قائد الفرقة 101 مشاه أ0س', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (265, N'السيد/ مدير شرطة ولاية البحر الأحمر', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (266, N'السيد/ مدير وحدة أمن دورديب', 68)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (267, N'السيد/ مدير إدارة العمليات البرية', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (268, N'السيد/ مدير إدارة الاستخبارات البرية', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (269, N'السيد/ مدير إدارة العمليات برية', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (270, N'السيد/ مدير إدارة الإستخبارات البرية', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (271, N'السيد/ مدير إدارة الأمن الوقائي', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (272, N'السيد/ قائد المنطقة العسكرية المركزية', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (273, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (274, N'السيد/ قائد منطقة بحري العسكرية أ.س', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (275, N'السيد/ ركن أ.س سلاج الأسلحة والذخائر', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (276, N'السيد/ قائد الفرقة الأولى مشاة أ.س', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (277, N'السيد/ قائد الفرقة 17 مشاة عمليات', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (278, N'السيد/ قائد الفرقة 17 مشاة أ.س', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (279, N'السيد/ مدير شرطة ولاية سنار', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (280, N'السيد/ مدير وحدة أمن سنار', 84)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (281, N'السيد/ مدير إدارة العلميات البرية', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (282, N'السيد/ مدير إدارة الاستخبارات البرية', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (283, N'السيد/ مدير إدارة الأمن الوقائي', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (284, N'السيد/ قائد المنطقة العسكرية المركزية', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (285, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (286, N'السيد/ قائد منطقة بحري العسكرية أ.س', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (287, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (288, N'السيد/ قائد الفرقة 19 مشاه أ0س', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (289, N'السيد/ قائد سلاح المدفعية عطبرة أ0س', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (290, N'السيد/ قائد الفرقة الثالثة مشاه أ0س', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (291, N'السيد/ قائد مستودع حجر العسل', 91)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (292, N'السيد/ مدير إدارة الأمن الوقائي', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (293, N'السيد/ قائد المنطقة العسكرية المركزية', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (294, N'السيد/ مدير الادارة العامة للادلة والتحقيقات الجنائية .', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (295, N'السيد/ قائد منطقة بحري العسكرية أ.س .', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (296, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (297, N'السيد/ قائد الفرقة الثالثة  أ.س', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (298, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (299, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (300, N'السيد/ قائد الفرقة 101 مشاة', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (301, N'السيد/ قائد الفرقة 101مشاة أ.س', 62)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (302, N'السيد/ مدير شرطة ولاية البحر الاحمر', 62)
GO
print 'Processed 300 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (303, N'السيد/ مدير إدارة العلميات البرية', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (304, N'السيد/ مدير إدارة الاستخبارات البرية', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (305, N'السيد/ مدير إدارة الأمن الوقائي', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (306, N'السيد/ قائد المنطقة العسكرية المركزية', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (307, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (308, N'السيد/ قائد منطقة بحري العسكرية أ.س', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (309, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (310, N'السيد/ مدير شرطة قري', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (311, N'السيد/ مدير وحدة أمن قري', 75)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (312, N'السيد/ مدير إدارة العلميات البرية', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (313, N'السيد/ مدير إدارة الاستخبارات البرية', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (314, N'السيد/ مدير إدارة الأمن الوقائي', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (315, N'السيد/ قائد المنطقة العسكرية المركزية', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (316, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (317, N'السيد/ قائد منطقة بحري العسكرية أ.س', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (318, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (319, N'السيد/ مديرة شرطة قري', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (320, N'السيد/ مدير وحدة أمن قري', 15)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (321, N'السيد/ مدير ادارة العمليات البرية', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (322, N'السيد/ مدير ادارة الاستخبارات البرية', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (323, N'السيد/ مدير الامن الوقائي', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (324, N'السيد/ قائد المنطقة العسكرية المركزية', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (325, N'السيد/ مدير عام الادارة العامة للادلة الجنائية', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (326, N'السيد/ قائد منطقة الخرطوم العسكرية أ.س', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (327, N'السيد/ قائد منطقة بحري العسكرية أ.س', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (328, N'السيد/ ركن أ.س سلاح الاسلحة', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (329, N'السيد/ قائد الفرقة الاولي مشاة أ.س', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (330, N'السيد/ مدير شرطة سنار', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (331, N'السيد/ مدير وحدة امن سنار', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (332, N'السيد/ ركن عمليات الفرقة 17 مشاة', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (333, N'السيد/ قائد الفرقة الرابعة أ.س', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (334, N'السيد/ مدير وحدة امن الدمازين', 79)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (335, N'السيد/ مدير إدارة العلميات البرية', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (336, N'السيد/ مدير إدارة الاستخبارات البرية', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (337, N'السيد/ مدير إدارة الأمن الوقائي', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (338, N'السيد/ قائد المنطقة العسكرية المركزية', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (339, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (340, N'السيد/ قائد منطقة بحري العسكرية أ.س', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (341, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (342, N'السيد/ قائد الفرقة الثالثة مشاه عمليات', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (343, N'السيد/ قائد الفرقة الثالثة مشاه أ.س', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (344, N'السيد/ قائد المدفعية عطبرة أ.س', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (345, N'السيد/ قائد منطقة هيا أ.س', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (346, N'السيد/ قائد الفرقة 101 مشاة عمليات', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (347, N'السيد/ قائد الفرقة 101 مشاة أ.س', 32)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (348, N'السيد/ مدير إدارة العلميات البرية', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (349, N'السيد/ مدير إدارة الاستخبارات البرية', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (350, N'السيد/ مدير إدارة الأمن الوقائي', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (351, N'السيد/ قائد المنطقة العسكرية المركزية', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (352, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (353, N'السيد/ مدير إدارة العمليات البرية', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (354, N'السيد/ مدير إدارة الاستخبارات البرية', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (355, N'السيد/ مدير إدارة الأمن الوقائي', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (356, N'السيد/ قائد المنطقة العسكرية المركزية', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (357, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (358, N'السيد/ قائد منطقة بحري العسكرية أ.س', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (359, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (360, N'السيد/ قائد الفرقة الثالثة أ.س', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (361, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (362, N'السيد/ قائد منطقة هيا أ.س', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (363, N'السيد/ قائد وحدة أمن هيا', 72)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (364, N'السيد/ مدير إدارة العلميات البرية', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (365, N'السيد/ مدير إدارة الاستخبارات البرية', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (366, N'السيد/ مدير إدارة الأمن الوقائي', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (367, N'السيد/ قائد المنطقة العسكرية المركزية', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (368, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (369, N'السيد/ قائد منطقة بحري العسكرية أ.س', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (370, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (371, N'السيد/ قائد منطقة جبل اولياء العسكرية أ.س', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (372, N'السيد/ قائد الفرقة 18 أ.س', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (373, N'السيد/ قائد الفرقة 18 عمليات', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (374, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (375, N'السيد/ قائد الفرقة 16 مشاة أ.س', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (376, N'السيد/ قائد الفرقة 16 مشاة عمليات', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (377, N'السيد/ مدير شرطة ولاية جنوب  دارفور', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (378, N'السيد/ مدير جهاز الامن ولاية جنوب دارفور', 78)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (379, N'السيد/ مدير إدارة العلميات البرية', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (380, N'السيد/ مدير إدارة الاستخبارات البرية', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (381, N'السيد/ مدير إدارة الأمن الوقائي', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (382, N'السيد/ قائد المنطقة العسكرية المركزية', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (383, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (384, N'السيد/ قائد منطقة بحري العسكرية أ.س', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (385, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (386, N'السيد/ قائد الفرقة الثالثة مشاة عمليات', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (387, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (388, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (389, N'السيد/ قائد منطقة هيا أ.س', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (390, N'السيد/ قائد منطقة جبيت أ.س', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (391, N'السيد/ قائد وحدة امن جبيت', 64)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (392, N'السيد/ مدير إدارة العلميات البرية', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (393, N'السيد/ مدير إدارة الاستخبارات البرية', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (394, N'السيد/ مدير إدارة الأمن الوقائي', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (395, N'السيد/ قائد المنطقة العسكرية المركزية', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (396, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (397, N'السيد/ قائد منطقة بحري العسكرية أ.س', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (398, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (399, N'السيد/ قائد الفرقة 19 مشاه عمليات', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (400, N'السيد/ قائد الفرقة 19 مشاه أ0س', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (401, N'السيد/ مدير شرطة دنقلا', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (402, N'السيد/ مدير وحدة أمن دنقلا', 38)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (403, N'السيد/ قائد منطقة بحري العسكرية أ.س', 60)
GO
print 'Processed 400 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (404, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (405, N'السيد/ قائد الفرقة الثالثة مشاة عمليات', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (406, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (407, N'السيد/ قائد سلاح المدفعية عطبرة', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (408, N'السيد/ قائد المدفعية عطبرة أ.س', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (409, N'السيد/ مدير شرطة ولاية نهر النيل', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (410, N'السيد/ مديرة وحدة امن ولاية نهر النيل', 60)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (411, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (412, N'السيد/ قائد سلاح المدفعية عمليات', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (413, N'السيد/ قائد سلاح المدفعية أ.س', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (414, N'السيد/ مدير شرطة ولاية نهر النيل', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (415, N'السيد/ مدير وحدة أمن ولاية نهر النيل', 55)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (416, N'السيد/ مدير إدارة الاستخبارات البرية', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (417, N'السيد/ مدير إدارة الأمن الوقائي', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (418, N'السيد/ قائد المنطقة العسكرية المركزية', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (419, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (420, N'السيد/ قائد منطقة بحري العسكرية أ.س', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (421, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (422, N'السيد/ قائد الفرقة الاولي مشاة أ.س', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (423, N'السيد/ قائد الفرقة الثانية مشاة عمليات', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (424, N'السيد/ قائد الفرقة 11 مشاة عمليات', 18)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (437, N'السيد/ مدير إدارة العمليات برية', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (438, N'السيد/ مدير إدارة الإستخبارات البرية', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (439, N'السيد/ مدير إدارة الأمن الوقائي', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (440, N'السيد/ قائد المنطقة العسكرية المركزية', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (441, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (442, N'السيد/ قائد منطقة بحري العسكرية أ.س', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (443, N'السيد/ ركن أ.س سلاج الأسلحة والذخائر', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (444, N'السيد/ قائد الفرقة الأولى مشاة أ.س', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (445, N'السيد/ قائد الفرقة 17 مشاة عمليات', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (446, N'السيد/ قائد الفرقة 17 مشاة أ.س', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (447, N'السيد/ مدير شرطة ولاية سنار', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (448, N'السيد/ مدير وحدة أمن سنار', 85)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (449, N'السيد/ مدير إدارة الأمن الوقائي', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (450, N'السيد/ قائد المنطقة العسكرية المركزية', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (451, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (452, N'السيد/ قائد منطقة بحري العسكرية أ.س', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (453, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (454, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (455, N'السيد/ قائد سلاح المدفعية عطبرة / أ0س', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (456, N'السيد/ مدير شرطة ولاية نهر النيل', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (457, N'السيد/ مدير وحدة أمن جبل جاري', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (458, N'السيد/ مدير إدارة العلميات البرية', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (459, N'السيد/ مدير إدارة الاستخبارات البرية', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (460, N'السيد/ مدير إدارة الأمن الوقائي', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (461, N'السيد/ قائد المنطقة العسكرية المركزية', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (462, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (463, N'السيد/ قائد منطقة بحري العسكرية أ.س', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (464, N'السيد/ قائد الفرقة الاولي عمليات', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (465, N'السيد/ قائد الفرقة الاولي أ.س', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (466, N'السيد/ قائد الفرقة الثانية عمليات', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (467, N'السيد/ قائد الفرقة الثانية أ.س', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (468, N'السيد/ مدير شرطة ولاية القضارف', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (469, N'السيد/ مدير وحدة امن القضارف', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (470, N'السيد/ مدير شرطة محلية البطانة', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (471, N'السيد/ مدير وحدة امن محلية البطانة', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (472, N'السيد/ قائد منطقة بحري العسكرية أ.س', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (473, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 82)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (474, N'السيد/ مدير إدارة العلميات البرية', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (475, N'السيد/ مدير إدارة الاستخبارات البرية', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (476, N'السيد/ مدير إدارة الأمن الوقائي', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (477, N'السيد/ قائد المنطقة العسكرية المركزية', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (478, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (479, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (480, N'السيد/ مدير إدارة العلميات البرية', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (481, N'السيد/ مدير إدارة الاستخبارات البرية', 47)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (482, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (483, N'السيد/ السيد قائد الفرقة الثالثة مشاة عمليات', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (484, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (485, N'السيد/ قائد سلاح المدفعية عطيرة عمليات', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (486, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 59)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (487, N'السيد/ قائد منطقة امدرمان العسكرية أ.س', 88)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (488, N'السيد/ مدير إدارة العلميات البرية', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (489, N'السيد/ مدير إدارة الاستخبارات البرية', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (490, N'السيد/ مدير إدارة الأمن الوقائي', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (491, N'السيد/ قائد المنطقة العسكرية المركزية', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (492, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (493, N'السيد/ قائد منطقة بحري العسكرية أ.س', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (494, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (495, N'السيد/ ركن أ.س سلاح المدفعية عطبرة', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (496, N'السيد/ قائد الفرقة 101 مشاة عمليات', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (497, N'السيد/ ركن أ.س الفرقة 101 مشاة', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (498, N'السيد/ وحدة أمن سنكات', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (499, N'السيد/ مدير شرطة سنكات', 69)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (500, N'السيد/ مدير إدارة العمليات برية ', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (501, N'السيد/ مدير إدارة الإستخبارات برية', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (502, N'السيد/ مدير إدارة الأمن الوقائي', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (503, N'السيد/ قائد المنطقة العسكرية المركزية', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (504, N'السيد/ مدير عام الإدارة العامة للأدلة الجنائية', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (505, N'السيد/ قائد منطقة بحري العسكرية أ.س', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (506, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (507, N'السيد/ مدير شرطة السليت', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (508, N'السيد/ مدير شرطة ولاية الخرطوم', 76)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (509, N'السيد/ مدير إدارة العلميات البرية', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (510, N'السيد/ مدير إدارة الاستخبارات البرية', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (511, N'السيد/ مدير إدارة الأمن الوقائي', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (512, N'السيد/ قائد المنطقة العسكرية المركزية', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (513, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (514, N'السيد/ قائد منطقة بحري العسكرية أ.س', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (515, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (516, N'السيد/ قائد الفرقة 18 مشاة عمليات', 7)
GO
print 'Processed 500 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (517, N'السيد/ قائد الفرقة 18 مشاة أ.س', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (518, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (519, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (520, N'السيد/ قائد الفرقة السادسة مشاة عمليات', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (521, N'السيد/ قائد الفرقة السادسة مشاة أ.س', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (522, N'السيد/ قائد الفرقة 15 مشاة عمليات', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (523, N'السيد/ قائد الفرقة 15 مشاة أ.س', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (524, N'السيد/ مدير شرطة الجنينة', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (525, N'السيد/ مدير أمن الجنينة', 7)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (526, N'السيد/ مدير إدارة العلميات البرية', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (527, N'السيد/ مدير إدارة الاستخبارات البرية', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (528, N'السيد/ مدير إدارة الأمن الوقائي', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (529, N'السيد/ قائد المنطقة العسكرية المركزية', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (530, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (531, N'السيد/ قائد منطقة بحري العسكرية أ.س', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (532, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (533, N'السيد/ قائد سلاح المدفعية عطبرة/عمليات', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (534, N'السيد/ قائد سلاح المدفعية عطبرة / أ0س', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (535, N'السيد/ مدير شرطة بربر', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (536, N'السيد/ مدير وحدة امن بربر', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (537, N'السيد/ مدير شركة صحاري للتعدين المحدودة ', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (538, N'السيد/ مدير شركة تارقيت للانشطة المتعددة ', 45)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (539, N'السيد/ مدير إدارة الأمن الوقائي', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (540, N'السيد/ قائد المنطقة العسكرية المركزية', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (541, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (542, N'السيد/ قائد منطقة بحري العسكرية أ.س', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (543, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (544, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (545, N'السيد/ السيد قائد الفرقة الثالثة مشاة عمليات', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (546, N'السيد/ قائد سلاح المدفعية عطبرة أ0س', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (547, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (548, N'السيد/ مدير شرطة أبو حمد', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (549, N'السيد/ مدير وحدة أمن أبو حمد', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (550, N'السيد/ مديرالشركة السودانية للموارد المعدنية', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (551, N'السيد/ مدير إدارة العلميات البرية', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (552, N'السيد/ مدير إدارة الاستخبارات البرية', 52)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (560, N'السيد/ مدير إدارة العلميات البرية', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (561, N'السيد/ مدير إدارة الاستخبارات البرية', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (562, N'السيد/ مدير إدارة الأمن الوقائي', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (563, N'السيد/ قائد المنطقة العسكرية المركزية', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (564, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (565, N'السيد/ قائد منطقة بحري العسكرية أ.س', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (566, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (567, N'السيد/ قائد الفرقة 101 مشاه عمليات', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (568, N'السيد/ قائد الفرقة 101 مشاه أ0س', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (569, N'السيد/ قائد الفرقة 12 مشاة عمليات', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (570, N'السيد/ قائد الفرقة 12 مشاة أ.س', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (571, N'السيد/ مدير شرطة ولاية البحر الأحمر', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (572, N'السيد/ مدير وحدة أمن دورديب', 66)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (573, N'السيد/ مدير إدارة العلميات البرية', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (574, N'السيد/ مدير إدارة الاستخبارات البرية', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (575, N'السيد/ مدير إدارة الأمن الوقائي', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (576, N'السيد/ قائد المنطقة العسكرية المركزية', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (577, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (578, N'السيد/ قائد منطقة بحري العسكرية أ.س', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (579, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (580, N'السيد/ مدير شرطة ولاية الخرطوم', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (581, N'السيد/ مدير وحدة امن قري', 1)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (582, N'السيد/ مدير إدارة العلميات البرية', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (583, N'السيد/ مدير إدارة الاستخبارات البرية', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (584, N'السيد/ مدير إدارة الأمن الوقائي', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (585, N'السيد/ قائد المنطقة العسكرية المركزية', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (586, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (587, N'السيد/ قائد منطقة بحري العسكرية أ.س', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (588, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (589, N'السيد/ السيد قائد الفرقة الثالثة مشاة عمليات', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (590, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (591, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (592, N'السيد/ قائد سلاح المدفعية عطبرة أ. س', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (593, N'السيد/ مدير جهاز المخابرات العامة نهر النيل', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (594, N'السيد/ مدير شرطة ولاية نهر النيل', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (595, N'السيد/ قائد الفرقة 101 مشاة أ.س', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (596, N'السيد/ قائد الفرقة 101 مشاة عمليات', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (597, N'السيد/ مدير جهاز المخابرات العامة ولاية البحر الاحمر', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (598, N'السيد/ مدير شرطة ولاية البحر الحمر', 70)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (599, N'السيد/ مدير إدارة العلميات البرية', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (600, N'السيد/ مدير إدارة الاستخبارات البرية', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (601, N'السيد/ مدير إدارة الأمن الوقائي', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (602, N'السيد/ قائد المنطقة العسكرية المركزية', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (603, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (604, N'السيد/ قائد منطقة بحري العسكرية أ.س', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (605, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (606, N'السيد/ ركن أ0س الفرقة 19 مشاه', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (607, N'السيد/ ركن عمليات الفرقة 19 مشاه', 23)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (608, N'السيد/ مدير إدارة العلميات البرية', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (609, N'السيد/ مدير إدارة الاستخبارات البرية', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (610, N'السيد/ مدير إدارة الأمن الوقائي', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (611, N'السيد/ قائد المنطقة العسكرية المركزية', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (612, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (613, N'السيد/ قائد منطقة بحري العسكرية أ.س', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (614, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (615, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (616, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (617, N'السيد/ مدير وحدة أمن ولاية نهر النيل', 61)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (618, N'السيد/ مدير إدارة العلميات البرية', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (619, N'السيد/ مدير إدارة الاستخبارات البرية', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (620, N'السيد/ مدير إدارة الأمن الوقائي', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (621, N'السيد/ قائد المنطقة العسكرية المركزية', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (622, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (623, N'السيد/ قائد منطقة بحري العسكرية أ.س', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (624, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 16)
GO
print 'Processed 600 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (625, N'السيد/ قائد منطقة وادي سيدنا العسكرية ', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (626, N'السيد/ قائد الكلية الحربية أ.س', 16)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (643, N'السيد/ مدير إدارة العلميات البرية', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (644, N'السيد/ مدير إدارة الاستخبارات البرية', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (645, N'السيد/ مدير إدارة الأمن الوقائي', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (646, N'السيد/ قائد المنطقة العسكرية المركزية', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (647, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (648, N'السيد/ قائد منطقة بحري العسكرية أ.س', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (649, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (650, N'السيد/ قائد الفرقة 18 مشاة عمليات', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (651, N'السيد/ قائد الفرقة 18 مشاه أ. س', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (652, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (653, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (654, N'السيد/ قائد الفرقة 14 مشاة عمليات', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (655, N'السيد/ قائد الفرقة 14 مشاة ا.س', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (656, N'السيد/ قائد اللواء 56 مشاه ', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (657, N'السيد/ مدير شرطة تلودي ', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (658, N'السيد/ مدير وحدة امن تلودي', 35)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (659, N'السيد/ مدير إدارة العلميات البرية', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (660, N'السيد/ مدير إدارة الاستخبارات البرية', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (661, N'السيد/ مدير إدارة الأمن الوقائي', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (662, N'السيد/ قائد المنطقة العسكرية المركزية', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (663, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (664, N'السيد/ قائد منطقة بحري العسكرية أ.س', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (665, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (666, N'السيد/ قائد الفرقة الثالثة مشاة عمليات', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (667, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (668, N'السيد/ قائد سلاح المدفعية عطبرة / عمليات', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (669, N'السيد/ قائد سلاح المدفعية عطبرة / أ0س', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (670, N'السيد/ مدير شرطة بربر', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (671, N'السيد/ مدير وحدة امن بربر', 46)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (672, N'السيد/ مدير إدارة العلميات البرية', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (673, N'السيد/ مدير إدارة الاستخبارات البرية', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (674, N'السيد/ مدير إدارة الأمن الوقائي', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (675, N'السيد/ قائد المنطقة العسكرية المركزية', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (676, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (677, N'السيد/ قائد منطقة بحري العسكرية أ.س', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (678, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (679, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (680, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (681, N'السيد/ قائد مفرزة سلاح الاسلحة والذخائر الابيض', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (682, N'السيد/ السيد مدير شرطة ولاية شمال كردفان', 26)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (683, N'السيد/ مدير إدارة العلميات البرية', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (684, N'السيد/ مدير إدارة الاستخبارات البرية', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (685, N'السيد/ مدير إدارة الأمن الوقائي', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (686, N'السيد/ قائد المنطقة العسكرية المركزية', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (687, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (688, N'السيد/ قائد منطقة بحري العسكرية أ.س', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (689, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (690, N'السيد/ قائد منطقة أمدرمان العسكرية عمليات', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (691, N'السيد/ قائد منطقة وادي سيدنا العسكريه', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (692, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (693, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (694, N'السيد/ مدير جهاز المخابرات العامة شمال كردفان', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (695, N'السيد/ مدير شرطة ولاية شمال كردفان', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (696, N'السيد/ قائد الفرقة 14 مشاة عمليات', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (697, N'السيد/ قائد الفرقة 14 مشاة ا.س', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (698, N'السيد/ مدير جهاز المخابرات العامة جنوب كردفان', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (699, N'السيد/ مدير شرطة ولاية جنوب كردفان', 27)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (700, N'السيد/ مدير إدارة العلميات البرية', 11)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (701, N'السيد/ مدير إدارة الاستخبارات البرية', 11)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (702, N'السيد/ مدير إدارة الأمن الوقائي', 11)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (703, N'السيد/ قائد المنطقة العسكرية المركزية', 11)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (704, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 11)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (705, N'السيد/ قائد المنطقة العسكرية المركزية', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (706, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (707, N'السيد/ قائد منطقة بحري العسكرية أ.س', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (708, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (709, N'السيد/ قائد الفرقة الثالثة مشاه أ0س', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (710, N'السيد/ قائد سلاح المدفعية عطبرة أ0س', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (711, N'السيد/ قائد الفقة 101 مشاه عمليات', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (712, N'السيد/ قائد الفرقة 101  مشاه أ0س', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (713, N'السيد/ مدير شرطة ولاية البحر الأحمر', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (714, N'السيد/ مدير وحدة أمن بورتسودان', 31)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (715, N'السيد/ مدير ادارة العمليات البرية', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (716, N'السيد/ مدير ادارة الاستخبارت البرية', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (717, N'السيد/ مدير ادارة الامن الوقائي', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (718, N'السيد/ قائد المنطقة العسكرية المركزية', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (719, N'السيد/ مدير الادارة العامة للادلة الجنائية', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (720, N'السيد/ قائد منطقة بحري العسكرية أ.س', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (721, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (722, N'السيد/ قائد الفرقة 19 مشاة عمليات', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (723, N'السيد/ قائد الفرقة 19 مشاة أ.س', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (724, N'السيد/ مدير شرطة دنقلا', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (725, N'السيد/ وحدة امن حلفا', 39)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (726, N'السيد/ مدير إدارة العلميات البرية', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (727, N'السيد/ مدير إدارة الاستخبارات البرية', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (728, N'السيد/ مدير إدارة الأمن الوقائي', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (729, N'السيد/ قائد المنطقة العسكرية المركزية', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (730, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (731, N'السيد/ قائد منطقة بحري العسكرية أ.س', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (732, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (733, N'السيد/ ركن أ0س الفرقة الأولي  مشاه', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (734, N'السيد/ ركن عمليات الفرقة الثانية مشاه', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (735, N'السيد/ ركن أ0س الفرقة الثانية مشاه', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (736, N'السيد/ مدير شرطة الفاو', 81)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (737, N'السيد/ مدير إدارة العلميات البرية', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (738, N'السيد/ مدير إدارة الاستخبارات البرية', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (739, N'السيد/ مدير إدارة الأمن الوقائي', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (740, N'السيد/ قائد المنطقة العسكرية المركزية', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (741, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 12)
GO
print 'Processed 700 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (742, N'السيد/ قائد منطقة بحري العسكرية أ.س', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (743, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (744, N'السيد/ مدير شرطة قري', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (745, N'السيد/ مدير وحدة امن قري', 12)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (746, N'السيد/ مدير ادارة العمليات البرية', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (747, N'السيد/ مدير ادارة الاستخبارات العسكرية', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (748, N'السيد/ مدير الامن الوقائي', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (749, N'السيد/ قائد المنطقة العسكرية المركزية', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (750, N'السيد/ مدير الادارة العامة للادلة الجنائية', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (751, N'السيد/ قائد منطقة بحري العسكرية أ.س', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (752, N'السيد/ ركن أ.س سلاح الاسلحة والذخائر', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (753, N'السيد/ قائد الفرقة 19 مشاة عمليات', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (754, N'السيد/ قائد الفرقة 19 مشاة أ.س', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (755, N'السيد/ مدير شرطة الولاية الشمالية', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (756, N'السيد/ وحدة امن دلقو', 40)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (757, N'السيد/ مدير إدارة العلميات البرية', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (758, N'السيد/ مدير إدارة الاستخبارات البرية', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (759, N'السيد/ مدير إدارة الأمن الوقائي', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (760, N'السيد/ قائد المنطقة العسكرية المركزية', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (761, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (762, N'السيد/ قائد منطقة بحري العسكرية أ.س', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (763, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (764, N'السيد/ وحدة امن منطقة قري', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (765, N'السيد/ مدير شرطة منطقة قري', 77)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (766, N'السيد/ مدير إدارة العلميات البرية', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (767, N'السيد/ مدير إدارة الاستخبارات البرية', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (768, N'السيد/ مدير إدارة الأمن الوقائي', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (769, N'السيد/ قائد المنطقة العسكرية المركزية', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (770, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (771, N'السيد/ قائد منطقة بحري العسكرية أ.س', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (772, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (773, N'السيد/ قائد الفرقة 18 مشاة عمليات', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (774, N'السيد/ قائد الفرقة 18 مشاة أ.س', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (775, N'السيد/ قائد الفرقة الخامسة مشاه عمليات', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (776, N'السيد/ قائد الفرقة السادسة  مشاة أ.س', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (777, N'السيد/ مدير شرطة الفاشر', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (778, N'السيد/ وحدة امن الفاشر', 9)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (779, N'السيد/ مدير إدارة العلميات البرية', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (780, N'السيد/ مدير إدارة الاستخبارات البرية', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (781, N'السيد/ مدير إدارة الأمن الوقائي', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (782, N'السيد/ قائد المنطقة العسكرية المركزية', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (783, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (784, N'السيد/ قائد منطقة بحري العسكرية أ.س', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (785, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (786, N'السيد/ قائد منطقة امدرمان أ.س', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (787, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (788, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (789, N'السيد/ مدير شرطة بارا', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (790, N'السيد/ مدير وحدة أمن بارا', 24)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (804, N'السيد/ مدير إدارة العلميات البرية', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (805, N'السيد/ مدير إدارة الاستخبارات البرية', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (806, N'السيد/ مدير إدارة الأمن الوقائي', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (807, N'السيد/ قائد المنطقة العسكرية المركزية', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (808, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (809, N'السيد/ قائد منطقة بحري العسكرية أ.س', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (810, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (811, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (812, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (813, N'السيد/ مدير شرطة ابوحمد', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (814, N'السيد/ مدير وحدة امن ابوحمد', 63)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (815, N'السيد/ مدير إدارة العلميات البرية', 14)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (816, N'السيد/ مدير إدارة الاستخبارات البرية', 14)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (817, N'السيد/ مدير إدارة الأمن الوقائي', 14)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (818, N'السيد/ قائد المنطقة العسكرية المركزية', 14)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (819, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 14)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (820, N'السيد/ قائد منطقة بحري العسكرية أ.س', 14)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (821, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 14)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (822, N'السيد/ مدير إدارة العلميات البرية', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (823, N'السيد/ مدير إدارة الاستخبارات البرية', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (824, N'السيد/ مدير إدارة الأمن الوقائي', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (825, N'السيد/ قائد المنطقة العسكرية المركزية', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (826, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (827, N'السيد/ قائد منطقة بحري العسكرية أ.س', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (828, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (829, N'السيد/ قائد منطقة أمدرمان العسكرية', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (830, N'السيد/ مدير وحدة أمن ولاية الخرطوم', 13)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (831, N'السيد/ مدير إدارة العلميات البرية', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (832, N'السيد/ مدير إدارة الاستخبارات البرية', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (833, N'السيد/ مدير إدارة الأمن الوقائي', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (834, N'السيد/ قائد المنطقة العسكرية المركزية', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (835, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (836, N'السيد/ قائد منطقة بحري العسكرية أ.س', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (837, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (838, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (839, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (840, N'السيد/ قائد الفرقة 101 مشاة عمليات', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (841, N'السيد/ قائد الفرقة 101 مشاة أ.س', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (842, N'السيد/ مدير شرطة ولاية البحر الأحمر ', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (843, N'السيد/ مدير وحدة أمن ولاية البحر الأحمر ', 65)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (844, N'السيد/ مدير إدارة العلميات البرية', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (845, N'السيد/ مدير إدارة الاستخبارات البرية', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (846, N'السيد/ مدير إدارة الأمن الوقائي', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (847, N'السيد/ قائد المنطقة العسكرية المركزية', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (848, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (849, N'السيد/ قائد منطقة بحري العسكرية أ.س', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (850, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (851, N'السيد/ قائد الفرقة 19 مشاة أ.س', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (852, N'السيد/ ركن عمليات الفرقة 19 مشاه', 25)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (853, N'السيد/ مدير إدارة الأمن الوقائي', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (854, N'السيد/ قائد المنطقة العسكرية المركزية', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (855, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 56)
GO
print 'Processed 800 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (856, N'السيد/ قائد منطقة بحري العسكرية أ.س', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (857, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (858, N'السيد/ قائدالفرقة الثالثة مشاه /أ.س', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (859, N'السيد/ قائد سلاح المدفعية عطبرة عمليات ', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (860, N'السيد/ قائد سلاح المدفعية عطبرة ا.س', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (861, N'السيد/ مدير شرطة العبيدية', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (862, N'السيد/ مدير وحدة أمن العبيدية', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (863, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (864, N'السيد/ قائد منطقة بحري العسكرية أ.س', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (865, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (866, N'السيد/ مدير إدارة العلميات البرية', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (867, N'السيد/ مدير إدارة الاستخبارات البرية', 56)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (868, N'السيد/ السيد قائد الفرقة الثالثة مشاة عمليات', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (869, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (870, N'السيد/ |قائد سلاح المدفعية عطبرة عمليات', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (871, N'السيد/ |قائد سلاح المدفعية عطبرة أس', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (872, N'السيد/ مدير شرطة ولاية نهر النيل', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (873, N'السيد/ قائد نقطة المفرقعات المتقدمة عطبرة', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (874, N'السيد/ مدير إدارة العلميات البرية', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (875, N'السيد/ مدير إدارة الاستخبارات البرية', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (876, N'السيد/ مدير إدارة الأمن الوقائي', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (877, N'السيد/ مدير إدارة العلميات البرية', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (878, N'السيد/ مدير إدارة الاستخبارات البرية', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (879, N'السيد/ قائد المنطقة العسكرية المركزية', 89)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (880, N'السيد/ مدير إدارة الأمن الوقائي', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (881, N'السيد/ قائد المنطقة العسكرية المركزية', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (882, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (883, N'السيد/ قائد منطقة بحري العسكرية أ.س', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (884, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (885, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (886, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (887, N'السيد/ |قائد سلاح المدفعية عطبرة عمليات', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (888, N'السيد/ |قائد سلاح المدفعية عطبرة أس', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (889, N'السيد/ مدير إدارة العلميات البرية', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (890, N'السيد/ مدير إدارة الاستخبارات البرية', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (891, N'السيد/ مدير إدارة الأمن الوقائي', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (892, N'السيد/ قائد المنطقة العسكرية المركزية', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (893, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (894, N'السيد/ قائد منطقة بحري العسكرية أ.س', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (895, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (896, N'السيد/ قائد الفرقة 18 مشاة عمليات', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (897, N'السيد/ قائد الفرقة 18 مشاه أ. س', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (898, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (899, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (900, N'السيد/ قائد الفرقة 14 مشاة عمليات', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (901, N'السيد/ قائد الفرقة 14 مشاة ا.س', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (902, N'السيد/ مدير شرطة ام روابة', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (903, N'السيد/ مدير وحدة امن ام روابة', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (904, N'السيد/ مدير شرطة العباسية', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (905, N'السيد/ مدير وحدة امن العباسية', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (906, N'السيد/ مدير شرطة ابوجبيهه', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (907, N'السيد/ مدير وحدة أمن ابوجبيهه', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (908, N'السيد/ مدير شرطة كلوتي', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (909, N'السيد/ مدير وحدة امن كلوتي', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (910, N'السيد/ مدير شرطة تلودي ', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (911, N'السيد/ مدير وحدة امن تلودي', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (912, N'السيد/ قائد اللواء 56 مشاه ', 34)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (913, N'السيد/ مدير شرطة ولاية نهر النيل', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (914, N'السيد/ مدير جهاز المخابرات العامة نهر النيل', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (915, N'السيد/ مدير شرطة ولاية نهر النيل', 58)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (916, N'السيد/ قائد منطقة بحري العسكرية أ.س', 11)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (917, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 11)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (918, N'السيد/ مدير إدارة العلميات البرية', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (919, N'السيد/ مدير إدارة الاستخبارات البرية', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (920, N'السيد/ مدير إدارة الأمن الوقائي', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (921, N'السيد/ مدير إدارة العلميات البرية', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (922, N'السيد/ مدير إدارة الاستخبارات البرية', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (923, N'السيد/ مدير إدارة الأمن الوقائي', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (924, N'السيد/ قائد المنطقة العسكرية المركزية', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (925, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (926, N'السيد/ قائد منطقة بحري العسكرية أ.س', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (927, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (928, N'السيد/ قائد الفرقة 18 مشاة عمليات', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (929, N'السيد/ قائد الفرقة 18 مشاة أ.س', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (930, N'السيد/ مدير شرطة ولاية النيل الابيض', 33)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (931, N'السيد/ مدير إدارة العلميات البرية', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (932, N'السيد/ مدير إدارة الاستخبارات البرية', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (933, N'السيد/ مدير إدارة الأمن الوقائي', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (934, N'السيد/ قائد المنطقة العسكرية المركزية', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (935, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (936, N'السيد/ قائد منطقة بحري العسكرية أ.س', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (937, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (938, N'السيد/ قائد الفرقة الثالثة مشاة عمليات', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (939, N'السيد/ قائد الفرقة الثالثة مشاة أ.س', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (940, N'السيد/ مدير شرطة ولاية نهر النيل', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (941, N'السيد/ مدير امن ولاية نهر النيل', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (942, N'السيد/ |قائد سلاح المدفعية عطبرة عمليات', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (943, N'السيد/ قائد سلاح المدفعية عطبرة أ.س', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (944, N'السيد/ قائد الفرقة الثالثة شندي أ.س', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (945, N'السيد/ قائد الفرقة الثالثة شندي عمليات', 53)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (946, N'السيد/ مدير إدارة العمليات البرية', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (947, N'السيد/ مدير إدارة الإستخبارت برية', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (948, N'السيد/ مدير الأمن الوقائي', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (949, N'السيد/ مدير الادارة العامة للادلة والتحقيقات الجنائية .', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (950, N'السيد/ قائد منطقة بحري العسكرية أ.س .', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (951, N'السيد/ ركن أ0س سلاح الأسلحة .', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (952, N'السيد/ قائد الفرقة الثالثة مشاه أ0س . ', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (953, N'السيد/ قائد سلاح المدفعية عطبرة إ.س .', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (954, N'السيد/ قائد سلاح المدفعية عمليات .', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (955, N'السيد/ مدير وحدة امن ولاية نهر النيل', 48)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (956, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 44)
GO
print 'Processed 900 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (957, N'السيد/ قائد منطقة بحري العسكرية أ.س', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (958, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (959, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (960, N'السيد/ السيد قائد الفرقة الثالثة مشاة عمليات', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (961, N'السيد/ مدير شرطة ولاية نهر النيل', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (962, N'السيد/ مدير جهاز المخابرات العامه نهر النيل', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (963, N'السيد/ |قائد سلاح المدفعية عطبرة عمليات', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (964, N'السيد/ |قائد سلاح المدفعية عطبرة أس', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (965, N'السيد/ مدير إدارة العلميات البرية', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (966, N'السيد/ مدير إدارة الاستخبارات البرية', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (967, N'السيد/ مدير إدارة الأمن الوقائي', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (968, N'السيد/ مدير إدارة العلميات البرية', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (969, N'السيد/ مدير إدارة الاستخبارات البرية', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (970, N'السيد/ مدير إدارة الأمن الوقائي', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (971, N'السيد/ قائد المنطقة العسكرية المركزية', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (972, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (973, N'السيد/ قائد منطقة بحري العسكرية أ.س', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (974, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (975, N'السيد/ قائدالفرقة الثالثة مشاه /أ.س', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (976, N'السيد/ قائد سلاح المدفعية عطبرة عمليات ', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (977, N'السيد/ قائد سلاح المدفعية عطبرة ا.س', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (978, N'السيد/ مدير شرطة العبيدية', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (979, N'السيد/ مدير وحدة أمن العبيدية', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (980, N'السيد/ مدير شركة تارقيت للأنشطة المتعددة', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (981, N'السيد/ مدير شركة رهبان الليل للانشطة المتعددة ', 57)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (982, N'السيد/ قائد المنطقة العسكرية المركزية', 44)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (983, N'السيد/ قائد المنطقة العسكرية المركزية', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (984, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (985, N'السيد/ قائد منطقة بحري العسكرية أ.س', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (986, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (987, N'السيد/ قائد منطقة امدرمان العسكرية', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (988, N'السيد/ قائد منطقة وادي سيدنا العسكرية', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (989, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (990, N'السيد/ مدير شرطة ولاية شمال كردفان', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (991, N'السيد/ قائد اللواء 56 مشاه ', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (992, N'السيد/ مدير شرطة تلودي ', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (993, N'السيد/ مدير وحدة امن تلودي', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (994, N'السيد/ قائد الفرقة الخامسة مشاه', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (995, N'السيد/ قائد الفرقة 14 مشاه', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (996, N'السيد/ مدير جهاز المخابرات العامة جنوب كردفان', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (997, N'السيد/ مدير شرطة ولاية جنوب كردفان', 6)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (998, N'السيد/ مدير إدارة العلميات البرية', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (999, N'السيد/ مدير إدارة الاستخبارات البرية', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1000, N'السيد/ مدير إدارة الأمن الوقائي', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1001, N'السيد/ قائد المنطقة العسكرية المركزية', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1002, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1003, N'السيد/ قائد منطقة بحري العسكرية أ.س', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1004, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1005, N'السيد/ قائد سلاح المهندسين أ.س', 30)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1006, N'السيد/ مدير إدارة العلميات البرية', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1007, N'السيد/ مدير إدارة الاستخبارات البرية', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1008, N'السيد/ مدير إدارة الأمن الوقائي', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1009, N'السيد/ قائد المنطقة العسكرية المركزية', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1010, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1011, N'السيد/ قائد منطقة بحري العسكرية أ.س', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1012, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1013, N'السيد/ قائد سلاح المدفعية عمليات', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1014, N'السيد/ قائد سلاح المدفعية ا.س', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1015, N'السيد/ مدير شرطة عطبرة', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1016, N'السيد/ وحدة امن عطبرة', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1017, N'السيد/ مدير شرطة العبيدية', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1018, N'السيد/ مدير شرطة البحر الاحمر', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1019, N'السيد/ وحدة امن البحر الاحمر', 74)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1020, N'السيد/ مدير إدارة العلميات البرية', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1021, N'السيد/ مدير إدارة الاستخبارات البرية', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1022, N'السيد/ مدير إدارة الأمن الوقائي', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1023, N'السيد/ قائد المنطقة العسكرية المركزية', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1024, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1025, N'السيد/ قائد منطقة بحري العسكرية أ.س', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1026, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1027, N'السيد/ قائد منطقة أمدرمان أ0س', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1028, N'السيد/ قائد سلاح المهندسين أ0س', 29)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1029, N'السيد/ مدير إدارة الأمن الوقائي', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1030, N'السيد/ قائد المنطقة العسكرية المركزية', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1031, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1032, N'السيد/ قائد منطقة بحري العسكرية أ.س', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1033, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1034, N'السيد/ السيد قائد الفرقة الثالثة مشاة أ.س', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1035, N'السيد/ السيد قائد الفرقة الثالثة مشاة عمليات', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1036, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1037, N'السيد/ قائد سلاح المدفعية عطبرة أ. س', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1038, N'السيد/ قائد الفرقة 101  مشاه أ0س', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1039, N'السيد/ قائد الفرقة 101 مشاه عمليات', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1044, N'السيد/ مدير إدارة العلميات البرية', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1045, N'السيد/ مدير إدارة الاستخبارات البرية', 71)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1058, N'السيد/ مدير إدارة الأمن الوقائي', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1059, N'السيد/ قائد المنطقة العسكرية المركزية', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1060, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1061, N'السيد/ قائد منطقة بحري العسكرية أ.س', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1062, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1063, N'السيد/ قائد منطقة أمدرمان العسكرية عمليات', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1064, N'السيد/ قائد منطقة أمدرمان أ0س', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1065, N'السيد/ قائد الفرقة الخامسة مشاه عمليات', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1066, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1067, N'السيد/ مدير جهاز المخابرات العامة شمال كردفان', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1068, N'السيد/ مدير شرطة ولاية شمال كردفان', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1069, N'السيد/ قائد الفرقة 14 مشاة عمليات', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1070, N'السيد/ قائد الفرقة 14 مشاة ا.س', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1071, N'السيد/ مدير جهاز المخابرات العامة جنوب كردفان', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1072, N'السيد/ مدير شرطة ولاية جنوب كردفان', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1073, N'السيد/ مدير إدارة العلميات البرية', 28)
GO
print 'Processed 1000 total records'
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1074, N'السيد/ مدير إدارة الاستخبارات البرية', 28)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1075, N'السيد/ مدير ادارة العمليات برية', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1076, N'السيد/ مدير ادارة الاستخبارات البرية', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1077, N'السيد/ مدير ادارة الامن الوقائي', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1078, N'السيد/ قائد المنطقة العسكرية المركزية', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1079, N'السيد/ مدير الادارة العامة للادلة الجنائية', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1080, N'السيد/ ركن ا.س سلاح الاسلحة والذخائر', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1081, N'السيد/ قائد الفرقة 18 مشاة عمليات', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1082, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1083, N'السيد/ قائد الفرقة الخامسة مشاة ا.س', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1084, N'السيد/ مدير شرطة ولاية جنوب كردفان', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1085, N'السيد/ وحدة امن كادقلي', 10)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1086, N'السيد/ مدير إدارة العلميات البرية', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1087, N'السيد/ مدير إدارة الاستخبارات البرية', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1088, N'السيد/ مدير إدارة الأمن الوقائي', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1089, N'السيد/ قائد المنطقة العسكرية المركزية', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1090, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1091, N'السيد/ قائد منطقة بحري العسكرية أ.س', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1092, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1093, N'السيد/ قائد الفرقة الثالية مشاه أ0س', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1094, N'السيد/ قائد سلاح المدفعية عطبرة عمليات', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1095, N'السيد/ قائد سلاح المدفعية عطبرة أ0س', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1096, N'السيد/ قائد الفرقة 101 / عمليات', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1097, N'السيد/ قائد الفرقة 101 / أ.س', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1098, N'السيد/ مدير شرطة جبيت ', 51)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1106, N'السيد/ مدير إدارة العلميات البرية', 2)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1107, N'السيد/ مدير إدارة الاستخبارات البرية', 2)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1108, N'السيد/ مدير إدارة الأمن الوقائي', 2)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1109, N'السيد/ قائد المنطقة العسكرية المركزية', 2)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1110, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 2)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1111, N'السيد/ قائد منطقة بحري العسكرية أ.س', 2)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1112, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 2)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1114, N'السيد/ قري', 94)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1122, N'السيد/ مدير إدارة العلميات البرية', 95)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1123, N'السيد/ مدير إدارة الاستخبارات البرية', 95)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1124, N'السيد/ مدير إدارة الأمن الوقائي', 95)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1125, N'السيد/ قائد المنطقة العسكرية المركزية', 95)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1126, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 95)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1127, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 95)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1128, N'السيد/ قائد منطقة بحري العسكرية أ.س', 95)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1142, N'السيد/ مدير إدارة العلميات البرية', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1143, N'السيد/ مدير إدارة الاستخبارات البرية', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1144, N'السيد/ مدير إدارة الأمن الوقائي', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1145, N'السيد/ قائد المنطقة العسكرية المركزية', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1146, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1147, N'السيد/ قائد منطقة بحري العسكرية أ.س', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1148, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1149, N'السيد/ قائد الفرقة 18 مشاة عمليات', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1150, N'السيد/ قائد الفرقة الخامسة مشاة ا.س', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1151, N'السيد/ قائد الفرقة 14 مشاة عمليات', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1152, N'السيد/ قائد الفرقة 14 مشاة ا.س', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1153, N'السيد/ مدير شرطة ولاية جنوب كردفان', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1154, N'السيد/ وحدة امن كادوقلي', 4)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1155, N'السيد/ مدير إدارة العلميات البرية', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1156, N'السيد/ مدير إدارة الاستخبارات البرية', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1157, N'السيد/ مدير إدارة الأمن الوقائي', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1158, N'السيد/ قائد المنطقة العسكرية المركزية', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1159, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1160, N'السيد/ قائد منطقة بحري العسكرية أ.س', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1161, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1162, N'السيد/ قائد الفرقة 18 مشاة عمليات', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1163, N'السيد/ قائد الفرقة 18 مشاه أ. س', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1164, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1165, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1166, N'السيد/ قائد الفرقة 14 مشاة عمليات', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1167, N'السيد/ قائد الفرقة 14 مشاة ا.س', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1168, N'السيد/ قائد اللواء 56 مشاه ', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1169, N'السيد/ مدير وحدة امن تلودي', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1170, N'السيد/ مدير شرطة تلودي ', 3)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1171, N'السيد/ مدير إدارة العلميات البرية', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1172, N'السيد/ مدير إدارة الاستخبارات البرية', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1173, N'السيد/ مدير إدارة الأمن الوقائي', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1174, N'السيد/ قائد المنطقة العسكرية المركزية', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1175, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1176, N'السيد/ قائد منطقة بحري العسكرية أ.س', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1177, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1178, N'السيد/ قائد الفرقة 18 مشاة عمليات', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1179, N'السيد/ قائد الفرقة 18 مشاه أ. س', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1180, N'السيد/ قائد الفرقة الخامسة مشاة عمليات', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1181, N'السيد/ قائد الفرقة الخامسة مشاة أ.س', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1182, N'السيد/ قائد الفرقة 14 مشاة عمليات', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1183, N'السيد/ قائد الفرقة 14 مشاة ا.س', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1184, N'السيد/ قائد اللواء 56 مشاه ', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1185, N'السيد/ مدير شرطة تلودي ', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1186, N'السيد/ مدير وحدة امن تلودي', 5)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1187, N'السيد/ مدير إدارة العلميات البرية', 96)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1188, N'السيد/ مدير إدارة الاستخبارات البرية', 96)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1189, N'السيد/ مدير إدارة الأمن الوقائي', 96)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1190, N'السيد/ قائد المنطقة العسكرية المركزية', 96)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1191, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 96)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1192, N'السيد/ قائد منطقة بحري العسكرية أ.س', 96)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1193, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 96)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1194, N'السيد/ مدير إدارة العلميات البرية', 97)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1195, N'السيد/ مدير إدارة الاستخبارات البرية', 97)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1196, N'السيد/ مدير إدارة الأمن الوقائي', 97)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1197, N'السيد/ قائد المنطقة العسكرية المركزية', 97)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1198, N'السيد/ مدير الإدارة العامة للأدلة الجنائية', 97)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1199, N'السيد/ قائد منطقة بحري العسكرية أ.س', 97)
INSERT [dbo].[PassCopiesDetails] ([PassCopySirsID], [Sirs], [PassCopyID]) VALUES (1200, N'السيد/ ركن أ.س سلاح الأسلحة والذخائر', 97)
SET IDENTITY_INSERT [dbo].[PassCopiesDetails] OFF
/****** Object:  Table [dbo].[PassCopies1]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassCopies1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sender] [nvarchar](150) NULL,
	[Receiver] [nvarchar](150) NULL,
	[Sirs] [nvarchar](150) NULL,
	[Point1] [nvarchar](50) NULL,
	[Point2] [nvarchar](50) NULL,
	[Point3] [nvarchar](50) NULL,
 CONSTRAINT [PK_PassCopies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassCopies]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassCopies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sender] [nvarchar](50) NULL,
	[Receiver] [nvarchar](50) NULL,
	[Point1] [nvarchar](50) NULL,
	[Point2] [nvarchar](50) NULL,
	[Point3] [nvarchar](50) NULL,
 CONSTRAINT [PK_PassCopies_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PassCopies] ON
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (1, N'', N'', N'الخرطوم', N'الجيلي', N'العيلفون')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (2, N'', N'', N'الكدرو', N'بحري', N'العيلفون')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (3, N'', N'', N'جنوب كردفان', N' التضامن', N'تلودي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (4, N'', N'', N'جنوب كردفان', N'كادوقلي', N'')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (5, N'', N'', N'حجر العسل', N'عطبرة', N'أبو حراز')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (6, N'', N'', N'حجر العسل', N' بارا', N'تلودي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (7, N'', N'', N'حجر العسل', N'الأبيض', N'الجنينة')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (8, N'', N'', N'حجر العسل', N'الأبيض', N'نيالا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (9, N'', N'', N'حجر العسل', N'الابيض', N'الفاشر')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (10, N'', N'', N'حجر العسل', N'الابيض', N'كادوقلي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (11, N'', N'', N'حجر العسل', N'البكاش', N'الجيلي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (12, N'', N'', N'حجر العسل', N'البكاش', N'قري')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (13, N'', N'', N'حجر العسل', N'الجيلي', N'أمدرمان')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (14, N'', N'', N'حجر العسل', N'الجيلي', N'الكدرو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (15, N'', N'', N'حجر العسل', N'الجيلي', N'قري')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (16, N'', N'', N'حجر العسل', N'الحلفايا', N'الكلية الحربية')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (17, N'', N'', N'حجر العسل', N'العبيدية', N'جبال النمر')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (18, N'', N'', N'حجر العسل', N'القضارف', N'الصباغ')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (19, N'', N'', N'حجر العسل', N'القضارف', N'الفاو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (20, N'', N'', N'حجر العسل', N'القطينة', N'ربك')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (21, N'', N'', N'حجر العسل', N'الملتقي', N'دلقو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (22, N'', N'', N'حجر العسل', N'الملتقي', N'عبري')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (23, N'', N'', N'حجر العسل', N'الملتقي', N'كريمة')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (24, N'', N'', N'حجر العسل', N'امدرمان', N'بارا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (25, N'', N'', N'حجر العسل ', N'امدرمان ', N'دنقلا ')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (26, N'', N'', N'حجر العسل', N'بارا', N'الابيض')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (27, N'', N'', N'حجر العسل', N'بارا', N'الليري')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (28, N'', N'', N'حجر العسل', N'بارا', N'كلوقي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (29, N'', N'', N'حجر العسل', N'بحري', N'أمدرمان')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (30, N'', N'', N'حجر العسل', N'بحري', N'العيلفون')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (31, N'', N'', N'حجر العسل', N'بورتسودان', N'جبال نمر')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (32, N'', N'', N'حجر العسل', N'بورتسودان', N'سقوم')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (33, N'', N'', N'حجر العسل', N'جبل أولياء', N'ربك')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (34, N'', N'', N'حجر العسل', N'جنوب كردفان', N'التضامن')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (35, N'', N'', N'حجر العسل', N'جنوب كردفان', N'تلودي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (36, N'', N'', N'حجر العسل', N'دنقلا', N'')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (37, N'', N'', N'حجر العسل', N'دنقلا', N']دلقو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (38, N'', N'', N'حجر العسل', N'دنقلا', N'الدويشات')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (39, N'', N'', N'حجر العسل', N'دنقلا', N'حلفا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (40, N'', N'', N'حجر العسل', N'دنقلا', N'دلقو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (41, N'', N'', N'حجر العسل', N'دنقلا', N'كريمة')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (42, N'', N'', N'حجر العسل', N'سنجة', N'الدمازين')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (43, N'', N'', N'حجر العسل', N'شندي', N'ابوحمد')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (44, N'', N'', N'حجر العسل', N'شندي', N'العوتيب')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (45, N'', N'', N'حجر العسل', N'شندي', N'بربر')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (46, N'', N'', N'حجر العسل', N'شندي', N'بربر / ابوفصوص')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (47, N'', N'', N'حجر العسل', N'شندي', N'شندي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (48, N'', N'', N'حجر العسل', N'شندي', N'عطبرة')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (49, N'', N'', N'حجر العسل', N'شندي', N'غرب شندي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (50, N'', N'', N'حجر العسل', N'شندي', N'غرب عطبرة')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (51, N'', N'', N'حجر العسل', N'عطبرة', N'جبيت المعادن / شنعاب')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (52, N'', N'', N'حجر العسل', N'عطبرة', N'أبو حمد')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (53, N'', N'', N'حجر العسل', N'عطبرة', N'الحجاجية')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (54, N'', N'', N'حجر العسل', N'عطبرة', N'الشريك')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (55, N'', N'', N'حجر العسل', N'عطبرة', N'الصباغ')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (56, N'', N'', N'حجر العسل ', N'عطبرة', N'العبيدية ')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (57, N'', N'', N'حجر العسل ', N'عطبرة', N'العبيدية / الكليس')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (58, N'', N'', N'حجر العسل ', N'عطبرة', N'الفاضلاب جنوب')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (59, N'', N'', N'حجر العسل', N'عطبرة', N'المرات')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (60, N'', N'', N'حجر العسل', N'عطبرة', N'الياسمين')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (61, N'', N'', N'حجر العسل', N'عطبرة', N'بربر')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (62, N'', N'', N'حجر العسل', N'عطبرة', N'بورتسودان')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (63, N'', N'', N'حجر العسل', N'عطبرة', N'جبال النمر')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (64, N'', N'', N'حجر العسل', N'عطبرة', N'جبيت')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (65, N'', N'', N'حجر العسل', N'عطبرة', N'حلايب')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (66, N'', N'', N'حجر العسل', N'عطبرة', N'درديب')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (67, N'', N'', N'حجر العسل', N'عطبرة', N'دنقلا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (68, N'', N'', N'حجر العسل', N'عطبرة', N'دورديب')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (69, N'', N'', N'حجر العسل', N'عطبرة', N'سنكات')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (70, N'', N'', N'حجر العسل', N'عطبرة', N'نورايا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (71, N'', N'', N'حجر العسل', N'عطبرة', N'نوراية ــ مربع 58')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (72, N'', N'', N'حجر العسل', N'عطبرة', N'هيا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (73, N'', N'', N'حجر العسل', N'عطبرة', N'وادي العلاق')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (74, N'', N'', N'حجر العسل', N'عطبرة/ العبيدية', N'الياسمين')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (75, N'', N'', N'حجر العسل', N'قري', N'')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (76, N'', N'', N'حجر العسل', N'قري', N'السليت')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (77, N'', N'', N'حجر العسل', N'قري', N'مجمع سابقات')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (78, N'', N'', N'حجر العسل', N'كوستي', N'نيالا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (79, N'', N'', N'حجر العسل', N'مدني', N'الدمازين')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (80, N'', N'', N'حجر العسل', N'مدني', N'الشوك')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (81, N'', N'', N'حجر العسل', N'مدني', N'الفاو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (82, N'', N'', N'حجر العسل', N'مدني', N'القضارف')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (83, N'', N'', N'حجر العسل', N'مدني', N'القضارف/ سمسم')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (84, N'', N'', N'حجر العسل', N'مدني', N'سنار')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (85, N'', N'', N'حجر العسل', N'مدني', N'سنار /جبل موية')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (86, N'', N'', N'حجر العسل', N'مدني', N'كسلا')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (87, N'', N'', N'حجرالعسل', N'امدرمان', N'سلاح المهندسين')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (88, N'', N'', N'حجرالعسل', N'دنقلا', N'دلقو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (89, N'', N'', N'حجرالعسل', N'عطبرة', N'وادي الكرمت')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (90, N'', N'', N'قري', N'الجيلي', N'الكدرو')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (91, N'', N'', N'وادي حلفا', N'عطبرة', N'حجر العسل')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (92, NULL, NULL, N'حجر العسل', N' التضامن', N'تلودي')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (93, NULL, NULL, N'الكدرو', N'بحري', N'العيلفون')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (94, NULL, NULL, N'الخرطوم', N'الجيلي', N'قري')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (95, NULL, NULL, N'الخرطوم', N'الحلفايا', N'شمبات')
INSERT [dbo].[PassCopies] ([ID], [Sender], [Receiver], [Point1], [Point2], [Point3]) VALUES (96, NULL, NULL, N'الخرطوم', N'بحري', N'شندي')
SET IDENTITY_INSERT [dbo].[PassCopies] OFF
/****** Object:  Table [dbo].[OurImportDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OurImportDetails](
	[OurImportDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Unit] [nvarchar](50) NULL,
	[SampleNo] [nvarchar](50) NULL,
	[RecordNo] [nvarchar](50) NULL,
	[OurImportID] [int] NULL,
 CONSTRAINT [PK_OurImportDetails] PRIMARY KEY CLUSTERED 
(
	[OurImportDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OurImportDetails] ON
INSERT [dbo].[OurImportDetails] ([OurImportDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurImportID]) VALUES (12, N'نترات امونيوم ', CAST(175587.00 AS Decimal(18, 2)), N'كجم', N'', N'', 1)
INSERT [dbo].[OurImportDetails] ([OurImportDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurImportID]) VALUES (13, N'أنفو', CAST(475.00 AS Decimal(18, 2)), N'كجم', N'', N'', 1)
INSERT [dbo].[OurImportDetails] ([OurImportDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurImportID]) VALUES (14, N'كبسولة كهربائية تاخيرية 4 متر', CAST(42641.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 1)
INSERT [dbo].[OurImportDetails] ([OurImportDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurImportID]) VALUES (15, N'املشن 30مم', CAST(350.00 AS Decimal(18, 2)), N'كجم', N'', N'', 1)
SET IDENTITY_INSERT [dbo].[OurImportDetails] OFF
/****** Object:  Table [dbo].[OURIMPORT]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OURIMPORT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ACCOUNT] [nvarchar](50) NULL,
	[DISTRACTOR] [nvarchar](150) NULL,
	[STATIONREC] [nvarchar](150) NULL,
	[RECEIVER] [nvarchar](150) NULL,
	[CONSIGNMENT] [nvarchar](150) NULL,
	[DISTDATE] [date] NULL,
	[POLICYID] [nvarchar](50) NULL,
	[NOTES] [nvarchar](150) NULL,
	[DISTRACTAUTHERITY] [nvarchar](150) NULL,
	[RANK] [nvarchar](150) NULL,
	[DISTSIGNATURE] [nvarchar](150) NULL,
	[DISTADOPTION] [nvarchar](150) NULL,
	[RECAUTHERITY] [nvarchar](150) NULL,
	[RECRANK] [nvarchar](150) NULL,
	[RECNAME] [nvarchar](150) NULL,
	[DISTNAME] [nvarchar](150) NULL,
	[RECSIGNATURE] [nvarchar](150) NULL,
	[RECADOPTION] [nvarchar](150) NULL,
	[DURATION] [nvarchar](150) NULL,
	[STATIONDIST] [nvarchar](150) NULL,
	[INSTRUCTIONS] [nvarchar](150) NULL,
	[OurImportNo] [int] NULL,
 CONSTRAINT [PK_OURIMPORT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OURIMPORT] ON
INSERT [dbo].[OURIMPORT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurImportNo]) VALUES (1, N'مفرقعات', NULL, NULL, NULL, NULL, CAST(0x6A420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[OURIMPORT] OFF
/****** Object:  Table [dbo].[OurDistractDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OurDistractDetails](
	[OurDistractDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Unit] [nvarchar](20) NULL,
	[SampleNo] [nvarchar](50) NULL,
	[RecordNo] [nvarchar](50) NULL,
	[OurDistractID] [int] NULL,
 CONSTRAINT [PK_OurDistractDetails] PRIMARY KEY CLUSTERED 
(
	[OurDistractDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OurDistractDetails] ON
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (4, N'نترات أمونيوم', CAST(25000.00 AS Decimal(18, 2)), N'كجم', N'', N'', 2)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (8, N'كورتكس', CAST(5000.00 AS Decimal(18, 2)), N'متر', N'', N'', 3)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (9, N'كبسولة كهربائية لحظية 4 متر', CAST(250.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 3)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (10, N'نترات أمونيوم', CAST(500.00 AS Decimal(18, 2)), N'كجم', N'', N'', 3)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (11, N'كورتكس', CAST(5000.00 AS Decimal(18, 2)), N'متر', N'', N'', 4)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (12, N'كبسولة كهربائية لحظية 4 متر', CAST(250.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 4)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (13, N'نترات أمونيوم', CAST(500.00 AS Decimal(18, 2)), N'كجم', N'', N'', 4)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (14, N'املشن 30مم', CAST(350.00 AS Decimal(18, 2)), N'كجم', N'', N'', 4)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (15, N'كورتكس', CAST(5000.00 AS Decimal(18, 2)), N'متر', N'', N'', 5)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (16, N'شريط أمان', CAST(1000.00 AS Decimal(18, 2)), N'متر', N'', N'', 5)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (17, N'كبسولة كهربائية لحظية 4 متر', CAST(100.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 5)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (18, N'كبسولة عادية', CAST(100.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 5)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (25, N'كورتكس', CAST(6000.00 AS Decimal(18, 2)), N'متر', N'', N'', 6)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (26, N'شريط أمان', CAST(1000.00 AS Decimal(18, 2)), N'متر', N'', N'', 6)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (27, N'كبسولة كهربائية لحظية 4 متر', CAST(750.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 6)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (28, N'كبسولة عادية', CAST(500.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 6)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (29, N'نترات امونيوم ', CAST(1000.00 AS Decimal(18, 2)), N'كجم', N'', N'', 6)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (30, N'كبسولة نونيل 3.6 متر', CAST(500.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 6)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (31, N'كورتكس', CAST(5000.00 AS Decimal(18, 2)), N'متر', N'', N'', 7)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (32, N'كبسولة كهربائية لحظية 4 متر', CAST(250.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 7)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (33, N'نترات أمونيوم', CAST(500.00 AS Decimal(18, 2)), N'كجم', N'', N'', 7)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (46, N'نترات امونيوم ', CAST(3000.00 AS Decimal(18, 2)), N'كجم', N'', N'', 1)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (47, N'كبسولة كهربائية تاخيرية 4 متر', CAST(1000.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 1)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (48, N'املشن 30مم', CAST(1000.00 AS Decimal(18, 2)), N'كجم', N'', N'', 1)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (55, N'كورتكس', CAST(6000.00 AS Decimal(18, 2)), N'متر', N'', N'', 8)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (56, N'شريط أمان', CAST(1000.00 AS Decimal(18, 2)), N'متر', N'', N'', 8)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (57, N'كبسولة كهربائية لحظية 4 متر', CAST(750.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 8)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (58, N'كبسولة عادية', CAST(500.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 8)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (59, N'نترات امونيوم ', CAST(1000.00 AS Decimal(18, 2)), N'كجم', N'', N'', 8)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (60, N'كبسولة نونيل 3.6 متر', CAST(500.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 8)
INSERT [dbo].[OurDistractDetails] ([OurDistractDetailsID], [Description], [Quantity], [Unit], [SampleNo], [RecordNo], [OurDistractID]) VALUES (61, N'متعدد', CAST(100.00 AS Decimal(18, 2)), N'قطعة', N'', N'', 9)
SET IDENTITY_INSERT [dbo].[OurDistractDetails] OFF
/****** Object:  Table [dbo].[OURDISTRACT]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OURDISTRACT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ACCOUNT] [nvarchar](20) NULL,
	[DISTRACTOR] [nvarchar](100) NULL,
	[STATIONREC] [nvarchar](50) NULL,
	[RECEIVER] [nvarchar](50) NULL,
	[CONSIGNMENT] [nvarchar](50) NULL,
	[DISTDATE] [date] NULL,
	[POLICYID] [nvarchar](20) NULL,
	[NOTES] [nvarchar](70) NULL,
	[DISTRACTAUTHERITY] [nvarchar](50) NULL,
	[RANK] [nvarchar](20) NULL,
	[DISTSIGNATURE] [nvarchar](40) NULL,
	[DISTADOPTION] [nvarchar](50) NULL,
	[RECAUTHERITY] [nvarchar](50) NULL,
	[RECRANK] [nvarchar](20) NULL,
	[RECNAME] [nvarchar](80) NULL,
	[DISTNAME] [nvarchar](80) NULL,
	[RECSIGNATURE] [nvarchar](40) NULL,
	[RECADOPTION] [nvarchar](20) NULL,
	[DURATION] [nvarchar](30) NULL,
	[STATIONDIST] [nvarchar](30) NULL,
	[INSTRUCTIONS] [nvarchar](80) NULL,
	[OurDistractNo] [int] NULL,
 CONSTRAINT [PK_OURDISTRACT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OURDISTRACT] ON
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (1, N'مفرقعات', N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'شركة النواتي الذهب والنحاس المحدودة', NULL, CAST(0x6A420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (2, N'مفرقعات', N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'شركة مانوب للتعدين', NULL, CAST(0x6B420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (3, N'مفرقعات', N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N' الرضاء للانشطة المتعددة', NULL, CAST(0x6C420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (4, NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'أعمال الرفعة للتعدين', NULL, CAST(0x6C420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (5, NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'محاجر الادريسي للحجر الطبيعي', NULL, CAST(0x6C420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (6, NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'محجر ود جادات للجبص', NULL, CAST(0x6C420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (7, N'مفرقعات', N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N'محجر الشاهين للتعدين', NULL, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (8, NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', N'بورتسودان', N'محجر ود جادات للجبص', NULL, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'حجر العسل', NULL, NULL)
INSERT [dbo].[OURDISTRACT] ([ID], [ACCOUNT], [DISTRACTOR], [STATIONREC], [RECEIVER], [CONSIGNMENT], [DISTDATE], [POLICYID], [NOTES], [DISTRACTAUTHERITY], [RANK], [DISTSIGNATURE], [DISTADOPTION], [RECAUTHERITY], [RECRANK], [RECNAME], [DISTNAME], [RECSIGNATURE], [RECADOPTION], [DURATION], [STATIONDIST], [INSTRUCTIONS], [OurDistractNo]) VALUES (9, NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, N' الرضاء للانشطة المتعددة', NULL, CAST(0x1A430B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[OURDISTRACT] OFF
/****** Object:  Table [dbo].[NOOBJECTIONS1]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOOBJECTIONS1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FDATE] [date] NULL,
	[FSIDENAME] [nvarchar](80) NULL,
	[SID] [nvarchar](20) NULL,
	[SDATE] [date] NULL,
	[SSIDENAME] [nvarchar](80) NULL,
	[EXPORTER] [nvarchar](80) NULL,
	[COUNTRY] [nvarchar](30) NULL,
	[AMMOUNT] [decimal](18, 3) NULL,
	[UNIT] [nvarchar](15) NULL,
	[CLASS] [nvarchar](250) NULL,
	[POS] [decimal](18, 0) NULL,
	[NAME] [nvarchar](80) NULL,
	[POSITION] [nvarchar](80) NULL,
	[NOOBJECTIONID] [decimal](18, 0) NULL,
	[FINANCEID] [nvarchar](50) NULL,
	[RANK] [nvarchar](25) NULL,
 CONSTRAINT [PK_NOOBJECTIONS1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NOOBJECTIONS]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOOBJECTIONS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FDATE] [date] NULL,
	[FSIDENAME] [nvarchar](80) NULL,
	[SID] [nvarchar](20) NULL,
	[SDATE] [date] NULL,
	[SSIDENAME] [nvarchar](80) NULL,
	[EXPORTER] [nvarchar](80) NULL,
	[COUNTRY] [nvarchar](30) NULL,
	[AMMOUNT] [decimal](18, 3) NULL,
	[UNIT] [nvarchar](15) NULL,
	[CLASS] [nvarchar](250) NULL,
	[POS] [decimal](18, 0) NULL,
	[NAME] [nvarchar](80) NULL,
	[POSITION] [nvarchar](80) NULL,
	[NOOBJECTIONID] [decimal](18, 0) NULL,
	[FINANCEID] [nvarchar](50) NULL,
	[RANK] [nvarchar](25) NULL,
	[NoObjectionNo] [int] NULL,
 CONSTRAINT [PK_NOOBJECTIONS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NOOBJECTIONS] ON
INSERT [dbo].[NOOBJECTIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [SSIDENAME], [EXPORTER], [COUNTRY], [AMMOUNT], [UNIT], [CLASS], [POS], [NAME], [POSITION], [NOOBJECTIONID], [FINANCEID], [RANK], [NoObjectionNo]) VALUES (1, CAST(0x79420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NOOBJECTIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [SSIDENAME], [EXPORTER], [COUNTRY], [AMMOUNT], [UNIT], [CLASS], [POS], [NAME], [POSITION], [NOOBJECTIONID], [FINANCEID], [RANK], [NoObjectionNo]) VALUES (2, CAST(0x79420B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[NOOBJECTIONS] ([ID], [FDATE], [FSIDENAME], [SID], [SDATE], [SSIDENAME], [EXPORTER], [COUNTRY], [AMMOUNT], [UNIT], [CLASS], [POS], [NAME], [POSITION], [NOOBJECTIONID], [FINANCEID], [RANK], [NoObjectionNo]) VALUES (3, CAST(0xAF430B00 AS Date), N'ffdfd', N'123', NULL, N'dsdsd', N'fdfdfd', NULL, NULL, NULL, NULL, NULL, N'fdfd', N'fdfd', NULL, NULL, N'fdfd', 1)
SET IDENTITY_INSERT [dbo].[NOOBJECTIONS] OFF
/****** Object:  Table [dbo].[NoObjectionDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoObjectionDetails](
	[NoObjectionDetailID] [int] IDENTITY(1,1) NOT NULL,
	[Class] [nvarchar](200) NULL,
	[Unit] [nvarchar](20) NULL,
	[Quantity] [decimal](18, 3) NULL,
	[NoObjectionID] [int] NULL,
 CONSTRAINT [PK_NoObjectionDetails] PRIMARY KEY CLUSTERED 
(
	[NoObjectionDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NoObjectionDetails] ON
INSERT [dbo].[NoObjectionDetails] ([NoObjectionDetailID], [Class], [Unit], [Quantity], [NoObjectionID]) VALUES (2, N'aa', N'aaa', CAST(0.000 AS Decimal(18, 3)), 2)
INSERT [dbo].[NoObjectionDetails] ([NoObjectionDetailID], [Class], [Unit], [Quantity], [NoObjectionID]) VALUES (17, N'aa', N'aaa', CAST(10.000 AS Decimal(18, 3)), 1)
INSERT [dbo].[NoObjectionDetails] ([NoObjectionDetailID], [Class], [Unit], [Quantity], [NoObjectionID]) VALUES (18, N'aaaa (aaa)', N'MT', CAST(1000.000 AS Decimal(18, 3)), 1)
INSERT [dbo].[NoObjectionDetails] ([NoObjectionDetailID], [Class], [Unit], [Quantity], [NoObjectionID]) VALUES (19, N'am', N'Meter', CAST(10.000 AS Decimal(18, 3)), 3)
SET IDENTITY_INSERT [dbo].[NoObjectionDetails] OFF
/****** Object:  Table [dbo].[MovementForms]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovementForms](
	[MovementFormID] [int] IDENTITY(1,1) NOT NULL,
	[MovementDate] [date] NULL,
	[Sender] [nvarchar](150) NULL,
	[Receiver] [nvarchar](150) NULL,
	[Commander] [nvarchar](150) NULL,
	[Guard1] [nvarchar](150) NULL,
	[Rank1] [nvarchar](50) NULL,
	[Name1] [nvarchar](150) NULL,
	[Position1] [nvarchar](150) NULL,
	[Rank2] [nvarchar](50) NULL,
	[Name2] [nvarchar](150) NULL,
	[Position2] [nvarchar](150) NULL,
	[Rank3] [nvarchar](50) NULL,
	[Name3] [nvarchar](150) NULL,
	[Position3] [nvarchar](150) NULL,
	[NoObjectionID] [int] NULL,
	[PassPermissionID] [int] NULL,
	[SenderLocation] [nvarchar](50) NULL,
	[ReceiverLocation] [nvarchar](50) NULL,
	[Point1] [nvarchar](50) NULL,
	[Point2] [nvarchar](50) NULL,
	[Point3] [nvarchar](50) NULL,
	[MovementFormNo] [int] NULL,
	[TRANSPORTEDBY] [nvarchar](50) NULL,
 CONSTRAINT [PK_MovementForms] PRIMARY KEY CLUSTERED 
(
	[MovementFormID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MovementForms] ON
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (1, CAST(0x6A420B00 AS Date), NULL, NULL, N'', N'', N'', N'', NULL, N'', N'', NULL, NULL, NULL, N'', NULL, NULL, N'حجر العسل', N'جبيت', N'حجر العسل', N'عطبرة', N'جبيت', 118, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (2, CAST(0x6D420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'محاجر الادريسي للحجر الطبيعي', N'', NULL, N'نقيب', N'محمــد بابكـــر التجــــاني بابكـــــر', N'رئيس شعبة الإستخبارات العسكرية', N'لواء ركن', N'نديــــم حامــد تبــري كبـدان', N'قائد سلاح الأسلحة و الذخائر', N'لواء ركن', N'أحمد عمر شنان محمد خير', N'مديـر إدارة العمليـات بريـــة', NULL, NULL, N'حجر العسل', N'بورتسودان', N'حجر العسل', N'عطبرة', N'بورتسودان', 121, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (3, CAST(0x6D420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'أعمال الرفعة للتعدين', N'', NULL, N'نقيب', N'محمــد بابكـــر التجــــاني بابكـــــر', N'رئيس شعبة الإستخبارات العسكرية', N'لواء ركن', N'نديــــم حامــد تبــري كبـدان', N'قائد سلاح الأسلحة و الذخائر', N'لواء ركن', N'أحمد عمر شنان محمد خير', N'مديـر إدارة العمليـات بريـــة', NULL, NULL, N'حجر العسل ', N'دلقو', N'حجر العسل', N'الملتقي', N'دنقلا', 122, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (4, CAST(0x6D420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'محجر الشاهين للتعدين', N'', NULL, N'نقيب', N'محمــد بابكـــر التجــــاني بابكـــــر', N'رئيس شعبة الإستخبارات العسكرية', N'لواء ركن', N'نديــــم حامــد تبــري كبـدان', N'قائد سلاح الأسلحة و الذخائر', N'لواء ركن', N'أحمد عمر شنان محمد خير', N'مديـر إدارة العمليـات بريـــة', NULL, NULL, N'حجر العسل', N'دلقو', N'حجر العسل', N'الملتقي', N'دلقو', 123, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (5, CAST(0x6D420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'محجر ود جادات للجبص', N'', NULL, N'نقيب', N'محمــد بابكـــر التجــــاني بابكـــــر', N'رئيس شعبة الإستخبارات العسكرية', N'لواء ركن', N'نديــــم حامــد تبــري كبـدان', N'قائد سلاح الأسلحة و الذخائر', N'لواء ركن', N'أحمد عمر شنان محمد خير', N'مديـر إدارة العمليـات بريـــة', NULL, NULL, NULL, NULL, N'حجر العسل', N'عطبرة', N'جبيت المعادن / شنعاب', NULL, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (6, CAST(0x6D420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'محجر الشاهين للتعدين', N'', NULL, N'', N'', NULL, N'', N'', NULL, NULL, NULL, N'', NULL, NULL, NULL, NULL, N'حجر العسل', N'الملتقي', N'دلقو', 1, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (7, CAST(0x6D420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'شركة مانوب للتعدين', N'', NULL, N'', N'', NULL, N'', N'', NULL, NULL, NULL, N'', NULL, NULL, NULL, NULL, N'حجر العسل', N'عطبرة', N'أبو حراز', 1, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (8, CAST(0x6D420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'محجر ود جادات للجبص', N'', NULL, N'', N'', NULL, N'', N'', NULL, NULL, NULL, N'', NULL, NULL, NULL, NULL, N'حجر العسل', N'عطبرة', N'جبيت المعادن / شنعاب', 124, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (9, CAST(0x74420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة', N'شركة تارقيت للأنشطة المتعددة', N'', NULL, N'نقيب', N'محمــد بابكـــر التجــــاني بابكـــــر', N'رئيس شعبة الإستخبارات العسكرية', N'لواء ركن', N'نديــــم حامــد تبــري كبـدان', NULL, NULL, NULL, N'', NULL, NULL, NULL, NULL, N'الخرطوم', N'الجيلي', N'قري', 125, NULL)
INSERT [dbo].[MovementForms] ([MovementFormID], [MovementDate], [Sender], [Receiver], [Commander], [Guard1], [Rank1], [Name1], [Position1], [Rank2], [Name2], [Position2], [Rank3], [Name3], [Position3], [NoObjectionID], [PassPermissionID], [SenderLocation], [ReceiverLocation], [Point1], [Point2], [Point3], [MovementFormNo], [TRANSPORTEDBY]) VALUES (10, CAST(0x1E430B00 AS Date), N'شركة تارقيت للأنشطة المتعددة', N'شركة تارقيت للأنشطة المتعددة', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', NULL, NULL, N'حجر العسل', N'حجر العسل', N'الخرطوم', N'الجيلي', N'قري', 126, NULL)
SET IDENTITY_INSERT [dbo].[MovementForms] OFF
/****** Object:  Table [dbo].[MovementFormDetials]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovementFormDetials](
	[MovementFormDetialID] [int] IDENTITY(1,1) NOT NULL,
	[Class] [nvarchar](150) NULL,
	[Unit] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[MovementFormID] [int] NULL,
	[MovementPath] [nvarchar](50) NULL,
 CONSTRAINT [PK_MovementFormDetials] PRIMARY KEY CLUSTERED 
(
	[MovementFormDetialID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MovementFormDetials] ON
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (23, N'كورتكس', N'متر', 5000, 2, N'حجر العسل')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (24, N'شريط أمان', N'متر', 1000, 2, N'عطبرة')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (25, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', 100, 2, N'بورتسودان')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (26, N'كبسولة عادية', N'قطعة', 100, 2, N'بالبر')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (31, N'كورتكس', N'متر', 5000, 3, N'حجر العسل')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (32, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', 250, 3, N'الملتقي')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (33, N'نترات أمونيوم', N'كجم', 500, 3, N'دلقو')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (34, N'املشن 30مم', N'كجم', 350, 3, N'بالبر')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (43, N'كورتكس', N'متر', 5000, 4, N'حجر العسل')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (44, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', 250, 4, N'الملتقي')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (45, N'نترات أمونيوم', N'كجم', 500, 4, N'دلقو')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (46, NULL, NULL, NULL, 4, N'بالبر')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (47, N'كورتكس', N'متر', 6000, 5, N'حجر العسل')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (48, N'شريط أمان', N'متر', 1000, 5, N'عطبرة')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (49, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', 750, 5, N'جبيت المعادن / شنعاب')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (50, N'كبسولة عادية', N'قطعة', 500, 5, N'البر')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (51, N'نترات امونيوم ', N'كجم', 1000, 5, N'')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (52, N'كبسولة نونيل 3.6 متر', N'قطعة', 500, 5, N'')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (53, N'كورتكس', N'متر', 5000, 6, N'حجر العسل')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (54, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', 250, 6, N'الملتقي')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (55, N'نترات أمونيوم', N'كجم', 500, 6, N'دلقو')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (56, NULL, NULL, NULL, 6, N'بالبر')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (57, N'نترات أمونيوم', N'كجم', 25000, 7, N'حجر العسل')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (58, NULL, NULL, NULL, 7, N'عطبرة')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (59, NULL, NULL, NULL, 7, N'أبو حراز')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (60, NULL, NULL, NULL, 7, N'بالبر')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (61, N'كورتكس', N'متر', 6000, 8, N'حجر العسل')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (62, N'شريط أمان', N'متر', 1000, 8, N'عطبرة')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (63, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', 750, 8, N'جبيت المعادن / شنعاب')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (64, N'كبسولة عادية', N'قطعة', 500, 8, N'البر')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (65, N'نترات امونيوم ', N'كجم', 1000, 8, N'')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (66, N'كبسولة نونيل 3.6 متر', N'قطعة', 500, 8, N'')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (71, N'حاوية', N'40 قدم', 16, 9, N'الخرطوم')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (72, NULL, NULL, NULL, 9, N'الجيلي')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (73, NULL, NULL, NULL, 9, N'قري')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (74, NULL, NULL, NULL, 9, N'')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (75, N'حاوية', N'40 قدم', 16, 10, N'الخرطوم')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (76, NULL, NULL, NULL, 10, N'الجيلي')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (77, NULL, NULL, NULL, 10, N'قري')
INSERT [dbo].[MovementFormDetials] ([MovementFormDetialID], [Class], [Unit], [Quantity], [MovementFormID], [MovementPath]) VALUES (78, NULL, NULL, NULL, 10, N'البر')
SET IDENTITY_INSERT [dbo].[MovementFormDetials] OFF
/****** Object:  Table [dbo].[IMPORTPERMISSIONS]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMPORTPERMISSIONS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FDATE] [date] NULL,
	[SID] [nvarchar](20) NULL,
	[SDATE] [date] NULL,
	[PERMITTED] [nvarchar](80) NULL,
	[CRAFTSMANSHIP] [nvarchar](50) NULL,
	[ADDRESS] [nvarchar](150) NULL,
	[PORT] [nvarchar](30) NULL,
	[EXPLOSIVESID] [nvarchar](1000) NULL,
	[POINT1] [nvarchar](15) NULL,
	[POINT2] [nvarchar](15) NULL,
	[POINT3] [nvarchar](15) NULL,
	[RANK] [nvarchar](15) NULL,
	[NAME] [nvarchar](150) NULL,
	[POSITION] [nvarchar](150) NULL,
	[NOOBJECTIONID] [nvarchar](50) NULL,
	[FINANCEID] [nvarchar](50) NULL,
	[ImportPermissionNo] [int] NULL,
 CONSTRAINT [PK_IMPORTPERMISSIONS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IMPORTPERMISSIONS] ON
INSERT [dbo].[IMPORTPERMISSIONS] ([ID], [FDATE], [SID], [SDATE], [PERMITTED], [CRAFTSMANSHIP], [ADDRESS], [PORT], [EXPLOSIVESID], [POINT1], [POINT2], [POINT3], [RANK], [NAME], [POSITION], [NOOBJECTIONID], [FINANCEID], [ImportPermissionNo]) VALUES (1, CAST(0x6B420B00 AS Date), NULL, CAST(0x6B420B00 AS Date), N'شركة تارقيت للأنشطة المتعددة', N'تسويق المتفجرات التجارية', N'بحري - كافوري - مربع 11 - عقار رقم 22', N'ميناء جدة', N'عدد (15)حاوية 40 قدم
عدد (2) حاوية 20قدم
عدد (160) طن نترات أمونيوم + املشن + ملحقات
', N'بورتسودان', N'عطبرة', N'حجر العسل', N'لواء ركن', N'نديــــم حامــد تبــــري كبـــدان', N'مفتش عام مفرقعات الســـودان', NULL, NULL, 7)
INSERT [dbo].[IMPORTPERMISSIONS] ([ID], [FDATE], [SID], [SDATE], [PERMITTED], [CRAFTSMANSHIP], [ADDRESS], [PORT], [EXPLOSIVESID], [POINT1], [POINT2], [POINT3], [RANK], [NAME], [POSITION], [NOOBJECTIONID], [FINANCEID], [ImportPermissionNo]) VALUES (2, CAST(0x93430B00 AS Date), NULL, CAST(0x93430B00 AS Date), N'شركة تارقيت للأنشطة المتعددة المحدودة', N'fdfd', N'fdfd', N'fds', NULL, N'بي', N'بي', N'بي', N'لواء ركن', N'نديــــم حامــد تبــــري كبـــدان', N'مفتش عام مفرقعات الســـودان', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[IMPORTPERMISSIONS] OFF
/****** Object:  Table [dbo].[ImportPermissionDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportPermissionDetails](
	[ImportPermissionsDetailID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Unit] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[ImportPermissionID] [int] NULL,
 CONSTRAINT [PK_ImportPermissionsDetails] PRIMARY KEY CLUSTERED 
(
	[ImportPermissionsDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ImportPermissionDetails] ON
INSERT [dbo].[ImportPermissionDetails] ([ImportPermissionsDetailID], [Description], [Unit], [Quantity], [ImportPermissionID]) VALUES (1, N'حاوية', N'40 قدم', 16, 1)
INSERT [dbo].[ImportPermissionDetails] ([ImportPermissionsDetailID], [Description], [Unit], [Quantity], [ImportPermissionID]) VALUES (3, N'حاوية', N'40 قدم', 11, 2)
INSERT [dbo].[ImportPermissionDetails] ([ImportPermissionsDetailID], [Description], [Unit], [Quantity], [ImportPermissionID]) VALUES (4, N'اميلشن', N'متر', 150, 2)
SET IDENTITY_INSERT [dbo].[ImportPermissionDetails] OFF
/****** Object:  Table [dbo].[IMPORTCLASS]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMPORTCLASS](
	[AMMOUNT] [decimal](10, 0) NULL,
	[CLASS] [nvarchar](35) NULL,
	[UNIT] [nvarchar](15) NULL,
	[FID] [int] NULL,
	[CLASSID] [int] NULL,
	[RECEIVER] [nvarchar](50) NULL,
	[DISTRACTOR] [nvarchar](50) NULL,
	[RECORD] [nvarchar](15) NULL,
	[ACCOUNT] [nvarchar](20) NULL,
	[DISTDATE] [date] NULL,
	[BALANCED] [nvarchar](50) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_IMPORTCLASS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IMPORTALLOWED]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMPORTALLOWED](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FDATE] [date] NULL,
	[SIDENAME] [nvarchar](50) NULL,
	[ADDRESS] [nvarchar](100) NULL,
	[TEL1] [nvarchar](15) NULL,
	[TEL2] [nvarchar](15) NULL,
	[TEL3] [nvarchar](15) NULL,
	[E_MAIL] [nvarchar](30) NULL,
	[FAX] [nvarchar](15) NULL,
	[POB] [nvarchar](20) NULL,
	[OTHER] [nvarchar](100) NULL,
	[IsDistributor] [bit] NULL,
	[ImportAllowedNo] [int] NULL,
 CONSTRAINT [PK_IMPORTALLOWED] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IMPORTALLOWED] ON
INSERT [dbo].[IMPORTALLOWED] ([ID], [FDATE], [SIDENAME], [ADDRESS], [TEL1], [TEL2], [TEL3], [E_MAIL], [FAX], [POB], [OTHER], [IsDistributor], [ImportAllowedNo]) VALUES (1, NULL, N'شركة تارقيت للأنشطة المتعددة المحدودة', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[IMPORTALLOWED] OFF
/****** Object:  Table [dbo].[GasDepots]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GasDepots](
	[GasDepotID] [int] IDENTITY(1,1) NOT NULL,
	[Company] [nvarchar](150) NULL,
	[Representitive] [nvarchar](100) NULL,
	[PermissionDate] [date] NULL,
	[CompanyLetterDate] [date] NULL,
	[State] [nvarchar](50) NULL,
	[Township] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Land] [nvarchar](20) NULL,
	[Block] [nvarchar](20) NULL,
	[Rank] [nvarchar](20) NULL,
	[Name] [nvarchar](100) NULL,
	[Position] [nvarchar](50) NULL,
	[UrbanPlanningLetterNo] [nvarchar](50) NULL,
	[GasDepotNo] [int] NULL,
	[Area] [nvarchar](20) NULL,
	[UrbanPlanningLetterDate] [date] NULL,
 CONSTRAINT [PK_GasDepots] PRIMARY KEY CLUSTERED 
(
	[GasDepotID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GasDepots] ON
INSERT [dbo].[GasDepots] ([GasDepotID], [Company], [Representitive], [PermissionDate], [CompanyLetterDate], [State], [Township], [City], [Land], [Block], [Rank], [Name], [Position], [UrbanPlanningLetterNo], [GasDepotNo], [Area], [UrbanPlanningLetterDate]) VALUES (1, N'fdsfds', N'fdsfds', CAST(0x6A420B00 AS Date), CAST(0x6A420B00 AS Date), N'sss', N'sss', N'ss', N'11111', N'111', N'ss', N'ss', N'ss', N'11', NULL, N'1111', NULL)
INSERT [dbo].[GasDepots] ([GasDepotID], [Company], [Representitive], [PermissionDate], [CompanyLetterDate], [State], [Township], [City], [Land], [Block], [Rank], [Name], [Position], [UrbanPlanningLetterNo], [GasDepotNo], [Area], [UrbanPlanningLetterDate]) VALUES (2, N'fdsfds', N'dffdd', CAST(0x71420B00 AS Date), CAST(0x71420B00 AS Date), N'sss', N'sss', N'ss', N'ss', N'ss', N'ss', N'ss', N'ss', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[GasDepots] OFF
/****** Object:  Table [dbo].[GasCenters]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GasCenters](
	[GasCenterID] [int] IDENTITY(1,1) NOT NULL,
	[Company] [nvarchar](150) NULL,
	[GasType] [nvarchar](20) NULL,
	[Representitive] [nvarchar](100) NULL,
	[PermissionDate] [date] NULL,
	[CompanyLetterDate] [date] NULL,
	[State] [nvarchar](50) NULL,
	[Township] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Land] [nvarchar](20) NULL,
	[Block] [nvarchar](20) NULL,
	[Rank] [nvarchar](20) NULL,
	[Name] [nvarchar](100) NULL,
	[Position] [nvarchar](50) NULL,
	[GasCenterNo] [int] NULL,
 CONSTRAINT [PK_GasCenters] PRIMARY KEY CLUSTERED 
(
	[GasCenterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GasCenters] ON
INSERT [dbo].[GasCenters] ([GasCenterID], [Company], [GasType], [Representitive], [PermissionDate], [CompanyLetterDate], [State], [Township], [City], [Land], [Block], [Rank], [Name], [Position], [GasCenterNo]) VALUES (1, N'شركة النيل', N'النيل', N'مخمد اسماعيل سعيد', CAST(0x6A420B00 AS Date), CAST(0x6A420B00 AS Date), N'لخرطوم', N'بحري', N'الكدرو', N'15', N'2', N'مقدم ركن', N'صلاح الامين سعد عوض الكريم', N'مساعد مفتش عام مفرقعات السودان', NULL)
SET IDENTITY_INSERT [dbo].[GasCenters] OFF
/****** Object:  Table [dbo].[FuelStations]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuelStations](
	[FuelStationID] [int] IDENTITY(1,1) NOT NULL,
	[Company] [nvarchar](150) NULL,
	[Representitive] [nvarchar](100) NULL,
	[PermissionDate] [date] NULL,
	[CompanyLetterDate] [date] NULL,
	[State] [nvarchar](50) NULL,
	[Township] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Land] [nvarchar](20) NULL,
	[Block] [nvarchar](20) NULL,
	[Rank] [nvarchar](20) NULL,
	[Name] [nvarchar](100) NULL,
	[Position] [nvarchar](50) NULL,
	[FuelStationNo] [int] NULL,
	[Area] [nvarchar](20) NULL,
	[UrbanPlanningLetterDate] [date] NULL,
 CONSTRAINT [PK_FuelStations] PRIMARY KEY CLUSTERED 
(
	[FuelStationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FireworksRequests]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FireworksRequests](
	[FireworksRequestID] [int] IDENTITY(1,1) NOT NULL,
	[RequestDate] [date] NULL,
	[Sender] [nvarchar](150) NULL,
	[Receiver] [nvarchar](150) NULL,
	[Rank] [nvarchar](150) NULL,
	[Name] [nvarchar](150) NULL,
	[Position] [nvarchar](150) NULL,
	[FireworksRequestNo] [int] NULL,
 CONSTRAINT [PK_FireworksRequests] PRIMARY KEY CLUSTERED 
(
	[FireworksRequestID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FireworksRequests] ON
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (1, CAST(0x6A420B00 AS Date), NULL, N' الرضاء للانشطة المتعددة', N'cxzcxz', N'aaa', N'aaaa', 1)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (2, CAST(0x6C420B00 AS Date), NULL, NULL, NULL, NULL, N'مساعد مفتش عام مفرقعات السودان', 1)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (3, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, NULL, N'مساعد مفتش عام مفرقعات السودان ', 1)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (4, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (5, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (6, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, NULL, N'مساعد مفتش عام مفرقعات السودان', 4)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (7, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, NULL, N'مساعد مفتش عام مفرقعات السودان', 5)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (8, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, N'ddd', N'ddd', 6)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (9, CAST(0x6D420B00 AS Date), NULL, NULL, NULL, N'dsadsa', N'sdadsa', 7)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (10, CAST(0x6D420B00 AS Date), NULL, NULL, N'fdfds', N'aaa', N'aaaa', 8)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (11, CAST(0x6D420B00 AS Date), NULL, NULL, N'cxzcxz', N'cxcxz', N'cxcxz', 9)
INSERT [dbo].[FireworksRequests] ([FireworksRequestID], [RequestDate], [Sender], [Receiver], [Rank], [Name], [Position], [FireworksRequestNo]) VALUES (12, CAST(0x71420B00 AS Date), N'تارقيت', N'عطبرة', N'مقدم ركن', N'صلاح الأمين سعد عبد الكريم', N'مساعد مفتش عام مفرقعات السودان', 10)
SET IDENTITY_INSERT [dbo].[FireworksRequests] OFF
/****** Object:  Table [dbo].[FireworksRequestDetails]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FireworksRequestDetails](
	[FireworksReqeustDetailID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[Unti] [nvarchar](50) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[FireWorksRequestID] [int] NULL,
 CONSTRAINT [PK_FireworksRequestDetails] PRIMARY KEY CLUSTERED 
(
	[FireworksReqeustDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FireworksRequestDetails] ON
INSERT [dbo].[FireworksRequestDetails] ([FireworksReqeustDetailID], [Description], [Unti], [Quantity], [FireWorksRequestID]) VALUES (1, N'كورتكس', N'متر', CAST(100.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[FireworksRequestDetails] ([FireworksReqeustDetailID], [Description], [Unti], [Quantity], [FireWorksRequestID]) VALUES (2, N'أملشن 90 مم', N'كجم', CAST(200.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[FireworksRequestDetails] ([FireworksReqeustDetailID], [Description], [Unti], [Quantity], [FireWorksRequestID]) VALUES (3, N'املشن 32 مم', N'كجم', CAST(100.00 AS Decimal(18, 2)), 12)
INSERT [dbo].[FireworksRequestDetails] ([FireworksReqeustDetailID], [Description], [Unti], [Quantity], [FireWorksRequestID]) VALUES (4, N'بوستر 250 جرام', N'قطعة', CAST(1000.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[FireworksRequestDetails] OFF
/****** Object:  Table [dbo].[Fireworks]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fireworks](
	[FireworksID] [int] IDENTITY(1,1) NOT NULL,
	[Fees] [decimal](18, 2) NULL,
	[FID] [int] NULL,
	[Company] [nvarchar](150) NULL,
	[Job] [nvarchar](50) NULL,
	[Address] [nvarchar](150) NULL,
	[PermissionDate] [date] NULL,
	[CompanyLetterDate] [date] NULL,
	[State] [nvarchar](50) NULL,
	[Township] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Land] [nvarchar](20) NULL,
	[Block] [nvarchar](20) NULL,
	[Type] [nvarchar](20) NULL,
	[Rank] [nvarchar](20) NULL,
	[Name] [nvarchar](100) NULL,
	[Position] [nvarchar](50) NULL,
	[LargStoreNo] [nvarchar](20) NULL,
	[MidStoreNo] [nvarchar](20) NULL,
	[SmallStoreNo] [nvarchar](20) NULL,
	[FireworksNo] [int] NULL,
 CONSTRAINT [PK_Fireworks] PRIMARY KEY CLUSTERED 
(
	[FireworksID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinanceDetials]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinanceDetials](
	[FinanceDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 2) NULL,
	[Data] [nvarchar](150) NULL,
	[FinanceID] [int] NULL,
 CONSTRAINT [PK_FinanceDetials] PRIMARY KEY CLUSTERED 
(
	[FinanceDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FINANCE]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FINANCE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MONEYIN] [decimal](10, 0) NULL,
	[MONEYTEXT] [nvarchar](60) NULL,
	[CERTIFIER] [nvarchar](60) NULL,
	[SIDENAME] [nvarchar](60) NULL,
	[COME] [nvarchar](60) NULL,
	[RECEIVEE] [nvarchar](60) NULL,
	[RECEIVER] [nvarchar](60) NULL,
	[STATION] [nvarchar](60) NULL,
	[FDATE] [date] NULL,
	[EXPLANATION] [nvarchar](60) NULL,
	[STATUS] [nvarchar](60) NULL,
	[NOTES] [nvarchar](60) NULL,
	[MONEYOUT] [decimal](18, 0) NULL,
	[STATUSID] [decimal](18, 0) NULL,
	[Rank] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[Position] [nvarchar](250) NULL,
	[FinanceNo] [int] NULL,
 CONSTRAINT [PK_FINANCE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DISTRACTCLASS]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DISTRACTCLASS](
	[AMMOUNT] [numeric](10, 0) NULL,
	[CLASS] [nvarchar](35) NULL,
	[FID] [nvarchar](15) NULL,
	[CLASSID] [nvarchar](20) NULL,
	[RECEIVER] [nvarchar](50) NULL,
	[DISTRACTOR] [nvarchar](50) NOT NULL,
	[RECORD] [nvarchar](50) NULL,
	[ACCOUNT] [nvarchar](15) NULL,
	[DISTDATE] [date] NULL,
	[UNIT] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONDNAMES]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONDNAMES](
	[ID] [int] NOT NULL,
	[NAME] [varchar](40) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'EXPLOSIVES.CONDNAMES.ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CONDNAMES', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'EXPLOSIVES.CONDNAMES."NAME"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CONDNAMES', @level2type=N'COLUMN',@level2name=N'NAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'EXPLOSIVES.CONDNAMES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CONDNAMES'
GO
/****** Object:  Table [dbo].[Conditions]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conditions](
	[ConditionID] [int] IDENTITY(1,1) NOT NULL,
	[Condition] [nvarchar](100) NULL,
	[PermissionNameID] [int] NULL,
 CONSTRAINT [PK_Conditions] PRIMARY KEY CLUSTERED 
(
	[ConditionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Conditions] ON
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (1, N'كروكي الموقع (شركة & محجر )', 1)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (2, N'شعادة صحة البيئه (شركة & محجر )', 1)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (3, N'رخصة محجر من الولاية (محجر)', 1)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (4, N'خطاب عدم الممانعة', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (5, N'خطاب من وزارة العادن الاتحادية', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (6, N'نوع المواد', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (7, N'كمية المواد', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (8, N'مواصفات المواد', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (9, N'شهادة ضبط الجودة', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (10, N'خطاب من شرطة الجمارك', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (11, N'خطاب هيئة التصنيع الحربي', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (12, N'شهادة التامين', 2)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (13, N'السجل التجاري', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (14, N'موقع العمل', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (15, N'خطاب من وزارة المعادن', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (16, N'خطاب من وزير الدفاع', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (17, N'نوع النشاط', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (18, N'مواصفات المواد', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (19, N'جهة التخليص', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (20, N'جهة النقل', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (21, N'دولة المنشا', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (22, N'الجهة الناقلة وخط السير', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (23, N'رخصة التخزين', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (24, N'كمية المواد', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (25, N'اصناف المواد', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (26, N'التاريخ المتوقع لدخول المواد', 4)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (27, N'تصريح المرور', 3)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (28, N'كمية ونوع المفرقعات', 3)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (29, N'نوع المركبة ورقم اللوحة', 3)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (30, N'بيانات نقل التفجرات', 3)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (31, N'اسم فرد الاستخبارات', 3)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (32, N'اسم فني المفرقعات', 3)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (33, N'عقد من وزارة المحاجر والمناجم (محاجر)', 3)
INSERT [dbo].[Conditions] ([ConditionID], [Condition], [PermissionNameID]) VALUES (34, N'عقد من وزارة المعادن (شركه)', 3)
SET IDENTITY_INSERT [dbo].[Conditions] OFF
/****** Object:  Table [dbo].[CLASSES]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASSES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CLASS] [nvarchar](50) NULL,
	[UNIT] [nvarchar](10) NULL,
	[RECENT] [decimal](18, 2) NULL,
	[IMPORTED] [decimal](18, 2) NULL,
	[DISTRACTED] [decimal](18, 2) NULL,
	[ACCOUNT] [nvarchar](20) NULL,
 CONSTRAINT [PK_CLASSES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CLASSES] ON
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (1, N'بوستر 250 جرام', N'', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (2, N'كبسوله نونل 9 متر صيني', N'', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (3, N'أنفو', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (4, N'نترات امونيوم ', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (5, N'أملشن 90 مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (6, N'كبسولة كهربائية تاخيرية 4 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (7, N'كورتكس', N'متر', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (8, N'شريط أمان', N'متر', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (9, N'املشن 32 مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (10, N'نترات أمونيوم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (11, N'املشن كروي', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (12, N'متفجرات عجينية', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (13, N'سير توصيل نونل', N'متر', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (14, N'C4', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (15, N'صورايخ', N'قطعة', NULL, NULL, NULL, N'ألعاب')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (16, N'قنلبة', N'قطعة', NULL, NULL, NULL, N'ألعاب')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (17, N'كاندل', N'قطعة', NULL, NULL, NULL, N'ألعاب')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (18, N'متعدد', N'قطعة', NULL, NULL, NULL, N'ألعاب')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (19, N'Auto Stem', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (20, N'املشن 60 مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (21, N'املشن 70 مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (22, N'TNT مقاس 75 جم', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (23, N'TNT مقاس 200 جم', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (24, N'TNT مقاس 250 جم', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (25, N'TNT مقاس 400 جم', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (26, N'TNT مقاس 1 رطل', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (27, N'TNT مقاس 10 رطل', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (28, N'TNT مقاس 25 رطل', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (29, N'TNT مقاس 50 رطل', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (30, N'كبسولة نونل 3 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (31, N'كبسولة نونل 5 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (32, N'كبسولة نونل 7 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (33, N'كبسولة نونل 10 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (34, N'كبسولة نونل 12 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (35, N'كبسولة نونل 15 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (36, N'كبسولة كهربائية لحظية 2متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (37, N'كبسولة كهربائية لحظية 3 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (38, N'كبسولة كهربائية لحظية 5 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (39, N'كبسولة كهربائية تاخيرية 3 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (40, N'سلك توصيل ', N'متر', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (41, N'قطع توصيل', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (42, N'جهاز تفجير', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (43, N'كبسولة نونل 9 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (44, N'املشن 30مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (45, N'املشن 50مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (46, N'كبسولة كهربائية لحظية 4 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (47, N'كبسولة نونل 9متر 500ملي سكند ', N'قطعة ', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (48, N'كبسولة نونل 4.8 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (49, N'كبسولة نونل 7.2 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (50, N'كبسولة نونل 12 متر سعودي', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (51, N'املشن 55مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (52, N'كبسولة نونل 9 متر سعودي', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (53, N'كبسولة نونل 9 متر صيني', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (54, N'موصلات سطحية 6متر 42 ملي سكند', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (55, N'موصلات سطحية 6متر 25ملي سكند ', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (56, N'كبسولة نونل 15 متر سعودي', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (57, N'املشن 75 مم', N'كجم', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (58, N'كبسولة نونل 7 متر سعودي', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (59, N'بوستر 400 جرام', N'', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (60, N'بوستر 400 جم', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (61, N'كبسولة عادية', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (62, N'كبسولة نونيل 3.6 متر', N'قطعة', NULL, NULL, NULL, N'مفرقعات')
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (63, N'fdfd', N'قطعة', NULL, NULL, NULL, NULL)
INSERT [dbo].[CLASSES] ([ID], [CLASS], [UNIT], [RECENT], [IMPORTED], [DISTRACTED], [ACCOUNT]) VALUES (64, N'بببب', N'قطعة', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[CLASSES] OFF
/****** Object:  Table [dbo].[Ammo]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ammo](
	[AmmoID] [int] IDENTITY(1,1) NOT NULL,
	[AmmoStoreNo] [nvarchar](20) NULL,
	[Company] [nvarchar](150) NULL,
	[PermissionDate] [date] NULL,
	[CompanyLetterDate] [date] NULL,
	[State] [nvarchar](50) NULL,
	[Township] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Land] [nvarchar](20) NULL,
	[Block] [nvarchar](20) NULL,
	[Rank] [nvarchar](20) NULL,
	[Name] [nvarchar](100) NULL,
	[Position] [nvarchar](50) NULL,
	[ReceiptNo] [nvarchar](20) NULL,
	[Fees] [decimal](18, 2) NULL,
	[FID] [int] NULL,
	[Job] [nvarchar](50) NULL,
	[LargStoreNo] [nvarchar](50) NULL,
	[MidStoreNo] [nvarchar](50) NULL,
	[SmallStoreNo] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[AmmoNo] [int] NULL,
 CONSTRAINT [PK_Ammo] PRIMARY KEY CLUSTERED 
(
	[AmmoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ammo] ON
INSERT [dbo].[Ammo] ([AmmoID], [AmmoStoreNo], [Company], [PermissionDate], [CompanyLetterDate], [State], [Township], [City], [Land], [Block], [Rank], [Name], [Position], [ReceiptNo], [Fees], [FID], [Job], [LargStoreNo], [MidStoreNo], [SmallStoreNo], [Address], [AmmoNo]) VALUES (2, NULL, NULL, CAST(0x38430B00 AS Date), CAST(0x38430B00 AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Ammo] OFF
/****** Object:  Table [dbo].[Accounts]    Script Date: 03/31/2023 07:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[ID] [int] NOT NULL,
	[ACCOUNT] [nvarchar](50) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accounts] ([ID], [ACCOUNT]) VALUES (1, N'مفرقعات')
INSERT [dbo].[Accounts] ([ID], [ACCOUNT]) VALUES (2, N'ألعاب')
INSERT [dbo].[Accounts] ([ID], [ACCOUNT]) VALUES (3, N'ذخيرة')
/****** Object:  Default [DF_PERMISSIONS_IsImport]    Script Date: 03/31/2023 07:03:30 ******/
ALTER TABLE [dbo].[PERMISSIONS] ADD  CONSTRAINT [DF_PERMISSIONS_IsImport]  DEFAULT ((0)) FOR [IsImport]
GO
/****** Object:  Default [DF_PERMISSIONS_IsDistruct]    Script Date: 03/31/2023 07:03:30 ******/
ALTER TABLE [dbo].[PERMISSIONS] ADD  CONSTRAINT [DF_PERMISSIONS_IsDistruct]  DEFAULT ((0)) FOR [IsDistruct]
GO
/****** Object:  Default [DF_IMPORTALLOWED_IsDistributor]    Script Date: 03/31/2023 07:03:30 ******/
ALTER TABLE [dbo].[IMPORTALLOWED] ADD  CONSTRAINT [DF_IMPORTALLOWED_IsDistributor]  DEFAULT ((0)) FOR [IsDistributor]
GO
