ALTER TABLE [SCH_Aptude_KBX].[TBL_Ships]
	ADD CONSTRAINT [FK_Ships_Clients]
	FOREIGN KEY (IdClient)
	REFERENCES [SCH_Aptude_KBX].[TBL_Clients] (Id)
