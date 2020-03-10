USE TennisklubbenHTKDB

go 

CREATE PROCEDURE dbo.spTennisKlubben_GetMemberFromId
	@MemberId INT

As
BEGIN
	SET NOCOUNT ON
	SELECT *
	FROM Members
	WHERE MemberId = @MemberId
END