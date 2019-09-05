CREATE TABLE [SCH_Aptude_KBX].[TBL_Ships]
(
	[Id] INT NOT NULL , 
    [IdClient] INT NOT NULL, 
    [AddressFrom] VARCHAR(50) NOT NULL, 
    [AddressTo] VARCHAR(50) NOT NULL, 
    [DateDeparted] DATE NOT NULL, 
    [DateRecivedExpects] DATE NOT NULL, 
    [StatusShip] CHAR NOT NULL, 
    [DateRecivedReal] DATE NULL, 
    [Guid] UNIQUEIDENTIFIER NOT NULL, 
    PRIMARY KEY ([Id], [IdClient])
)
