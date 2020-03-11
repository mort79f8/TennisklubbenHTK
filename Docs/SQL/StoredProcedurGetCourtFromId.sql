USE TennisklubbenHTKDB

go 

CREATE PROCEDURE dbo.spTennisKlubben_GetCourtFromId
	@CourtId INT

As
BEGIN
	SET NOCOUNT ON
	SELECT *
	FROM Court
	WHERE CourtId = @CourtId
END