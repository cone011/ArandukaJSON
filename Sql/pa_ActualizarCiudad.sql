
CREATE PROCEDURE dbo.pa_ActualizarCiudad 
(
	@idCiudad SMALLINT = NULL
	@CodigoCiudad VARCHAR(3) = NULL,
	@DescripcionCiudad VARCHAR(50) = NULL
	@UsuarioModificacion VARCHAR(20) = NULL
)
AS
SET NOCOUNT ON;
BEGIN
	UPDATE Ciudad SET CodigoCiudad = @CodigoCiudad,
					  DescripcionCiudad = @DescripcionCiudad,
					  UsuarioModificacion = @UsuarioModificacion,
					  FechaModificacion = GETDATE()
			    WHERE idCiudad = @idCiudad
END
