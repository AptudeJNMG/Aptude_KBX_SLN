ALTER TABLE [SCH_Aptude_KBX].[TBL_InternationalRates]
	ADD CONSTRAINT [FK_IRates_CountryTo]
	FOREIGN KEY (IdCountryTo)
	REFERENCES [SCH_Aptude_KBX].[TBL_Countries] (Id)
