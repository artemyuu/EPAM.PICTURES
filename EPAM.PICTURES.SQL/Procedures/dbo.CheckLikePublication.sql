CREATE PROCEDURE [dbo].[CheckLikePublication]
	@publicationId int,
	@userId int
AS
	SELECT COUNT(*) FROM PublicationsLikes WHERE PublicationsLikes.PublicationId = @publicationId AND PublicationsLikes.UserId = @userId
RETURN 0