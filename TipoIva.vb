
Public Class TipoIva 
	
	Private _idTipoIva As Integer 
	
	Public Property idTipoIva() As Integer
		Get
			Return _idTipoIva
		End Get
		
		Set(ByVal value As Integer)
			_idTipoIva = value
		End Set
	End Property
	
	Private _DescripcionTipoIva As String 
	
	Public Property DescripcionTipoIva() As String 
		Get
			Return _DescripcionTipoIva
		End Get
		
		Set(ByVal value As String)
			_DescripcionTipoIva = value
		End Set
	End Property
	
	Private _Porcentaje As Integer
	
	Public Property Porcentaje() As Integer
		Get
			Return _Porcentaje
		End Get
		
		Set(ByVal value as Integer)
			_Porcentaje = value
		End Set
	End Property
	
	Private _FechaAgregado as Date 

    Public Property FechaAgregado() as Date 
        Get
            Return _FechaAgregado
        End Get
        Set(ByVal value as Date)
            _FechaAgregado = value
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