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

CREATE TABLE Court (
	CourtId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Underlay NVARCHAR(50) NOT NULL
	);
GO

CREATE TABLE Reservation (
	ReservationId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Time NVARCHAR(11) NOT NULL,
	Court INT NOT NULL FOREIGN KEY REFERENCES Court(CourtId)
	);
GO

CREATE TABLE ReservationMembers (
	ReservationMembersId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Reservation INT NOT NULL FOREIGN KEY REFERENCES Reservation(ReservationId),
	Member INT NOT NULL FOREIGN KEY REFERENCES Members(MemberId)
	);
GO