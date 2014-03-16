USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblLichDayVaHoc]    Script Date: 3/16/2014 4:53:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblLichDayVaHoc](
	[FK_sMaPCCT] [varchar](50) NOT NULL,
	[FK_sMalop] [varchar](50) NOT NULL,
	[iCaHoc] [smallint] NOT NULL,
	[tNgayDay] [datetime] NOT NULL,
	[iSoTietDay] [smallint] NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblLichHoc_1] PRIMARY KEY CLUSTERED 
(
	[FK_sMaPCCT] ASC,
	[FK_sMalop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblLichDayVaHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLichDayVaHoc_tblLopHoc] FOREIGN KEY([FK_sMalop])
REFERENCES [dbo].[tblLopHoc] ([PK_sMalop])
GO

ALTER TABLE [dbo].[tblLichDayVaHoc] CHECK CONSTRAINT [FK_tblLichDayVaHoc_tblLopHoc]
GO

ALTER TABLE [dbo].[tblLichDayVaHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLichHoc_tblPhanCongCongTac] FOREIGN KEY([FK_sMaPCCT])
REFERENCES [dbo].[tblPhanCongCongTac] ([PK_sMaPCCT])
GO

ALTER TABLE [dbo].[tblLichDayVaHoc] CHECK CONSTRAINT [FK_tblLichHoc_tblPhanCongCongTac]
GO


