﻿
-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblGiangVien_Update
		@PK_sMaGV	varchar(50)
		,@sHoTenGV	nvarchar(100)
		,@sTendangnhapGV	varchar(50)
		,@sMatkhauGV	varchar(50)
		,@sEmailGV	varchar(50)
		,@sDiachiGV	nvarchar(100)
		,@sSdtGV	varchar(13)
		,@tNgaysinhGV	datetime
		,@bGioitinhGV	bit
		,@sCMNDGV	varchar(9)
		,@tNgayCapCMNDGV	datetime
		,@sNoiCapCMNDGV	nvarchar(100)
		,@bHonNhanGV	bit
		,@tNgayNhanCongTacGV	datetime
		,@iChucVuGV	smallint
		,@iHocViGV	smallint
		,@bCongChucGV	bit
		,@sLinkChannels	varchar(200)
		,@sLinkChatRooms	varchar(200)
		,@iTrangThaiGV	smallint
AS
BEGIN
	SET NOCOUNT ON;
		
	UPDATE [tblGiangVien]	SET
		 [sHoTenGV] 	= @sHoTenGV
		,[sTendangnhapGV] 	= @sTendangnhapGV
		,[sMatkhauGV] 	= @sMatkhauGV
		,[sEmailGV] 	= @sEmailGV
		,[sDiachiGV] 	= @sDiachiGV
		,[sSdtGV] 	= @sSdtGV
		,[tNgaysinhGV] 	= @tNgaysinhGV
		,[bGioitinhGV] 	= @bGioitinhGV
		,[sCMNDGV] 	= @sCMNDGV
		,[tNgayCapCMNDGV] 	= @tNgayCapCMNDGV
		,[sNoiCapCMNDGV] 	= @sNoiCapCMNDGV
		,[bHonNhanGV] 	= @bHonNhanGV
		,[tNgayNhanCongTacGV] 	= @tNgayNhanCongTacGV
		,[iChucVuGV] 	= @iChucVuGV
		,[iHocViGV] 	= @iHocViGV
		,[bCongChucGV] 	= @bCongChucGV
		,[sLinkChannels] 	= @sLinkChannels
		,[sLinkChatRooms] 	= @sLinkChatRooms
		,[iTrangThaiGV] 	= @iTrangThaiGV
	WHERE 
		[PK_sMaGV] 	= @PK_sMaGV
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject 
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblGiangVien_Delete
		@PK_sMaGV	varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
		
	Delete [tblGiangVien]
	Where
		[PK_sMaGV] 	= @PK_sMaGV
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblGiangVien_Insert
			@PK_sMaGV	varchar(50)
			,@sHoTenGV	nvarchar(100)
			,@sTendangnhapGV	varchar(50)
			,@sMatkhauGV	varchar(50)
			,@sEmailGV	varchar(50)
			,@sDiachiGV	nvarchar(100)
			,@sSdtGV	varchar(13)
			,@tNgaysinhGV	datetime
			,@bGioitinhGV	bit
			,@sCMNDGV	varchar(9)
			,@tNgayCapCMNDGV	datetime
			,@sNoiCapCMNDGV	nvarchar(100)
			,@bHonNhanGV	bit
			,@tNgayNhanCongTacGV	datetime
			,@iChucVuGV	smallint
			,@iHocViGV	smallint
			,@bCongChucGV	bit
			,@sLinkChannels	varchar(200)
			,@sLinkChatRooms	varchar(200)
			,@iTrangThaiGV	smallint
AS
BEGIN
	SET NOCOUNT ON;
		
	Insert Into [tblGiangVien]( [PK_sMaGV]
				,[sHoTenGV]
				,[sTendangnhapGV]
				,[sMatkhauGV]
				,[sEmailGV]
				,[sDiachiGV]
				,[sSdtGV]
				,[tNgaysinhGV]
				,[bGioitinhGV]
				,[sCMNDGV]
				,[tNgayCapCMNDGV]
				,[sNoiCapCMNDGV]
				,[bHonNhanGV]
				,[tNgayNhanCongTacGV]
				,[iChucVuGV]
				,[iHocViGV]
				,[bCongChucGV]
				,[sLinkChannels]
				,[sLinkChatRooms]
				,[iTrangThaiGV]
				)
		
	Values	( @PK_sMaGV
				,@sHoTenGV
				,@sTendangnhapGV
				,@sMatkhauGV
				,@sEmailGV
				,@sDiachiGV
				,@sSdtGV
				,@tNgaysinhGV
				,@bGioitinhGV
				,@sCMNDGV
				,@tNgayCapCMNDGV
				,@sNoiCapCMNDGV
				,@bHonNhanGV
				,@tNgayNhanCongTacGV
				,@iChucVuGV
				,@iHocViGV
				,@bCongChucGV
				,@sLinkChannels
				,@sLinkChatRooms
				,@iTrangThaiGV
				)

END

GO

-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblGiangVien_SelectItem
		@PK_sMaGV	varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
		
	Select 		[PK_sMaGV]
				, [sHoTenGV]
				, [sTendangnhapGV]
				, [sMatkhauGV]
				, [sEmailGV]
				, [sDiachiGV]
				, [sSdtGV]
				, [tNgaysinhGV]
				, [bGioitinhGV]
				, [sCMNDGV]
				, [tNgayCapCMNDGV]
				, [sNoiCapCMNDGV]
				, [bHonNhanGV]
				, [tNgayNhanCongTacGV]
				, [iChucVuGV]
				, [iHocViGV]
				, [bCongChucGV]
				, [sLinkChannels]
				, [sLinkChatRooms]
				, [iTrangThaiGV]
	From	[tblGiangVien]
	Where
		[PK_sMaGV] 	= @PK_sMaGV
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblGiangVien_SelectList
AS
BEGIN
	SET NOCOUNT ON;
		
	Select 		[PK_sMaGV]
				, [sHoTenGV]
				, [sTendangnhapGV]
				, [sMatkhauGV]
				, [sEmailGV]
				, [sDiachiGV]
				, [sSdtGV]
				, [tNgaysinhGV]
				, [bGioitinhGV]
				, [sCMNDGV]
				, [tNgayCapCMNDGV]
				, [sNoiCapCMNDGV]
				, [bHonNhanGV]
				, [tNgayNhanCongTacGV]
				, [iChucVuGV]
				, [iHocViGV]
				, [bCongChucGV]
				, [sLinkChannels]
				, [sLinkChatRooms]
				, [iTrangThaiGV]
	From	[tblGiangVien]
	Order by [PK_sMaGV]
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblGiangVien_Search
			@PK_sMaGV	varchar(50)
			,@sHoTenGV	nvarchar(100)
			,@sTendangnhapGV	varchar(50)
			,@sMatkhauGV	varchar(50)
			,@sEmailGV	varchar(50)
			,@sDiachiGV	nvarchar(100)
			,@sSdtGV	varchar(13)
			,@tNgaysinhGV	datetime
			,@bGioitinhGV	bit
			,@sCMNDGV	varchar(9)
			,@tNgayCapCMNDGV	datetime
			,@sNoiCapCMNDGV	nvarchar(100)
			,@bHonNhanGV	bit
			,@tNgayNhanCongTacGV	datetime
			,@iChucVuGV	smallint
			,@iHocViGV	smallint
			,@bCongChucGV	bit
			,@sLinkChannels	varchar(200)
			,@sLinkChatRooms	varchar(200)
			,@iTrangThaiGV	smallint
AS
BEGIN
	SET NOCOUNT ON;
		
	Select 		[PK_sMaGV]
				, [sHoTenGV]
				, [sTendangnhapGV]
				, [sMatkhauGV]
				, [sEmailGV]
				, [sDiachiGV]
				, [sSdtGV]
				, [tNgaysinhGV]
				, [bGioitinhGV]
				, [sCMNDGV]
				, [tNgayCapCMNDGV]
				, [sNoiCapCMNDGV]
				, [bHonNhanGV]
				, [tNgayNhanCongTacGV]
				, [iChucVuGV]
				, [iHocViGV]
				, [bCongChucGV]
				, [sLinkChannels]
				, [sLinkChatRooms]
				, [iTrangThaiGV]
	From	[tblGiangVien]
	Where
		(@PK_sMaGV is null or [PK_sMaGV] 	like '%' + @PK_sMaGV+ '%')
		AND (@sHoTenGV is null or [sHoTenGV] 	like '%' + @sHoTenGV+ '%')
		AND (@sTendangnhapGV is null or [sTendangnhapGV] 	like '%' + @sTendangnhapGV+ '%')
		AND (@sMatkhauGV is null or [sMatkhauGV] 	like '%' + @sMatkhauGV+ '%')
		AND (@sEmailGV is null or [sEmailGV] 	like '%' + @sEmailGV+ '%')
		AND (@sDiachiGV is null or [sDiachiGV] 	like '%' + @sDiachiGV+ '%')
		AND (@sSdtGV is null or [sSdtGV] 	like '%' + @sSdtGV+ '%')
		AND (@tNgaysinhGV is null or [tNgaysinhGV] 	= @tNgaysinhGV)
		AND (@bGioitinhGV is null or [bGioitinhGV] = @bGioitinhGV)
		AND (@sCMNDGV is null or [sCMNDGV] 	like '%' + @sCMNDGV+ '%')
		AND (@tNgayCapCMNDGV is null or [tNgayCapCMNDGV] 	= @tNgayCapCMNDGV)
		AND (@sNoiCapCMNDGV is null or [sNoiCapCMNDGV] 	like '%' + @sNoiCapCMNDGV+ '%')
		AND (@bHonNhanGV is null or [bHonNhanGV] = @bHonNhanGV)
		AND (@tNgayNhanCongTacGV is null or [tNgayNhanCongTacGV] 	= @tNgayNhanCongTacGV)
		AND (@iChucVuGV is null or [iChucVuGV] 	like '%' + @iChucVuGV+ '%')
		AND (@iHocViGV is null or [iHocViGV] 	like '%' + @iHocViGV+ '%')
		AND (@bCongChucGV is null or [bCongChucGV] = @bCongChucGV)
		AND (@sLinkChannels is null or [sLinkChannels] 	like '%' + @sLinkChannels+ '%')
		AND (@sLinkChatRooms is null or [sLinkChatRooms] 	like '%' + @sLinkChatRooms+ '%')
		AND (@iTrangThaiGV is null or [iTrangThaiGV] 	like '%' + @iTrangThaiGV+ '%')
		
END

GO

	