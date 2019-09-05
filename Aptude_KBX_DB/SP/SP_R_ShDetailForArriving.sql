CREATE PROCEDURE [SCH_Aptude_KBX].[SP_R_ShDetailForArriving]
	@IdWarehouseTo int
AS
	SET NOCOUNT ON 

	SELECT A.DateDepart
	,A.IdClient
	,A.IdShip
	,A.IdWarehouseFrom
	,A.IdWarehouseTo
	FROM [SCH_Aptude_KBX].TBL_ShipDetails AS A (NOLOCK)
	WHERE A.IdWarehouseTo = @IdWarehouseTo
	AND A.DateArrive IS NULL

RETURN 0
