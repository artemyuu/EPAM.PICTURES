CREATE TABLE [dbo].[PublicationsLikes] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [UserId]        INT NOT NULL,
    [PublicationId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]),
    FOREIGN KEY ([PublicationId]) REFERENCES [dbo].[Publications] ([Id])
);

