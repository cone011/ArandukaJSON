
CREATE PROCEDURE dbo.pa_ConsultarBanco
(
	@opcion INT,
	@idBanco SMALLINT = NULL
)
AS 
SET NOCOUNT ON;
IF @opcion = 1 --GetAll()
BEGIN 
	SELECT * FROM Banco
END 
ELSE IF @opcion = 2 --GetObjectById
BEGIN 
	SELECT * FROM Banco B
	WHERE B.idBanco = @idBanco
END 