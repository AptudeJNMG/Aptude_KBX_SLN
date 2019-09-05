ALTER TABLE [SCH_Aptude_KBX].[TBL_ShipDetails]
	ADD CONSTRAINT [FK_ShDetails_WHouses2]
	FOREIGN KEY (IdWarehouseTo)
	REFERENCES [SCH_Aptude_KBX].[TBL_WareHouses] (Id)
