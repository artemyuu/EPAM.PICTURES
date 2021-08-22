CREATE PROCEDURE [dbo].[DeleteTag]
	@id int
AS
	DELETE FROM Tags WHERE Tags.id = @id
RETURN 0