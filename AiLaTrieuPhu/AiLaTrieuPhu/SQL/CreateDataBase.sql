-- Create Database AiLaTrieuPhu
Create Database AiLaTrieuPhu
On( Name = AiLaTrieuPhu,
FileName = 'D:\AiLaTrieuPhu_Data.mdf',
Size = 10MB,
Maxsize=100MB,
FileGrowth = 10%)
Log On( Name = AiLaTrieuPhu_Log,
FileName = 'D:\AiLaTrieuPhu_Log.ldf',
Size = 2MB,
Maxsize=Unlimited,
FileGrowth = 10%)

-- 1.	Table taikhoan
USE AiLaTrieuPhu
CREATE TABLE Taikhoan
(
	taikhoan_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	taikhoan_tentaikhoan VARCHAR(50) NOT NULL UNIQUE CHECK (taikhoan_tentaikhoan!=''),
	taikhoan_matkhau VARCHAR(50) NOT NULL,
	taikhoan_Email VARCHAR(100) NOT NULL UNIQUE CHECK (taikhoan_Email!=''),
	taikhoan_tendaydu NVARCHAR(100) NOT NULL,
	taikhoan_diachi NVARCHAR(500) NOT NULL,
	taikhoan_ngaysinh DATETIME NOT NULL,
	taikhoan_sodienthoai VARCHAR(50),
	taikhoan_quenhan INT DEFAULT(0),
	taikhoan_anhdaidien NVARCHAR(200) DEFAULT('~/Images/Avatar/Default.jpg'),
	taikhoan_trangthai BIT DEFAULT('FALSE'),
	taikhoan_ngaydangky DATETIME DEFAULT(GETDATE())
)

-- 2.	Table Cauhoi
USE AiLaTrieuPhu
CREATE TABLE Cauhoi
(
	Cauhoi_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Cauhoi_cauhoi NVARCHAR(500) NOT NULL,
	Cauhoi_A NVARCHAR(500) NOT NULL,
	Cauhoi_B NVARCHAR(500) NOT NULL,
	Cauhoi_C NVARCHAR(500) NOT NULL,
	Cauhoi_D NVARCHAR(500) NOT NULL,
	Cauhoi_dung INT NOT NULL,
	Cauhoi_capdo INT NOT NULL
)


-- 3.	Table Diem
USE AiLaTrieuPhu
CREATE TABLE Diem
(
	Diem_ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Diem_User INT NOT NULL
		CONSTRAINT taikhoan_ID FOREIGN KEY (Diem_User)
		REFERENCES Taikhoan(taikhoan_ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	Diem_tien BIGINT,
	Diem_ngay DATETIME DEFAULT(GETDATE())
)