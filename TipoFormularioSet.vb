
Public Class TipoFormularioSet
	
	Protected _idTipoFormularioSet
	
	Public Property idTipoFormularioSet() As Integer 
		Get
			Return _idTipoFormularioSet
		End Get
		
		Set(ByVal value As Integer)
			_idTipoFormularioSet = value
		End Set
	End Property
	
	Protected _CodigoTipoFormularioSet As String 
	
	Public Property CodigoTipoFormularioSet() As String 
		Get
			Return _CodigoTipoFormularioSet
		End Get
		
		Set(ByVal value As String)
			_CodigoTipoFormularioSet = value
		End Set
	End Property
	
	Protected _DescripcionTipoFormularioSet As String 
	
	Public Property DescripcionTipoFormularioSet () As String 
		Get
			Return _DescripcionTipoFormularioSet
		End Get
		
		Set(ByVal value As String)
			_DescripcionTipoFormularioSet = value
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
