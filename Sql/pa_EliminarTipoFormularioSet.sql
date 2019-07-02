
CREATE PROCEDURE dbo.pa_EliminarTipoFormularioSet
(
	@idTipoFormulariosSet INT = NULL
)
AS 
SET NOCOUNT ON ;
BEGIN 
	DELETE FROM TipoFomularioSet WHERE idTipoFormulariosSet = @idTipoFormulariosSet
END
