USE TennisklubbenHTKDB
go

CREATE PROCEDURE dbo.spTennisKlubbenHTK_GetListOfCourts

AS

BEGIN
	SET NOCOUNT ON;
	
	SELECT * 
	FROM Court

END