CREATE PROCEDURE [dbo].[CreatePublication]
	@author int,
	@title nvarchar(50),
	@description nvarchar(MAX),
	@image nvarchar(50),
	@dateOfCreation datetime
AS
	INSERT INTO Publications (UserId, Title, Description, Image, DateOfCreation) VALUES (@author, @title, @description, @image, @dateOfCreation)
RETURN 0