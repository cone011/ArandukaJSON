
Public Class Banco
	
	Protected _idBanco As Integer 
	
	Public Property idBanco() As Integer 
		Get 
			Return _idBanco
		End Get
		
		Set(ByVal value As Integer)
			_idBanco = value
		End Set
	End Property
	
	Protected _CodigoBanco As String 
	
	Public Property CodigoBanco() As String 
		Get
			Return _CodigoBanco
		End Get
		
		Set(ByVal value As String)
			_CodigoBanco = value
		EnD Set
	End Property
	
	Protected _DescripcionBanco As String 
	
	Public Property DescripcionBanco() As String 
		Get 
			Return _DescripcionBanco
		End Get
		
		Set(ByVal value As String)
			_DescripcionBanco = value
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