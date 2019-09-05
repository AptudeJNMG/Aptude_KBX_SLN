CREATE TABLE [SCH_Aptude_KBX].[TBL_ShipItems]
(
	[Id] INT NOT NULL,
	[IdShip] INT NOT NULL , 
    [IdClient] INT NOT NULL, 
    [Item] VARCHAR(50) NOT NULL, 
    [Dimensions] VARCHAR(50) NOT NULL, 
    [Units] CHAR(5) NOT NULL, 
    [Guid] UNIQUEIDENTIFIER NOT NULL, 
    PRIMARY KEY ([Id], [IdShip], [IdClient])
)
