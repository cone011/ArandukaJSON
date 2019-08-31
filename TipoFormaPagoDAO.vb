Imports System.Data
Imports System.Data.SqlClient


Public Class TipoFormaPagoDAO

    Public Const PA_CONSULTARTIPOFORMAPAGO = "pa_ConsultarTipoFormaPago"
    Public Const PA_INSERTARTIPOFORMAPAGO = "pa_InsertarTipoFormaPago"
    Public Const PA_ACTUALIZARTIPOFORMAPAGO = "pa_ActualizarTipoFormaPago"

    Public Function getAll(Optional opcion As Integer = 1) As List(Of TipoFormaPago)
        Dim list As List(Of TipoFormaPago) = New List(Of TipoFormaPago)
        Dim obj As TipoFormaPago
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try

            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARTIPOFORMAPAGO, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read
                obj = New TipoFormaPago

                If IsDBNull(reader("idTipoFormaPago")) = False Then
                    obj.idTipoFormaPago = reader("idTipoFormaPago")
                End If

                If IsDBNull(reader("CodigoTipoFormaPago")) = False Then
                    obj.CodigoTipoFormaPago = reader("CodigoTipoFormaPago")
                End If

                If IsDBNull(reader("DescripcionTipoFormaPago")) = False Then
                    obj.DescripcionTipoFormaPago = reader("DescripcionTipoFormaPago")
                End If

                list.Add(obj)
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return list
    End Function

    Public Function getObjectById(idNacionalidad As Integer, Optional opcion As Integer = 2) As TipoFormaPago

        Dim obj As TipoFormaPago = New TipoFormaPago
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try
            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARTIPOFORMAPAGO, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@idNacionalidad", idNacionalidad)
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read

                If IsDBNull(reader("idTipoFormaPago")) = False Then
                    obj.idTipoFormaPago = reader("idTipoFormaPago")
                End If

                If IsDBNull(reader("CodigoTipoFormaPago")) = False Then
                    obj.CodigoTipoFormaPago = reader("CodigoTipoFormaPago")
                End If

                If IsDBNull(reader("DescripcionTipoFormaPago")) = False Then
                    obj.DescripcionTipoFormaPago = reader("DescripcionTipoFormaPago")
                End If
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return obj
    End Function

    Public Function Save(obj As TipoFormaPago) As Boolean
        Dim persistencia As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim com As SqlCommand = New SqlCommand(PA_INSERTARTIPOFORMAPAGO, conn)
        Try
            com.Parameters.Add("@CodigoTipoFormaPago", SqlDbType.VarChar).Value = obj.CodigoTipoFormaPago
            com.Parameters.Add("@DescripcionTipoFormaPago", SqlDbType.VarChar).Value = obj.DescripcionTipoFormaPago
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
