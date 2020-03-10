USE TennisklubbenHTKDB
go

CREATE PROCEDURE dbo.spTennisKlubbenHTK_TurnMemberInActive
	@MemberId INT,
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

	UPDATE Members
	SET FirstName = @FirstName, LastName = @LastName, MemberAddress = @MemberAddress, MobilNumber = @MobilNumber, Email = @Email, Birthday = @Birthday, RankListPoints = @RankListPoints, Active = 0
	WHERE MemberId = @MemberId

END