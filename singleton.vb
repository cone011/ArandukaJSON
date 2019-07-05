

Public Class Singleton
	
	#Region "Formulario"
	Private Shared Instance As Singleton
	Private _frmGridClientes as frmGridClientes
	Private _frmGridProveedores As frmGridProveedores
	#End Region
	
    
	Public Shared ReadOnly Property GetInstance()
		Get
			If Instance = Nothing Then 
				Instance = New Singleton
			End If
			Return Instance
		End Get
	End Property
	
	Public Function frmGridClientes() As frmGridClientes
		If _frmGridClientes Is Nothing OrElse _frmGridClientes.isDisposed Then 
			_frmGridClientes = New _frmGridClientes
		End If
		Return _frmGridClientes
	End Function
	
	Public Function frmGridProveedores() As frmGridProveedores
		If _frmGridProveedores Is Nothing OrElse _frmGridProveedores.isDisposed Then
			_frmGridProveedores = New _frmGridProveedores
		End If
	End Function
End Class