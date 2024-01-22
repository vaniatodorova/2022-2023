CREATE TABLE [dbo].[Villains]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [EvilnessFactorId] INT NOT NULL, 
    CONSTRAINT [FK_Villains_EvilnessFactors] FOREIGN KEY ([EvilnessFactorId]) REFERENCES [EvilnessFactors]([Id])
)
