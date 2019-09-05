CREATE PROCEDURE [SCH_Aptude_KBX].[SP_C_Users]
	@Id INT,
	@Mail VARCHAR(50)
	,@Password VARCHAR(50)
AS
	SET NOCOUNT ON

	DECLARE @ACTIVE BIT = 1

	INSERT INTO [SCH_Aptude_KBX].TBL_Users(
	Active
	,Id
	,Mail
	,Password)
	VALUES(
	@Active
	,@Id
	,@Mail
	,[SCH_Aptude_KBX].FN_Encrypt(@Password))

RETURN 0
