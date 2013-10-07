----- 1. Insert Table Accounts Admin
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertAccountsAdmin

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertAccountsAdmin
		@Accounts_Username VARCHAR(50),
		@Accounts_Password VARCHAR(50),
		@Accounts_Email VARCHAR(100),
		@Accounts_Permission INT,
		@Accounts_LinkAvatar NVARCHAR(200),
		@Accounts_FullName NVARCHAR(100),
		@Accounts_Address NVARCHAR(500),
		@Accounts_DateOfBirth DATETIME,
		@Accounts_PhoneNumber VARCHAR(50),
		@Accounts_Status BIT
	AS
	BEGIN
	INSERT INTO Accounts(Accounts_Username,Accounts_Password, Accounts_Email, Accounts_Permission, Accounts_LinkAvatar, Accounts_FullName, Accounts_Address, Accounts_DateOfBirth,Accounts_PhoneNumber, Accounts_Status)
	VALUES (@Accounts_Username,@Accounts_Password, @Accounts_Email, @Accounts_Permission, @Accounts_LinkAvatar, @Accounts_FullName, @Accounts_Address, CONVERT(DATETIME, @Accounts_DateOfBirth,103), @Accounts_PhoneNumber, @Accounts_Status)
	END

	----- Test Proc -----
	SELECT * FROM Accounts





----- 2. Insert Table Accounts
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertAccounts

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertAccounts
		@Accounts_Username VARCHAR(50),
		@Accounts_Password VARCHAR(50),
		@Accounts_Email VARCHAR(100),
		@Accounts_LinkAvatar NVARCHAR(200),
		@Accounts_FullName NVARCHAR(100),
		@Accounts_Address NVARCHAR(500),
		@Accounts_DateOfBirth DATETIME,
		@Accounts_PhoneNumber VARCHAR(50)
	AS
	BEGIN
	INSERT INTO Accounts(Accounts_Username,Accounts_Password, Accounts_Email, Accounts_LinkAvatar, Accounts_FullName, Accounts_Address, Accounts_DateOfBirth,Accounts_PhoneNumber)
	VALUES (@Accounts_Username,@Accounts_Password, @Accounts_Email, @Accounts_LinkAvatar, @Accounts_FullName, @Accounts_Address, CONVERT(DATETIME, @Accounts_DateOfBirth,103), @Accounts_PhoneNumber)
	END

	----- Test Proc -----
	SELECT * FROM Accounts






----- 3. Update Table Accounts Admin
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_UpdateAccountsAdmin

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_UpdateAccountsAdmin
		@Accounts_Username VARCHAR(50),
		@Accounts_Password VARCHAR(50),
		@Accounts_Email VARCHAR(100),
		@Accounts_Permission INT,
		@Accounts_LinkAvatar NVARCHAR(200),
		@Accounts_FullName NVARCHAR(100),
		@Accounts_Address NVARCHAR(500),
		@Accounts_DateOfBirth DATETIME,
		@Accounts_PhoneNumber VARCHAR(50),
		@Accounts_Status BIT
	AS
	BEGIN
	UPDATE Accounts
	SET
		Accounts_Username=@Accounts_Username,
		Accounts_Password=@Accounts_Password,
		Accounts_Email=@Accounts_Email,
		Accounts_Permission=@Accounts_Permission,
		Accounts_LinkAvatar=@Accounts_LinkAvatar,
		Accounts_FullName=@Accounts_FullName,
		Accounts_Address=@Accounts_Address,
		Accounts_DateOfBirth=CONVERT(DATETIME, @Accounts_DateOfBirth,103),
		Accounts_PhoneNumber=@Accounts_PhoneNumber,
		Accounts_Status=@Accounts_Status
	WHERE Accounts_Username=@Accounts_Username
	END

	----- Test Proc -----
	EXEC ThangNMjsc_UpdateAccountsAdmin 'admin','40bd001563085fc35165329ea1ff5c5ecbdbbeef','thang',3,'http://thangnm.googlecode.com/svn/favicon.ico','ThangNM','hn','12/12/1992','190283','TRUE'
	SELECT * FROM Accounts






----- 4. Update Table Accounts Customer
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_UpdateAccounts

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_UpdateAccounts
		@Accounts_Username VARCHAR(50),
		@Accounts_Password VARCHAR(50),
		@Accounts_Email VARCHAR(100),
		@Accounts_LinkAvatar NVARCHAR(200),
		@Accounts_FullName NVARCHAR(100),
		@Accounts_Address NVARCHAR(500),
		@Accounts_DateOfBirth DATETIME,
		@Accounts_PhoneNumber VARCHAR(50)
	AS
	BEGIN
	UPDATE Accounts
	SET
		Accounts_Username=@Accounts_Username,
		Accounts_Password=@Accounts_Password,
		Accounts_Email=@Accounts_Email,
		Accounts_LinkAvatar=@Accounts_LinkAvatar,
		Accounts_FullName=@Accounts_FullName,
		Accounts_Address=@Accounts_Address,
		Accounts_DateOfBirth=CONVERT(DATETIME, @Accounts_DateOfBirth,103),
		Accounts_PhoneNumber=@Accounts_PhoneNumber
	WHERE Accounts_Username=@Accounts_Username
	END

	----- Test Proc -----
	SELECT * FROM Accounts








	----- 5. Update Table Accounts Customer
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_ResetPasswordAccounts

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_ResetPasswordAccounts
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






----- 6. ThangNMjsc_deleteAccountsbyUsername
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_deleteAccountsbyUsername

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_deleteAccountsbyUsername @Accounts_Username VARCHAR(400)
AS
BEGIN
DELETE Accounts
WHERE Accounts_Username IN (SELECT StringValue FROM StringCommaSplit(@Accounts_Username))
END

	----- Test	 Proc -----
EXEC ThangNMjsc_deleteAccountsbyUsername 'hellodrtrt,kltrtr'





----- 7. Login Table Accounts Admin
	----- Delete Proc ----- 
DROP PROCEDURE ThangNMjsc_LoginAccountsAdmin

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_LoginAccountsAdmin
@Accounts_Username VARCHAR(50), @Accounts_Password VARCHAR(50)
AS
BEGIN
   SELECT *
  FROM Accounts WHERE (Accounts_Username LIKE @Accounts_Username) AND (Accounts_Password LIKE @Accounts_Password) AND (Accounts_Permission IN (1,2)) AND (Accounts_Status='TRUE')
END

----- Test	 Proc -----
EXEC ThangNMjsc_LoginAccountsAdmin 'admin', '40bd001563085fc35165329ea1ff5c5ecbdbbeef'




----- 8. Login Table Accounts
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_LoginAccounts

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_LoginAccounts @Accounts_Username VARCHAR(50), @Accounts_Password VARCHAR(50)
AS
BEGIN
   SELECT *
  FROM Accounts WHERE Accounts_Username=@Accounts_Username and Accounts_Password=@Accounts_Password
END

----- Test	 Proc -----
EXEC ThangNMjsc_LoginAccounts 'admin', '40bd001563085fc35165329ea1ff5c5ecbdbbeef'




----- 9. Check Table Accounts
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_CheckAccounts

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_CheckAccounts @Accounts_Username VARCHAR(50)
AS
BEGIN
   SELECT Accounts_Permission, Accounts_Status
  FROM Accounts WHERE Accounts_Username=@Accounts_Username
END

----- Test	 Proc -----
EXEC ThangNMjsc_CheckAccounts 'admin'





----- 10. Check Email Accounts
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_CheckEmailAccounts

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_CheckEmailAccounts @Accounts_Email VARCHAR(100)
AS
BEGIN
   SELECT *
  FROM Accounts WHERE Accounts_Email=@Accounts_Email
END

----- Test	 Proc -----
EXEC ThangNMjsc_CheckEmailAccounts 'thang.991992@hotmail.com'





----- 11. ThangNMjsc_getDataSetAccounts
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetAccounts

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetAccounts @Accounts_Permission INT
AS
BEGIN
IF (@Accounts_Permission =100)
   SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_Permission, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate], Accounts_LinkAvatar, Accounts_FullName, Accounts_Address, CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber, Accounts_Status
   FROM Accounts WHERE Accounts_Permission IN (1,2,3)
   ORDER BY Accounts_RegisterDate DESC
ELSE
   SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_Permission, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate], Accounts_LinkAvatar, Accounts_FullName, Accounts_Address, CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber, Accounts_Status
   FROM Accounts WHERE Accounts_Permission=@Accounts_Permission
   ORDER BY Accounts_RegisterDate DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetAccounts 100



----- 12. ThangNMjsc_getAccountsbyUsername
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getAccountsbyUsername

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getAccountsbyUsername @Accounts_Username VARCHAR(50)
AS
BEGIN
SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_Permission, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate], Accounts_LinkAvatar,
	 Accounts_FullName, Accounts_Address, CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber, Accounts_Status
FROM Accounts WHERE Accounts_Username=@Accounts_Username
END

	----- Test	 Proc -----
EXEC ThangNMjsc_getAccountsbyUsername 'test'




----- 13. Search Table Accounts
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_SearchAccountsbyFullname

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_SearchAccountsbyFullname
		@Accounts_FullName NVARCHAR(100),
		@Accounts_Username VARCHAR(50),
		@Accounts_Email VARCHAR(100),
		@Accounts_Permission VARCHAR(50),
		@Accounts_Address NVARCHAR(500)
	AS
	BEGIN
	SELECT Accounts_ID, Accounts_Username, Accounts_Password, Accounts_Email, Accounts_Permission, CONVERT(VARCHAR(10),Accounts_RegisterDate,103) AS [Accounts_RegisterDate], Accounts_LinkAvatar,
	 Accounts_FullName, Accounts_Address, CONVERT(VARCHAR(10),Accounts_DateOfBirth,103)  AS [Accounts_DateOfBirth], Accounts_PhoneNumber, Accounts_Status
	FROM Accounts
	WHERE ((Accounts_FullName LIKE '%' +@Accounts_FullName +'%' OR Accounts_FullName IS NULL)
		 AND (Accounts_Username LIKE '%' +@Accounts_Username +'%' OR Accounts_Username IS NULL)
		 AND (Accounts_Email LIKE '%' +@Accounts_Email +'%' OR Accounts_Email IS NULL) AND Accounts_Permission IN(SELECT StringValue FROM StringCommaSplit(@Accounts_Permission))
		 AND (Accounts_Address LIKE '%' +@Accounts_Address +'%' OR Accounts_Address IS NULL))
	ORDER BY Accounts_RegisterDate DESC
	END

	----- Test Proc -----
	EXEC ThangNMjsc_SearchAccountsbyFullname '','','',''



	




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