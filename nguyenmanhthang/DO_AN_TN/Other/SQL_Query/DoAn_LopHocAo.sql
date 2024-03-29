USE [master]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'!YÚUZpæà¤²ÜÎ£r`*øï~¯ÀÆÖînr', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'V*©_åN@i?	ã%<Ã=À¡¬vIê,Òmå|ïs', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/****** Object:  Login [BUILTIN\Users]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'BUILTIN\Users')
CREATE LOGIN [BUILTIN\Users] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQLSERVER]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT Service\MSSQLSERVER')
CREATE LOGIN [NT Service\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\ReportServer]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\ReportServer')
CREATE LOGIN [NT SERVICE\ReportServer] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLWriter')
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\Winmgmt')
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [ThangNM\Nguyen Manh Thang]    Script Date: 06/04/2014 16:03:12 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'ThangNM\Nguyen Manh Thang')
CREATE LOGIN [ThangNM\Nguyen Manh Thang] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
EXEC sys.sp_addsrvrolemember @loginame = N'NT Service\MSSQLSERVER', @rolename = N'sysadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'NT SERVICE\SQLWriter', @rolename = N'sysadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'NT SERVICE\Winmgmt', @rolename = N'sysadmin'
GO
EXEC sys.sp_addsrvrolemember @loginame = N'ThangNM\Nguyen Manh Thang', @rolename = N'sysadmin'
GO
USE [DoAn_LopHocAo]
GO
/****** Object:  Table [dbo].[tblBaiViet]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblBaiViet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblBaiViet](
	[FK_sMaGV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PK_lMaBaiViet] [bigint] IDENTITY(1,1) NOT NULL,
	[sTieuDe] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sLinkAnh] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sTag] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sNoiDung] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[iLuotXem] [int] NOT NULL,
	[tNgayViet] [datetime] NOT NULL,
	[tNgayCapNhat] [datetime] NOT NULL,
	[sMoTa] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblBaiViet] PRIMARY KEY CLUSTERED 
(
	[PK_lMaBaiViet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblBaiViet] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblCauHoi]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCauHoi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblCauHoi](
	[FK_sMaGV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PK_lCauhoi_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[sCauhoi_Cauhoi] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sCauhoi_A] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sCauhoi_B] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sCauhoi_C] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sCauhoi_D] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[iCauhoi_Dung] [smallint] NOT NULL,
	[sBoCauHoi] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[tNgayTao] [datetime] NOT NULL,
	[tNgayCapNhat] [datetime] NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblCauHoi] PRIMARY KEY CLUSTERED 
(
	[PK_lCauhoi_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblCauHoi] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblConfig]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblConfig]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblConfig](
	[PK_lConfigID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Config] PRIMARY KEY CLUSTERED 
(
	[PK_lConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[tblConfig] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblDiemThi]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDiemThi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDiemThi](
	[FK_sMaSV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[FK_sMaMonhoc] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PK_iSolanhoc] [smallint] NOT NULL,
	[fDiemchuyencan] [float] NULL,
	[fDiemgiuaky] [float] NULL,
	[fDiemthilan1] [float] NULL,
	[fDiemthilan2] [float] NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblDiemThi] PRIMARY KEY CLUSTERED 
(
	[FK_sMaSV] ASC,
	[FK_sMaMonhoc] ASC,
	[PK_iSolanhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblDiemThi] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblError]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblError]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblError](
	[PK_lErrorID] [bigint] IDENTITY(1,1) NOT NULL,
	[sLink] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[sIP] [varchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[sBrowser] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[iCodes] [smallint] NULL,
	[tTime] [datetime] NULL,
	[tTimeCheck] [datetime] NULL,
	[iStatus] [smallint] NULL,
 CONSTRAINT [PK_tblError] PRIMARY KEY CLUSTERED 
(
	[PK_lErrorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblError] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblGiangVien]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblGiangVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblGiangVien](
	[PK_sMaGV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sHoTenGV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sTendangnhapGV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sMatkhauGV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sEmailGV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sDiachiGV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sSdtGV] [varchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[tNgaysinhGV] [datetime] NOT NULL,
	[bGioitinhGV] [bit] NOT NULL,
	[sCMNDGV] [varchar](9) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[tNgayCapCMNDGV] [datetime] NOT NULL,
	[sNoiCapCMNDGV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[bHonNhanGV] [bit] NOT NULL,
	[tNgayNhanCongTacGV] [datetime] NOT NULL,
	[iChucVuGV] [smallint] NOT NULL,
	[iHocViGV] [smallint] NOT NULL,
	[bCongChucGV] [bit] NOT NULL,
	[sLinkChannelsGV] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[sLinkChatRoomsGV] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[sLinkAvatarGV] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[iTrangThaiGV] [smallint] NOT NULL,
 CONSTRAINT [PK_tblGiangVien] PRIMARY KEY CLUSTERED 
(
	[PK_sMaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblGiangVien_sCMNDGV] UNIQUE NONCLUSTERED 
(
	[sCMNDGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblGiangVien_sEmailGV] UNIQUE NONCLUSTERED 
(
	[sEmailGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblGiangVien_sTendangnhapGV] UNIQUE NONCLUSTERED 
(
	[sTendangnhapGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblGiangVien] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblLichDayVaHoc]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichDayVaHoc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichDayVaHoc](
	[FK_sMaPCCT] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[FK_sMalop] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[iCaHoc] [smallint] NOT NULL,
	[tNgayDay] [datetime] NOT NULL,
	[iSoTietDay] [smallint] NULL,
	[sSinhVienNghi] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblLichDayVaHoc] PRIMARY KEY CLUSTERED 
(
	[FK_sMaPCCT] ASC,
	[FK_sMalop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblLichDayVaHoc] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblLopHoc]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLopHoc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLopHoc](
	[PK_sMalop] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sTenlop] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[iNamvaotruong] [smallint] NOT NULL,
	[iSiso] [smallint] NOT NULL,
	[iSoNamDaoTao] [smallint] NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblLopHoc] PRIMARY KEY CLUSTERED 
(
	[PK_sMalop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblLopHoc_sTenlop] UNIQUE NONCLUSTERED 
(
	[sTenlop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblLopHoc] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMonHoc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblMonHoc](
	[PK_sMaMonhoc] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sTenMonhoc] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[iSotrinh] [smallint] NOT NULL,
	[iSotietday] [smallint] NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[PK_sMaMonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblMonHoc_sTenMonhoc] UNIQUE NONCLUSTERED 
(
	[sTenMonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblMonHoc] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblPhanCongCongTac]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblPhanCongCongTac](
	[PK_sMaPCCT] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[FK_sMaGV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[FK_sMaMonhoc] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[tNgayBatDau] [datetime] NULL,
	[tNgayKetThuc] [datetime] NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblPhanCongCongTac] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPCCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblPhanCongCongTac] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSinhVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblSinhVien](
	[FK_sMaLop] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PK_sMaSV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sHotenSV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sTendangnhapSV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sMatkhauSV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sEmailSV] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sDiachiSV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[sSdtSV] [varchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[tNgaysinhSV] [datetime] NOT NULL,
	[bGioitinhSV] [bit] NOT NULL,
	[sCMNDSV] [varchar](9) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[tNgayCapCMNDSV] [datetime] NOT NULL,
	[sNoiCapCMNDSV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[bHonNhanSV] [bit] NOT NULL,
	[sNguoiLienHeSV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[sDiaChiNguoiLienHeSV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[sSdtNguoiLienHeSV] [varchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[iQuanHeVoiNguoiLienHeSV] [smallint] NULL,
	[bKetnapDoanSV] [bit] NULL,
	[iNamketnapDoanSV] [smallint] NULL,
	[sNoiketnapDoanSV] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[iNamtotnghiepTHPTSV] [smallint] NOT NULL,
	[tNgayNhapHocSV] [datetime] NOT NULL,
	[tNgayRaTruongSV] [datetime] NULL,
	[tNgayCapTheSV] [datetime] NOT NULL,
	[sLinkAvatarSV] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[iTrangThaiSV] [smallint] NOT NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[PK_sMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblSinhVien_sCMNDSV] UNIQUE NONCLUSTERED 
(
	[sCMNDSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblSinhVien_sEmailSV] UNIQUE NONCLUSTERED 
(
	[sEmailSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblSinhVien_sTendangnhapSV] UNIQUE NONCLUSTERED 
(
	[sTendangnhapSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tblSinhVien] TO  SCHEMA OWNER 
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblBaiViet_sLinkAnh]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblBaiViet] ADD  CONSTRAINT [DF_tblBaiViet_sLinkAnh]  DEFAULT ('~\Images\Avatar\default.jpg') FOR [sLinkAnh]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblBaiViet_iLuotXem]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblBaiViet] ADD  CONSTRAINT [DF_tblBaiViet_iLuotXem]  DEFAULT ((0)) FOR [iLuotXem]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblBaiViet_tNgayViet]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblBaiViet] ADD  CONSTRAINT [DF_tblBaiViet_tNgayViet]  DEFAULT (getdate()) FOR [tNgayViet]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblBaiViet_iTrangThai]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblBaiViet] ADD  CONSTRAINT [DF_tblBaiViet_iTrangThai]  DEFAULT ((1)) FOR [iTrangThai]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblCauHoi_tNgayTao]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblCauHoi] ADD  CONSTRAINT [DF_tblCauHoi_tNgayTao]  DEFAULT (getdate()) FOR [tNgayTao]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblCauHoi_iTrangThai]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblCauHoi] ADD  CONSTRAINT [DF_tblCauHoi_iTrangThai]  DEFAULT ((1)) FOR [iTrangThai]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblDiemThi_PK_iSolanhoc]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblDiemThi] ADD  CONSTRAINT [DF_tblDiemThi_PK_iSolanhoc]  DEFAULT ((1)) FOR [PK_iSolanhoc]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblDiemThi_iTrangThai]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblDiemThi] ADD  CONSTRAINT [DF_tblDiemThi_iTrangThai]  DEFAULT ((1)) FOR [iTrangThai]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Error_tTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblError] ADD  CONSTRAINT [DF_Error_tTime]  DEFAULT (getdate()) FOR [tTime]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblError_iStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblError] ADD  CONSTRAINT [DF_tblError_iStatus]  DEFAULT ((1)) FOR [iStatus]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblGiangVien_sLinkAvatarGV]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblGiangVien] ADD  CONSTRAINT [DF_tblGiangVien_sLinkAvatarGV]  DEFAULT ('~\Images\Avatar\default.jpg') FOR [sLinkAvatarGV]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblGiangVien_iTrangThaiGV]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblGiangVien] ADD  CONSTRAINT [DF_tblGiangVien_iTrangThaiGV]  DEFAULT ((1)) FOR [iTrangThaiGV]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblLichDayVaHoc_iCaHoc]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblLichDayVaHoc] ADD  CONSTRAINT [DF_tblLichDayVaHoc_iCaHoc]  DEFAULT ((1)) FOR [iCaHoc]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblLichDayVaHoc_iTrangThai]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblLichDayVaHoc] ADD  CONSTRAINT [DF_tblLichDayVaHoc_iTrangThai]  DEFAULT ((1)) FOR [iTrangThai]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblLopHoc_iNamvaotruong]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_iNamvaotruong]  DEFAULT (datepart(year,getdate())) FOR [iNamvaotruong]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblLopHoc_iTrangThai]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_iTrangThai]  DEFAULT ((1)) FOR [iTrangThai]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblMonHoc_iSotrinh]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_iSotrinh]  DEFAULT ((4)) FOR [iSotrinh]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblMonHoc_iTrangThai]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_iTrangThai]  DEFAULT ((1)) FOR [iTrangThai]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblPhanCongCongTac_tNgayBatDau]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblPhanCongCongTac] ADD  CONSTRAINT [DF_tblPhanCongCongTac_tNgayBatDau]  DEFAULT (getdate()) FOR [tNgayBatDau]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblPhanCongCongTac_iTrangThai]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblPhanCongCongTac] ADD  CONSTRAINT [DF_tblPhanCongCongTac_iTrangThai]  DEFAULT ((1)) FOR [iTrangThai]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblSinhVien_tNgayCapTheSV]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_tNgayCapTheSV]  DEFAULT (getdate()) FOR [tNgayCapTheSV]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblSinhVien_sLinkAvatarSV]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_sLinkAvatarSV]  DEFAULT ('~\Images\Avatar\default.jpg') FOR [sLinkAvatarSV]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_tblSinhVien_iTrangThaiSV]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_iTrangThaiSV]  DEFAULT ((1)) FOR [iTrangThaiSV]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblBaiViet_tblGiangVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblBaiViet]'))
ALTER TABLE [dbo].[tblBaiViet]  WITH CHECK ADD  CONSTRAINT [FK_tblBaiViet_tblGiangVien] FOREIGN KEY([FK_sMaGV])
REFERENCES [dbo].[tblGiangVien] ([PK_sMaGV])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblBaiViet_tblGiangVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblBaiViet]'))
ALTER TABLE [dbo].[tblBaiViet] CHECK CONSTRAINT [FK_tblBaiViet_tblGiangVien]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblCauHoi_tblGiangVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblCauHoi]'))
ALTER TABLE [dbo].[tblCauHoi]  WITH CHECK ADD  CONSTRAINT [FK_tblCauHoi_tblGiangVien] FOREIGN KEY([FK_sMaGV])
REFERENCES [dbo].[tblGiangVien] ([PK_sMaGV])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblCauHoi_tblGiangVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblCauHoi]'))
ALTER TABLE [dbo].[tblCauHoi] CHECK CONSTRAINT [FK_tblCauHoi_tblGiangVien]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDiemThi_tblMonHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDiemThi]'))
ALTER TABLE [dbo].[tblDiemThi]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemThi_tblMonHoc] FOREIGN KEY([FK_sMaMonhoc])
REFERENCES [dbo].[tblMonHoc] ([PK_sMaMonhoc])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDiemThi_tblMonHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDiemThi]'))
ALTER TABLE [dbo].[tblDiemThi] CHECK CONSTRAINT [FK_tblDiemThi_tblMonHoc]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDiemThi_tblSinhVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDiemThi]'))
ALTER TABLE [dbo].[tblDiemThi]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemThi_tblSinhVien] FOREIGN KEY([FK_sMaSV])
REFERENCES [dbo].[tblSinhVien] ([PK_sMaSV])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblDiemThi_tblSinhVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblDiemThi]'))
ALTER TABLE [dbo].[tblDiemThi] CHECK CONSTRAINT [FK_tblDiemThi_tblSinhVien]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblLichDayVaHoc_tblLopHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLichDayVaHoc]'))
ALTER TABLE [dbo].[tblLichDayVaHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLichDayVaHoc_tblLopHoc] FOREIGN KEY([FK_sMalop])
REFERENCES [dbo].[tblLopHoc] ([PK_sMalop])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblLichDayVaHoc_tblLopHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLichDayVaHoc]'))
ALTER TABLE [dbo].[tblLichDayVaHoc] CHECK CONSTRAINT [FK_tblLichDayVaHoc_tblLopHoc]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblLichDayVaHoc_tblPhanCongCongTac]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLichDayVaHoc]'))
ALTER TABLE [dbo].[tblLichDayVaHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLichDayVaHoc_tblPhanCongCongTac] FOREIGN KEY([FK_sMaPCCT])
REFERENCES [dbo].[tblPhanCongCongTac] ([PK_sMaPCCT])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblLichDayVaHoc_tblPhanCongCongTac]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLichDayVaHoc]'))
ALTER TABLE [dbo].[tblLichDayVaHoc] CHECK CONSTRAINT [FK_tblLichDayVaHoc_tblPhanCongCongTac]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblPhanCongCongTac_tblGiangVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac]  WITH CHECK ADD  CONSTRAINT [FK_tblPhanCongCongTac_tblGiangVien] FOREIGN KEY([FK_sMaGV])
REFERENCES [dbo].[tblGiangVien] ([PK_sMaGV])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblPhanCongCongTac_tblGiangVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac] CHECK CONSTRAINT [FK_tblPhanCongCongTac_tblGiangVien]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblPhanCongCongTac_tblMonHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac]  WITH CHECK ADD  CONSTRAINT [FK_tblPhanCongCongTac_tblMonHoc] FOREIGN KEY([FK_sMaMonhoc])
REFERENCES [dbo].[tblMonHoc] ([PK_sMaMonhoc])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblPhanCongCongTac_tblMonHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac] CHECK CONSTRAINT [FK_tblPhanCongCongTac_tblMonHoc]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblSinhVien_tblLopHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhVien_tblLopHoc] FOREIGN KEY([FK_sMaLop])
REFERENCES [dbo].[tblLopHoc] ([PK_sMalop])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tblSinhVien_tblLopHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [FK_tblSinhVien_tblLopHoc]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblBaiViet_tNgayViet_tNgayCapNhat]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblBaiViet]'))
ALTER TABLE [dbo].[tblBaiViet]  WITH CHECK ADD  CONSTRAINT [CK_tblBaiViet_tNgayViet_tNgayCapNhat] CHECK  (([tNgayViet]<=[tNgayCapNhat]))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblBaiViet_tNgayViet_tNgayCapNhat]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblBaiViet]'))
ALTER TABLE [dbo].[tblBaiViet] CHECK CONSTRAINT [CK_tblBaiViet_tNgayViet_tNgayCapNhat]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblCauHoi_tNgayTao_tNgayCapNhat]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblCauHoi]'))
ALTER TABLE [dbo].[tblCauHoi]  WITH CHECK ADD  CONSTRAINT [CK_tblCauHoi_tNgayTao_tNgayCapNhat] CHECK  (([tNgayTao]<=[tNgayCapNhat]))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblCauHoi_tNgayTao_tNgayCapNhat]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblCauHoi]'))
ALTER TABLE [dbo].[tblCauHoi] CHECK CONSTRAINT [CK_tblCauHoi_tNgayTao_tNgayCapNhat]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblError_tTime_tTimeCheck]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblError]'))
ALTER TABLE [dbo].[tblError]  WITH CHECK ADD  CONSTRAINT [CK_tblError_tTime_tTimeCheck] CHECK  (([tTime]<=[tTimeCheck]))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblError_tTime_tTimeCheck]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblError]'))
ALTER TABLE [dbo].[tblError] CHECK CONSTRAINT [CK_tblError_tTime_tTimeCheck]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_PK_sMaGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_tblGiangVien_PK_sMaGV] CHECK  (([PK_sMaGV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_PK_sMaGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien] CHECK CONSTRAINT [CK_tblGiangVien_PK_sMaGV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sCMNDGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_tblGiangVien_sCMNDGV] CHECK  (([sCMNDGV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sCMNDGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien] CHECK CONSTRAINT [CK_tblGiangVien_sCMNDGV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sDiachiGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_tblGiangVien_sDiachiGV] CHECK  (([sDiachiGV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sDiachiGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien] CHECK CONSTRAINT [CK_tblGiangVien_sDiachiGV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sEmailGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_tblGiangVien_sEmailGV] CHECK  (([sEmailGV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sEmailGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien] CHECK CONSTRAINT [CK_tblGiangVien_sEmailGV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sHoTenGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_tblGiangVien_sHoTenGV] CHECK  (([sHoTenGV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sHoTenGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien] CHECK CONSTRAINT [CK_tblGiangVien_sHoTenGV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sMatkhauGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_tblGiangVien_sMatkhauGV] CHECK  (([sMatkhauGV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sMatkhauGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien] CHECK CONSTRAINT [CK_tblGiangVien_sMatkhauGV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sTendangnhapGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_tblGiangVien_sTendangnhapGV] CHECK  (([sTendangnhapGV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblGiangVien_sTendangnhapGV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblGiangVien]'))
ALTER TABLE [dbo].[tblGiangVien] CHECK CONSTRAINT [CK_tblGiangVien_sTendangnhapGV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblLopHoc_PK_sMalop]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLopHoc]'))
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [CK_tblLopHoc_PK_sMalop] CHECK  (([PK_sMalop]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblLopHoc_PK_sMalop]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLopHoc]'))
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [CK_tblLopHoc_PK_sMalop]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblLopHoc_sTenlop]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLopHoc]'))
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [CK_tblLopHoc_sTenlop] CHECK  (([sTenlop]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblLopHoc_sTenlop]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblLopHoc]'))
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [CK_tblLopHoc_sTenlop]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblMonHoc_PK_sMaMonhoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMonHoc]'))
ALTER TABLE [dbo].[tblMonHoc]  WITH CHECK ADD  CONSTRAINT [CK_tblMonHoc_PK_sMaMonhoc] CHECK  (([PK_sMaMonhoc]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblMonHoc_PK_sMaMonhoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMonHoc]'))
ALTER TABLE [dbo].[tblMonHoc] CHECK CONSTRAINT [CK_tblMonHoc_PK_sMaMonhoc]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblMonHoc_sTenMonhoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMonHoc]'))
ALTER TABLE [dbo].[tblMonHoc]  WITH CHECK ADD  CONSTRAINT [CK_tblMonHoc_sTenMonhoc] CHECK  (([sTenMonhoc]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblMonHoc_sTenMonhoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblMonHoc]'))
ALTER TABLE [dbo].[tblMonHoc] CHECK CONSTRAINT [CK_tblMonHoc_sTenMonhoc]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblPhanCongCongTac_PK_sMaPCCT]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac]  WITH CHECK ADD  CONSTRAINT [CK_tblPhanCongCongTac_PK_sMaPCCT] CHECK  (([PK_sMaPCCT]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblPhanCongCongTac_PK_sMaPCCT]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac] CHECK CONSTRAINT [CK_tblPhanCongCongTac_PK_sMaPCCT]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblPhanCongCongTac_tNgayBatDau_tNgayKetThuc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac]  WITH CHECK ADD  CONSTRAINT [CK_tblPhanCongCongTac_tNgayBatDau_tNgayKetThuc] CHECK  (([tNgayBatDau]<=[tNgayKetThuc]))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblPhanCongCongTac_tNgayBatDau_tNgayKetThuc]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblPhanCongCongTac]'))
ALTER TABLE [dbo].[tblPhanCongCongTac] CHECK CONSTRAINT [CK_tblPhanCongCongTac_tNgayBatDau_tNgayKetThuc]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_PK_sMaSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [CK_tblSinhVien_PK_sMaSV] CHECK  (([PK_sMaSV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_PK_sMaSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [CK_tblSinhVien_PK_sMaSV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sCMNDSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [CK_tblSinhVien_sCMNDSV] CHECK  (([sCMNDSV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sCMNDSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [CK_tblSinhVien_sCMNDSV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sDiachiSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [CK_tblSinhVien_sDiachiSV] CHECK  (([sDiachiSV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sDiachiSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [CK_tblSinhVien_sDiachiSV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sEmailSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [CK_tblSinhVien_sEmailSV] CHECK  (([sEmailSV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sEmailSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [CK_tblSinhVien_sEmailSV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sMatkhauSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [CK_tblSinhVien_sMatkhauSV] CHECK  (([sMatkhauSV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sMatkhauSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [CK_tblSinhVien_sMatkhauSV]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sTendangnhapSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [CK_tblSinhVien_sTendangnhapSV] CHECK  (([sTendangnhapSV]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_tblSinhVien_sTendangnhapSV]') AND parent_object_id = OBJECT_ID(N'[dbo].[tblSinhVien]'))
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [CK_tblSinhVien_sTendangnhapSV]
GO
/****** Object:  Trigger [dbo].[TG_tblSinhVien_Delete_Is_Update_iSiso]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TG_tblSinhVien_Delete_Is_Update_iSiso]'))
EXEC dbo.sp_executesql @statement = N'CREATE TRIGGER [dbo].[TG_tblSinhVien_Delete_Is_Update_iSiso]
ON [dbo].[tblSinhVien]
AFTER DELETE
AS
BEGIN
UPDATE tblLopHoc	SET
	iSiso 	= iSiso - 1
WHERE PK_sMalop = (SELECT FK_sMaLop FROM Deleted)
END' 
GO
/****** Object:  Trigger [dbo].[TG_tblSinhVien_Insert_Is_Update_iSiso]    Script Date: 06/04/2014 16:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TG_tblSinhVien_Insert_Is_Update_iSiso]'))
EXEC dbo.sp_executesql @statement = N'CREATE TRIGGER [dbo].[TG_tblSinhVien_Insert_Is_Update_iSiso]
ON [dbo].[tblSinhVien]
AFTER INSERT
AS
BEGIN
UPDATE tblLopHoc	SET
	iSiso 	= iSiso + 1
WHERE PK_sMalop = (SELECT FK_sMaLop FROM Inserted)
END' 
GO
