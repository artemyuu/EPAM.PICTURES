CREATE PROCEDURE [dbo].[GetUserById]
	@id int
AS
	SELECT Id, Name, Surname, Username, Password, Role, DateOfBirth, RegistrationDate, Email, Image FROM Users WHERE Users.Id = @id
RETURN 0