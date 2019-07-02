
Public Class TipoConceptoRenta
	
	Protected _idTipoConceptoRenta As Integer 
	
	Public Property idTipoConceptoRenta() As Integer 
		Get
			Return _idTipoConceptoRenta
		End Get
		
		Set(ByVal value As Integer)
			_idTipoConceptoRenta = value
		End Set
	End Property
	
	Protected _CodigoTipoConceptoRenta As String 
	
	Public Property CodigoTipoConceptoRenta() As String 
		Get
			Return _CodigoTipoConceptoRenta
		End Get
		
		Set(ByVal value As String)
			_CodigoTipoConceptoRenta = value
		End Set
	End Property
	
	Protected _DescripcionTipoConceptoRenta As String 
	
	Public Property DescripcionTipoConceptoRenta() As String 
		Get
		   Return _DescripcionTipoConceptoRenta
		End Get
		
		Set
			_DescripcionTipoConceptoRenta = value
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
	
	Protected _FechaCreacion As Date 
	
	Public Property FecheCreacion() As Date 
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