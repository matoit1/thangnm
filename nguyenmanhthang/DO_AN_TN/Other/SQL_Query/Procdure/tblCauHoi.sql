﻿
-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblCauHoi_Update
		@FK_sMaGV	varchar(50)
		,@PK_lCauhoi_ID	bigint
		,@sCauhoi_Cauhoi	nvarchar(500)
		,@sCauhoi_A	nvarchar(500)
		,@sCauhoi_B	nvarchar(500)
		,@sCauhoi_C	nvarchar(500)
		,@sCauhoi_D	nvarchar(500)
		,@iCauhoi_Dung	smallint
		,@sBoCauHoi	varchar(50)
		,@tNgayTao	datetime
		,@tNgayCapNhat	datetime
		,@iTrangThai	smallint
AS
BEGIN
	SET NOCOUNT ON;
		
	UPDATE [tblCauHoi]	SET
		 [FK_sMaGV] 	= @FK_sMaGV
		,[sCauhoi_Cauhoi] 	= @sCauhoi_Cauhoi
		,[sCauhoi_A] 	= @sCauhoi_A
		,[sCauhoi_B] 	= @sCauhoi_B
		,[sCauhoi_C] 	= @sCauhoi_C
		,[sCauhoi_D] 	= @sCauhoi_D
		,[iCauhoi_Dung] 	= @iCauhoi_Dung
		,[sBoCauHoi] 	= @sBoCauHoi
		,[tNgayTao] 	= @tNgayTao
		,[tNgayCapNhat] 	= @tNgayCapNhat
		,[iTrangThai] 	= @iTrangThai
	WHERE 
		[PK_lCauhoi_ID] 	= @PK_lCauhoi_ID
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject 
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblCauHoi_Delete
		@PK_lCauhoi_ID	bigint
AS
BEGIN
	SET NOCOUNT ON;
		
	Delete [tblCauHoi]
	Where
		[PK_lCauhoi_ID] 	= @PK_lCauhoi_ID
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblCauHoi_Insert
			@FK_sMaGV	varchar(50)
			,@PK_lCauhoi_ID	bigint
			,@sCauhoi_Cauhoi	nvarchar(500)
			,@sCauhoi_A	nvarchar(500)
			,@sCauhoi_B	nvarchar(500)
			,@sCauhoi_C	nvarchar(500)
			,@sCauhoi_D	nvarchar(500)
			,@iCauhoi_Dung	smallint
			,@sBoCauHoi	varchar(50)
			,@tNgayTao	datetime
			,@tNgayCapNhat	datetime
			,@iTrangThai	smallint
AS
BEGIN
	SET NOCOUNT ON;
		
	Insert Into [tblCauHoi]( [FK_sMaGV]
				,[PK_lCauhoi_ID]
				,[sCauhoi_Cauhoi]
				,[sCauhoi_A]
				,[sCauhoi_B]
				,[sCauhoi_C]
				,[sCauhoi_D]
				,[iCauhoi_Dung]
				,[sBoCauHoi]
				,[tNgayTao]
				,[tNgayCapNhat]
				,[iTrangThai]
				)
		
	Values	( @FK_sMaGV
				,@PK_lCauhoi_ID
				,@sCauhoi_Cauhoi
				,@sCauhoi_A
				,@sCauhoi_B
				,@sCauhoi_C
				,@sCauhoi_D
				,@iCauhoi_Dung
				,@sBoCauHoi
				,@tNgayTao
				,@tNgayCapNhat
				,@iTrangThai
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
CREATE PROCEDURE tblCauHoi_SelectItem
		@PK_lCauhoi_ID	bigint
AS
BEGIN
	SET NOCOUNT ON;
		
	Select 		[FK_sMaGV]
				, [PK_lCauhoi_ID]
				, [sCauhoi_Cauhoi]
				, [sCauhoi_A]
				, [sCauhoi_B]
				, [sCauhoi_C]
				, [sCauhoi_D]
				, [iCauhoi_Dung]
				, [sBoCauHoi]
				, [tNgayTao]
				, [tNgayCapNhat]
				, [iTrangThai]
	From	[tblCauHoi]
	Where
		[PK_lCauhoi_ID] 	= @PK_lCauhoi_ID
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblCauHoi_SelectList
AS
BEGIN
	SET NOCOUNT ON;
		
	Select 		[FK_sMaGV]
				, [PK_lCauhoi_ID]
				, [sCauhoi_Cauhoi]
				, [sCauhoi_A]
				, [sCauhoi_B]
				, [sCauhoi_C]
				, [sCauhoi_D]
				, [iCauhoi_Dung]
				, [sBoCauHoi]
				, [tNgayTao]
				, [tNgayCapNhat]
				, [iTrangThai]
	From	[tblCauHoi]
	Order by [PK_lCauhoi_ID]
		
END

GO

-- =============================================
-- This stored procedure is generated by BuildProject
-- Author:	ThangNM
-- Create date:	16/03/2014 16:44
-- Description:	
-- Revise History:	
-- =============================================
CREATE PROCEDURE tblCauHoi_Search
			@FK_sMaGV	varchar(50)
			,@PK_lCauhoi_ID	bigint
			,@sCauhoi_Cauhoi	nvarchar(500)
			,@sCauhoi_A	nvarchar(500)
			,@sCauhoi_B	nvarchar(500)
			,@sCauhoi_C	nvarchar(500)
			,@sCauhoi_D	nvarchar(500)
			,@iCauhoi_Dung	smallint
			,@sBoCauHoi	varchar(50)
			,@tNgayTao	datetime
			,@tNgayCapNhat	datetime
			,@iTrangThai	smallint
AS
BEGIN
	SET NOCOUNT ON;
		
	Select 		[FK_sMaGV]
				, [PK_lCauhoi_ID]
				, [sCauhoi_Cauhoi]
				, [sCauhoi_A]
				, [sCauhoi_B]
				, [sCauhoi_C]
				, [sCauhoi_D]
				, [iCauhoi_Dung]
				, [sBoCauHoi]
				, [tNgayTao]
				, [tNgayCapNhat]
				, [iTrangThai]
	From	[tblCauHoi]
	Where
		(@FK_sMaGV is null or [FK_sMaGV] 	like '%' + @FK_sMaGV+ '%')
		AND (@PK_lCauhoi_ID is null or [PK_lCauhoi_ID] 	like '%' + @PK_lCauhoi_ID+ '%')
		AND (@sCauhoi_Cauhoi is null or [sCauhoi_Cauhoi] 	like '%' + @sCauhoi_Cauhoi+ '%')
		AND (@sCauhoi_A is null or [sCauhoi_A] 	like '%' + @sCauhoi_A+ '%')
		AND (@sCauhoi_B is null or [sCauhoi_B] 	like '%' + @sCauhoi_B+ '%')
		AND (@sCauhoi_C is null or [sCauhoi_C] 	like '%' + @sCauhoi_C+ '%')
		AND (@sCauhoi_D is null or [sCauhoi_D] 	like '%' + @sCauhoi_D+ '%')
		AND (@iCauhoi_Dung is null or [iCauhoi_Dung] 	like '%' + @iCauhoi_Dung+ '%')
		AND (@sBoCauHoi is null or [sBoCauHoi] 	like '%' + @sBoCauHoi+ '%')
		AND (@tNgayTao is null or [tNgayTao] 	= @tNgayTao)
		AND (@tNgayCapNhat is null or [tNgayCapNhat] 	= @tNgayCapNhat)
		AND (@iTrangThai is null or [iTrangThai] 	like '%' + @iTrangThai+ '%')
		
END

GO

	
CREATE PROCEDURE tblCauHoi_SelectByFK_sMaGV
		@FK_sMaGV	varchar
AS
BEGIN
	SET NOCOUNT ON;

	Select 		[FK_sMaGV]
				, [PK_lCauhoi_ID]
				, [sCauhoi_Cauhoi]
				, [sCauhoi_A]
				, [sCauhoi_B]
				, [sCauhoi_C]
				, [sCauhoi_D]
				, [iCauhoi_Dung]
				, [sBoCauHoi]
				, [tNgayTao]
				, [tNgayCapNhat]
				, [iTrangThai]
	From	[tblCauHoi]
	Where	FK_sMaGV	= @FK_sMaGV
END

GO
	