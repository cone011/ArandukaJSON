
Public Class TipoDescuento
	
	Protected _idTipoDescuento As Integer 
	
	Public Property idDescuento() As Integer 
		Get
			Return _idTipoDescuento
		End Get
		
		Set(ByVal value As Integer)
			_idTipoDescuento = value
		End Set
	End Property
	
	Protected _CodigoTipoDescuento As String 
	
	Public Property CodigoTipoDescuent() As String 
		Get
			Return _CodigoTipoDescuento
		End Get
		
		Set(ByVal value As String)
			_CodigoTipoDescuento = value
		End Set
	End Property
	
	Protected _DescripcionTipoDescuento As String 
	
	Public Property DescripcionTipoDescuento() As String 
		Get
			Return _DescripcionTipoDescuento
		End Get
	End Property
	
	Protected _PorcentajeDescuento As Integer 
	
	Public Property PorcentajeDescuento() As Integer 
		Get
			Return _PorcentajeDescuento
		End Get
		
		Set(ByVal value As Integer)
			_PorcentajeDescuento = value
		End Set
	End Property
	
	Protected _FechaCreacion As Date 
	
	Public Property FechaCreacion() As Date 
		Get
			Return _FechaCreacion
		End Get
		
		Set(ByVal value As Date)
			_FechaCreacion = value
		End Set
	End Property
	
	Protected _UsuarioCreacion As String 
	
	Public Property UsuarioCreacion() As String 
		Get
			Return _UsuarioCreacion
		End Get
		
		Set(ByVal value As String)
			_UsuarioCreacion = value
		End Set
	End Property
	
	Protected _FechaModificacion As Date
	
	Public Property FechaModificacio() As Date
		Get
			Return _FechaModificacion
		End Get
		
		Set(ByVal value As Date)
			_FechaModificacion = value
		End Set
	End Property
	
	Protected _UsuarioModificacion As String 
	
	Public Property UsuarioModificacion() As String 
		Get
			Return _UsuarioModificacion
		End Get
		
		Set(ByVal value As String)
			_UsuarioModificacion = value
		End Set
	End Property
End Class
