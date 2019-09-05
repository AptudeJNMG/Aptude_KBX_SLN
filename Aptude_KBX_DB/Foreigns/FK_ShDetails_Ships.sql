ALTER TABLE [SCH_Aptude_KBX].[TBL_ShipDetails]
	ADD CONSTRAINT [FK_ShDetails_Ships]
	FOREIGN KEY (IdShip,IdClient)
	REFERENCES [SCH_Aptude_KBX].[TBL_Ships] (Id,IdClient)
