CREATE TABLE [dbo].[Towns]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [CountryCode] INT NOT NULL, 
    CONSTRAINT [FK_Towns_Countries] FOREIGN KEY ([CountryCode]) REFERENCES [Countries]([Id]), 
)
