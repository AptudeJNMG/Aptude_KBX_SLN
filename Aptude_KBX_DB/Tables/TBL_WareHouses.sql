﻿CREATE TABLE [SCH_Aptude_KBX].[TBL_WareHouses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [Active] BIT NOT NULL, 
    [IdState] INT NOT NULL
)
