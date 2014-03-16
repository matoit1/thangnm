USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblCauHoi]    Script Date: 3/16/2014 4:52:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblCauHoi](
	[FK_sMaGV] [varchar](50) NOT NULL,
	[PK_lCauhoi_ID] [bigint] NOT NULL,
	[sCauhoi_Cauhoi] [nvarchar](500) NOT NULL,
	[sCauhoi_A] [nvarchar](500) NOT NULL,
	[sCauhoi_B] [nvarchar](500) NOT NULL,
	[sCauhoi_C] [nvarchar](500) NOT NULL,
	[sCauhoi_D] [nvarchar](500) NOT NULL,
	[iCauhoi_Dung] [smallint] NOT NULL,
	[sBoCauHoi] [varchar](50) NOT NULL,
	[tNgayTao] [datetime] NOT NULL,
	[tNgayCapNhat] [datetime] NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblCauHoi] PRIMARY KEY CLUSTERED 
(
	[PK_lCauhoi_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblCauHoi]  WITH CHECK ADD  CONSTRAINT [FK_tblCauHoi_tblGiangVien] FOREIGN KEY([FK_sMaGV])
REFERENCES [dbo].[tblGiangVien] ([PK_sMaGV])
GO

ALTER TABLE [dbo].[tblCauHoi] CHECK CONSTRAINT [FK_tblCauHoi_tblGiangVien]
GO


