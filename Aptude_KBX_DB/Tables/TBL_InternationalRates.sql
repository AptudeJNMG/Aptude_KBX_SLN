CREATE TABLE [SCH_Aptude_KBX].[TBL_InternationalRates]
(
    [Rates] FLOAT NOT NULL, 
    [IdCountryFrom] INT NOT NULL, 
    [IdCountryTo] INT NOT NULL, 
    [IdTransportType] INT NOT NULL, 
    [BitActive] BIT NOT NULL, 
    CONSTRAINT [PK_TBL_InternationalRates] PRIMARY KEY ([IdCountryFrom], [IdCountryTo], [IdTransportType])
)
