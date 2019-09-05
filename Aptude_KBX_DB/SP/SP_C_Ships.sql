CREATE PROCEDURE [SCH_Aptude_KBX].[SP_C_Ships]
	@AddressFrom VARCHAR(50)
	,@AddressTo VARCHAR(50)
	,@DateDeparted DATE
	,@DateRecivedExpects DATE
	,@DateRecivedReal DATE
	,@Guid UNIQUEIDENTIFIER
	,@IdClient INT
	,@IdStatusShip CHAR(1)
AS
	SET NOCOUNT ON

	DECLARE @Id INT  

	SELECT @Id = [SCH_Aptude_KBX].FN_NewShip(@IdClient)

	INSERT INTO [SCH_Aptude_KBX].TBL_Ships(
	AddressFrom
	,AddressTo
	,DateDeparted
	,DateRecivedExpects
	,DateRecivedReal
	,Guid
	,Id
	,IdClient
	,StatusShip)
	VALUES(
	@AddressFrom
	,@AddressTo
	,@DateDeparted
	,@DateRecivedExpects
	,@DateRecivedReal
	,@Guid
	,@Id
	,@IdClient
	,@IdStatusShip)
	
RETURN 0
