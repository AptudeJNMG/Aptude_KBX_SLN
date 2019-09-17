ALTER TABLE [SCH_Aptude_KBX].[TBL_States]
	ADD CONSTRAINT [FK_States_Countries]
	FOREIGN KEY (IdCountry)
	REFERENCES [SCH_Aptude_KBX].[TBL_Countries] (Id)
