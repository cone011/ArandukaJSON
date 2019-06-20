CREATE PROCEDURE pa_ConsultarTipoCliente
(
	@opcion AS INTEGER,
	@idTipoCliente AS INTEGER = NULL,
)
AS
SET NOCOUNT ON;
IF @opcion = 1 
BEGIN
	SELECT * FROM TipoCliente TC
END
ELSE IF @opcion = 2 
BEGIN 
	SELECT * FROM TipoCliente TC 
	WHERE TC.idTipoCliente = @idTipoCliente
END  