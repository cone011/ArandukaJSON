CREATE PROCEDURE pa_EliminarTipoProveedor
(
	@idTipoProveedor INT = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN 
	DELETE FROM TipoProveedor TP WHERE TP.idTipoProveedor = @idTipoProveedor
END