CREATE PROCEDURE [dbo].[DeleteCommentByPublicationId]
	@publicationId int
AS
	DELETE FROM Comments WHERE Comments.PublicationId = @publicationId
RETURN 0