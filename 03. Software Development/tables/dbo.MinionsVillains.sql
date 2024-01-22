CREATE TABLE [dbo].[MinionsVillains]
(
	[MinionId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VillainId] INT NOT NULL, 
    CONSTRAINT [FK_MinionsVillains_Villains] FOREIGN KEY ([VillainId]) REFERENCES [Villains]([Id]), 
    CONSTRAINT [FK_MinionsVillains_Minions] FOREIGN KEY ([MinionId]) REFERENCES [Minions]([Id])
)
