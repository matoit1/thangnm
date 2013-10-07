----- 1. Insert Table Supports -----
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_SendSupports

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_SendSupports
		@Customer_ID INT,
		@Product_ID BIGINT,
		@Supports_Type NVARCHAR(200),
		@Answers_Content NVARCHAR(2000)
	AS
	BEGIN
	INSERT INTO Supports(Customer_ID, Product_ID, Supports_Type)
	VALUES (@Customer_ID, @Product_ID, @Supports_Type)
	INSERT INTO Answers(Support_ID, Answers_Content)
	VALUES (SCOPE_IDENTITY(), @Answers_Content)
	END

	----- Test Proc -----
	Exec ThangNMjsc_SendSupports 4,5,'Bao loi','hehe','1','2','3'
	SELECT * FROM Support





----- 2. Update Table Answers -----
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_ReplySupports

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_ReplySupports
		@Answers_ID BIGINT,
		@Support_ID BIGINT,
		@Staff_ID INT,
		@Answers_Question NVARCHAR(2000)
	AS
	BEGIN
	UPDATE Answers
	SET
		Staff_ID=@Staff_ID,
		Answers_Question=@Answers_Question,
		Answers_DateTimeB=GETDATE()
	WHERE Answers_ID=@Answers_ID
	UPDATE Supports
	SET
		Supports_Status='TRUE'
	WHERE Supports_ID=@Support_ID
	END

	----- Test Proc -----
	EXEC ThangNMjsc_ReplySupports 3,3,1,'oki'
	SELECT * FROM Answers






----- 3. Update Table Answers -----
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_ForwardSupports

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_ForwardSupports
		@Support_ID BIGINT,
		@Answers_Content NVARCHAR(2000)
	AS
	BEGIN
		INSERT INTO Answers(Support_ID,  Answers_Content, Answers_DateTimeA)
		VALUES (@Support_ID, @Answers_Content, GETDATE())

	UPDATE Supports
	SET
		Supports_Status='FALSE'
	WHERE Supports_ID=@Support_ID
	END

	----- Test Proc -----
	EXEC ThangNMjsc_ForwardSupports 2,'test','test1','test1','test1'
	SELECT * FROM Answers





----- 4. Delete Table Supports
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_DeleteSupports

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_DeleteSupports
		@Supports_ID varchar(400)
	AS
	DELETE FROM Supports
	WHERE Supports_ID IN (SELECT IntegerValue FROM IntegerCommaSplit(@Supports_ID))

	----- Test Proc -----
	EXEC ThangNMjsc_DeleteSupports '1,3'






----- 5. ThangNMjsc_getDataSetNewSupports
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetNewSupports

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetNewSupports @Supports_Status BIT
AS
BEGIN
	SELECT a.Supports_ID, a.Supports_Type, b.Products_Name ,c.Accounts_Username ,a.Supports_Status,(select top 1 CONVERT(VARCHAR(10),d.Answers_DateTimeA,103) FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) AS [Answers_DateTimeA]
	,(SELECT TOP 1 g.Accounts_Username  FROM Answers d inner join Accounts g on d.Staff_ID =g.Accounts_ID   WHERE d.Support_ID =a.Supports_ID ) AS [Staff_ID]
	 FROM Supports a inner join Products b ON a.Product_ID=b.Products_ID inner join Accounts c ON a.Customer_ID =c.Accounts_ID 
	 WHERE a.Supports_Status=@Supports_Status
	 ORDER BY (select top 1 d.Answers_DateTimeA FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetNewSupports 'False'






----- 6 . ThangNMjsc_getDataSetSupportsbySupports_ID
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetSupportsbySupports_ID

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetSupportsbySupports_ID @Supports_ID BIGINT
AS
BEGIN
	 SELECT a.Supports_ID, a.Supports_Type,b.Products_ID, b.Products_Name ,(select TOP 1 Accounts_Username from Accounts where Accounts_ID= g.Staff_ID)AS [Staff],
	 (select TOP 1 Accounts_LinkAvatar from Accounts where Accounts_ID= g.Staff_ID)AS [AvatarStaff],
	  c.Accounts_Username, c.Accounts_LinkAvatar,a.Supports_Status,
	 g.Answers_Content, CONVERT(VARCHAR(10),g.Answers_DateTimeA,103) AS [Answers_DateTimeA], CONVERT(VARCHAR(10),g.Answers_DateTimeB,103) AS [Answers_DateTimeB], g.Answers_ID, g.Answers_Question
	 FROM Supports a inner join Products b ON a.Product_ID=b.Products_ID inner join Accounts c ON a.Customer_ID =c.Accounts_ID INNER JOIN Answers g ON a.Supports_ID = g.Support_ID
	 WHERE a.Supports_ID=@Supports_ID
	 ORDER BY [Answers_DateTimeA] ASC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetSupportsbySupports_ID 45






----- 7 . ThangNMjsc_getDataSetSupportsbyCustomer_ID
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetSupportsbyCustomer_IDandSupports_Status

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetSupportsbyCustomer_IDandSupports_Status
@Customer_ID INT, @Supports_Status BIT
AS
BEGIN
SELECT a.Supports_ID, a.Supports_Type, b.Products_Name ,c.Accounts_Username ,a.Supports_Status,(select top 1 CONVERT(VARCHAR(10),d.Answers_DateTimeA,103) FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) AS [Answers_DateTimeA]
	,(SELECT TOP 1 g.Accounts_Username  FROM Answers d inner join Accounts g on d.Staff_ID =g.Accounts_ID   WHERE d.Support_ID =a.Supports_ID ) AS [Staff_ID]
	 FROM Supports a inner join Products b ON a.Product_ID=b.Products_ID inner join Accounts c ON a.Customer_ID =c.Accounts_ID 
	 WHERE a.Customer_ID=@Customer_ID AND a.Supports_Status=@Supports_Status
	 ORDER BY (select top 1 d.Answers_DateTimeA FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetSupportsbyCustomer_IDandSupports_Status 67,'TRUE'







----- 8 . ThangNMjsc_getDataSetSupportsbyCustomer_IDAll
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetSupportsbyCustomer_IDAll

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetSupportsbyCustomer_IDAll
@Customer_ID INT
AS
BEGIN
SELECT Supports_ID, Customer_ID, Product_ID, Supports_Type, Answers_ID, Staff_ID, 
	Answers_Content, Answers_Question, CONVERT(VARCHAR(10),Answers_DateTimeA,103) AS [Answers_DateTimeA], CONVERT(VARCHAR(10),Answers_DateTimeB,103) AS [Answers_DateTimeB]
FROM Answers INNER JOIN Supports ON Support_ID = Supports_ID
WHERE Customer_ID =@Customer_ID
ORDER BY Answers_DateTimeA DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetSupportsbyCustomer_IDAll 4






----- 9. Search ThangNMjsc_SearchAnswersbySupports_Type
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_SearchAnswersbySupports_Type

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_SearchAnswersbySupports_Type
	 @Supports_Status BIT,
	 @Supports_Type VARCHAR (1000),
	 @Accounts_Username VARCHAR (1000),
	 @Products_Name VARCHAR (1000),
	 @Answers_DateTimeA1 DATETIME,
	 @Answers_DateTimeA2 DATETIME
	AS
	BEGIN
		SELECT a.Supports_ID, a.Supports_Type, b.Products_Name ,c.Accounts_Username ,a.Supports_Status,(select top 1 CONVERT(VARCHAR(10),d.Answers_DateTimeA,103) FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) AS [Answers_DateTimeA]
		,(SELECT TOP 1 g.Accounts_Username  FROM Answers d inner join Accounts g on d.Staff_ID =g.Accounts_ID   WHERE d.Support_ID =a.Supports_ID ) AS Staff_ID
		 FROM Supports a inner join Products b ON a.Product_ID=b.Products_ID inner join Accounts c ON a.Customer_ID =c.Accounts_ID 
		 WHERE ((a.Supports_Status=@Supports_Status) AND (Supports_Type LIKE '%'+@Supports_Type+'%' OR Supports_Type IS NULL)
		 AND (c.Accounts_Username LIKE '%'+@Accounts_Username+'%' OR c.Accounts_Username IS NULL)
		 AND (b.Products_Name LIKE '%'+@Products_Name+'%' OR b.Products_Name IS NULL)
		 AND ((select top 1d.Answers_DateTimeA FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) BETWEEN Convert(datetime,@Answers_DateTimeA1, 101) AND Convert(datetime,@Answers_DateTimeA2, 101))
		 )
		 ORDER BY [Answers_DateTimeA] DESC
	END

	----- Test Proc -----
	SELECT * FROM Supports
	EXEC ThangNMjsc_SearchAnswersbySupports_Type 'TRUE', '','guest','','',''






----- 10 . ThangNMjsc_SearchAnswersbySupports_TypeAndAccounts_Username
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_SearchAnswersbySupports_TypeAndAccounts_Username

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_SearchAnswersbySupports_TypeAndAccounts_Username
	 @Supports_Status BIT,
	 @Supports_Type VARCHAR (1000),
	 @Accounts_Username VARCHAR (1000),
	 @Products_Name VARCHAR (1000),
	 @Answers_DateTimeA1 DATETIME,
	 @Answers_DateTimeA2 DATETIME
AS
BEGIN
SELECT a.Supports_ID, a.Supports_Type, b.Products_Name ,c.Accounts_Username ,a.Supports_Status,(select top 1 CONVERT(VARCHAR(10),d.Answers_DateTimeA,103) FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) AS [Answers_DateTimeA]
	,(SELECT TOP 1 g.Accounts_Username  FROM Answers d inner join Accounts g on d.Staff_ID =g.Accounts_ID   WHERE d.Support_ID =a.Supports_ID ) AS [Staff_ID]
	 FROM Supports a inner join Products b ON a.Product_ID=b.Products_ID inner join Accounts c ON a.Customer_ID =c.Accounts_ID 
	 WHERE ((a.Supports_Status=@Supports_Status) AND (a.Supports_Type LIKE '%'+@Supports_Type+'%' OR a.Supports_Type IS NULL)
		 AND (c.Accounts_Username LIKE '%'+@Accounts_Username+'%' OR c.Accounts_Username IS NULL)
		 AND (b.Products_Name LIKE '%'+@Products_Name+'%' OR b.Products_Name IS NULL)
		 AND ((select top 1 CONVERT(VARCHAR(10),d.Answers_DateTimeA,103) FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) BETWEEN Convert(VARCHAR(10), @Answers_DateTimeA1, 103) AND Convert(VARCHAR(10), @Answers_DateTimeA2, 103))
		 )
	 ORDER BY (select top 1 d.Answers_DateTimeA FROM Answers d WHERE d.Support_ID =a.Supports_ID  ORDER BY d.Answers_DateTimeA  DESC) DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_SearchAnswersbySupports_TypeAndAccounts_Username 68,'FALSE'







----- 11. Search Table Supports
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_SearchSupports

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_SearchSupports
		@Customer_ID INT,
		@Product_ID BIGINT,
		@Supports_Type NVARCHAR(200)
	AS
	BEGIN
	SELECT a.Supports_ID, a.Customer_ID, a.Product_ID, a.Supports_Type, b.Answers_ID, b.Staff_ID, 
	b.Answers_Content, b.Answers_Question
	FROM Answers b INNER JOIN Supports a ON b.Support_ID = a.Supports_ID
	WHERE ((Customer_ID = @Customer_ID) AND (Product_ID = @Product_ID)
	AND (Supports_Type LIKE '%'+@Supports_Type+'%'))
	END

	----- Test Proc -----
	SELECT * FROM Supports
	EXEC ThangNMjsc_SearchSupports 64,84,'sd'






----- 12. Tao function de chuyen chuoi String thanh bigint
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