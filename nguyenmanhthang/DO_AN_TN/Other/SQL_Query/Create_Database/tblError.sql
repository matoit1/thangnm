USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblError]    Script Date: 3/16/2014 4:52:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblError](
	[PK_lErrorID] [bigint] IDENTITY(1,1) NOT NULL,
	[sLink] [varchar](200) NULL,
	[sIP] [varchar](15) NULL,
	[sBrowser] [varchar](200) NULL,
	[iCodes] [smallint] NULL,
	[tTime] [datetime] NULL,
	[tTimeCheck] [datetime] NULL,
	[iStatus] [smallint] NULL,
 CONSTRAINT [PK__Error__7A235C0AE93740E7] PRIMARY KEY CLUSTERED 
(
	[PK_lErrorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblError] ADD  CONSTRAINT [DF__Error__Error_Tim__6CF8245B]  DEFAULT (getdate()) FOR [tTime]
GO


