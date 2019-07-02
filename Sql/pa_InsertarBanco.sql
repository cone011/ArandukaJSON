
CREATE PROCEDURE dbo.pa_InsertarBanco
(
	@CodigoBanco VARCHAR(3) = NULL,
	@DescripcionBanco VARCHAR(50) = NULL,
	@UsuarioCreacion VARCHAR(20) = NULL
)
AS 
SET NOCOUNT ON;
BEGIN 
	INSERT INTO Banco(
						CodigoBanco,
						DescripcionBanco,
						UsuarioCreacion,
						FechaCreacion
					 )
			  VALUES(
						@CodigoBanco,
						@DescripcionBanco,
						@UsuarioCreacion,
						GETDATE()
					)
END 
