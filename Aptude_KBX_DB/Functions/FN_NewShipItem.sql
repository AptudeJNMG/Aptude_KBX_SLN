CREATE FUNCTION [SCH_Aptude_KBX].[FN_NewShipItem]
(
	@IdClient INT,
	@IdShip INT
)
RETURNS INT
AS
BEGIN
	DECLARE @Zero INT = 0
	DECLARE @NewId INT = 1

	RETURN ISNULL((SELECT TOP 1 A.Id
				FROM SCH_Aptude_KBX.TBL_ShipItems AS A (NOLOCK)
				WHERE A.IdClient = @IdClient
				AND A.IdShip = @IdShip
				ORDER BY A.Id DESC),@Zero) + @NewId
					
END
