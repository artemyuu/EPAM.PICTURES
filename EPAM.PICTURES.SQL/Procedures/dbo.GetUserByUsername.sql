CREATE PROCEDURE [dbo].[GetUserByUsername]
	@username nvarchar(25)
AS
	SELECT Id, Name, Surname, Username, Password, Role, DateOfBirth, RegistrationDate, Email, Image FROM Users WHERE Users.Username = @username
RETURN 0