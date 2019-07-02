
CREATE PROCEDURE dbo.pa_InsertarTipoConceptoRenta
(
	@CodigoTipoConceptoRenta VARCHAR(3) = NULL,
	@DescripcionTipoConceptoRenta VARCHAR(50) = NULL,
	@TipoContribuyente VARCHAR(3) = NULL,
	@UsuarioCreacion VARCHAR(20) = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN
	INSERT INTO TipoContribuyente(
									CodigoTipoConceptoRenta,
									DescripcionTipoConceptoRenta,
									TipoContribuyente,
									UsuarioCreacion,
									FechaCreacion
								 )
						  VALUES(
									@CodigoTipoConceptoRenta,
									@DescripcionTipoConceptoRenta,
									@TipoContribuyente,
									@UsuarioCreacion,
									GETDATE()
								)
END
