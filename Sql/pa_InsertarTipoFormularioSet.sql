
CREATE PROCEDURE dbo.pa_InsertarTipoFormularioSet
(
	@CodigoTipoFormularioSet VARCHAR(3) = NULL,
	@DescripcionTipoFormularioSet VARCHAR(50) = NULL,
	@UsuarioCreacion VARCHAR(20) = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN 
	INSERT INTO TipoFormularioSet(
									CodigoTipoFormularioSet,
									DescripcionTipoFormularioSet,
									UsuarioCreacion,
									FechaModificacion
								 )
						  VALUES(
									@CodigoTipoFormularioSet,
									@DescripcionTipoFormularioSet,
									@UsuarioCreacion,
									GETDATE()
								)
END
