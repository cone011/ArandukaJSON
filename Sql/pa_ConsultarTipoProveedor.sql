CREATE PROCEDURE pa_ConsultarTipoProveedor
(
  @opcion AS SMALLINT,
  @idTipoProveedor AS INTEGER = NULL
)
AS 
SET NOCOUNT ON ;
IF @opcion = 1 
BEGIN
	SELECT * FROM TipoProveedor TP
END 
ELSE IF @opcion = 2 
BEGIN
	SELECT * FROM TipoProveedor TP
	WHERE TP.idTipoProveedor = @idTipoProveedor
END 