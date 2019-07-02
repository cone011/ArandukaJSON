
CREATE PROCEDURE dbo.pa_ConsultarTipoConceptoRenta
(
	@opcion INT,
	@idTipoConceptoRenta INT = NULL
)
AS 
SET NOCOUNT ON ;
IF @opcion = 1 
BEGIN 
	SELECT * FROM TipoConceptoRenta
END
ELSE IF @opcion = 2 
BEGIN 
	SELECT * FROM TipoConceptoRenta 
	WHERE idTipoConceptoRenta = @idTipoConceptoRenta
END
