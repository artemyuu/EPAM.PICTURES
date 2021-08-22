CREATE PROCEDURE [dbo].[GetTagById]
	@id int
AS
	SELECT Id, Title FROM Tags WHERE Tags.Id = @id
RETURN 0