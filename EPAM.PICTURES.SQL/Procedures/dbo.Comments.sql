CREATE PROCEDURE [dbo].[CreateComment]
	@publication int,
	@author int,
	@dateOfCreation datetime,
	@commentBody nvarchar(MAX)
AS
	INSERT INTO Comments (PublicationId, UserId, DateOfCreation, CommentBody) VALUES (@publication, @author, @dateOfCreation, @commentBody)
RETURN 0