
CREATE PROCEDURE dbo.pa_ConsultarCiudad
(
	@opcion INT,
	@idCiudad SMALLINT = NULL
)
AS 
SET NOCOUNT ON;
IF @opcion = 1 
BEGIN
	SELECT * FROM Ciudad
END
ELSE IF @opcion = 2
BEGIN 
	SELECT * FROM Ciudad 
	WHERE idCiudad = @idCiudad
END
