USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblBaiViet]    Script Date: 3/16/2014 4:51:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblBaiViet](
	[FK_sMaGV] [varchar](50) NOT NULL,
	[PK_lMaBaiViet] [bigint] NOT NULL,
	[sTieuDe] [nvarchar](500) NOT NULL,
	[sLinkAnh] [varchar](200) NOT NULL,
	[sTag] [nvarchar](500) NOT NULL,
	[sNoiDung] [nvarchar](max) NOT NULL,
	[iLuotXem] [int] NOT NULL,
	[tNgayViet] [datetime] NOT NULL,
	[tNgayCapNhat] [datetime] NOT NULL,
	[sMoTa] [nvarchar](200) NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblBaiViet] PRIMARY KEY CLUSTERED 
(
	[PK_lMaBaiViet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblBaiViet]  WITH CHECK ADD  CONSTRAINT [FK_tblBaiViet_tblGiangVien] FOREIGN KEY([FK_sMaGV])
REFERENCES [dbo].[tblGiangVien] ([PK_sMaGV])
GO

ALTER TABLE [dbo].[tblBaiViet] CHECK CONSTRAINT [FK_tblBaiViet_tblGiangVien]
GO


