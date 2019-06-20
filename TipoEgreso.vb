
Public Class TipoEgreso
	
	Private _idTipoEgreso As Integer
	
	Public Property idTipoEgreso() As Integer
		Get
			Return _idTipoEgreso
		End Get
		
		Set(ByVal value As Integer)
			_idTipoEgreso = value
		End Set
	End Property
	
	Private _CodigoEgreso As String 
	
	Public Property CodigoEgreso() As String 
		Get
			Return _CodigoEgreso
		End Get
		
		Set(ByVal value As String)
			_CodigoEgreso = value
		End Set
	End Property
	
	Private _DescripcionEgreso As String 
	
	Public Property DescripcionEgreso() As String
		Get
			Return _DescripcionEgreso
		End Get
		
		Set(ByVal value As String)
			_DescripcionEgreso = value
		End Set
	End Property
	
	  Private _UsuarioAgregado as String

    Public Property UsuarioAgregado() as String
        Get
            Return _UsuarioAgregado
        End Get
        Set(ByVal value as String)
            _UsuarioAgregado = value
        End Set
    End Property

    Private _FechaModificacion as Date

    Public Property FechaModificacion() as Date 
        Get
            Return _FechaModificacion
        End Get 
        Set(ByVal value as Date)
            _FechaModificacion = value
        End Set
    End Property


    Private _UsuarioModificacion as String

    Public Property UsuarioModificacion() as String
        Get
            Return _UsuarioModificacion
        End Get
        Set(ByVal value as String)
            _UsuarioModificacion = value
        End Set
    End Property
End Class