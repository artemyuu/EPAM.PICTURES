CREATE PROCEDURE [dbo].[GetPublicationById]
	@id int
AS
	SELECT * FROM Publications WHERE Publications.Id = @id
RETURN 0