﻿CREATE TABLE [SCH_Aptude_KBX].[TBL_Clients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Mail] VARCHAR(50) NOT NULL, 
    [Password] VARBINARY(MAX) NOT NULL, 
    [Active] BIT NOT NULL
)
