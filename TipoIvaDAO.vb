Imports System.Data
Imports System.Data.SqlClient


Public Class TipoIvaDAO

    Public Const PA_CONSULTARTIPOIVA = "pa_ConsultarTipoIva"
    Public Const PA_INSERTARTIPOIVA = "pa_InsertarTipoIva"
    Public Const PA_ACTUALIZARTIPOIVA = "pa_ActualizarTipoIva"


    Public Function getAll(Optional opcion As Integer = 1) As List(Of TipoIva)
        Dim list As List(Of TipoIva) = New List(Of TipoIva)
        Dim obj As TipoIva
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try

            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARTIPOIVA, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read
                obj = New TipoIva

                If IsDBNull(reader("idTipoIva")) = False Then
                    obj.idTipoIva = reader("idNacionalidad")
                End If

                If IsDBNull(reader("CodigoTipoIva")) = False Then
                    obj.CodigoTipoIva = reader("CodigoTipoIva")
                End If

                If IsDBNull(reader("DescripcionTipoIva")) = False Then
                    obj.DescripcionTipoIva = reader("DescripcionTipoIva")
                End If

                If IsDBNull(reader("Porcentaje")) = False Then
                    obj.Porcentaje = reader("Porcentaje")
                End If

                list.Add(obj)
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return list
    End Function

    Public Function getObjectById(idTipoIva As Integer, Optional opcion As Integer = 2) As TipoIva

        Dim obj As TipoIva = New TipoIva
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try
            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARTIPOIVA, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@idTipoIva", idTipoIva)
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read

                If IsDBNull(reader("idTipoIva")) = False Then
                    obj.idTipoIva = reader("idNacionalidad")
                End If

                If IsDBNull(reader("CodigoTipoIva")) = False Then
                    obj.CodigoTipoIva = reader("CodigoTipoIva")
                End If

                If IsDBNull(reader("DescripcionTipoIva")) = False Then
                    obj.DescripcionTipoIva = reader("DescripcionTipoIva")
                End If

                If IsDBNull(reader("Porcentaje")) = False Then
                    obj.Porcentaje = reader("Porcentaje")
                End If

            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return obj
    End Function


    Public Function Save(obj As TipoIva) As Boolean
        Dim persistencia As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim com As SqlCommand = New SqlCommand(PA_INSERTARTIPOIVA, conn)
        Try
            com.Parameters.Add("@CodigoTipoIva", SqlDbType.VarChar).Value = obj.CodigoTipoIva
            com.Parameters.Add("@DescripcionTipoIva", SqlDbType.VarChar).Value = obj.DescripcionTipoIva
            com.Parameters.Add("@Porcentaje", SqlDbType.Int).Value = obj.Porcentaje
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
