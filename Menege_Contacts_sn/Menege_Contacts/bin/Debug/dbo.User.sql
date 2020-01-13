CREATE TABLE [dbo].[User]
(
	[IdUser] INT NOT NULL PRIMARY KEY IDENTITY, 
    [First Name] VARCHAR(50) NULL, 
    [Last Name] VARCHAR(50) NULL, 
    [Username] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NULL, 
    [Picture] IMAGE NULL
)
