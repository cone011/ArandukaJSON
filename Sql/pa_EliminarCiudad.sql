
CREATE PROCEDURE dbo.pa_EliminarCiudad
(
	@idCiudad SMALLINT = NULL
)
AS 
SET NOCOUNT ON;
BEGIN
	DELETE FROM Ciudad WHERE idCiudad = @idCiudad
END
