CREATE PROCEDURE [dbo].[DeletePublication]
	@id int
AS
	DELETE FROM Publications WHERE Publications.id = @id
RETURN 0