
Public Class ClasificacionContable
	Private _idClasificacionContable As Integer
	
	Public Property idClasificacionContable() As Integer
		Get
			Return _idClasificacionContable
		End Get
		
		Set(ByVal value As Integer)
			_idClasificacionContable = value
		End Set
	End Property
	
	Private _CodigoClasificacionContable As String 
	
	Public Property CodigoClasificacionContable() As String 
		Get 
			Return _CodigoClasificacionContable
		End Get
		
		Set(ByVal value As String)
			_CodigoClasificacionContable = value
		End Set
	End Property
	
	Private _DescripcionClasificacionContable As String 
	
	Public Property DescripcionClasificacionContable() As String 
		Get
			Return _DescripcionClasificacionContable
		End Get
		
		Set(ByVal value As String)
			_DescripcionClasificacionContable = value
		End Set
	End Property
	
	Private _TipoMovimiento As String 
	
	Public Property TIpoMovimiento() As String 
		Get
			Return _TipoMovimiento
		End Get
		
		Set(ByVal value As String)
			_TipoMovimiento = value
		End Set
	End Property
	
	Private _FechaCreacion As Date 
	
	Public Property FechaCreacion() As Date 
		Get
			Return _FechaCreacion
		End Get
		
		Set(ByVal value As Date)
			_FechaCreacion = value
		End Set
	End Property
	
	Private _UsuarioCreacion As String 
	
	Public Property UsuarioCreacion() As String
		Get
			Return _UsuarioCreacion
		End Get
		
		Set(ByVal value As String)
			_UsuarioCreacion = value
		End Set
	End Property
	
	Private _FechaModificacion As Date 
	
	Public Property FechaModificacion() As Date 
		Get
			Return _FechaModificacion
		End Get
		
		Set(ByVal value As Date)
			_FechaModificacion = value
		End Set
	End Property
	
	Private _UsuarioModificacion As String 
	
	Public Property UsuarioModificacion() As String
		Get
			Return _UsuarioModificacion
		End Get
		
		Set(ByVal value As String)
			_UsuarioModificacion = value
		End Set
	End Property
End Class