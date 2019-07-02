
Public Class TipoMoneda

	Protected _idTipoMoneda As Integer 
	
	Public Property idTipoMoneda() As Integer 
		Get 
			Return _idTipoMoneda
		End Get
		
		Set(ByVal value As Integer)
			_idTipoMoneda = value
		End Set
	End Property
	
	Protected _CodigoTipoMoneda As String
	
	Public Property CodigoTipoMoneda() As String 
		Get
			Return _CodigoTipoMoneda
		End Get
		
		Set(ByVal value As String)
			_CodigoTipoMoneda = value
		End Set
	End Property
	
	Protected _DescripcionTipoMoneda As String 
	
	Public Property DescripcionTipoMoneda() As String 
		Get
			Return _DescripcionTipoMoneda
		End Get
		
		Set(ByVal value As String)
			_DescripcionTipoMoneda = value
		End Set
	End Property
	
	Protected _CotizacionMoneda As Integer 
	
	Public Property CotizacionMoneda() As Integer
		Get
			Return _CotizacionMoneda
		End Get
		
		Set 
			_CotizacionMoneda = value
		End Set
	End Property
	Protected _FechaCreacion As Date 
	
	Public Property FechaCreacion() As Date 
		Get
			Return _FechaCreacion
		End Get
		
		Set(ByVal value As String)
			_FechaCreacion = value
		End Set
	End Property
	
	Protected _UsuarioCreacion As String 
	
	Public Property UsuarioCreacion() As String 
		Get
			Return _UsuarioCreacion
		End Get
		
		Set 
			ByVal(value As String)
				_UsuarioCreacion = value
		End Set
	End Property
	
	Protected _FechaModificacion As Date 
	
	Public Property FechaCreacion() As Date
		Get
			Return _FechaCreacion
		End Get
		
		Set
		
		End Set
	End Property
	
	Protected _UsuarioModificacion As String 
	
	Public Property UsuarioModificacion() As String 
		Get
			Return _UsuarioModificacion
		End Get
		
		Set 
			ByVal(value As String)
				_UsuarioModificacion = value
		End Set
	End Property

End Class