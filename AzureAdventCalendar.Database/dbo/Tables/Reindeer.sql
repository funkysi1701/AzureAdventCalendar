CREATE TABLE [dbo].[Reindeer] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (255) NULL,
    [Speed] INT            NULL,
    CONSTRAINT [PK_Reindeer] PRIMARY KEY CLUSTERED ([Id] ASC)
);

