
CREATE PROCEDURE dbo.pa_InsertarCiudad
(
	@CodigoCiudad VARCHAR(3) = NULL,
	@DescripcionCiudad VARCHAR(50) = NULL,
	@UsuarioCreacion VARCHAR(20) = NULL
)
AS 
SET NOCOUNT ON;
BEGIN
	INSERT INTO Ciudad(
						CodigoCiudad,
						DescripcionCiudad,
						UsuarioCreacion,
						FechaCreacion
					  )
			    VALUES(
						@CodigoCiudad,
						@DescripcionCiudad,
						@UsuarioCreacion,
						GETDATE()
					  )
END
