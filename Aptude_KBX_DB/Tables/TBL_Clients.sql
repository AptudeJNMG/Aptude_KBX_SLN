CREATE TABLE [SCH_Aptude_KBX].[TBL_Clients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Mail] VARCHAR(50) NOT NULL
)
