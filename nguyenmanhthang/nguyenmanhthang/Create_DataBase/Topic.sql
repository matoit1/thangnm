----- 1. Topic_Insert
----- Delete Proc -----
DROP PROCEDURE Topic_Insert

----- Create Proc -----
CREATE PROCEDURE Topic_Insert
	@Topic_Author INT,
	@Topic_Title NVARCHAR(500),
	@Topic_LinkImage NVARCHAR(200),
	@Topic_Category INT,
	@Topic_Parent INT,
	@Topic_Tag NVARCHAR(500),
	@Topic_Content NVARCHAR(MAX),
	@Topic_Description NVARCHAR(200),
	@Topic_Visit INT,
	@Topic_Status BIT
AS
BEGIN 
	INSERT INTO Topic(Topic_Author, Topic_Title, Topic_LinkImage, Topic_Category, Topic_Parent, Topic_Tag, Topic_Content, Topic_Description, Topic_Visit, Topic_Status)
	VALUES			  (@Topic_Author,@Topic_Title, @Topic_LinkImage, @Topic_Category, @Topic_Parent, @Topic_Tag, @Topic_Content, @Topic_Description, @Topic_Visit, @Topic_Status)
END

----- Test Proc -----
EXEC Topic_Insert 2,'Thông tin website', 'ThangNMjsc','','',0,1,getdate()





----- 2. Topic_Update
----- Delete Proc -----
DROP PROCEDURE Topic_Update

----- Create Proc -----
CREATE PROCEDURE Topic_Update
	@Topic_ID BIGINT,
	@Topic_Author INT,
	@Topic_Title NVARCHAR(500),
	@Topic_LinkImage NVARCHAR(200),
	@Topic_Category INT,
	@Topic_Parent INT,
	@Topic_Tag NVARCHAR(500),
	@Topic_Content NVARCHAR(MAX),
	@Topic_Description NVARCHAR(200),
	@Topic_Visit INT,
	@Topic_Status BIT
AS
BEGIN
	UPDATE Topic
	SET Topic_Author = @Topic_Author,
		Topic_Title = @Topic_Title,
		Topic_LinkImage = @Topic_LinkImage,
		Topic_Category = @Topic_Category,
		Topic_Parent = @Topic_Parent,
		Topic_Tag = @Topic_Tag,
		Topic_Content = @Topic_Content,
		Topic_Description = @Topic_Description,
		Topic_Visit = @Topic_Visit,
		Topic_Status = @Topic_Status,
		Topic_LastUpdate=GETDATE()
	WHERE Topic_ID=@Topic_ID
END

----- Test Proc -----
EXEC Topic_Update 1,3,'Test Update', '',1,1,'ThangNM', 'ND','ND', 1,'true'






----- 3. Topic_Delete
----- Delete Proc -----
DROP PROCEDURE Topic_Delete

----- Create Proc -----
CREATE PROCEDURE Topic_Delete
	@Topic_ID BIGINT
AS
BEGIN
	DELETE FROM Topic
	WHERE (Topic_ID=@Topic_ID)
END

----- Test Proc -----
EXEC Topic_Delete 1


----- 4. Topic_DeleteList
----- Delete Proc -----
DROP PROCEDURE Topic_DeleteList

----- Create Proc -----
CREATE PROCEDURE Topic_DeleteList
	@ListTopic_ID VARCHAR(200)
AS
BEGIN
	DELETE FROM Topic
	WHERE Topic_ID IN (SELECT StringValue FROM StringCommaSplit(@ListTopic_ID))
END

----- Test Proc -----
EXEC Topic_DeleteList 1


----- 5. Topic_Block
----- Delete Proc -----
DROP PROCEDURE Topic_Block

----- Create Proc -----
CREATE PROCEDURE Topic_Block
	@Topic_ID BIGINT,
	@Topic_Status BIT
AS
BEGIN
	UPDATE Topic
	SET Topic_Status = @Topic_Status
	WHERE Topic_ID=@Topic_ID
END

----- Test Proc -----
EXEC Topic_Block 1




----- 6. Topic_SelectListbyTopic_Status
----- Delete Proc -----
DROP PROCEDURE Topic_SelectListbyTopic_Status

----- Create Proc -----
CREATE PROCEDURE Topic_SelectListbyTopic_Status
	@Topic_Status BIT
AS
BEGIN
	SELECT Topic_ID, Topic_Author, Topic_Title, Topic_LinkImage, Topic_Category, Topic_Parent, Topic_Tag, Topic_Content, Topic_Description,Topic_Visit, Topic_Status, CONVERT(VARCHAR(10),Topic_LastUpdate,103)  AS [Topic_LastUpdate]
	FROM Topic
	WHERE	Topic_Status = @Topic_Status
			AND Topic_Category <> 0
	ORDER BY Topic_ID DESC
END

----- Test	 Proc -----
EXEC Topic_SelectListbyTopic_Status 'true'




----- 7. Topic_getTopicbyTopic_ID
----- Delete Proc -----
DROP PROCEDURE Topic_getTopicbyTopic_ID

----- Create Proc -----
CREATE PROCEDURE Topic_getTopicbyTopic_ID
	@Topic_ID BIGINT
AS
BEGIN
	SELECT Topic_ID, Topic_Author, Topic_Title, Topic_LinkImage, Topic_Category, Topic_Parent, Topic_Tag, Topic_Content, Topic_Description, Topic_Visit, Topic_Status, 
		CONVERT(varchar,Topic_LastUpdate,103)+ ', '+ CONVERT(varchar,Topic_LastUpdate,24)  AS [Topic_LastUpdate],
		b.Accounts_Like, b.Accounts_LinkAvatar, b.Accounts_Username, b.Accounts_Signature, b.Accounts_Permission,
		b.Accounts_FullName,CONVERT(VARCHAR, b.Accounts_RegisterDate,103) AS [Accounts_RegisterDate],
		(SELECT COUNT(dbo.Topic.Topic_ID) FROM Topic INNER JOIN Accounts b ON Topic.Topic_Author = b.Accounts_ID) AS [CountTopic]
	FROM Topic INNER JOIN Accounts b ON Topic.Topic_Author = b.Accounts_ID
	WHERE Topic_ID=@Topic_ID
END

----- Test	 Proc -----
EXEC Topic_getTopicbyTopic_ID 21




----- 8. Topic_SelectListToShow
----- Delete Proc -----
DROP PROCEDURE Topic_SelectListToShow

----- Create Proc -----
CREATE PROCEDURE Topic_SelectListToShow
	@Topic_Status BIT,
	@Quantity INT
AS
BEGIN
	SELECT TOP (@Quantity) Topic_ID, Accounts.Accounts_Username, Topic_Title, Topic_LinkImage, Topic_Category, Topic_Parent, Topic_Tag, Topic_Description, Topic_Visit, Topic_Status,
			CONVERT(varchar,Topic_LastUpdate,103)+ ', '+ CONVERT(varchar,Topic_LastUpdate,24)  AS [Topic_LastUpdate]
	FROM Topic INNER JOIN Accounts ON Accounts.Accounts_ID = Topic.Topic_Author
	WHERE Topic_Status=@Topic_Status AND Topic_Category<>0
	ORDER BY [Topic_LastUpdate] DESC
END

----- Test	 Proc -----
EXEC Topic_SelectListToShow 'true', 100



----- 9. Topic_ASC_Visit
----- Delete Proc -----
DROP PROCEDURE Topic_ASC_Visit

----- Create Proc -----
CREATE PROCEDURE Topic_ASC_Visit
	@Topic_ID BIGINT
AS
BEGIN
	DECLARE @Topic_Visit INT
	SET @Topic_Visit =(SELECT Topic_Visit FROM Topic WHERE Topic_ID=@Topic_ID)
	UPDATE Topic
	SET Topic_Visit = @Topic_Visit+1
	WHERE Topic_ID=@Topic_ID
END

----- Test	 Proc -----
EXEC Topic_ASC_Visit 22



----- 6. Topic_SelectListbyTopic_Category
----- Delete Proc -----
DROP PROCEDURE Topic_SelectListbyTopic_Category

----- Create Proc -----
CREATE PROCEDURE Topic_SelectListbyTopic_Category
	@Quantity INT,
	@Topic_Category INT
AS
BEGIN
	SELECT TOP (@Quantity) Topic_ID, Topic_Author, Topic_Title, Topic_LinkImage, Topic_Category, Topic_Parent, Topic_Tag, Topic_Content, Topic_Description,Topic_Visit, Topic_Status, CONVERT(VARCHAR(10),Topic_LastUpdate,103)  AS [Topic_LastUpdate]
	FROM Topic
	WHERE (Topic_Category=@Topic_Category) AND (Topic_Status='TRUE')
	ORDER BY Topic_ID DESC
END

----- Test	 Proc -----
EXEC Topic_SelectListbyTopic_Category 100,0



----- 10. Topic_SelectListbyTopic_Tag
----- Delete Proc -----
DROP PROCEDURE Topic_SelectListbyTopic_Tag

----- Create Proc -----
CREATE PROCEDURE Topic_SelectListbyTopic_Tag
	@Topic_Tag NVARCHAR(500)
AS
BEGIN
	SELECT Topic_ID, Topic_Author, Topic_Title, Topic_LinkImage, Topic_Category, Topic_Parent, Topic_Tag, Topic_Content, Topic_Description,Topic_Visit, Topic_Status, CONVERT(VARCHAR(10),Topic_LastUpdate,103)  AS [Topic_LastUpdate]
	FROM Topic
	WHERE Topic_Status='true' AND Topic_Category <> 0 AND (Topic_Tag LIKE '%' + @Topic_Tag + '%')
	ORDER BY Topic_ID DESC
END

----- Test	 Proc -----
EXEC Topic_SelectListbyTopic_Tag 'ThangNM'