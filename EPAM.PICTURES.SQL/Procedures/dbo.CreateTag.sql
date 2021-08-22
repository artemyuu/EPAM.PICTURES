CREATE PROCEDURE [dbo].[CreateTag]
	@title nvarchar(30)
AS
	INSERT INTO Tags (Title) VALUES (@title)
RETURN 0