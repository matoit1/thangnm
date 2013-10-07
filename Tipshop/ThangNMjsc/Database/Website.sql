----- 1. Insert Table OrdersDetails
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertWebsite

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertWebsite
		@Website_Title NVARCHAR(200),
		@Website_Content NVARCHAR(4000)
	AS
	BEGIN 
	INSERT INTO Website(Website_Title, Website_Content)
	VALUES			  (@Website_Title, @Website_Content)
	END

	----- Test Proc -----
	EXEC ThangNMjsc_InsertWebsite 'Thông tin website', 'ThangNMjsc'





----- 2. Update Table Website
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_UpdateWebsite

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_UpdateWebsite
		@Website_ID INT,
		@Website_Title NVARCHAR(200),
		@Website_Content NVARCHAR(4000)
	AS
	BEGIN
	UPDATE Website
	SET
		Website_Content=@Website_Content,
		Website_Title=@Website_Title,
		Website_LastUpdate=GETDATE()
	WHERE Website_ID=@Website_ID
	END

	----- Test Proc -----
	EXEC ThangNMjsc_UpdateWebsite 2,'test','test'

	SELECT * FROM Pay






	----- 3. Delete Table Orders
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_DeleteWebsite

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_DeleteWebsite
		@Website_ID INT
	AS
	DELETE FROM Website
	WHERE (Website_ID=@Website_ID)

	----- Test Proc -----
	EXEC ThangNMjsc_DeleteWebsite 1





	----- 4. ThangNMjsc_getDataSetWebsite
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetWebsite

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetWebsite
AS
BEGIN
   SELECT Website_ID, Website_Title, Website_Content, CONVERT(VARCHAR(10),Website_LastUpdate,103)  AS [Website_LastUpdate]
  FROM Website
  ORDER BY Website_ID DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetWebsite




	----- 5. ThangNMjsc_getDataSetWebsitebyWebsite_ID
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetWebsitebyWebsite_ID

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetWebsitebyWebsite_ID
@Website_ID INT
AS
BEGIN
   SELECT Website_ID, Website_Title, Website_Content, CONVERT(VARCHAR(10),Website_LastUpdate,103)  AS [Website_LastUpdate]
  FROM Website WHERE Website_ID=@Website_ID
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetWebsitebyWebsite_ID 2