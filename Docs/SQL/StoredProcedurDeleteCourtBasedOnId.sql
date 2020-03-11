USE TennisklubbenHTKDB

go 

CREATE PROCEDURE dbo.spTennisKlubben_DeleteCourtBasedOnId
	@CourtId INT

As
BEGIN
	SET NOCOUNT ON
	DELETE FROM Court
	WHERE CourtId = @CourtId

END