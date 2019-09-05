CREATE PROCEDURE [SCH_Aptude_KBX].[SP_C_Clients]
	@BirthDate DATE
	,@LastName VARCHAR(50)
	,@Mail VARCHAR(50)
	,@Name VARCHAR(50)
AS
	SET NOCOUNT ON

	INSERT INTO [SCH_Aptude_KBX].TBL_Clients(
	BirthDate
	,LastName
	,Mail
	,FirstName)
	VALUES(
	@BirthDate
	,@LastName
	,@Mail
	,@Name)

RETURN 0
