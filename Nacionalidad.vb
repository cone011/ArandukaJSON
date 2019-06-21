
Public Class Nacionalidad
	Private _idNacionalidad As Integer 
	
	Public Property idNacionalidad() As Integer
		Get
			Return _idNacionalidad
		End Get
		
		Set(ByVal value As Integer)
			_idNacionalidad = value
		End Set
	End Property
	
	Private _CodigoNacionalidad As String 
	
	Public Property CodigoNacionalidad() As String 
		Get
			Return _CodigoNacionalidad
		End Get
		
		Set(ByVal value As String)
			_CodigoNacionalidad = value
		End Set
	End Property
	
	Private _DescripcionNacionalidad As String 
	
	Public Property DescripcionNacionalidad() As String 
		Get
			Return _DescripcionNacionalidad
		End Get
		
		Set(ByVal value As String)
			_DescripcionNacionalida = Value
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
	
	Private _FechaCreacion As Date
	
	Public Property FechaCreacion As Date
		Get 
			Return _FechaCreacion
		End Get
		
		Set(ByVal value As Date)
			_FechaCreacion = value
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
	
	Private _FechaModificacion As Date
	
	Public Property FechaModificacion As Date
		Get 
			Return _FechaModificacion
		End Get
		
		Set(ByVal value As Date)
			_FechaModificacion = value
		End Set
	End Property
End Class