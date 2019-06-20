CREATE PROCEDURE pa_ActualizarTipoCliente
(
	@DescripcionTipoCliente VARCHAR(50) = NULL,
	@UsuarioModificacion VARCHAR(50) = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN
	INSERT INTO(DescripcionTipoCliente,
				FechaAgregado,
				UsuarioModificacion)
			VALUES(@DescripcionTipoCliente,
				   GETDATE(),
				   @UsuarioModificacion)
END