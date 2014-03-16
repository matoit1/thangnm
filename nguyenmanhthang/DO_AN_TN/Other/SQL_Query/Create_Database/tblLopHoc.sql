USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblLopHoc]    Script Date: 3/16/2014 4:53:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblLopHoc](
	[PK_sMalop] [varchar](50) NOT NULL,
	[sTenlop] [nvarchar](100) NOT NULL,
	[iNamvaotruong] [smallint] NOT NULL,
	[iSiso] [smallint] NOT NULL,
	[iSoNamDaoTao] [smallint] NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblLop] PRIMARY KEY CLUSTERED 
(
	[PK_sMalop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


