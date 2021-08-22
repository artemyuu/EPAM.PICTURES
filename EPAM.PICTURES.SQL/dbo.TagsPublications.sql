CREATE TABLE [dbo].[TagsPublications] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [TagId]         INT NOT NULL,
    [PublicationId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TagId]) REFERENCES [dbo].[Tags] ([Id]),
    FOREIGN KEY ([PublicationId]) REFERENCES [dbo].[Publications] ([Id])
);

