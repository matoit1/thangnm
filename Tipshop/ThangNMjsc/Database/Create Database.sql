-- Create Database Tipshop
Create Database Tipshop
On( Name = Tipshop,
FileName = 'D:\Tipshop_Data.mdf',
Size = 10MB,
Maxsize=100MB,
FileGrowth = 10%)
Log On( Name = Tipshop_Log,
FileName = 'D:\Tipshop_Log.ldf',
Size = 2MB,
Maxsize=Unlimited,
FileGrowth = 10%)


-- 1.	Table Accounts
USE Tipshop
CREATE TABLE Accounts
(
	Accounts_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Accounts_Username VARCHAR(50) NOT NULL UNIQUE CHECK (Accounts_Username!=''),
	Accounts_Password VARCHAR(50) NOT NULL,
	Accounts_Email VARCHAR(100) NOT NULL UNIQUE CHECK (Accounts_Email!=''),
	Accounts_Permission INT DEFAULT(0),
	Accounts_RegisterDate DATETIME DEFAULT(GETDATE()),
	Accounts_LinkAvatar NVARCHAR(200) DEFAULT('~/Images/Avatar/Default.jpg'),
	Accounts_FullName NVARCHAR(100) NOT NULL,
	Accounts_Address NVARCHAR(500) NOT NULL,
	Accounts_DateOfBirth DATETIME NOT NULL,
	Accounts_PhoneNumber VARCHAR(50),
	Accounts_Status BIT DEFAULT('FALSE')
)


-- 2.	Table Products
USE Tipshop
CREATE TABLE  Products
(
	Products_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Products_Group BIGINT DEFAULT(0) NOT NULL,
	Products_Parent BIGINT,
	Products_Name NVARCHAR(500) NOT NULL,
	Products_Price BIGINT,
	Products_Sale BIGINT,
	Products_VAT BIT DEFAULT('FALSE'),
	Products_Description NVARCHAR(2000),
	Products_Info NVARCHAR(2000),
	Products_Origin NVARCHAR(500),
	Products_Image1 NVARCHAR(200) DEFAULT('~/Images/Products/Default.jpg'),
	Products_Image2 NVARCHAR(200),
	Products_Image3 NVARCHAR(200),
	Products_Video NVARCHAR(200),
	Products_LastUpdate DATETIME DEFAULT(GETDATE()),
	Products_Visible BIT DEFAULT('TRUE')
)


-- 3.	Table Pay
USE Tipshop
CREATE TABLE  Pay
(
	Pay_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Pay_Name NVARCHAR(500) NOT NULL,
	Pay_Visible BIT
)



-- 4.	Table Orders
USE Tipshop
CREATE TABLE Orders
(
	Orders_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Client_ID INT NOT NULL
		CONSTRAINT Client_ID FOREIGN KEY (Client_ID)
		REFERENCES Accounts(Accounts_ID)
		ON UPDATE CASCADE,
	Pay_ID INT NOT NULL
		CONSTRAINT Pay_ID FOREIGN KEY (Pay_ID)
		REFERENCES Pay(Pay_ID)
		ON UPDATE CASCADE,
	Pay_Email VARCHAR(100) NOT NULL,
	Pay_FullName NVARCHAR(100) NOT NULL,
	Pay_Address NVARCHAR(500) NOT NULL,
	Pay_PhoneNumber VARCHAR(50) NOT NULL,
	Pay_Note NVARCHAR(200) NOT NULL,
	Pay_Status BIT DEFAULT('FALSE'),
	Pay_DateOfStart DATETIME DEFAULT(GETDATE()),
	Pay_DateOfFinish DATETIME
)



-- 5.	Table OrdersDetails
USE Tipshop
CREATE TABLE OrdersDetails
(
	OrdersDetails_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Orders_ID BIGINT NOT NULL
		CONSTRAINT Orders_ID FOREIGN KEY (Orders_ID)
		REFERENCES Orders(Orders_ID)
		ON DELETE CASCADE 
		ON UPDATE CASCADE,
	Pro_ID BIGINT NOT NULL
		CONSTRAINT Pro_ID FOREIGN KEY (Pro_ID)
		REFERENCES Products(Products_ID)
		ON UPDATE CASCADE,
	OrdersDetails_UnitPrice BIGINT NOT NULL,
	OrdersDetails_Quantity INT NOT NULL
)


-- 6.	Table Supports
USE Tipshop
CREATE TABLE Supports
(
	Supports_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Customer_ID INT NOT NULL
		CONSTRAINT Customer_ID FOREIGN KEY (Customer_ID)
		REFERENCES Accounts(Accounts_ID)
		ON DELETE CASCADE 
		ON UPDATE CASCADE,
	Product_ID BIGINT NOT NULL
		CONSTRAINT Product_ID FOREIGN KEY (Product_ID)
		REFERENCES Products(Products_ID)
		ON UPDATE CASCADE,
	Supports_Type NVARCHAR(200) NOT NULL,
	Supports_Status BIT DEFAULT('FALSE')
)

-- 7.	Table Answers
USE Tipshop
CREATE TABLE Answers
(
	Answers_ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Support_ID BIGINT NOT NULL
		CONSTRAINT Support_ID FOREIGN KEY (Support_ID)
		REFERENCES Supports(Supports_ID)
		ON DELETE CASCADE 
		ON UPDATE CASCADE,
	Staff_ID INT
		CONSTRAINT Staff_ID FOREIGN KEY (Staff_ID)
		REFERENCES Accounts(Accounts_ID),
	Answers_Content NVARCHAR(2000),
	Answers_Question NVARCHAR(2000),
	Answers_DateTimeA DATETIME DEFAULT(GETDATE()),
	Answers_DateTimeB DATETIME
)


-- 8.	Table Website
USE Tipshop
CREATE TABLE Website
(
	Website_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Website_Title NVARCHAR(200),
	Website_Content NVARCHAR(4000),
	Website_LastUpdate DATETIME DEFAULT(GETDATE())
)