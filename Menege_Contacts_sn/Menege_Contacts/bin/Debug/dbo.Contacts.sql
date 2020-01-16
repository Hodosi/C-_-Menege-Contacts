CREATE TABLE [dbo].[Contacts]
(
	[IdContact] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Group_Id] INT NULL, 
    [Phone] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Address] VARCHAR(50) NULL, 
    [Image] IMAGE NULL, 
    [User_Id] NCHAR(10) NULL
)
