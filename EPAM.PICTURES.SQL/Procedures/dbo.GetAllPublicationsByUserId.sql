CREATE PROCEDURE [dbo].[GetAllPublicationsByUserId]
	@userId int
AS
	SELECT * FROM Publications WHERE Publications.UserId = @userId
RETURN 0