USE TennisklubbenHTKDB
go

CREATE PROCEDURE dbo.spTennisKlubbenHTK_UpdateCourt
	@CourtId INT,
	@Name NVARCHAR(50),
	@Underlay NVARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON

	UPDATE Court
	SET Name = @Name, Underlay = @Underlay
	WHERE CourtId = @CourtId

END