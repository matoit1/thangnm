----- Create insert-----
alter PROCEDURE Cauhoi_Insert
	
	@Cauhoi_cauhoi VARCHAR(500),
	@Cauhoi_A NVARCHAR(500),
	@Cauhoi_B NVARCHAR(500),
	@Cauhoi_C NVARCHAR(500),
	@Cauhoi_D NVARCHAR(500),
	@Cauhoi_dung int,
	@Cauhoi_capdo int,
	@Cauhoi_ghichu nvarchar(500)
	
	
AS
BEGIN
	INSERT INTO Cauhoi(Cauhoi_cauhoi,Cauhoi_A,Cauhoi_B,Cauhoi_C,Cauhoi_D,Cauhoi_dung,Cauhoi_capdo,Cauhoi_ghichu)
	VALUES (@Cauhoi_cauhoi,@Cauhoi_A,@Cauhoi_B,@Cauhoi_C,@Cauhoi_D,@Cauhoi_dung,@Cauhoi_capdo,@Cauhoi_ghichu)
END

-- create update------
alter PROCEDURE Cauhoi_Update
	@Cauhoi_ID BIGINT,
	@Cauhoi_cauhoi NVARCHAR(500),
	@Cauhoi_A NVARCHAR(500),
	@Cauhoi_B NVARCHAR(500),
	@Cauhoi_C NVARCHAR(500),
	@Cauhoi_D NVARCHAR(500),
	@Cauhoi_dung INT,
	@Cauhoi_capdo INT,
	@Cauhoi_ghichu nvarchar(500)
AS
BEGIN
	UPDATE Cauhoi
	SET
		Cauhoi_cauhoi=@Cauhoi_cauhoi,
		Cauhoi_A=@Cauhoi_A,
		Cauhoi_B=@Cauhoi_B,
		Cauhoi_C=@Cauhoi_C,
		Cauhoi_D=@Cauhoi_D,
		Cauhoi_dung=@Cauhoi_dung,
		Cauhoi_capdo=@Cauhoi_capdo,
		Cauhoi_ghichu=@Cauhoi_ghichu
	WHERE	Cauhoi_ID=@Cauhoi_ID
END



----- create delete -----
alter PROCEDURE Cauhoi_Delete
	@Cauhoi_ID BIGINT
AS
BEGIN
	DELETE Cauhoi
	WHERE Cauhoi_ID = @Cauhoi_ID
END


----create search------
ALTER PROCEDURE Cauhoi_Search
	@Cauhoi_ID BIGINT,
	@Cauhoi_cauhoi NVARCHAR(500)
AS
BEGIN
	SELECT * FROM Cauhoi
	WHERE ((@Cauhoi_ID = 0  OR Cauhoi_ID = @Cauhoi_ID ) AND (@Cauhoi_cauhoi IS NULL OR Cauhoi_cauhoi LIKE '%'+ @Cauhoi_cauhoi +'%') and (@Cauhoi_ = 0  OR Cauhoi_ID = @Cauhoi_ID ))
END
-- test
exec Cauhoi_Search  null,'th'


--================================================================



----- Create insert-----
alter PROCEDURE Diem_Insert

	@Diem_User INT,
	@Diem_tien BIGINT
AS
BEGIN
	INSERT INTO Diem(Diem_User,Diem_tien)
	VALUES (@Diem_User,@Diem_tien)
END

-- test

exec Diem_Insert 5,10


-- create update------
alter PROCEDURE Diem_Update
	@Diem_ID BIGINT,
	@Diem_User INT,
	@Diem_tien BIGINT
AS
BEGIN
	UPDATE Diem
	SET
		Diem_User=@Diem_User,
		Diem_tien=@Diem_tien
	WHERE	Diem_ID=@Diem_ID
END

-- test

exec Diem_Update 10,5,1000

----- create delete -----
CREATE PROCEDURE Diem_Delete
	@Diem_ID BIGINT
AS
BEGIN
	DELETE Diem
	WHERE Diem_ID = @Diem_ID
END
-- test

exec Diem_Delete 10

----create search------
ALTER PROCEDURE Diem_Search
	@Diem_User INT
AS
BEGIN
	SELECT * FROM Diem
	WHERE ((@Diem_User =0 OR Diem_User = @Diem_User ))
END

-- test

exec Diem_Search 5

--======================================================================
--------------------------------------------------------------------------


----- Create insert-----
CREATE PROCEDURE Taikhoan_Insert
	@taikhoan_tentaikhoan VARCHAR(50),
	@taikhoan_matkhau VARCHAR (50),
	@taikhoan_Email VARCHAR (100),
	@taikhoan_tendaydu VARCHAR (100),
	@taikhoan_diachi NVARCHAR (500),
	@taikhoan_ngaysinh DATETIME,
	@taikhoan_sodienthoai VARCHAR(50),
	@taikhoan_quyenhan INT,
	@taikhoan_annhdaidien NVARCHAR(200),
	@taikhoan_trangthai BIT
AS
BEGIN
	INSERT INTO Taikhoan(taikhoan_tentaikhoan,taikhoan_matkhau,taikhoan_Email,taikhoan_tendaydu,taikhoan_diachi,taikhoan_ngaysinh,taikhoan_sodienthoai,taikhoan_quyenhan,taikhoan_annhdaidien,taikhoan_trangthai)
	VALUES (@taikhoan_tentaikhoan,@taikhoan_matkhau,@taikhoan_Email,@taikhoan_tendaydu,@taikhoan_diachi,@taikhoan_ngaysinh,@taikhoan_sodienthoai,@taikhoan_quyenhan,@taikhoan_annhdaidien,@taikhoan_trangthai)
END

--test
exec Taikhoan_Insert 'thang','123','thang@gmail','thangml','vp','11/09/1992','018t8',1,'','true'
exec Taikhoan_Insert 'minh','123','minh@gmail','thangml','vp','11/09/1992','018t8',1,'','true'					

-- create update------
alter PROCEDURE Taikhoan_Update
	@taikhoan_ID BIGINT,
	@taikhoan_tentaikhoan VARCHAR(50),
	@taikhoan_matkhau VARCHAR(50),
	@taikhoan_Email VARCHAR(100),
	@taikhoan_tendaydu VARCHAR(100),
	@taikhoan_diachi NVARCHAR(500),
	@taikhoan_ngaysinh DATETIME,
	@taikhoan_sodienthoai VARCHAR(50),
	@taikhoan_quyenhan INT,
	@taikhoan_annhdaidien NVARCHAR(200),
	@taikhoan_trangthai BIT
AS
BEGIN
	UPDATE Taikhoan
	SET
		taikhoan_tentaikhoan=@taikhoan_tentaikhoan,
		taikhoan_matkhau=@taikhoan_matkhau,
		taikhoan_Email=@taikhoan_Email,
		taikhoan_tendaydu=@taikhoan_tendaydu,
		taikhoan_diachi=@taikhoan_diachi,
		taikhoan_ngaysinh=@taikhoan_ngaysinh,
		taikhoan_sodienthoai=@taikhoan_sodienthoai,
		taikhoan_quyenhan=@taikhoan_quyenhan,
		taikhoan_annhdaidien=@taikhoan_annhdaidien,
		taikhoan_trangthai=@taikhoan_trangthai
	WHERE	taikhoan_ID=@taikhoan_ID
END

-- test

exec Taikhoan_Update 1,'thang','123','thang@gmail','thangml','vp','11/09/1992','018t8',1,'','true'


----- create delete -----
CREATE PROCEDURE Taikhoan_Delete
	@taikhoan_ID BIGINT
AS
BEGIN
	DELETE Taikhoan
	WHERE taikhoan_ID = @taikhoan_ID
END
-- test

exec Taikhoan_Delete 1


----create search------
CREATE PROCEDURE Taikhoan_Search
	@taikhoan_tentaikhoan VARCHAR(50)
AS
BEGIN
	SELECT * FROM Taikhoan
	WHERE ((@taikhoan_tentaikhoan like '' OR taikhoan_tentaikhoan=@taikhoan_tentaikhoan))
END
--test
exec Taikhoan_Search minh






========================

create Proc LoadCauHoiTheoID
@Cauhoi_ID BIGINT
As
Begin
Select * from Cauhoi where Cauhoi_ID=@Cauhoi_ID
End




Create proc TaikhoanLogin
	@taikhoan_tentaikhoan varchar(50),
	@taikhoan_matkhau varchar(50)
as
begin
	select * from Taikhoan where taikhoan_tentaikhoan=@taikhoan_tentaikhoan and taikhoan_matkhau=@taikhoan_matkhau
end