USE TennisklubbenHTKDB
go

CREATE PROCEDURE dbo.spTennisKlubbenHTK_GetListOfMembers

AS

BEGIN
	SET NOCOUNT ON;
	
	SELECT * 
	FROM Members

END
