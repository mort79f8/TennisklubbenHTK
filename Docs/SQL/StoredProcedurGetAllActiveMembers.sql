Use TennisklubbenHTKDB

Go

CREATE PROCEDURE dbo.spTennisKlubbenHTK_GetAllActiveMembers

AS
BEGIN
	SET NOCOUNT ON

	SELECT *
	FROM Members
	WHERE Active = 1

END