CREATE TABLE [dbo].[Publications] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [UserId]         INT            NOT NULL,
    [Title]          NVARCHAR (50)  NOT NULL,
    [Description]    NVARCHAR (MAX) NULL,
    [Image]          NVARCHAR (50)  NOT NULL,
    [DateOfCreation] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

