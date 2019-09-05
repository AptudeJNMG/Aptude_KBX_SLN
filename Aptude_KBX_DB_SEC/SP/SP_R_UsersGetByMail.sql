CREATE PROCEDURE [SCH_Aptude_KBX].[SP_R_UsersGetByMail]
	@Mail VARCHAR(50)
AS
	SELECT	A.Active
	,A.Id
	,A.Mail
	,A.Password
	FROM	[SCH_Aptude_KBX].TBL_Users AS A (NOLOCK)
	WHERE A.Mail LIKE '%' + @Mail + '%'

RETURN 0
