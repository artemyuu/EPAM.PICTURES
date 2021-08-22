CREATE PROCEDURE [dbo].[AuthenticationUser]
	@email nvarchar(255),
	@password nvarchar(50)
AS
	SELECT Id, Name, Surname, Username, Role, Password, DateOfBirth, RegistrationDate, Email, Image FROM Users WHERE Users.Email = @email AND Users.Password = @password
RETURN 0