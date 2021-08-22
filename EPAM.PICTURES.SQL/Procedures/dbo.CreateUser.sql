CREATE PROCEDURE [dbo].[CreateUser]
	@name nvarchar(35),
	@surname nvarchar(35),
	@email nvarchar(255),
	@username nvarchar(25),
	@password nvarchar(50),
	@role int,
	@dateOfBirth date,
	@registrationDate datetime,
	@image nvarchar(50)
AS
	INSERT INTO Users (Name, Surname, Email, Username, Password, Role, DateOfBirth, RegistrationDate, Image) VALUES (@name, @surname, @email, @username, @password, @role, @dateOfBirth, @registrationDate, @image)
RETURN 0