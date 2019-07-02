
CREATE PROCEDURE dbo.pa_ActualizarBanco
(
	@idBanco SMALLINT = NULL,
	@CodigoBanco VARCHAR(3) = NULL,
	@DescripcionBanco VARCHAR(50) = NULL,
	@UsuarioModificacion VARCHAR(20) = NULL
)
AS 
SET NOCOUNT ON;
BEGIN 
	UPDATE Banco SET CodigoBanco = @CodigoBanco,
					 DescripcionBanco = @DescripcionBanco,
					 UsuarioModificacion = @UsuarioModificacion,
					 FechaModificacion = GETDATE()
			    WHERE idBanco = @idBanco
END 
