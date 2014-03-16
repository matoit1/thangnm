USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 3/16/2014 4:54:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblSinhVien](
	[FK_sMaLop] [varchar](50) NOT NULL,
	[PK_sMaSV] [varchar](50) NOT NULL,
	[sHotenSV] [nvarchar](100) NOT NULL,
	[sTendangnhapSV] [varchar](50) NOT NULL,
	[sMatkhauSV] [varchar](50) NOT NULL,
	[sEmailSV] [varchar](50) NOT NULL,
	[sDiachiSV] [nvarchar](100) NOT NULL,
	[sSdtSV] [varchar](13) NOT NULL,
	[tNgaysinhSV] [datetime] NOT NULL,
	[bGioitinhSV] [bit] NOT NULL,
	[sCMNDSV] [varchar](9) NOT NULL,
	[tNgayCapCMNDSV] [datetime] NOT NULL,
	[sNoiCapCMNDSV] [nvarchar](100) NOT NULL,
	[bHonNhanSV] [bit] NOT NULL,
	[sNguoiLienHeSV] [nvarchar](100) NULL,
	[sDiaChiNguoiLienHeSV] [nvarchar](100) NULL,
	[sSdtNguoiLienHeSV] [varchar](13) NULL,
	[iQuanHeVoiNguoiLienHeSV] [smallint] NULL,
	[bKetnapDoanSV] [bit] NULL,
	[iNamketnapDoanSV] [smallint] NULL,
	[sNoiketnapDoanSV] [nvarchar](100) NULL,
	[iNamtotnghiepTHPTSV] [smallint] NOT NULL,
	[tNgayNhapHocSV] [datetime] NOT NULL,
	[tNgayRaTruongSV] [datetime] NULL,
	[tNgayCapTheSV] [datetime] NOT NULL,
	[iTrangThaiSV] [smallint] NOT NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[PK_sMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhVien_tblLopHoc] FOREIGN KEY([FK_sMaLop])
REFERENCES [dbo].[tblLopHoc] ([PK_sMalop])
GO

ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [FK_tblSinhVien_tblLopHoc]
GO


