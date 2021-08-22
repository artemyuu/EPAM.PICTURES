CREATE PROCEDURE [dbo].[GetCountLikesByPublicationId]
	@publicationId int
AS
	SELECT COUNT(*) FROM PublicationsLikes WHERE PublicationsLikes.PublicationId = @publicationId