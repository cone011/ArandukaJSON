
CREATE PROCEDURE dbo.pa_ActualizarTipoConceptoRenta
(
	@idTipoConceptoRenta SMALLINT = NULL,
	@CodigoTipoConceptoRenta VARCHAR(3) = NULL,
	@DescripcionTipoConceptoRenta VARCHAR(50) = NULL,
	@TipoContribuyente VARCHAR(3) = NULL,
	@UsuarioModificacion VARCHAR(20) = NULL
)
AS
SET NOCOUNT ON ;
BEGIN
		UPDATE TipoContribuyente SET CodigoTipoConceptoRenta = @CodigoTipoConceptoRenta,
									 DescripcionTipoConceptoRenta = @DescripcionTipoConceptoRenta,
									 TipoContribuyente = @TipoContribuyente,
									 UsuarioModificacion = @UsuarioModificacion,
									 FechaModificacion = GETDATE()
							    WHERE idTipoConceptoRenta = @idTipoConceptoRenta
END
