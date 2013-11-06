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

-- 1.	Table Accounts
USE AiLaTrieuPhu
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
	Accounts_Status BIT DEFAULT('FALSE'),
	Accounts_RegisterDate DATETIME DEFAULT(GETDATE())
)

-- 2.	Table Question
USE AiLaTrieuPhu
CREATE TABLE Question
(
	Question_ID INT PRIMARY KEY NOT NULL,
	Question_Ask VARCHAR(500) NOT NULL,
	Question_A NVARCHAR(500) NOT NULL,
	Question_B NVARCHAR(500) NOT NULL,
	Question_C NVARCHAR(500) NOT NULL,
	Question_D NVARCHAR(500) NOT NULL,
	Question_True INT NOT NULL,
	Question_Level INT NOT NULL
)


-- 3.	Table Ranking
USE AiLaTrieuPhu
CREATE TABLE  Ranking
(
	Ranking_ID INT PRIMARY KEY NOT NULL,
	Ranking_User INT NOT NULL
		CONSTRAINT Accounts_ID FOREIGN KEY (Accounts_ID)
		REFERENCES Accounts(Accounts_ID)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	Ranking_Money BIGINT
)


-- 3.	Table MuonTra
USE AiLaTrieuPhu
CREATE TABLE  MuonTra
(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NgayMuon DateTime DEFAULT(GETDATE()),
	NgayTra DateTime,
	MaDC VARCHAR(10) NOT NULL
		CONSTRAINT MaDC FOREIGN KEY (MaDC)
		REFERENCES DungCu(MaDC)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	TenGVMuon NVARCHAR(100) NOT NULL,
	GhiChu NVARCHAR(100)
)



----- Nhập dữ liệu ---------
-- 1.	Table LoaiDungCu
USE N17_QLDungcuHoctap
INSERT INTO LoaiDungCu(MaLoaiDC, TenLoaiDC) 
	VALUES	('TinHoc',N'Thiết bị giảng dậy Môn Tin Học'),
			('DiaLy',N'Thiết bị giảng dậy Môn Địa Lý'),
			('VatLy',N'Thiết bị giảng dậy Môn Vật Lý'),
			('HoaHoc',N'Thiết bị giảng dậy Môn Hóa Học'),
			('SinhHoc',N'Thiết bị giảng dậy Môn Sinh Học'),
			('TheDuc',N'Thiết bị giảng dậy Môn Thể Dục'),
			('Khac',N'Các loại khác')


-- 2.	Table DungCu
INSERT INTO DungCu(MaDC, TenDC, MaLoaiDC, Soluong, Mota, GhiChu)
	VALUES	('TH001',N'Máy chiếu ','TinHoc',2,N'Infocus In112, Độ phân giải: SVGA (800x 600), Bóng đèn 180W',N''),
			('TH002',N'Bút Laze','TinHoc',2,N'Bút LASER LOGITECH',N'con trỏ laser màu đỏ'),
			('TH003',N'Loa, Micro','TinHoc',1,N'Hãng sản xuất :V-PLUS, Công suất ra : 10 max , DC 9V input',N'Pin đầy có thể sử dụng liên tục 4 -5 h'),
			('TH004',N'Switch D-Link','TinHoc',1,N'Switch D-Link 24 port - 10/100/1000Mbps - TCP/IP',N''),
			('TH005',N'Dây mạng','TinHoc',12,N'Cable mạng Cat 5 Loại Chất Lượng L1 (Chạy >150m) 04 Sợi Đồng 04 Sợi Kron',N''),

			('DL001',N'Quả địa cầu','DiaLy',1,N'Kích thước bán kính 30cm',N''),
			('DL002',N'Bản đồ Thế giới','DiaLy',1,N'Bản đồ thế giới mặt phẳng 1m x 0.6m',N''),
			('DL003',N'Bản đồ Việt Nam','DiaLy',1,N'Bản đồ địa hình Việt Nam',N''),
			('DL004',N'Mô hình dải Ngân hà','DiaLy',1,N'8 hành tinh bay xung quanh mặt trời',N''),
			('DL005',N'Bảng tính giờ quốc tế GMT','DiaLy',1,N'Bản đồ chia theo múi giờ GMT của 1 số quốc gia trên TG',N''),

			('VL001',N'Mô hình Bảng điện xoay chiều','VatLy',1,N'1 bóng đèn, 1 ổ cắm, 1 công tắc, 2 cầu chì, 1 phích cắm',N'Đơn vị tính: chiếc'),
			('VL002',N'Gương cầu lồi','VatLy',1,N'gương cầu lồi F=2',N'Đơn vị tính: chiếc'),
			('VL003',N'Bút thử điện','VatLy',1,N'Bút thử điện',N'Đơn vị tính: chiếc'),
			('VL004',N'Máy phát tần','VatLy',1,N'Máy phát tần số Max 100MHz',N'Đơn vị tính: chiếc'),
			('VL005',N'Đồng hồ đo Vôn kế, Ampe Kế','VatLy',1,N'Đồng hồ đo Vôn kế Max 500V, Ampe Kế 20A',N'Đơn vị tính: chiếc'),

			('HH001',N'Ống nghiệm','HoaHoc',9,N'Ống nghiệm thủy tinh',N'Đơn vị tính: chiếc'),
			('HH002',N'Axit H2SO4','HoaHoc',1,N'Axit H2SO4 nồng độ 80%',N'Đơn vị tính: lọ'),
			('HH003',N'Axit HCl','HoaHoc',1,N'Axit HCl Nồng độ 20%',N'Đơn vị tính: lọ'),
			('HH004',N'Bazơ NaOH','HoaHoc',1,N'Bazơ NaOH',N'Đơn vị tính: lọ'),
			('HH005',N'Muối NaCl','HoaHoc',2,N'Muối NaCl dạng tinh thể',N'đơn vị tính: lọ'),
			('HH006',N'Kim loại Zn','HoaHoc',1,N'Kim loại Zn nguyên chất',N'Đơn vị tính: gam'),
			('HH007',N'Kim loại Cu','HoaHoc',1,N'Kim loại Cu nguyên chất',N'Đơn vị tính: gam'),

			('SH001',N'Nhiệt kế','SinhHoc',2,N'Nhiệt kế đo nhiệt độ cơ thể người',N'Đơn vị tính: chiếc'),
			('SH002',N'Máy đo huyết áp','SinhHoc',2,N'Máy đo huyết áp',N'Đơn vị tính: chiếc'),
			('SH003',N'Mô hình cấu tạo châu chấu','SinhHoc',1,N'Mô hình cấu tạo châu chấu',N'Đơn vị tính: bộ'),
			('SH004',N'Mô hình tổng hợp ARN','SinhHoc',1,N'Mô hình tổng hợp ARN ở người',N'Đơn vị tính: bộ'),
			('SH005',N'Kính hiển vi','SinhHoc',5,N'Kính hiển vi F=1',N'Đơn vị tính: chiếc'),

			('TD001',N'Đồng hồ bấm giây','TheDuc',3,N'',N'Đơn vị tính: chiếc'),
			('TD002',N'Găng tay đấu võ','TheDuc',2,N'',N'Đơn vị tính: đôi'),
			('TD003',N'Đệm nhảy cao','TheDuc',1,N'',N'Đơn vị tính: chiếc'),
			('TD004',N'Còi','TheDuc',1,N'',N'Đơn vị tính: chiếc'),
			('TD005',N'Bàn đạp chạy ngắn','TheDuc',2,N'',N'Đơn vị tính: bộ')


-- 3.	Table MuonTra
INSERT INTO MuonTra(NgayMuon, NgayTra, MaDC, TenGVMuon, GhiChu) 
	VALUES	(CONVERT(DATETIME,'05/01/2013',103),CONVERT(DATETIME,'06/01/2013',103),'DL001',N'Lê Xuân Hòa',N''),
			(CONVERT(DATETIME,'08/03/2013',103),CONVERT(DATETIME,'08/03/2013',103),'TH003',N'Nguyễn Đức Nam',N''),
			(CONVERT(DATETIME,'05/09/2013',103),CONVERT(DATETIME,'06/09/2013',103),'HH003',N'Trần Văn Oánh',N''),
			(CONVERT(DATETIME,'12/09/2013',103),CONVERT(DATETIME,'15/09/2013',103),'HH003',N'Trần Văn Oánh',N''),
			(CONVERT(DATETIME,'22/10/2013',103),CONVERT(DATETIME,'22/10/2013',103),'VL004',N'Nguyễn Văn Đức',N''),
			(CONVERT(DATETIME,'29/10/2013',103),CONVERT(DATETIME,'01/10/2013',103),'DL003',N'Lê Xuân Hòa',N''),
			(CONVERT(DATETIME,'05/10/2013',103),CONVERT(DATETIME,'07/10/2013',103),'TH003',N'Nguyễn Xuân Quang',N''),
			(CONVERT(DATETIME,'09/10/2013',103),CONVERT(DATETIME,'11/10/2013',103),'SH004',N'Trần Thị Lý',N''),
			(CONVERT(DATETIME,'05/11/2013',103),'','HH006',N'Cao Văn Ngọc',N''),
			(CONVERT(DATETIME,'05/11/2013',103),'','TD004',N'Trần Thị Dung',N'')
			