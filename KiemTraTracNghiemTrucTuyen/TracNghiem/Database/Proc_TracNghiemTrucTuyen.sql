CREATE PROC Question_SELECTList_Question_by_Array_Cauhoi_ID
@mangcauhoi VARCHAR(1000)
AS
BEGIN
SELECT * FROM Cauhoi WHERE (Cauhoi_ID IN (SELECT StringValue FROM StringCommASplit(@mangcauhoi)))
END
EXEC Question_SELECTList_Question_by_Array_Cauhoi_ID '139,118,8,123,36,235,206,37,195,226'


CREATE PROC Question_SELECTList_Cauhoi_ID
AS
BEGIN
SELECT Cauhoi_ID FROM Cauhoi
END
EXEC Question_SELECTList_Cauhoi_ID



CREATE PROC Cauhoi_CheckQuestion
@Cauhoi_ID BIGINT,
@Cauhoi_dung INT
AS
BEGIN
SELECT * FROM Cauhoi WHERE (Cauhoi_ID = @Cauhoi_ID) AND (Cauhoi_dung = @Cauhoi_dung)
END


CREATE PROC CountAllQuestion
AS
BEGIN
SELECT count(*) AS [SumQuestion] FROM Cauhoi
END

EXEC CountAllQuestion

CREATE PROC Question_SelectList
AS
BEGIN
SELECT * FROM Cauhoi
END