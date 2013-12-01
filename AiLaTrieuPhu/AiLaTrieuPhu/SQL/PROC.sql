create proc Cauhoi_DanhsachCauhoi
	@Cauhoi_capdo int
AS
BEGIN
	SELECT * FROM Cauhoi WHERE Cauhoi_capdo=@Cauhoi_capdo
END



EXEC Cauhoi_DanhsachCauhoi 1





create proc Taikhoan_DanhsachAdmin
	@taikhoan_quyenhan int
As
BEGIN
	Select * From Taikhoan Where taikhoan_quyenhan=@taikhoan_quyenhan
End

drop Taikhoan_DanhsachAdmin

EXEC Taikhoan_DanhsachAdmin 1



create proc DanhsachCauhoi
	@Cauhoi_capdo int
AS
BEGIN
	SELECT * FROM Cauhoi WHERE Cauhoi_capdo=@Cauhoi_capdo
END