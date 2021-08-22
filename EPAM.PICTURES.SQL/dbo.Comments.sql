CREATE TABLE [dbo].[Comments] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [PublicationId]  INT            NOT NULL,
    [UserId]         INT            NOT NULL,
    [DateOfCreation] DATETIME       NOT NULL,
    [CommentBody]    NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]),
    FOREIGN KEY ([PublicationId]) REFERENCES [dbo].[Publications] ([Id])
);

