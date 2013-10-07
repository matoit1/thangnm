-- 1.	Table Accounts
USE ThangNMjsc
INSERT INTO Accounts(Accounts_Username,Accounts_Password,Accounts_Email,Accounts_Permission,Accounts_FullName,Accounts_Address,Accounts_DateOfBirth,Accounts_PhoneNumber,Accounts_Status, Accounts_LinkAvatar) 
	VALUES('admin','40bd001563085fc35165329ea1ff5c5ecbdbbeef','thang.991992@gmail.com',2,N'Nguyễn Mạnh Thắng',N'Hà Nội','09/09/1992','01675279562','TRUE','~/Images/Avatar/admin.jpg')
INSERT INTO Accounts(Accounts_Username,Accounts_Password,Accounts_Email,Accounts_Permission,Accounts_FullName,Accounts_Address,Accounts_DateOfBirth,Accounts_PhoneNumber) 
	VALUES('administrator','40bd001563085fc35165329ea1ff5c5ecbdbbeef','thang.991992@hotmail.com',1,N'ThangNM',N'Ha noi','08/13/1992','01258460005')
INSERT INTO Accounts(Accounts_Username,Accounts_Password,Accounts_Email,Accounts_Permission,Accounts_FullName,Accounts_Address,Accounts_DateOfBirth,Accounts_PhoneNumber) 
	VALUES('hacker','40bd001563085fc35165329ea1ff5c5ecbdbbeef','diendancntt.forumit@gmail.com',1,N'Anonymous',N'Facebook','09/09/1992','01663796917')

INSERT INTO Accounts(Accounts_Username,Accounts_Password,Accounts_Email,Accounts_FullName,Accounts_Address,Accounts_DateOfBirth,Accounts_PhoneNumber) 
	VALUES('client','40bd001563085fc35165329ea1ff5c5ecbdbbeef','it.site44.com@gmail.com',N'Nguyễn Đức Anh',N'Nam Định','11/04/1991','01686398381')
INSERT INTO Accounts(Accounts_Username,Accounts_Password,Accounts_Email,Accounts_FullName,Accounts_Address,Accounts_DateOfBirth,Accounts_PhoneNumber) 
	VALUES('guest','40bd001563085fc35165329ea1ff5c5ecbdbbeef','thang_991992@yahoo.com',N'Bùi Văn Minh',N'Vĩnh Phúc','05/09/1992','01663797172')

SELECT * FROM Accounts
	
	
	
-- 2.	Table Products
USE ThangNMjsc
GO
INSERT INTO Products(Products_Name,Products_Description) 
	VALUES(N'Máy tính',N'Máy tính để bàn, Máy tính Bảng, Máy tính Xách tay,...')
INSERT INTO Products(Products_Group,Products_Name,Products_Price,Products_Sale,Products_VAT,Products_Description,Products_Info,Products_Origin) 
	VALUES(1,N'Laptop Asus',7800000,800000,'TRUE',N'Hàng mới về',N'Hàng nhập khẩu nguyên chiếc',N'Trung Quốc')

INSERT INTO Products(Products_Name,Products_Description) 
	VALUES(N'Thiết bị lưu trữ',N'Ổ cứng HDD, SSD, Ổ đĩa quang DVD, RAM, USB,SD...')
INSERT INTO Products(Products_Group,Products_Name,Products_Price,Products_Sale,Products_VAT,Products_Description,Products_Info,Products_Origin) 
	VALUES(3,N'RAM',200000,0,'TRUE',N'Hàng mới về',N'Nhập khẩu',N'Trung Quốc')

INSERT INTO Products(Products_Name,Products_Description) 
	VALUES(N'Thiết bị ngoại vi',N'Màn hình máy tính, Chuột máy tính, Bàn phím, Loa, Webcame, Cáp nối,...')
INSERT INTO Products(Products_Group,Products_Name,Products_Price,Products_Sale,Products_VAT,Products_Description,Products_Info,Products_Origin) 
	VALUES(5,N'Chuột Laze HP',400000,50000,'TRUE',N'Hàng tồn kho',N'Hàng nhập khẩu nguyên chiếc',N'Trung Quốc')

INSERT INTO Products(Products_Name,Products_Description) 
	VALUES(N'Thiết bị Mạng',N'Router, Modem ADSL, Switch, Card mạng, USB 3G,...')
INSERT INTO Products(Products_Group,Products_Name,Products_Price,Products_Sale,Products_VAT,Products_Description,Products_Info,Products_Origin) 
	VALUES(7,N'Router',500000,0,'TRUE',N'TP_Link',N'Hàng nhập khẩu nguyên chiếc',N'Đài Loan')

INSERT INTO Products(Products_Name,Products_Description) 
	VALUES(N'Phần mềm',N'Antivirus, Hệ điều hành, Ofice,...')
INSERT INTO Products(Products_Group,Products_Name,Products_Price,Products_Sale,Products_VAT,Products_Description,Products_Info,Products_Origin) 
	VALUES(9,N'Windows 7',300000,0,'TRUE',N'Hàng mới về',N'Hot',N'US')

SELECT * FROM Products

	
		
-- 3.	Table Supports
USE ThangNMjsc
GO
INSERT INTO Supports(Customer_ID,Product_ID,Supports_Type)
	VALUES(4,3,N'Lỗi nguồn')
INSERT INTO Supports(Customer_ID,Product_ID,Supports_Type)
	VALUES(4,2,N'Bật không lên')
INSERT INTO Supports(Customer_ID,Product_ID,Supports_Type)
	VALUES(4,4,N'Báo lỗi sản phẩm')
INSERT INTO Supports(Customer_ID,Product_ID,Supports_Type)
	VALUES(5,5,N'Không chạy')
		
SELECT * FROM Supports
		


-- 4.	Table Answers
USE ThangNMjsc
GO
INSERT INTO Answers(Support_ID,Staff_ID,Answers_Content,Answers_DateTimeB)
	VALUES(1,2,N'Chập chờn không lên', GETDATE())
INSERT INTO Answers(Support_ID,Staff_ID,Answers_Content,Answers_DateTimeB)
	VALUES(2,2,N'Lỗi nguồn', GETDATE())
INSERT INTO Answers(Support_ID,Answers_Content)
	VALUES(3,N'lỗi không chạy')
INSERT INTO Answers(Support_ID,Staff_ID,Answers_Content,Answers_DateTimeB)
	VALUES(4,3,N'Thiếu chức năng', GETDATE())

SELECT * FROM Answers