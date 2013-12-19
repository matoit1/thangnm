-- Create Database NguyenManhThang
Create Database NguyenManhThang
On( Name = NguyenManhThang,
FileName = 'D:\NguyenManhThang_Data.mdf',
Size = 5MB,
Maxsize=UNLIMITED,
FileGrowth = 10%)
Log On( Name = NguyenManhThang_Log,
FileName = 'D:\NguyenManhThang_Log.ldf',
Size = 2MB,
Maxsize=UNLIMITED,
FileGrowth = 10%)


-- 1.	Table Accounts
USE NguyenManhThang
CREATE TABLE Accounts
(
	Accounts_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Accounts_Username VARCHAR(50) NOT NULL UNIQUE CHECK (Accounts_Username!=''),
	Accounts_Password VARCHAR(50) NOT NULL,
	Accounts_Email VARCHAR(100) NOT NULL UNIQUE CHECK (Accounts_Email!=''),
	Accounts_FullName NVARCHAR(100) NOT NULL,
	Accounts_Address NVARCHAR(500) NOT NULL,
	Accounts_DateOfBirth DATETIME NOT NULL,
	Accounts_PhoneNumber VARCHAR(50),
	Accounts_Permission INT DEFAULT(0),
	Accounts_LinkAvatar NVARCHAR(200) DEFAULT('~/Images/Avatar/Default.jpg'),
	Accounts_Signature VARCHAR(200),
	Accounts_Like INT DEFAULT(0),
	Accounts_Notification BIT DEFAULT('FALSE'),
	Accounts_Status BIT DEFAULT('FALSE'),
	Accounts_RegisterDate DATETIME DEFAULT(GETDATE())
)

-- 2.	Table PermissFunction
USE NguyenManhThang
CREATE TABLE PermissFunction
(
	PermissFunction_ID VARCHAR(50) PRIMARY KEY NOT NULL,
	PermissFunction_Name NVARCHAR(200) NOT NULL,
	PermissFunction_Link VARCHAR(200) NOT NULL,
	PermissFunction_Ex1 VARCHAR(200),
	PermissFunction_Ex2 VARCHAR(200),
	PermissFunction_Ex3 VARCHAR(200)
)

-- 3.	Table AccountsPermiss
USE NguyenManhThang
CREATE TABLE AccountsPermiss
(
	AccountsPermiss_UserID INT NOT NULL
		CONSTRAINT AccountsPermiss_UserID FOREIGN KEY (AccountsPermiss_UserID)
		REFERENCES Accounts(Accounts_ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	AccountsPermiss_FunctionID VARCHAR(50) NOT NULL
		CONSTRAINT AccountsPermiss_FunctionID FOREIGN KEY (AccountsPermiss_FunctionID)
		REFERENCES PermissFunction(PermissFunction_ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	AccountsPermiss_Ex1 VARCHAR(200),
	AccountsPermiss_Ex2 VARCHAR(200),
	AccountsPermiss_Ex3 VARCHAR(200),
	PRIMARY KEY(AccountsPermiss_UserID, AccountsPermiss_FunctionID)
)


-- 2.	Topic
USE NguyenManhThang
CREATE TABLE Topic
(
	Topic_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Topic_Author INT NOT NULL
		CONSTRAINT Topic_Author FOREIGN KEY (Topic_Author)
		REFERENCES Accounts(Accounts_ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	Topic_Title NVARCHAR(500),
	Topic_LinkImage NVARCHAR(200) DEFAULT('~/Images/Topic/Default.jpg'),
	Topic_Category INT,
	Topic_Parent INT,
	Topic_Tag NVARCHAR(500),
	Topic_Content NVARCHAR(MAX),
	Topic_Description NVARCHAR(200),
	Topic_Visit INT DEFAULT(0),
	Topic_Status BIT DEFAULT('TRUE'),
	Topic_LastUpdate DATETIME DEFAULT(GETDATE())
)



-- 3.	Comment
USE NguyenManhThang
CREATE TABLE Comment
(
	Comment_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Topic_ID BIGINT NOT NULL
		CONSTRAINT Client_ID FOREIGN KEY (Topic_ID)
		REFERENCES Topic(Topic_ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	Comment_Name NVARCHAR(100),
	Comment_Email NVARCHAR(100),
	Comment_Website NVARCHAR(100),
	Comment_Content NVARCHAR(4000),
	Comment_Status BIT DEFAULT('TRUE'),
	Comment_LastUpdate DATETIME DEFAULT(GETDATE())
)


-- 4.	Error
USE NguyenManhThang
CREATE TABLE Error
(
	Error_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Error_Link NVARCHAR(200),
	Error_IP VARCHAR(50),
	Error_Browser NVARCHAR(200),
	Error_Code INT,
	Error_Status BIT DEFAULT('TRUE'),
	Error_Time DATETIME DEFAULT(GETDATE()),
	Error_TimeCheck DATETIME
)

drop table Comment, Topic, Accounts, Error




ALTER TABLE table_name
ADD column_name datatype



ALTER TABLE table_name
DROP COLUMN column_name


--SQL Server / MS Access:
ALTER TABLE table_name
ALTER COLUMN column_name datatype

--My SQL / Oracle:
ALTER TABLE table_name
MODIFY COLUMN column_name datatype