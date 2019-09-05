CREATE TABLE [SCH_Aptude_KBX].[TBL_ShipDetails]
(
	[IdShip] INT NOT NULL , 
    [IdClient] INT NOT NULL, 
    [IdWarehouseFrom] INT NOT NULL, 
	[IdWarehouseTo] INT NOT NULL, 
    [DateArrive] SMALLDATETIME NULL, 
    [DateDepart] SMALLDATETIME NOT NULL, 
    CONSTRAINT [PK_TBL_ShipDetails] PRIMARY KEY ([IdShip], [IdClient], [DateDepart]) 
)
