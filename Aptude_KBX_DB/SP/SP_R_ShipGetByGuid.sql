CREATE PROCEDURE [SCH_Aptude_KBX].[SP_R_ShipGetByGuid]
	@Guid UNIQUEIDENTIFIER
AS
	SET NOCOUNT ON 

	SELECT A.AddressFrom
	,A.AddressTo
	,A.DateDeparted
	,A.DateRecivedExpects
	FROM [SCH_Aptude_KBX].TBL_Ships AS A(NOLOCK)
	WHERE A.Guid =	@Guid

RETURN 0
