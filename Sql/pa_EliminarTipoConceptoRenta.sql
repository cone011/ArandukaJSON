
CREATE PROCEDURE dbo.pa_EliminarTipoConceptoRenta
(
	@idTipoConceptoRenta INT = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN 
	DELETE FROM TipoConceptoRenta WHERE idTipoConceptoRenta = @idTipoConceptoRenta
END
