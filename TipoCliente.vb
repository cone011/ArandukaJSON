

public class TipoCliente

    Private _idTipoCliente As interger  
    
    Public Property idTipoCliente() As Integer
        Get
            Return _idTipoCliente
        End Get
        Set(ByVal value As Integer)
            _idTipoCliente = value
        End Set
    End Property

    Private _DescripcionTipoCliente as String 
    
    Public Property DescripcionTipoCliente() as String
        Get 
            Return _DescripcionTipoCliente
        end Get
        Set(ByVal value as String)
            _DescripcionTipoCliente = value
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
    
end class