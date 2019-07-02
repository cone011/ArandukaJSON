
Public Class TipoRetencion
	Protected _idTipoRetencion As Integer 
	
	Public Property idTipoRetencion() As Integer
		Get
			Return _idTipoRetencion
		End Get
		
		Set(ByVal value As Integer)
				_idTipoRetencion = value
		End Set
	End Property
	
	Protected _CodigoTipoRetencion As String 
	
	Public Property CodigoTipoRetencio() As String 
		Get 
			Return _CodigoTipoRetencion
		End Get
		
		Set(ByVal value As String)
			_CodigoTipoRetencion = value
		End Set
	End Property
	
	Protected _DescripcionTipoRetencion As String 
	
	Public Property DescripcionTipoRetencion() As String 
		Get
			Return _DescripcionTipoRetencion
		End Get
		
		Set(ByVal value As String)
			_DescripcionTipoRetencion = value
		End Set
	End Property
	
	Protected _Tipo As String 
	
	Public Property Tipo() As String 
		Get
			Return _Tipo
		End Get
		
		Set(ByVal value As String)
			_Tipo = value
		End Set
	End Property
	
	Protected _idTipoIva As Integer
	
	Public Property idTipoIva() As Integer
		Get
			Return _id
		End Get
		
		Set(ByVal value As Integer)
			_idTipoIva = valu
		End Set
	End Property
	
	Protected _PorcentajeRetenido As Integer 
	
	Public Property PorcentajeRetenido() As Integer
		Get
			Return _PorcentajeRetenido
		End Get
		
		Set(ByVal value As Integer)
			_PorcentajeRetenido = value
		End Set
	End Property
	
	Protected _CuentaContable As String 
	
	Public Property CuentaContable() As String 
		Get
			Return _CuentaContable
		End Get
		
		Set(ByVal value As String)
			_CuentaContable = value
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
	
	Public Protected UsuarioCreacion() As String 
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
	
	Public Property UsuarioModificaion() As String 
		Get
			Return _UsuarioModificacion
		End Get
		
		Set(ByVal value As String)
			_UsuarioModificacion = value
		End Set
	End Property
	
End Class