----- 1. Comment_Insert
----- Delete Proc -----
DROP PROCEDURE Comment_Insert

----- Create Proc -----
CREATE PROCEDURE Comment_Insert
	@Topic_ID BIGINT,
	@Comment_Name NVARCHAR(100),
	@Comment_Email NVARCHAR(100),
	@Comment_Website NVARCHAR(100),
	@Comment_Content NVARCHAR(4000)
AS
BEGIN 
	INSERT INTO Comment(Topic_ID, Comment_Name, Comment_Email, Comment_Website, Comment_Content, Comment_LastUpdate)
	VALUES			  (@Topic_ID, @Comment_Name, @Comment_Email, @Comment_Website, @Comment_Content, GETDATE())
END

----- Test Proc -----
EXEC Comment_Insert 1, 'Thông tin website', 'ThangNMjsc',''


	


----- 2. Comment_Update
----- Delete Proc -----
DROP PROCEDURE Comment_Update

----- Create Proc -----
CREATE PROCEDURE Comment_Update
	@Comment_ID BIGINT,
	@Topic_ID BIGINT,
	@Comment_Name NVARCHAR(100),
	@Comment_Email NVARCHAR(100),
	@Comment_Website NVARCHAR(100),
	@Comment_Content NVARCHAR(4000),
	@Comment_Status BIT,
	@Comment_LastUpdate DATETIME
AS
BEGIN
	UPDATE Comment
	SET Topic_ID = @Topic_ID,
		Comment_Name = @Comment_Name,
		Comment_Email = @Comment_Email,
		Comment_Website = @Comment_Website,
		Comment_Content = @Comment_Content,
		Comment_Status = @Comment_Status,
		Comment_LastUpdate = GETDATE()
	WHERE Comment_ID=@Comment_ID
END

----- Test Proc -----
EXEC Comment_Update 2,'test','test'






----- 3. Comment_Delete
----- Delete Proc -----
DROP PROCEDURE Comment_Delete

----- Create Proc -----
CREATE PROCEDURE Comment_Delete
	@Comment_ID BIGINT
AS
BEGIN
	DELETE FROM Comment
	WHERE (Comment_ID=@Comment_ID)
END

----- Test Proc -----
EXEC Comment_Delete 1



----- 4. Comment_Block
----- Delete Proc -----
DROP PROCEDURE Comment_Block

----- Create Proc -----
CREATE PROCEDURE Comment_Block
	@Comment_ID BIGINT,
	@Comment_Status BIT
AS
BEGIN
	UPDATE Comment
	SET Comment_Status = @Comment_Status
	WHERE Comment_ID=@Comment_ID
END

----- Test Proc -----
EXEC Comment_Block 1




----- 5. Comment_SelectListbyTopic_ID
----- Delete Proc -----
DROP PROCEDURE Comment_SelectListbyTopic_ID

----- Create Proc -----
CREATE PROCEDURE Comment_SelectListbyTopic_ID
	@Topic_ID BIGINT,
	@Comment_Status BIT
AS
BEGIN
	SELECT Comment_ID, Comment_Name, Comment_Email, Comment_Website, Comment_Content, Comment_Status, 
	CONVERT(varchar,Comment_LastUpdate,103)+ ', '+ CONVERT(varchar,Comment_LastUpdate,24)  AS [Comment_LastUpdate]
	FROM Comment
	WHERE (Topic_ID=@Topic_ID AND Comment_Status=@Comment_Status)
	ORDER BY [Comment_LastUpdate] ASC
END

----- Test	 Proc -----
EXEC Comment_SelectListbyTopic_ID 14,'false'