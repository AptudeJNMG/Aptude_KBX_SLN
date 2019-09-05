ALTER TABLE [SCH_Aptude_KBX].[TBL_ShipItems]
	ADD CONSTRAINT [FK_ShItems_Ships]
	FOREIGN KEY (IdShip,IdClient)
	REFERENCES [SCH_Aptude_KBX].[TBL_Ships] (Id,IdClient)
