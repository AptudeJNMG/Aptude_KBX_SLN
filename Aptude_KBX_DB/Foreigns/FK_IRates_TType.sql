ALTER TABLE [SCH_Aptude_KBX].[TBL_InternationalRates]
	ADD CONSTRAINT [FK_IRates_TTypes]
	FOREIGN KEY (IdTransportType)
	REFERENCES [SCH_Aptude_KBX].[TBL_TransportType] (Id)
