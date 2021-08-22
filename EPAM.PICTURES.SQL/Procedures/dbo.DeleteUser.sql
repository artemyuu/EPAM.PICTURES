CREATE PROCEDURE [dbo].[DeleteUser]
	@id int
AS
	DELETE FROM Users WHERE Users.id = @id
RETURN 0