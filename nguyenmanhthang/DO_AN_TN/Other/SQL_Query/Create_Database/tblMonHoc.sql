USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 3/16/2014 4:53:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblMonHoc](
	[PK_sMaMonhoc] [varchar](50) NOT NULL,
	[sTenMonhoc] [nvarchar](100) NOT NULL,
	[iSotrinh] [smallint] NOT NULL,
	[iSotietday] [smallint] NOT NULL,
	[iTrangThai] [smallint] NOT NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[PK_sMaMonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


