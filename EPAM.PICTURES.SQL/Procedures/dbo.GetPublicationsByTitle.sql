CREATE PROCEDURE [dbo].[GetPublicationsByTitle]
	@title nvarchar(50)
AS
	SELECT * FROM Publications WHERE (LOWER(Publications.Title) LIKE LOWER(@title) + '%') ORDER BY Publications.DateOfCreation DESC
RETURN 0