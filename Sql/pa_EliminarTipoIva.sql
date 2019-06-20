CREATE PROCEDURE pa_EliminarTipoIva
(
	@idTipoIva INT = NULL
)
AS 
SET NOCOUNT ON;
BEGIN
	DELETE FROM TipoIva WHERE idTipoIva = @idTipoIva
END 