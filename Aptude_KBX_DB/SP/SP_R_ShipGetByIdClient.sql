CREATE PROCEDURE [SCH_Aptude_KBX].[SP_R_ShipGetByIdClient]
	@IdClient INT
AS
	SET NOCOUNT ON 

	SELECT A.AddressFrom
	,A.AddressTo
	,A.DateDeparted
	,A.DateRecivedExpects
	FROM [SCH_Aptude_KBX].TBL_Ships AS A(NOLOCK)
	WHERE A.IdClient =	@IdClient

RETURN 0
