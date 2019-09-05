ALTER TABLE [SCH_Aptude_KBX].[TBL_InternationalRates]
	ADD CONSTRAINT [FK_IRates_CountryFrom]
	FOREIGN KEY (IdCountryFrom)
	REFERENCES [SCH_Aptude_KBX].[TBL_Countries] (Id)
