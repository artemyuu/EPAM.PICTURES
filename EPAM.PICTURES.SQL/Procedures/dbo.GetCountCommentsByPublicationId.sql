CREATE PROCEDURE [dbo].[GetCountCommentsByPublicationId]
	@publicationId int
AS
	SELECT COUNT(*) FROM Comments WHERE Comments.PublicationId = @publicationId