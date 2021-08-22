CREATE PROCEDURE [dbo].[DeleteComment]
	@id int
AS
	DELETE FROM Comments WHERE Comments.Id = @id
RETURN 0