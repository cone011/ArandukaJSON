
Public Class TipoProveedor


    Private _idTipoProveedor As Integer
	
	Public Property idTipoProveedor() As Integer
		Get
		   Return _idTipoProveedor
		End Get
		
		Set(ByVal value as Integer)
			_idTipoProveedor = value
		End Set
	End Property
	
	Private _Descripcion As String
	
	Public Property Descripcion() As String
		Get
		  Return _Descripcion
		End Get
		
		Set(ByVal value as String)
			_Descripcion = value
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
		
		Set(ByVal as value As String)
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
		
		Set(ByVal as value As String)
		   _UsuarioModificacion = value
		End Set
   	End Property
End Class