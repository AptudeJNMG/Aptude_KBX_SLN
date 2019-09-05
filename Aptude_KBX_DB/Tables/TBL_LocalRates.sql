CREATE TABLE [SCH_Aptude_KBX].[TBL_LocalRates]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ZipFrom] CHAR(10) NOT NULL, 
    [ZipTo] CHAR(10) NOT NULL, 
    [Active] BIT NOT NULL, 
    [Rates] FLOAT NOT NULL, 
    [IdStateFrom] INT NOT NULL, 
    [IdStateTo] INT NOT NULL
)
