CREATE PROCEDURE [dbo].[AddLikePublication]
	@publicationId int,
	@userId int
AS
	INSERT INTO PublicationsLikes (PublicationId, UserId) VALUES (@publicationId, @userId)
RETURN 0