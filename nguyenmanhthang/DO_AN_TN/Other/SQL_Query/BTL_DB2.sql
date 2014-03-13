--1. Tạo bảng tblSanPham
Create Table tblSanPham
(	PK_sMaSP VARCHAR(10) NOT NULL PRIMARY KEY,
	sTenSP NVARCHAR(50) NOT NULL UNIQUE,
	sMoTaSP NVARCHAR(50),
	sDonViTinhSP NVARCHAR(50) CHECK(sDonViTinhSP IN ('chiếc', 'cái', 'thanh', 'kg')),
	fGiaBanSP FLOAT,
);
--2. Tạo bảng tblKhachHang
Create Table tblKhachHang
(	PK_sMaKH VARCHAR(10) NOT NULL PRIMARY KEY,
	sTenKH NVARCHAR(50) NOT NULL,
	sDiaChiKH NVARCHAR(50),
	sSdtKH VARCHAR(11) NOT NULL CHECK(sSdtKH IN(0,1,2,3,4,5,6,7,8,9) AND sSdtKH.LEFT='0'),
	tNgaySinhKH DATETIME CHECK((tNgaySinhKH.YEAR() - GETDATE().YEAR()) >=18),
	sGioiTinhKH NVARCHAR(3)
);

--3. Tạo bảng tblHoaDon
Create Table tblHoaDon
(	PK_sMaHD VARCHAR(10) NOT NULL PRIMARY KEY,
	FK_sMaKH VARCHAR(10)
	FOREIGN KEY(FK_sMaKH) REFERENCES tblKhachHang(PK_sMaKH)
		ON UPDATE NO ACTION
		ON DELETE SET NULL,
	tNgayMua DATETIME NOT NULL,
	tNgayGiao DATETIME NOT NULL CHECK(tNgayMua < tNgayGiao)
);
--4. Tạo bảng tblChiTietHoaDon
Create Table tblChiTietHoaDon
(	FK_sMaSP VARCHAR(10)
		FOREIGN KEY(FK_sMaSP) REFERENCES tblSanPham(PK_sMaSP)
		ON UPDATE NO ACTION
		ON DELETE SET NULL,
	FK_sMaHD VARCHAR(10)
		FOREIGN KEY(FK_sMaHD) REFERENCES tblHoaDon(PK_sMaHD)
		ON UPDATE NO ACTION
		ON DELETE SET NULL,
	iSoLuong INT CHECK(iSoLuong>=1)
);




-- 1. PK_sMaSP, PK_sMaKH, PK_sMaHD là khóa chính, không được bỏ trông, không dược trùng nhau
-- 2. FK_sMaSP, FK_sMaKH, FK_sMaHD là khóa chính, không được bỏ trông, phải có bên bảng chính
-- 3. tNgayMua < tNgayBan (Ngày mua phải trước Ngày giao hàng)
-- 4. fGiaBanSP, iSoluong >=1 (Số lượng mua phải lớn hơn 1)
-- 5. sDonViTinhSP = {chiếc, cái, thanh, kg}
-- 6. sGioiTinh = {Nam, Nữ} {chỉ cho phép nhập Nam hoặc Nữ}
-- 7. sSdtKH = {0 + max(10)} (Số điện thoại phải dưới 11 số và bắt đầu từ số 0)
-- 8. tNgaySinh < NOW().YEAR - 18 (Công dân trên 18 mới bán)
-- 9. sTenSP không được trùng nhau




















--1. Tạo bảng tblSanPham
Create Table tblSanPham
(	PK_sMaSP VARCHAR(10) NOT NULL PRIMARY KEY,
	sTenSP NVARCHAR(50) NOT NULL UNIQUE,
	sMoTaSP NVARCHAR(50),
	sDonViTinhSP NVARCHAR(50) CHECK(sDonViTinhSP IN ('chiếc', 'cái', 'thanh', 'kg')),
	fGiaBanSP FLOAT
);

--2. Tạo bảng tblKhachHang
Create Table tblKhachHang
(	PK_sMaKH VARCHAR(10) NOT NULL PRIMARY KEY,
	sTenKH NVARCHAR(50) NOT NULL,
	sDiaChiKH NVARCHAR(50),
	sSdtKH VARCHAR(11) NOT NULL CHECK(sSdtKH IN(0,1,2,3,4,5,6,7,8,9) AND LEFT(sSdtKH,1)='0'),
	tNgaySinhKH DATE,
	--tNgaySinhKH DATE CHECK(YEAR(tNgaySinhKH - values current timestamp) >=18),
	sGioiTinhKH NVARCHAR(3)
);

--3. Tạo bảng tblHoaDon
Create Table tblHoaDon
(	PK_sMaHD VARCHAR(10) NOT NULL PRIMARY KEY,
	FK_sMaKH VARCHAR(10),
	FOREIGN KEY(FK_sMaKH) REFERENCES tblKhachHang(PK_sMaKH)
		ON UPDATE NO ACTION
		ON DELETE SET NULL,
	tNgayMua DATE NOT NULL,
	tNgayGiao DATE NOT NULL,
	CONSTRAINT Mua_Giao CHECK(tNgayMua <= tNgayGiao)
);

--4. Tạo bảng tblChiTietHoaDon
Create Table tblChiTietHoaDon
(	FK_sMaSP VARCHAR(10),
		FOREIGN KEY(FK_sMaSP) REFERENCES tblSanPham(PK_sMaSP)
		ON UPDATE NO ACTION
		ON DELETE SET NULL,
	FK_sMaHD VARCHAR(10),
		FOREIGN KEY(FK_sMaHD) REFERENCES tblHoaDon(PK_sMaHD)
		ON UPDATE NO ACTION
		ON DELETE SET NULL,
	iSoLuong INT CHECK(iSoLuong>=1)
);


--2. Tạo bảng tblKhachHang
Create Table tblKhachHang1
(	PK_sMaKH VARCHAR(10) NOT NULL PRIMARY KEY,
	sTenKH NVARCHAR(50) NOT NULL,
	sDiaChiKH NVARCHAR(50),
	sSdtKH VARCHAR(11) NOT NULL CHECK(sSdtKH IN(0,1,2,3,4,5,6,7,8,9) AND LEFT(sSdtKH,1)='0'),
	tNgaySinhKH DATE,
	CONSTRAINT Tuoi CHECK((YEAR(current_timestamp) - YEAR(tNgaySinhKH)) >=18),
	--tNgaySinhKH DATE CHECK(YEAR(tNgaySinhKH - values current timestamp) >=18),
	sGioiTinhKH NVARCHAR(3)
);




create table Student
 ( StudentID integer
 , DateOfBirth date
  constraint Over18
   check ( 
      year(current_date) - year(DateOfBirth) > 18
        or 
      year(current_date) - year(DateOfBirth) = 18
  and month(current_date) > month(DateOfBirth) 
        or 
      year(current_date) - year(DateOfBirth) = 18
  and month(current_date) = month(DateOfBirth) 
  and day(current_date) >= day(DateOfBirth)
         )
 );
 
 
values current date;
 
values current timestamp;
 
select current date from sysibm.sysdummy1;

-- 1. PK_sMaSP, PK_sMaKH, PK_sMaHD là khóa chính, không được bỏ trông, không dược trùng nhau
-- 2. FK_sMaSP, FK_sMaKH, FK_sMaHD là khóa chính, không được bỏ trông, phải có bên bảng chính
-- 3. tNgayMua < tNgayBan (Ngày mua phải trước Ngày giao hàng)
-- 4. fGiaBanSP, iSoluong >=1 (Số lượng mua phải lớn hơn 1)
-- 5. sDonViTinhSP = {chiếc, cái, thanh, kg}
-- 6. sGioiTinh = {Nam, Nữ} {chỉ cho phép nhập Nam hoặc Nữ}
-- 7. sSdtKH = {0 + max(10)} (Số điện thoại phải dưới 11 số và bắt đầu từ số 0)
-- 8. tNgaySinh < NOW().YEAR - 18 (Công dân trên 18 mới bán)
-- 9. sTenSP không được trùng nhau