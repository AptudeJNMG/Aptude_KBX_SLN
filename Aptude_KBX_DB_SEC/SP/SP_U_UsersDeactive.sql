CREATE PROCEDURE [SCH_Aptude_KBX].[SP_U_UsersDeactive]
	@Mail VARCHAR(50)
AS
	SET NOCOUNT ON
	DECLARE @Active BIT = 1
	DECLARE @DeActive BIT = 0

	UPDATE A
	SET A.Active = CASE WHEN A.Active  = @Active 
					THEN @DeActive  
					ELSE  @Active 
					END
	FROM [SCH_Aptude_KBX].TBL_Users AS A
	WHERE A.Mail = @Mail
	
RETURN 0
