ALTER TABLE [SCH_Aptude_KBX].[TBL_ShipDetails]
	ADD CONSTRAINT [FK_Ships_WHouses]
	FOREIGN KEY (IdWarehouseFrom)
	REFERENCES [SCH_Aptude_KBX].[TBL_WareHouses] (Id)
