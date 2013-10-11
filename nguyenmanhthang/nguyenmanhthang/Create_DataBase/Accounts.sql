
----- 7. Login Table Accounts
	----- Delete Proc ----- 
DROP PROCEDURE Accounts_Login

	----- Create Proc -----
CREATE PROCEDURE Accounts_Login
@Accounts_Username VARCHAR(50), @Accounts_Password VARCHAR(50)
AS
BEGIN
   SELECT *
  FROM Accounts WHERE (Accounts_Username LIKE @Accounts_Username) AND (Accounts_Password LIKE @Accounts_Password) AND (Accounts_Permission IN (1,2)) AND (Accounts_Status='TRUE')
END

----- Test	 Proc -----
EXEC Accounts_Login 'admin', '40bd001563085fc35165329ea1ff5c5ecbdbbeef'