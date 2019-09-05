CREATE PROCEDURE [SCH_Aptude_KBX].[SP_C_ShipDetails]
	@IdClient INT,
	@IdShip INT,
	@IdWarehouseFrom INT,
	@IdWarehouseTo INT
AS
	SET NOCOUNT ON

	INSERT INTO [SCH_Aptude_KBX].TBL_ShipDetails(
	DateArrive,
	DateDepart,
	IdClient,
	IdShip,
	IdWarehouseFrom,
	IdWarehouseTo)
	VALUES(	
		NULL,
	GETDATE(),
	@IdClient,
	@IdShip,
	@IdWarehouseFrom,
	@IdWarehouseTo)

RETURN 0
