CREATE PROCEDURE [SCH_Aptude_KBX].[SP_U_ShDetailArrived]
	@Guid UNIQUEIDENTIFIER,
	@IdWareHouse INT

AS
	SET NOCOUNT ON 

	DECLARE @IdShip INT
			,@IdClient INT

	SELECT @IdShip = A.Id
		,@IdClient = A.IdClient
	FROM [SCH_Aptude_KBX].TBL_Ships AS A (NOLOCK)
	WHERE A.Guid = @Guid

	UPDATE 	A
	SET A.DateArrive = GETDATE()
	FROM [SCH_Aptude_KBX].TBL_ShipDetails AS A
	WHERE A.IdClient = @IdClient
	AND A.IdShip = @IdShip
	AND A.IdWarehouseTo = @IdWareHouse
	AND A.DateArrive IS NULL


RETURN 0
