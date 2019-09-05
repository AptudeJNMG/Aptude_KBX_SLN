CREATE PROCEDURE [SCH_Aptude_KBX].[SP_U_UsersPassword]
	@Mail VARCHAR(50),
	@Password VARCHAR(50)
AS
	SET NOCOUNT ON

	UPDATE A
	SET A.Password = [SCH_Aptude_KBX].FN_Encrypt(@Password)
	FROM [SCH_Aptude_KBX].TBL_Users AS A
	WHERE A.Mail = @Mail
	
RETURN 0
