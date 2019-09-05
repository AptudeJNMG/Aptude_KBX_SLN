CREATE PROCEDURE [SCH_Aptude_KBX].[SP_R_UsersGetByLogin]
	@Mail VARCHAR(50)
	,@Password VARCHAR(50)
AS
	SET NOCOUNT ON
	DECLARE @Active BIT = 1

	SELECT A.Id
	FROM [SCH_Aptude_KBX].TBL_Users AS A (NOLOCK)
	WHERE A.Active = @Active
	AND A.Mail = @Mail
	AND [SCH_Aptude_KBX].FN_Decrypt(A.Password) = @Password
RETURN 0
