ALTER TABLE [SCH_Aptude_KBX].[TBL_LocalRates]
	ADD CONSTRAINT [FK_LocalRates_StatesFrom]
	FOREIGN KEY (IdStateFrom)
	REFERENCES [SCH_Aptude_KBX].[TBL_States] (Id)
