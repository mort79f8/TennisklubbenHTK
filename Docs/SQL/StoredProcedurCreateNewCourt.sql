USE TennisklubbenHTKDB
GO

CREATE PROCEDURE dbo.spTennisKlubbenHTK_CreateNewCourt
	@Name NVARCHAR(50),
	@Underlay NVARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON

	INSERT INTO dbo.Court
	(
		Name, Underlay
	)
	VALUES
	(
		@Name,
		@Underlay
	)

END