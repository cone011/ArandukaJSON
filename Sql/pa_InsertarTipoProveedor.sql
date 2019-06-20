CREATE PROCEDURE pa_ActualizarTipoProveedor
(
	@DescripcionTipoProveedor VARCHAR(50) = NULL,
	@UsuarioModificacion VARCHAR(50) = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN
	INSERT INTO(DescripcionTipoProveedor,
				FechaAgregado,
				UsuarioModificacion)
			VALUES(@DescripcionTipoProveedor,
				   GETDATE(),
				   @UsuarioModificacion)
END