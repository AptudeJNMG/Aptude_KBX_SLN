CREATE PROCEDURE [SCH_Aptude_KBX].[SP_C_WareHouses]
	@Address VARCHAR(50),
	@Name VARCHAR(50)
AS
	SET NOCOUNT ON
	DECLARE @Active BIT = 1

	INSERT INTO [SCH_Aptude_KBX].TBL_WareHouses(
	Active,
	Address,
	Name)
	VALUES(
	@Active,
	@Address,
	@Name)

RETURN 0
