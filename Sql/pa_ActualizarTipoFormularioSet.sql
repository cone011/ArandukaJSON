
CREATE PROCEDURE dbo.pa_ActualizarTipoFormularioSet
(
	@idTipoFormularioSet SMALLINT = NULL,
	@CodigoTipoFormularioSet VARCHAR(3) = NULL,
	@DescripcionTipoFormularioSet VARCHAR(50) = NULL,
	@UsuarioModificacion VARCHAR(20) = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN 
	UPDATE TipoFormularioSet SET CodigoTipoFormularioSet = @CodigoTipoFormularioSet,
								 DescripcionTipoFormularioSet = @DescripcionTipoFormularioSet,
								 UsuarioModificacion = @UsuarioModificacion,
								 FechaModificacion = GETDATE()
							WHERE idTipoFormularioSet = @idTipoFormularioSet
END
