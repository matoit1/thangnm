USE [DoAn_LopHocAo]
GO
/****** Object:  UserDefinedFunction [dbo].[IntegerCommaSplit]    Script Date: 06/04/2014 16:04:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----- Tao function de chuyen chuoi String thanh INT
CREATE FUNCTION [dbo].[IntegerCommaSplit](@ListofIds NVARCHAR(1000))
RETURNS @rtn TABLE (IntegerValue BIGINT)
AS
BEGIN
WHILE (Charindex(',',@ListofIds)>0)
BEGIN
    INSERT INTO @Rtn 
    SELECT LTRIM(RTRIM(SUBSTRING(@ListofIds,1,CHARINDEX(',',@ListofIds)-1)))
    SET @ListofIds = SUBSTRING(@ListofIds,CHARINDEX(',',@ListofIds)+LEN(','),LEN(@ListofIds))
END
INSERT INTO @Rtn 
    SELECT  LTRIM(RTRIM(@ListofIds))
RETURN 
END
GO
/****** Object:  UserDefinedFunction [dbo].[StringCommaSplit]    Script Date: 06/04/2014 16:04:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----- Tao function de chuyen chuoi String thanh String
CREATE FUNCTION [dbo].[StringCommaSplit](@ListofUsername NVARCHAR(1000))
RETURNS @rtn TABLE (StringValue NVARCHAR(1000))
AS
BEGIN
WHILE (CHARINDEX(',',@ListofUsername)>0)
BEGIN
    INSERT INTO @Rtn 
    SELECT LTRIM(RTRIM(SUBSTRING(@ListofUsername,1,CHARINDEX(',',@ListofUsername)-1)))
    SET @ListofUsername = SUBSTRING(@ListofUsername,CHARINDEX(',',@ListofUsername)+LEN(','),LEN(@ListofUsername))
END
INSERT INTO @Rtn 
    SELECT  LTRIM(RTRIM(@ListofUsername))
RETURN
END
GO
