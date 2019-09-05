ALTER TABLE [SCH_Aptude_KBX].[TBL_InternationalZip]
	ADD CONSTRAINT [FK_IZip_Country]
	FOREIGN KEY (IdCountry)
	REFERENCES [SCH_Aptude_KBX].[TBL_Countries] (Id)
