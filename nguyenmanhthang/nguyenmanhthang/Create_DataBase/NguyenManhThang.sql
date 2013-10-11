-- Create Database NguyenManhThang
Create Database NguyenManhThang
On( Name = NguyenManhThang,
FileName = 'D:\NguyenManhThang_Data.mdf',
Size = 10MB,
Maxsize=100MB,
FileGrowth = 10%)
Log On( Name = NguyenManhThang_Log,
FileName = 'D:\NguyenManhThang_Log.ldf',
Size = 2MB,
Maxsize=Unlimited,
FileGrowth = 10%)


-- 1.	Table Accounts
USE NguyenManhThang
CREATE TABLE Accounts
(
	Accounts_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Accounts_Username VARCHAR(50) NOT NULL UNIQUE CHECK (Accounts_Username!=''),
	Accounts_Password VARCHAR(50) NOT NULL,
	Accounts_Email VARCHAR(100) NOT NULL UNIQUE CHECK (Accounts_Email!=''),
	Accounts_Prefix INT NOT NULL DEFAULT(0),
	Accounts_Permission INT DEFAULT(0),
	Accounts_RegisterDate DATETIME DEFAULT(GETDATE()),
	Accounts_LinkAvatar NVARCHAR(200) DEFAULT('~/Images/Avatar/Default.jpg'),
	Accounts_FullName NVARCHAR(100) NOT NULL,
	Accounts_Address NVARCHAR(500) NOT NULL,
	Accounts_DateOfBirth DATETIME NOT NULL,
	Accounts_PhoneNumber VARCHAR(50),
	Accounts_Signature VARCHAR(200),
	Accounts_Like INT,
	Accounts_Notification BIT DEFAULT('FALSE'),
	Accounts_Status BIT DEFAULT('FALSE')
)

-- 2.	Topic
USE NguyenManhThang
CREATE TABLE Topic
(
	Topic_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Topic_Author INT NOT NULL
		CONSTRAINT Topic_Author FOREIGN KEY (Topic_Author)
		REFERENCES Accounts(Accounts_ID)
		ON UPDATE CASCADE,
	Topic_Title NVARCHAR(500),
	Topic_Category NVARCHAR(500),
	Topic_Tag NVARCHAR(500),
	Topic_Content NVARCHAR(4000),
	Topic_Visit INT,
	Topic_LastUpdate DATETIME DEFAULT(GETDATE())
)



-- 3.	Comment
USE NguyenManhThang
CREATE TABLE Comment
(
	Comment_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Topic_ID INT NOT NULL
		CONSTRAINT Client_ID FOREIGN KEY (Topic_ID)
		REFERENCES Topic(Topic_ID)
		ON UPDATE CASCADE,
	Comment_Name NVARCHAR(100),
	Comment_Email NVARCHAR(100),
	Comment_Website NVARCHAR(100),
	Comment_Content NVARCHAR(4000),
	Comment_LastUpdate DATETIME DEFAULT(GETDATE())
)

drop table Comment, Topic, Accounts