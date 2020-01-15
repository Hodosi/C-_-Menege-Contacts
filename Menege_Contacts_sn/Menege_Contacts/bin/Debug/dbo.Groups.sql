CREATE TABLE [dbo].[Groups] (
    [IdGroup] INT          IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (50) NULL,
    [UserId]  INT          NULL,
    PRIMARY KEY CLUSTERED ([IdGroup] ASC)
);

