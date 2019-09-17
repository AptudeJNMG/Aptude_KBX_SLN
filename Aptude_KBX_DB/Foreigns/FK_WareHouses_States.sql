ALTER TABLE [SCH_Aptude_KBX].[TBL_WareHouses]
	ADD CONSTRAINT [FK_WareHouses_States]
	FOREIGN KEY (IdState)
	REFERENCES [SCH_Aptude_KBX].[TBL_States] (Id)
