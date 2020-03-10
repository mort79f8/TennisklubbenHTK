CREATE PROCEDURE dbo.spTennisKlubbenHTKDB_CreateNewMember
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@MemberAddress NVARCHAR(100),
	@MobilNumber NVARCHAR(20),
	@Email NVARCHAR(100),
	@Birthday DATETIME2(7),
	@RankListPoints INT,
	@Active bit

AS
BEGIN
	SET NOCOUNT ON

	INSERT INTO dbo.Members
	(
		FirstName, LastName, MemberAddress, MobilNumber, Email, Birthday, RankListPoints, Active
	)
	VALUES
	(
		@FirstName,
		@LastName,
		@MemberAddress,
		@MobilNumber,
		@Email,
		@Birthday,
		@RankListPoints,
		@Active
	)

END
	