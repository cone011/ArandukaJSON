CREATE PROCEDURE pa_ConsultarTipoIva
(
	@opcion SMALLINT,
	@idTipoIva INT = NULL 
)
AS 
SET NOCOUNT ON;
IF @opcion = 1 
BEGIN
	SELECT * FROM TipoIva
END
ELSE IF @opcion = 2 
BEGIN
	SELECT * FROM TipoIva TI
	WHERE TI.idTipoIva = @idTipoIva
END