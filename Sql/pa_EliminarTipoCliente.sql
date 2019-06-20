CREATE PROCEDURE pa_EliminarTipoCliente 
(
   @idTipoCliente INT = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN
	DELETE FROM TipoCliente TC WHERE TC.idTipoCliente = @idTipoCliente
END