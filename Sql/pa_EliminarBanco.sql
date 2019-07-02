
CREATE PROCEDURE dbo.pa_EliminarBanco
(
	@idBanco SMALLINT = NULL
)
AS 
SET NOCOUNT ON;
BEGIN 
	DELETE FROM Banco WHERE idBanco = @idBanco
END 