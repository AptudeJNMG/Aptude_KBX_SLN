CREATE TABLE [SCH_Aptude_KBX].[TBL_InternationalZip]
(
	[IdCountry] INT NOT NULL , 
    [InOrOut] BIT NOT NULL, 
    [Zip] CHAR(10) NOT NULL, 
    [Active] BIT NOT NULL, 
    [IdTransportType] INT NOT NULL, 
    PRIMARY KEY ([IdTransportType], [InOrOut], [IdCountry])
)
