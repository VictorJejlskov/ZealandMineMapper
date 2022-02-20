SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


DROP TABLE [dbo].[Actor];

GO

CREATE TABLE [dbo].[Actor] (
    [Id]         INT        NOT NULL,
    [Name]       NCHAR (50) NOT NULL,
    [Country]    NCHAR (30) NOT NULL,
    [Birth_year] DATETIME   NOT NULL,
    [Alive]      BIT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

DROP TABLE [dbo].[Movie];
GO

CREATE TABLE [dbo].[Movie] (
    [Id]      INT        NOT NULL,
    [Title]   NCHAR (50) NOT NULL,
    [Year]    INT        NOT NULL,
    [Country] NCHAR (50) NOT NULL,
    [ActorId] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Movie_Actor] FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Actor] ([Id])
);


