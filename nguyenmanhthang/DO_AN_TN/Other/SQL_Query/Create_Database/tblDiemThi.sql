USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblDiemThi]    Script Date: 3/16/2014 4:52:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblDiemThi](
	[FK_sMaSV] [varchar](50) NOT NULL,
	[FK_sMaMonhoc] [varchar](50) NOT NULL,
	[PK_iSolanhoc] [smallint] NOT NULL,
	[fDiemchuyencan] [float] NULL,
	[fDiemgiuaky] [float] NULL,
	[fDiemthilan1] [float] NULL,
	[fDiemthilan2] [float] NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblDiem] PRIMARY KEY CLUSTERED 
(
	[FK_sMaSV] ASC,
	[FK_sMaMonhoc] ASC,
	[PK_iSolanhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblDiemThi]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemThi_tblMonHoc] FOREIGN KEY([FK_sMaMonhoc])
REFERENCES [dbo].[tblMonHoc] ([PK_sMaMonhoc])
GO

ALTER TABLE [dbo].[tblDiemThi] CHECK CONSTRAINT [FK_tblDiemThi_tblMonHoc]
GO

ALTER TABLE [dbo].[tblDiemThi]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemThi_tblSinhVien] FOREIGN KEY([FK_sMaSV])
REFERENCES [dbo].[tblSinhVien] ([PK_sMaSV])
GO

ALTER TABLE [dbo].[tblDiemThi] CHECK CONSTRAINT [FK_tblDiemThi_tblSinhVien]
GO


