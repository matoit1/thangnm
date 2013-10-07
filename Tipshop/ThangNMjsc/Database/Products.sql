----- 1. Insert Table Group Products -----
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertGroupProducts

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertGroupProducts
		@Products_Parent BIGINT,
		@Products_Name NVARCHAR(500),
		@Products_Description NVARCHAR(2000)
	AS
	BEGIN
	INSERT INTO Products(Products_Parent, Products_Name, Products_Description)
	VALUES (@Products_Parent, @Products_Name, @Products_Description)
	END

	----- Test Proc -----
	Exec ThangNMjsc_InsertGroupProducts 0,'h','4'
	SELECT * FROM Products







----- 2. Insert Table Products -----
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertProducts

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertProducts
		@Products_Group BIGINT,
		@Products_Name NVARCHAR(500),
		@Products_Price FLOAT,
		@Products_Sale FLOAT, 
		@Products_VAT BIT,
		@Products_Description NVARCHAR(2000),
		@Products_Info NVARCHAR(2000),
		@Products_Origin NVARCHAR(500),
		@Products_Image1 VARCHAR(200),
		@Products_Image2 VARCHAR(200),
		@Products_Image3 VARCHAR(200),
		@Products_Video VARCHAR(200)
	AS
	BEGIN
	INSERT INTO Products(Products_Group,Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video)
	VALUES (@Products_Group,@Products_Name, @Products_Price, @Products_Sale, @Products_VAT, @Products_Description,@Products_Info,
			@Products_Origin, @Products_Image1, @Products_Image2, @Products_Image3, @Products_Video)
	END

	----- Test Proc -----
	EXEC ThangNMjsc_InsertProducts 11,'e',null,null,'TRUE','','',''

	SELECT * FROM Products






----- 3. Update Table Group Product -----
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_UpdateGroupProducts

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_UpdateGroupProducts
		@Products_ID BIGINT,
		@Products_Parent BIGINT,
		@Products_Name NVARCHAR(500),
		@Products_Description NVARCHAR(2000),
		@Products_Visible BIT
	AS
	BEGIN
	UPDATE Products
	SET
		Products_Parent=@Products_Parent,
		Products_Name=@Products_Name,
		Products_Description=@Products_Description,
		Products_LastUpdate=GETDATE(),
		Products_Visible=@Products_Visible
	WHERE Products_ID=@Products_ID
	END

	----- Test Proc -----
	SELECT * FROM Products






----- 4. Update Table Product -----
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_UpdateProducts

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_UpdateProducts
		@Products_ID BIGINT,
		@Products_Group BIGINT,
		@Products_Name NVARCHAR(500),
		@Products_Price FLOAT,
		@Products_Sale FLOAT, 
		@Products_VAT BIT,
		@Products_Description NVARCHAR(2000),
		@Products_Info NVARCHAR(2000),
		@Products_Origin NVARCHAR(500),
		@Products_Image1 VARCHAR(200),
		@Products_Image2 VARCHAR(200),
		@Products_Image3 VARCHAR(200),
		@Products_Video VARCHAR(200),
		@Products_Visible BIT
	AS
	BEGIN
	UPDATE Products
	SET
		Products_Group=@Products_Group,
		Products_Name=@Products_Name,
		Products_Price=@Products_Price,
		Products_Sale=@Products_Sale,
		Products_VAT=@Products_VAT,
		Products_Description=@Products_Description,
		Products_Info=@Products_Info,
		Products_Origin=@Products_Origin,
		Products_Image1=@Products_Image1,
		Products_Image2=@Products_Image2,
		Products_Image3=@Products_Image3,
		Products_Video=@Products_Video,
		Products_LastUpdate=GETDATE(),
		Products_Visible=@Products_Visible
	WHERE Products_ID=@Products_ID
	END

	----- Test Proc -----
	SELECT * FROM Products






----- 5. Delete Table Products by Products_ID
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_DeleteProductsbyProducts_ID

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_DeleteProductsbyProducts_ID
		@Products_ID VARCHAR(400)
	AS
	DELETE FROM Products
	WHERE Products_ID IN (SELECT IntegerValue FROM IntegerCommaSplit(@Products_ID))

	----- Test Proc -----
	EXEC ThangNMjsc_DeleteProductsbyProducts_ID '34,36'



----- 6. getGroupProducts
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetGroupProducts

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetGroupProducts @Products_Group BIGINT
AS
BEGIN
   SELECT Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
  FROM Products WHERE Products_Group=@Products_Group
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetGroupProducts 0





----- 7. getProducts_Parent
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getGroupProducts_Parent

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getGroupProducts_Parent @Products_Group BIGINT
AS
BEGIN
   SELECT Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
  FROM Products WHERE (Products_Group=@Products_Group AND (Products_Parent IS NULL OR Products_Parent = 0) AND Products_Visible=1)
END

----- Test	 Proc -----
EXEC ThangNMjsc_getGroupProducts_Parent 0






----- 8. ThangNMjsc_getGroupProducts_Childrent
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getGroupProducts_Childrent

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getGroupProducts_Childrent @Products_Parent BIGINT
AS
BEGIN
   SELECT Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
  FROM Products WHERE Products_Parent=@Products_Parent
END

----- Test	 Proc -----
EXEC ThangNMjsc_getGroupProducts_Childrent 5







----- 9. getProducts
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetProducts

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetProducts @Products_Group BIGINT
AS
BEGIN
   SELECT Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
  FROM Products WHERE Products_Group<>@Products_Group
  ORDER BY Products_Group DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetProducts 0








----- 10. ThangNMjsc_getDataSetProductsbyProducts_ID
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetProductsbyProducts_ID

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetProductsbyProducts_ID @Products_ID BIGINT
AS
BEGIN
SELECT Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
		Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
FROM Products WHERE Products_ID=@Products_ID
END

	----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetProductsbyProducts_ID '1'







----- 11. Search Table Products
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_SearchProductsbyName

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_SearchProductsbyName
		@Products_Name NVARCHAR(500),
		@Products_Description NVARCHAR(2000),
		@Products_Info NVARCHAR(2000),
		@Products_Origin NVARCHAR(500)
	AS
	BEGIN
	SELECT Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
	FROM Products
	WHERE ((Products_Name LIKE '%' +@Products_Name +'%' OR Products_Name IS NULL) AND Products_Group<>0
		AND (Products_Description LIKE '%' +@Products_Description +'%' OR Products_Description IS NULL)
		AND (Products_Info LIKE '%' +@Products_Info +'%' OR Products_Info IS NULL)
		AND (Products_Origin LIKE '%' +@Products_Origin +'%' OR Products_Origin IS NULL)
	)
	ORDER BY Products_Group ASC
	END

	----- Test Proc -----
	EXEC ThangNMjsc_SearchProductsbyName '3g',,'','',''

	SELECT * FROM Products






----- 12. getProductbyProducts_GroupTop
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getProductbyProducts_GroupTop

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getProductbyProducts_GroupTop
@Products_Group BIGINT,
@Top INT
AS
BEGIN
   SELECT TOP (@Top) Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
  FROM Products WHERE (Products_Group=@Products_Group AND Products_Visible=1 )
  ORDER BY [Products_LastUpdate] DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getProductbyProducts_GroupTop 9,3





----- 13. getNewProductTop
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getNewProductTop

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getNewProductTop
@Top INT
AS
BEGIN
   SELECT TOP (@Top) Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
  FROM Products WHERE (Products_Group<>0 AND Products_Visible='TRUE' )
  ORDER BY Products_LastUpdate DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getNewProductTop 3


----- 14. getGroupProductsShow
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetGroupProductsShow

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetGroupProductsShow @Products_Group BIGINT
AS
BEGIN
   SELECT Products_ID, Products_Group, Products_Parent, Products_Name, Products_Price, Products_Sale, Products_VAT, Products_Description,Products_Info,
						Products_Origin, Products_Image1, Products_Image2, Products_Image3, Products_Video, CONVERT(VARCHAR(10),Products_LastUpdate,103)  AS [Products_LastUpdate], Products_Visible
  FROM Products WHERE (Products_Group=@Products_Group AND Products_Visible=1)
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetGroupProductsShow 0