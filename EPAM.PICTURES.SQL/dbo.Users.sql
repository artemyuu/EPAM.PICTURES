CREATE TABLE [dbo].[Users] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (35)  NOT NULL,
    [Surname]          NVARCHAR (35)  NOT NULL,
    [Email]            NVARCHAR (255) NOT NULL,
    [Username]         NVARCHAR (25)  NOT NULL,
    [Password]         NVARCHAR (50)  NOT NULL,
    [Role]             INT            NOT NULL,
    [DateOfBirth]      DATE           NOT NULL,
    [RegistrationDate] DATETIME       NOT NULL,
    [Image]            NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

