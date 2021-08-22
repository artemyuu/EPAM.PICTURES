CREATE PROCEDURE [dbo].[UpdateTag]
	@id int,
	@title nvarchar(30)
AS
	UPDATE Tags SET Title = @title WHERE Tags.Id = @id
RETURN 0