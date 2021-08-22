CREATE PROCEDURE [dbo].[GetPublicationByPage]
	@offset int,
	@limit int
AS
	SELECT * FROM Publications ORDER BY Publications.DateOfCreation DESC OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY
RETURN 0