
CREATE PROCEDURE dbo.pa_ConsultarTipoForumlarioSet
(
	@opcion INT,
	@idTipoFormularioSet SMALLINT = NULL
)
AS 
SET NOCOUNT ON ;
IF @opcion = 1 --GetAll()
BEGIN 
	SELECT * FROM TipoFormularioSet
END
ELSE IF @opcion = 2 --GetObjectById()
BEGIN
	SELECT * FROM TipoFormularioSet
	WHERE idTipoFormularioSet = @idTipoFormularioSet
END