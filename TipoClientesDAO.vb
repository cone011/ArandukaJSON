
Imports System.Data
Imports System.Data.SqlClient

Public Class TipoClientesDAO

    Public Const PA_CONSULTARTIPOCLIENTES = "pa_ConsultarTipoCliente"
    Public Const PA_INSERTARTIPOCLIENTES = "pa_InsertarTipoCliente"
    Public Const PA_ACTUALIZARTIPOCLIENTES = "pa_ActualizarTipoCliente"

    Public Function getAll(Optional opcion As Integer = 1) As List(Of TipoCliente)
        Dim list As List(Of TipoCliente) = New List(Of TipoCliente)
        Dim obj As TipoCliente
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try

            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARTIPOCLIENTES, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read
                obj = New TipoCliente

                If IsDBNull(reader("idTipoCliente")) = False Then
                    obj.idTipoCliente = reader("idTipoCliente")
                End If

                If IsDBNull(reader("CodigoTipoCliente")) = False Then
                    obj.CodigoTipoCliente = reader("CodigoTipoCliente")
                End If

                If IsDBNull(reader("DescripcionTipoCliente")) = False Then
                    obj.DescripcionTipoCliente = reader("DescripcionTipoCliente")
                End If

                list.Add(obj)
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return list
    End Function

    Public Function getObjectById(idTipoCliente As Integer, Optional opcion As Integer = 2) As TipoCliente

        Dim obj As TipoCliente = New TipoCliente
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try
            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARTIPOCLIENTES, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@idTipoCliente", idTipoCliente)
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read

                If IsDBNull(reader("idTipoCliente")) = False Then
                    obj.idTipoCliente = reader("idTipoCliente")
                End If

                If IsDBNull(reader("CodigoTipoCliente")) = False Then
                    obj.CodigoTipoCliente = reader("CodigoTipoCliente")
                End If

                If IsDBNull(reader("DescripcionTipoCliente")) = False Then
                    obj.DescripcionTipoCliente = reader("DescripcionTipoCliente")
                End If
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return obj
    End Function

    Public Function Save(obj As TipoCliente) As Boolean
        Dim persistencia As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim com As SqlCommand = New SqlCommand(PA_INSERTARTIPOCLIENTES, conn)
        Try
            com.Parameters.Add("@CodigoTipoCliente", SqlDbType.VarChar).Value = obj.CodigoTipoCliente
            com.Parameters.Add("@DescripcionTipoCliente", SqlDbType.VarChar).Value = obj.DescripcionTipoCliente
            com.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar).Value = "PRUEBA"
            com.CommandType = CommandType.StoredProcedure
            conn.Open()
            com.ExecuteNonQuery()
            persistencia = True
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return persistencia
    End Function

End Class
