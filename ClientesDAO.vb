Imports System.Data
Imports System.Data.SqlClient


Public Class ClientesDAO

    Public Const PA_CONSULTARCLIENTES = "pa_ConsultarCliente"
    Public Const PA_INSERTARCLIENTES = "pa_InsertarCliente"
    Public Const PA_ACTUALIZARCLIENTES = "pa_ActualizarCliente"


    Public Function getAll(Optional opcion As Integer = 1) As List(Of Clientes)
        Dim list As List(Of Clientes) = New List(Of Clientes)
        Dim obj As Clientes
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try

            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARCLIENTES, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read
                obj = New Clientes

                If IsDBNull(reader("idCliente")) = False Then
                    obj.idCliente = reader("idCliente")
                End If

                If IsDBNull(reader("NombreCliente")) = False Then
                    obj.NombreCliente = reader("NombreCliente")
                End If

                If IsDBNull(reader("ApellidoCliente")) = False Then
                    obj.ApellidoCliente = reader("ApellidoCliente")
                End If

                If IsDBNull(reader("RazonSocial")) = False Then
                    obj.RazonSocial = reader("RazonSocial")
                End If

                If IsDBNull(reader("CedulaCliente")) = False Then
                    obj.CedulaCliente = reader("CedulaCliente")
                End If

                If IsDBNull(reader("TelefonoCliente")) = False Then
                    obj.TelefonoCliente = reader("TelefonoCliente")
                End If

                If IsDBNull(reader("CelularCliente")) = False Then
                    obj.CelularCliente = reader("CelularCliente")
                End If

                If IsDBNull(reader("EmailCliente")) = False Then
                    obj.EmailCliente = reader("EmailCliente")
                End If

                If IsDBNull(reader("Nacionalidad")) = False Then
                    obj.Nacionalidad = reader("Nacionalidad")
                End If

                If IsDBNull(reader("Direccion")) = False Then
                    obj.Direccion = reader("Direccion")
                End If

                If IsDBNull(reader("Departamento")) = False Then
                    obj.Departamento = reader("Departamento")
                End If

                If IsDBNull(reader("Ciudad")) = False Then
                    obj.Ciudad = reader("Ciudad")
                End If

                list.Add(obj)
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return list
    End Function

    Public Function getObjectById(idCliente As Integer, Optional opcion As Integer = 2) As Clientes

        Dim obj As Clientes = New Clientes
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try
            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARCLIENTES, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@idCliente", idCliente)
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read

                If IsDBNull(reader("idCliente")) = False Then
                    obj.idCliente = reader("idCliente")
                End If

                If IsDBNull(reader("NombreCliente")) = False Then
                    obj.NombreCliente = reader("NombreCliente")
                End If

                If IsDBNull(reader("ApellidoCliente")) = False Then
                    obj.ApellidoCliente = reader("ApellidoCliente")
                End If

                If IsDBNull(reader("RazonSocial")) = False Then
                    obj.RazonSocial = reader("RazonSocial")
                End If

                If IsDBNull(reader("CedulaCliente")) = False Then
                    obj.CedulaCliente = reader("CedulaCliente")
                End If

                If IsDBNull(reader("TelefonoCliente")) = False Then
                    obj.TelefonoCliente = reader("TelefonoCliente")
                End If

                If IsDBNull(reader("CelularCliente")) = False Then
                    obj.CelularCliente = reader("CelularCliente")
                End If

                If IsDBNull(reader("EmailCliente")) = False Then
                    obj.EmailCliente = reader("EmailCliente")
                End If

                If IsDBNull(reader("Nacionalidad")) = False Then
                    obj.Nacionalidad = reader("Nacionalidad")
                End If

                If IsDBNull(reader("Direccion")) = False Then
                    obj.Direccion = reader("Direccion")
                End If

                If IsDBNull(reader("Departamento")) = False Then
                    obj.Departamento = reader("Departamento")
                End If

                If IsDBNull(reader("Ciudad")) = False Then
                    obj.Ciudad = reader("Ciudad")
                End If
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return obj
    End Function

    Public Function getAllBusquedaClientes(busqueda As String, Optional opcion As Integer = 3) As List(Of Clientes)
        Dim list As List(Of Clientes) = New List(Of Clientes)
        Dim obj As Clientes
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try
            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARCLIENTES, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            param = StoredProcedureCommand.Parameters.AddWithValue("@sqlPart", busqueda)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read
                obj = New Clientes

                If IsDBNull(reader("idCliente")) = False Then
                    obj.idCliente = reader("idCliente")
                End If

                If IsDBNull(reader("NombreCliente")) = False Then
                    obj.NombreCliente = reader("NombreCliente")
                End If

                If IsDBNull(reader("ApellidoCliente")) = False Then
                    obj.ApellidoCliente = reader("ApellidoCliente")
                End If

                If IsDBNull(reader("RazonSocial")) = False Then
                    obj.RazonSocial = reader("RazonSocial")
                End If

                If IsDBNull(reader("CedulaCliente")) = False Then
                    obj.CedulaCliente = reader("CedulaCliente")
                End If

                list.Add(obj)
            Loop
            conn.Close()

        Catch ex As Exception
            Throw
        End Try
        Return list
    End Function

    Public Sub Save(obj As Clientes)

    End Sub

End Class
