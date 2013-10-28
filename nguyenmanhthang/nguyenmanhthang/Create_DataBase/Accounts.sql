----- 1. Accounts_Insert
----- Delete Proc -----
DROP PROCEDURE Accounts_Insert

----- Create Proc -----
CREATE PROCEDURE Accounts_Insert
	@Accounts_Username VARCHAR(50),
	@Accounts_Password VARCHAR(50),
	@Accounts_Email VARCHAR(100),
	@Accounts_FullName NVARCHAR(100),
	@Accounts_Address NVARCHAR(500),
	@Accounts_DateOfBirth DATETIME,
	@Accounts_PhoneNumber VARCHAR(50),
	@Accounts_Permission INT,
	@Accounts_LinkAvatar NVARCHAR(200),
	@Accounts_Signature VARCHAR(200),
	@Accounts_Like INT,
	@Accounts_Notification BIT,
	@Accounts_Status BIT
AS
BEGIN
	INSERT INTO Accounts(Accounts_Username,Accounts_Password, Accounts_Email, Accounts_FullName, Accounts_Address, Accounts_DateOfBirth,Accounts_PhoneNumber, Accounts_Permission, Accounts_LinkAvatar, Accounts_Signature, Accounts_Like, Accounts_Notification, Accounts_Status)
	VALUES (@Accounts_Username,@Accounts_Password, @Accounts_Email, @Accounts_FullName, @Accounts_Address, CONVERT(DATETIME, @Accounts_DateOfBirth,103), @Accounts_PhoneNumber, @Accounts_Permission, @Accounts_LinkAvatar, @Accounts_Signature, @Accounts_Like, @Accounts_Notification, @Accounts_Status)
END

----- Test Proc -----
SELECT * FROM Accounts



----- 2. Accounts_Update
----- Delete Proc -----
DROP PROCEDURE Accounts_Update

----- Create Proc -----
CREATE PROCEDURE Accounts_Update
	@Accounts_Username VARCHAR(50),
	@Accounts_Password VARCHAR(50),
	@Accounts_Email VARCHAR(100),
	@Accounts_FullName NVARCHAR(100),
	@Accounts_Address NVARCHAR(500),
	@Accounts_DateOfBirth DATETIME,
	@Accounts_PhoneNumber VARCHAR(50),
	@Accounts_Permission INT,
	@Accounts_LinkAvatar NVARCHAR(200),
	@Accounts_Signature VARCHAR(200),
	@Accounts_Like INT,
	@Accounts_Notification BIT,
	@Accounts_Status BIT
AS
BEGIN
UPDATE Accounts
SET
	Accounts_Username=@Accounts_Username,
	Accounts_Password=@Accounts_Password,
	Accounts_Email=@Accounts_Email,
	Accounts_FullName=@Accounts_FullName,
	Accounts_Address=@Accounts_Address,
	Accounts_DateOfBirth=CONVERT(DATETIME, @Accounts_DateOfBirth,103),
	Accounts_PhoneNumber=@Accounts_PhoneNumber,
	Accounts_Permission=@Accounts_Permission,
	Accounts_LinkAvatar=@Accounts_LinkAvatar,
	Accounts_Signature = @Accounts_Signature,
	Accounts_Like = @Accounts_Like,
	Accounts_Notification = @Accounts_Notification,
	Accounts_Status=@Accounts_Status
WHERE Accounts_Username=@Accounts_Username
END

----- Test Proc -----
EXEC Accounts_Update 'admin','40bd001563085fc35165329ea1ff5c5ecbdbbeef','thang',3,'http://thangnm.googlecode.com/svn/favicon.ico','ThangNM','hn','12/12/1992','190283','TRUE'
SELECT * FROM Accounts





----- 3. Accounts_ResetPassword
----- Delete Proc -----
DROP PROCEDURE Accounts_ResetPassword

----- Create Proc -----
CREATE PROCEDURE Accounts_ResetPassword
	@Accounts_Username VARCHAR(50),
	@Accounts_Password VARCHAR(50)
AS
BEGIN
	UPDATE Accounts
	SET
		Accounts_Username=@Accounts_Username,
		Accounts_Password=@Accounts_Password
	WHERE Accounts_Username=@Accounts_Username
END






----- 4. Accounts_Delete
----- Delete Proc -----
DROP PROCEDURE Accounts_Delete

----- Create Proc -----
CREATE PROCEDURE Accounts_Delete
	@Accounts_Username VARCHAR(400)
AS
BEGIN
	DELETE Accounts
	WHERE Accounts_Username IN (SELECT StringValue FROM StringCommaSplit(@Accounts_Username))
END

----- Test	 Proc -----
EXEC Accounts_Delete 'hellodrtrt,kltrtr'





----- 5. Accounts_Login
	----- Delete Proc ----- 
DROP PROCEDURE Accounts_Login

	----- Create Proc -----
CREATE PROCEDURE Accounts_Login
	@Accounts_Username VARCHAR(50),
	@Accounts_Password VARCHAR(50)
AS
BEGIN
	SELECT *
	FROM Accounts WHERE (Accounts_Username LIKE @Accounts_Username) AND (Accounts_Password LIKE @Accounts_Password) AND (Accounts_Permission IN (1,2)) AND (Accounts_Status='TRUE')
END

----- Test	 Proc -----
EXEC Accounts_Login 'admin', '40bd001563085fc35165329ea1ff5c5ecbdbbeef'





----- 9. Accounts_CheckAccounts_Username
	----- Delete Proc -----
DROP PROCEDURE Accounts_CheckAccounts_Username

	----- Create Proc -----
CREATE PROCEDURE Accounts_CheckAccounts_Username
	@Accounts_Username VARCHAR(50)
AS
BEGIN
	SELECT Accounts_Permission, Accounts_Status
	FROM Accounts WHERE Accounts_Username=@Accounts_Username
END

----- Test	 Proc -----
EXEC Accounts_CheckAccounts_Username 'admin'





----- 10. Accounts_CheckAccounts_Email
	----- Delete Proc -----
DROP PROCEDURE Accounts_CheckAccounts_Email

	----- Create Proc -----
CREATE PROCEDURE Accounts_CheckAccounts_Email
	@Accounts_Email VARCHAR(100)
AS
BEGIN
	SELECT *
	FROM Accounts WHERE Accounts_Email=@Accounts_Email
END

----- Test	 Proc -----
EXEC Accounts_CheckAccounts_Email 'thang.991992@hotmail.com'





------- 11. ThangNMjsc_getDataSetAccounts Topic_SelectListbyTopic_Status
--	----- Delete Proc -----
--DROP PROCEDURE ThangNMjsc_getDataSetAccounts

--	----- Create Proc -----
--CREATE PROCEDURE ThangNMjsc_getDataSetAccounts
--	@Accounts_Permission INT
--AS
--BEGIN
--	IF (@Accounts_Permission =100)
--	   SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_Permission, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate], Accounts_LinkAvatar, Accounts_FullName, Accounts_Address, CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber, Accounts_Status
--	   FROM Accounts WHERE Accounts_Permission IN (1,2,3)
--	   ORDER BY Accounts_RegisterDate DESC
--	ELSE
--	   SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_Permission, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate], Accounts_LinkAvatar, Accounts_FullName, Accounts_Address, CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber, Accounts_Status
--	   FROM Accounts WHERE Accounts_Permission=@Accounts_Permission
--	   ORDER BY Accounts_RegisterDate DESC
--END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetAccounts 100



----- 12. Accounts_SelectInfoByAccounts_Username
	----- Delete Proc -----
DROP PROCEDURE Accounts_SelectInfoByAccounts_Username

	----- Create Proc -----
CREATE PROCEDURE Accounts_SelectListbyAccounts_Username
	@Accounts_Username VARCHAR(50)
AS
BEGIN
	SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_FullName, Accounts_Address,
		  CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber,
		  Accounts_Permission, Accounts_LinkAvatar, Accounts_Signature, Accounts_Like, Accounts_Notification,
		   Accounts_Status, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate]
	FROM Accounts WHERE Accounts_Username=@Accounts_Username
END

	----- Test	 Proc -----
EXEC Accounts_SelectListbyAccounts_Username 'admin'




----- 13. Accounts_SearchAccounts
----- Delete Proc -----
DROP PROCEDURE Accounts_SearchAccounts

----- Create Proc -----
CREATE PROCEDURE Accounts_SearchAccounts
	@Accounts_Username VARCHAR(50),
	@Accounts_Email VARCHAR(100),
	@Accounts_FullName NVARCHAR(100),
	@Accounts_Address NVARCHAR(500),
	@Accounts_Permission VARCHAR(50)
AS
BEGIN
	SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_FullName, Accounts_Address,
		  CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber,
		  Accounts_Permission, Accounts_LinkAvatar, Accounts_Signature, Accounts_Like, Accounts_Notification,
		   Accounts_Status, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate]
	FROM Accounts
	WHERE ((Accounts_FullName LIKE '%' +@Accounts_FullName +'%' OR Accounts_FullName IS NULL)
			AND (Accounts_Username LIKE '%' +@Accounts_Username +'%' OR Accounts_Username IS NULL)
			AND (Accounts_Email LIKE '%' +@Accounts_Email +'%' OR Accounts_Email IS NULL) AND Accounts_Permission IN(SELECT StringValue FROM StringCommaSplit(@Accounts_Permission))
			AND (Accounts_Address LIKE '%' +@Accounts_Address +'%' OR Accounts_Address IS NULL))
	ORDER BY Accounts_RegisterDate DESC
END

----- Test Proc -----
EXEC Accounts_SearchAccounts '','','',''




----- 14. Tao function de chuyen chuoi String thanh String
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