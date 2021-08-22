CREATE PROCEDURE [dbo].[DeleteLikePublication]
	@publicationId int,
	@userId int
AS
	DELETE FROM PublicationsLikes WHERE PublicationsLikes.PublicationId = @publicationId AND PublicationsLikes.UserId = @userId
RETURN 0