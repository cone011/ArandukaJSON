
Public Class Ciudad
	
	Protected _idCiudad As Integer 
	
	Public Property idCiudad() As Integer 
		Get 
			Return _idCiudad
		End Get
		
		Set(ByVal value As Integer)
			_idCiudad = value
		End Set
	End Property
	
	Protected _CodigoCiudad As String 
	
	Public Property CodigoCiudad() As String 
		Get
			Return _CodigoCiudad
		End Get
		
		Set(ByVal value As String)
			_CodigoCiudad = value
		End Set
	End Property
	
	Protected _DescripcionCiudad As String
	
	Public Property DescripcionCiudad() As String 
		Get
			Return _DescripcionCiudad
		End Get
		
		Set(ByVal value As String)
			_DescripcionCiudad = value
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
	
	Public Property FechaModificacion() As Date 
		Get
			Return _FechaModificacion
		End Get
		
		Set
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
