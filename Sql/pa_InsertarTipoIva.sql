CREATE PROCEDURE pa_InsertarTipoIva
(
	@DescripcionTipoIva VARCHAR(50) = NULL,
	@Porcentaje INT = NULL,
	@UsuarioCreacion VARCHAR(50) = NULL
)
AS 
SET NOCOUNT ON;
BEGIN
	INSERT INTO TipoIva(DescripcionTipoIva,
						Porcentaje,
						FechaCreacion,
						UsuarioCreacion)
			VALUES(@DescripcionTipoIva,
				   @Porcentaje,
				   GETDATE(),
				   @UsuarioCreacion)
END 