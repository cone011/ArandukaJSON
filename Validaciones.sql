--VALIDACIONES PARA CLIENTES
CREATE FUNCTION dbo.func_ValidacionCliente
(
	@idCliente INT = NULL,
	@Codigo VARCHAR(3) = NULL
)
RETURN AS BIT
AS 
BEGIN 
	DECLARE @isExiste BIT, @CodigoCliente VARCHAR(3)
	
	SET @CodigoCliente = (SELECT TOP 1 CodigoCliente FROM Clientes WHERE idCliente = @idCliente)
	
	IF @Clienteid = Codigo
		SET @isExiste = 'TRUE'
	ELSE 
		SET @isExiste = 'FALSE'
		
	RETURN @isExiste
END

IF dbo.func_ValidacionCliente(@idCliente, @Codigo)
BEGIN 
	RAISERROR('No se puede grabar un mismo registro que ya existe.', 16, 1);
	RETURN ;
END

---VALIDACION PARA PROVEEDORES
CREATE FUNCTION dbo.func_ValidacionProveedor
(
	@idProveedor INT = NULL,
	@Codigo VARCHAR(3) = NULL
)
RETURN BIT
AS 
BEGIN 
	DECLARE @isExiste BIT, @CodigoProveedor VARCHAR(3)
	
	SET @CodigoCliente = (SELECT TOP 1 CodigoProveedor FROM Proveedores WHERE idProveedor = @idProveedor)
	
	IF @Codigo = @CodigoProveedor 
		SET @isExiste = 'TRUE'
	ELSE 
		SET @isExiste = 'FALSE'
	RETURN @isExiste
END

CREATE FUNCTION dbo.func_ValidacionMoneda
(
	@idMoneda INT = NULL,
	@Codigo VARCHAR(3) = NULL
)
RETURN BIT
AS 
BEGIN
	DECLARE @isExiste BIT, @CodigoMoneda VARCHAR(3) = NULL
	
	SET @CodigoMoneda = (SELECT TOP 1 CodigoMoneda FROM Moneda WHERE idMoneda = @idMoneda)
	
	IF @Codigo = @CodigoMoneda
		SET @isExiste = 'True'
	ELSE 
		SET @isExiste = 'False'
	RETURN @isExiste
END