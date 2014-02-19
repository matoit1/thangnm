create proc Cauhoi_Insert
@tencauhoi	nvarchar(2000)
,@daa	nvarchar(2000)
,@dab	nvarchar(2000)	
,@dac	nvarchar(2000)	
,@dad	nvarchar(2000)	
,@dadung	int
As
INSERT INTO Cauhoi (tencauhoi, daa, dab, dac, dad, dadung)
VALUES (@tencauhoi, @daa, @dab, @dac,@dad, @dadung)

--tesst
exec Cauhoi_Insert N'Câu 1',N'ĐA Câu 1',N'ĐA Câu 1',N'ĐA Câu 1',N'ĐA Câu 1', 2
select * from Cauhoi