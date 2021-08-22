CREATE PROCEDURE [dbo].[UpdateUser]
	@oldusername nvarchar(25),
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
	UPDATE Users SET Name = @name, Surname = @surname, Email = @email, Username = @username, Password = @password, Role = @role, DateOfBirth = @dateOfBirth, RegistrationDate = @registrationDate, Image = @image WHERE Users.Username = @oldusername
RETURN 0