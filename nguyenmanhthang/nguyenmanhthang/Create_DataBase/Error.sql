----- 1. Error_Insert
----- Delete Proc -----
DROP PROCEDURE Error_Insert

----- Create Proc -----
CREATE PROCEDURE Error_Insert
	@Error_ID BIGINT,
	@Error_Link NVARCHAR(200),
	@Error_IP VARCHAR(50),
	@Error_Browser NVARCHAR(200),
	@Error_Code INT,
	@Error_Status BIT
AS
BEGIN 
	INSERT INTO Error(Error_ID, Error_Link, Error_IP, Error_Browser, Error_Code, Error_Status, Error_Time)
	VALUES			  (@Error_ID, @Error_Link, @Error_IP, @Error_Browser, @Error_Code, @Error_Status, GETDATE())
END

----- Test Proc -----
EXEC Error_Insert 1, 'Thông tin website', 'ThangNMjsc','','',getdate()


	


----- 2. Error_Update
----- Delete Proc -----
DROP PROCEDURE Error_Update

----- Create Proc -----
CREATE PROCEDURE Error_Update
	@Error_ID BIGINT,
	@Error_Link NVARCHAR(200),
	@Error_IP VARCHAR(50),
	@Error_Browser NVARCHAR(200),
	@Error_Code INT,
	@Error_Status BIT
AS
BEGIN
	UPDATE Error
	SET Error_ID = @Error_ID,
		Error_Link = @Error_Link,
		Error_IP = @Error_IP,
		Error_Browser = @Error_Browser,
		Error_Code = @Error_Code,
		Error_Status = @Error_Status,
		Error_TimeCheck = GETDATE()
	WHERE Error_ID=@Error_ID
END

----- Test Proc -----
EXEC Error_Update 2,'test','test'






----- 3. Error_Delete
----- Delete Proc -----
DROP PROCEDURE Error_Delete

----- Create Proc -----
CREATE PROCEDURE Error_Delete
	@Error_ID BIGINT
AS
BEGIN
	DELETE FROM Error
	WHERE (Error_ID=@Error_ID)
END

----- Test Proc -----
EXEC Comment_Delete 1




----- 5. Comment_SelectListbyTopic_ID
----- Delete Proc -----
DROP PROCEDURE Comment_SelectListbyTopic_ID

----- Create Proc -----
CREATE PROCEDURE Comment_SelectListbyTopic_ID
	@Topic_ID BIGINT,
	@Comment_Status BIT
AS
BEGIN
	SELECT Topic_ID, Comment_Name, Comment_Email, Comment_Website, Comment_Content, Comment_Status, CONVERT(VARCHAR(10),Comment_LastUpdate,103)  AS [Comment_LastUpdate]
	FROM Comment
	WHERE (Topic_ID=@Topic_ID AND Comment_Status=@Comment_Status)
END

----- Test	 Proc -----
EXEC Comment_SelectListbyTopic_ID 2,1