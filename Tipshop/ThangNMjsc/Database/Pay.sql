----- 1. Insert Table Pay
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_InsertPay

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_InsertPay
		@Pay_Name NVARCHAR(500),
		@Pay_Visible BIT
	AS
	BEGIN
	INSERT INTO Pay(Pay_Name, Pay_Visible)
	VALUES (@Pay_Name, @Pay_Visible)
	END

		----- Test Proc -----
	EXEC ThangNMjsc_InsertPay 'Ngan luong','TRUE'
	SELECT * FROM Orders





----- 2. Update Table Pay
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_UpdatePay

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_UpdatePay
		@Pay_ID INT,
		@Pay_Name NVARCHAR(500),
		@Pay_Visible BIT
	AS
	BEGIN
	UPDATE Pay
	SET
		Pay_Name=@Pay_Name,
		Pay_Visible=@Pay_Visible
	WHERE Pay_ID=@Pay_ID
	END

	----- Test Proc -----
	EXEC ThangNMjsc_UpdatePay '1',N'Ngân lượng','TRUE'

	SELECT * FROM Pay






----- 3. Delete Table Pay
	----- Delete Proc -----
	DROP PROCEDURE ThangNMjsc_DeletePay

	----- Create Proc -----
	CREATE PROCEDURE ThangNMjsc_DeletePay
		@Pay_ID VARCHAR(400)
	AS
	DELETE FROM Pay
	WHERE Pay_ID IN (SELECT IntegerValue FROM IntegerCommaSplit(@Pay_ID))

	----- Test Proc -----
	EXEC ThangNMjsc_DeletePay '1,3'






----- 4. ThangNMjsc_getDataSetPaybyPay_Visible
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetPaybyPay_Visible

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetPaybyPay_Visible @Pay_Visible BIT
AS
BEGIN
   SELECT *
  FROM Pay WHERE Pay_Visible=@Pay_Visible
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetPaybyPay_Visible 1







----- 5. ThangNMjsc_getDataSetPaybyPay_Name
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetPaybyPay_ID

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetPaybyPay_ID @Pay_ID INT
AS
BEGIN
   SELECT *
  FROM Pay WHERE Pay_ID=@Pay_ID
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetPaybyPay_ID 1






----- 6. ThangNMjsc_getDataSetPay
	----- Delete Proc -----
DROP PROCEDURE ThangNMjsc_getDataSetPay

	----- Create Proc -----
CREATE PROCEDURE ThangNMjsc_getDataSetPay
AS
BEGIN
   SELECT *
   FROM Pay
   ORDER BY Pay_Visible DESC
END

----- Test	 Proc -----
EXEC ThangNMjsc_getDataSetPay