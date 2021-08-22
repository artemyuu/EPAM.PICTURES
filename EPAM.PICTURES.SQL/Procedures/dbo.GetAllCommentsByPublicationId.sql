CREATE PROCEDURE [dbo].[GetAllCommentsByPublicationId]
	@publicationId int
AS
	SELECT * FROM Comments WHERE Comments.PublicationId = @publicationId
RETURN 0