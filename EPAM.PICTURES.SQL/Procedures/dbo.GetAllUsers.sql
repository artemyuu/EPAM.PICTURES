CREATE PROCEDURE [dbo].[GetAllUsers]
AS
	SELECT Id, Name, Surname, Username, Password, Email, Role, DateOfBirth, RegistrationDate, Image FROM Users
RETURN 0