----- 1. Insert Table Orders
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertOrders

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertOrders
		@Client_ID INT,
		@Pay_ID INT,
		@Pay_Email VARCHAR(100),
		@Pay_FullName NVARCHAR(100),
		@Pay_Address NVARCHAR(500),
		@Pay_PhoneNumber VARCHAR(50),
		@Pay_Note NVARCHAR(200),
		@Pay_DateOfStart DATETIME,
		@Pay_DateOfFinish DATETIME
	AS
	BEGIN 
	INSERT INTO Orders(Client_ID, Pay_ID, Pay_Email, Pay_FullName, Pay_Address, Pay_PhoneNumber, Pay_Note, Pay_DateOfStart, Pay_DateOfFinish)
	VALUES			  (@Client_ID, @Pay_ID, @Pay_Email, @Pay_FullName, @Pay_Address, @Pay_PhoneNumber, @Pay_Note, @Pay_DateOfStart, @Pay_DateOfFinish)
	SET @Client_ID = SCOPE_IDENTITY()
	SELECT Orders_ID FROM Orders WHERE Orders_ID= SCOPE_IDENTITY()
	END

	----- Test Proc -----
	EXEC ThangNMjsc_InsertOrders 1,1,'nh@gmail','ThangNM','HN','018','Mua hang','10/08/2014','12/22/2014'





----- 2. Insert Table OrdersDetails
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertOrdersDetails

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertOrdersDetails
		@Orders_ID BIGINT,
		@Pro_ID BIGINT,
		@OrdersDetails_UnitPrice BIGINT,
		@OrdersDetails_Quantity INT
	AS
	BEGIN 
	INSERT INTO OrdersDetails(Orders_ID, Pro_ID, OrdersDetails_UnitPrice, OrdersDetails_Quantity)
	VALUES			  (@Orders_ID, @Pro_ID, @OrdersDetails_UnitPrice, @OrdersDetails_Quantity)
	END

	----- Test Proc -----
	EXEC ThangNMjsc_InsertOrdersDetails 1,1,1200,1





----- 3. Update Table Orders
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_UpdateOrders

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_UpdateOrders
		@Orders_ID VARCHAR(400),
		@Pay_Status BIT
	AS
	BEGIN
	UPDATE Orders
	SET
		Pay_Status=@Pay_Status
	WHERE Orders_ID IN (SELECT IntegerValue FROM IntegerCommaSplit(@Orders_ID))
	END

	----- Test Proc -----
	EXEC ThangNMjsc_UpdateOrders '1','FALSE'
	SELECT * FROM Orders



	----- 3. Delete Table Orders
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_DeleteOrders

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_DeleteOrders
		@Orders_ID VARCHAR(400)
	AS
	DELETE FROM Orders
	WHERE Orders_ID IN (SELECT IntegerValue FROM IntegerCommaSplit(@Orders_ID))

	----- Test Proc -----
	EXEC ThangNMjsc_DeleteOrders '1,3'







----- 4. ThangNMjsc_getDataSetOrders
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetOrders

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetOrders
	@Pay_Status BIT
AS
BEGIN
	 SELECT Orders.Orders_ID, Orders.Client_ID, Pay.Pay_Name, Orders.Pay_Email, Orders.Pay_FullName, Orders.Pay_Address,Accounts.Accounts_Username, Accounts.Accounts_FullName,
            Orders.Pay_PhoneNumber, Orders.Pay_Note, Orders.Pay_Status, CONVERT(VARCHAR(10),Orders.Pay_DateOfStart,103) AS [Pay_DateOfStart], CONVERT(VARCHAR(10),Orders.Pay_DateOfFinish,103) AS [Pay_DateOfFinish]
	FROM Accounts INNER JOIN Orders ON Accounts.Accounts_ID = Orders.Client_ID INNER JOIN Pay ON Orders.Pay_ID = Pay.Pay_ID
	WHERE (Orders.Pay_Status = @Pay_Status)
	ORDER BY Orders.Pay_DateOfStart DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetOrders 'false'






----- 5. ThangNMjsc_getDataSetOrdersbyClient_ID
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetOrdersbyClient_ID

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetOrdersbyClient_ID
	@Pay_Status BIT,
	@Accounts_Username VARCHAR(50)
AS
BEGIN
	 SELECT Orders.Orders_ID, Orders.Client_ID, Accounts.Accounts_Username, Pay.Pay_Name, Orders.Pay_Email, Orders.Pay_FullName, Orders.Pay_Address, dbo.Accounts.Accounts_FullName,
            Orders.Pay_PhoneNumber, Orders.Pay_Note, Orders.Pay_Status, CONVERT(VARCHAR(10),Orders.Pay_DateOfStart,103) AS [Pay_DateOfStart], CONVERT(VARCHAR(10),Orders.Pay_DateOfFinish,103) AS [Pay_DateOfFinish]
	FROM Accounts INNER JOIN Orders ON Accounts.Accounts_ID = Orders.Client_ID INNER JOIN Pay ON Orders.Pay_ID = Pay.Pay_ID
	WHERE (Orders.Pay_Status = @Pay_Status AND Accounts.Accounts_Username=@Accounts_Username)
	ORDER BY Orders.Pay_DateOfStart DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetOrdersbyClient_ID 'false','client'







----- 6. ThangNMjsc_getDataSetOrdersbyOrders_ID
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetOrdersbyOrders_ID

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetOrdersbyOrders_ID
	@Orders_ID BIGINT
AS
BEGIN
SELECT  a.Orders_ID, c.Pay_Name, a.Pay_Email, a.Pay_FullName, a.Pay_Address, a.Pay_PhoneNumber, 
        a.Pay_Note, a.Pay_Status, CONVERT(VARCHAR(10),a.Pay_DateOfStart,103) AS [Pay_DateOfStart], CONVERT(VARCHAR(10),a.Pay_DateOfFinish,103) AS [Pay_DateOfFinish],
		b.OrdersDetails_ID, b.Pro_ID, b.OrdersDetails_UnitPrice, b.OrdersDetails_Quantity, d.Products_ID, 
        d.Products_Group, d.Products_Name, d.Products_Price, d.Products_Sale, d.Products_VAT, 
        d.Products_Description, d.Products_Info, d.Products_Origin, e.Accounts_Username, e.Accounts_FullName
FROM Orders a INNER JOIN OrdersDetails b ON a.Orders_ID = b.Orders_ID INNER JOIN Pay c
	 ON a.Pay_ID = c.Pay_ID INNER JOIN Products d ON b.Pro_ID = d.Products_ID INNER JOIN
                         Accounts e ON a.Client_ID = e.Accounts_ID
WHERE (a.Orders_ID=@Orders_ID)
ORDER BY b.OrdersDetails_ID DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetOrdersbyOrders_ID 2


----- 7. ThangNMjsc_getSumQuantitybyOrders_ID
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getSumQuantitybyOrders_ID

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getSumQuantitybyOrders_ID
	@Orders_ID BIGINT
AS
BEGIN
SELECT  SUM(b.OrdersDetails_Quantity) AS [SumQuantity]
FROM Orders a INNER JOIN OrdersDetails b ON a.Orders_ID = b.Orders_ID
WHERE (a.Orders_ID=@Orders_ID)
END

----- Test	 Proc -----
EXEC ThangNMjsc_getSumQuantitybyOrders_ID 10