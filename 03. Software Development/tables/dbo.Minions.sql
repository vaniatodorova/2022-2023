CREATE TABLE [dbo].[Minions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Age] INT NOT NULL, 
    [TownId] INT NOT NULL, 
    CONSTRAINT [FK_Minions_Towns] FOREIGN KEY ([TownId]) REFERENCES [Towns]([Id])
)
