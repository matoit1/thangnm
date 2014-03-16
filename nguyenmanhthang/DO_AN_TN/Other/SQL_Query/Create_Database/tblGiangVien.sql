USE [DoAn_LopHocAo]
GO

/****** Object:  Table [dbo].[tblGiangVien]    Script Date: 3/16/2014 4:52:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblGiangVien](
	[PK_sMaGV] [varchar](50) NOT NULL,
	[sHoTenGV] [nvarchar](100) NOT NULL,
	[sTendangnhapGV] [varchar](50) NOT NULL,
	[sMatkhauGV] [varchar](50) NOT NULL,
	[sEmailGV] [varchar](50) NOT NULL,
	[sDiachiGV] [nvarchar](100) NOT NULL,
	[sSdtGV] [varchar](13) NOT NULL,
	[tNgaysinhGV] [datetime] NOT NULL,
	[bGioitinhGV] [bit] NOT NULL,
	[sCMNDGV] [varchar](9) NOT NULL,
	[tNgayCapCMNDGV] [datetime] NOT NULL,
	[sNoiCapCMNDGV] [nvarchar](100) NOT NULL,
	[bHonNhanGV] [bit] NOT NULL,
	[tNgayNhanCongTacGV] [datetime] NOT NULL,
	[iChucVuGV] [smallint] NOT NULL,
	[iHocViGV] [smallint] NOT NULL,
	[bCongChucGV] [bit] NOT NULL,
	[sLinkChannels] [varchar](200) NULL,
	[sLinkChatRooms] [varchar](200) NULL,
	[iTrangThaiGV] [smallint] NOT NULL,
 CONSTRAINT [PK_tblGiangVien] PRIMARY KEY CLUSTERED 
(
	[PK_sMaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


