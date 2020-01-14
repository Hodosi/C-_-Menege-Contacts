CREATE TABLE [dbo].[Users] (
    [IdUser]     INT          IDENTITY (1, 1) NOT NULL,
    [First_Name] VARCHAR (50) NULL,
    [Last_Name]  VARCHAR (50) NULL,
    [Username]   VARCHAR (50) NULL,
    [Password]   VARCHAR (50) NULL,
    [Picture]    IMAGE        NULL,
    PRIMARY KEY CLUSTERED ([IdUser] ASC)
);

