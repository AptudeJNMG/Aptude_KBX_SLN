﻿CREATE FUNCTION [SCH_Aptude_KBX].[FN_Decrypt]
(
	@encriptado VARBINARY(MAX)
)

RETURNS VARCHAR(50)
WITH ENCRYPTION
AS
BEGIN
	DECLARE @phrase VARCHAR(50)
	SET @phrase = 'NO ES QUE MUERA DE AMOR'

	RETURN DECRYPTBYPASSPHRASE (@phrase, @encriptado)
END