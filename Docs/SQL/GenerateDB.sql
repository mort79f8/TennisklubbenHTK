USE master
IF EXISTS(select * from sys.databases where name='TennisklubbenHTKDB')
DROP DATABASE TennisklubbenHTKDB
CREATE DATABASE TennisklubbenHTKDB
GO

USE TennisklubbenHTKDB

GO

CREATE TABLE Members (
	MemberId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	MemberAddress NVARCHAR(100) NOT NULL,
	MobilNumber NVARCHAR(20) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Birthday DATETIME2(7) NOT NULL,
	RankListPoints INT NOT NULL,
	Active bit NOT NUll
	);
GO