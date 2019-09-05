CREATE PROCEDURE [SCH_Aptude_KBX].[SP_C_ShipItems]
	@Dimensions VARCHAR(50),
	@Guid		UNIQUEIDENTIFIER,
	@IdClient	INT,
	@IdShip		INT,
	@Item		VARCHAR(50),
	@Units		CHAR(5)
AS
	SET NOCOUNT ON

	DECLARE @Id INT  
	SELECT @Id = [SCH_Aptude_KBX].FN_NewShipItem( @IdClient,@IdShip)

	INSERT INTO [SCH_Aptude_KBX].TBL_ShipItems(
		Dimensions,
		Guid,
		Id,
		IdClient,
		IdShip,
		Item,
		Units)
	VALUES(
		@Dimensions,
		@Guid,
		@Id,
		@IdClient,
		@IdShip,
		@Item,
		@Units)

RETURN 0
