USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblPhanCongCongTac]    Script Date: 3/16/2014 4:53:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPhanCongCongTac](
	[PK_sMaPCCT] [varchar](50) NOT NULL,
	[FK_sMaGV] [varchar](50) NOT NULL,
	[FK_sMaMonhoc] [varchar](50) NOT NULL,
	[tNgayBatDau] [datetime] NULL,
	[tNgayKetThuc] [datetime] NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblLichHoc] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPCCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblPhanCongCongTac]  WITH CHECK ADD  CONSTRAINT [FK_tblLichHoc_tblGiangVien] FOREIGN KEY([FK_sMaGV])
REFERENCES [dbo].[tblGiangVien] ([PK_sMaGV])
GO

ALTER TABLE [dbo].[tblPhanCongCongTac] CHECK CONSTRAINT [FK_tblLichHoc_tblGiangVien]
GO

ALTER TABLE [dbo].[tblPhanCongCongTac]  WITH CHECK ADD  CONSTRAINT [FK_tblLichHoc_tblMonHoc] FOREIGN KEY([FK_sMaMonhoc])
REFERENCES [dbo].[tblMonHoc] ([PK_sMaMonhoc])
GO

ALTER TABLE [dbo].[tblPhanCongCongTac] CHECK CONSTRAINT [FK_tblLichHoc_tblMonHoc]
GO


