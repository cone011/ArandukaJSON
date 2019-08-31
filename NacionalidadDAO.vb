Imports System.Data
Imports System.Data.SqlClient

Public Class NacionalidadDAO

    Public Const PA_CONSULTARNACIONALIDAD = "pa_ConsultarNacionalidad"
    Public Const PA_INSERTARNACIONALIDAD = "pa_InsertarNacionalidad"
    Public Const PA_ACTUALIZARNACIONALIDAD = "pa_ActualizarNacionalidad"
    Public Const PA_ELIMINARNACIONALIDAD = "pa_EliminarNacionalidad"

    Public Function getAll(Optional opcion As Integer = 1) As List(Of Nacionalidad)
        Dim list As List(Of Nacionalidad) = New List(Of Nacionalidad)
        Dim obj As Nacionalidad
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try

            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARNACIONALIDAD, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read
                obj = New Nacionalidad

                If IsDBNull(reader("idNacionalidad")) = False Then
                    obj.idNacionalidad = reader("idNacionalidad")
                End If

                If IsDBNull(reader("CodigoNacionalidad")) = False Then
                    obj.CodigoNacionalidad = reader("CodigoNacionalidad")
                End If

                If IsDBNull(reader("DescripcionNacionalidad")) = False Then
                    obj.DescripcionNacionalidad = reader("DescripcionNacionalidad")
                End If

                list.Add(obj)
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return list
    End Function


    Public Function getObjectById(idNacionalidad As Integer, Optional opcion As Integer = 2) As Nacionalidad

        Dim obj As Nacionalidad = New Nacionalidad
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim param As SqlParameter = New SqlParameter()

        Try
            Dim StoredProcedureCommand As SqlCommand = New SqlCommand(PA_CONSULTARNACIONALIDAD, conn)
            StoredProcedureCommand.CommandType = CommandType.StoredProcedure
            param = StoredProcedureCommand.Parameters.AddWithValue("@idNacionalidad", idNacionalidad)
            param = StoredProcedureCommand.Parameters.AddWithValue("@opcion", opcion)
            conn.Open()
            Dim reader As SqlDataReader = StoredProcedureCommand.ExecuteReader()

            Do While reader.Read

                If IsDBNull(reader("idNacionalidad")) = False Then
                    obj.idNacionalidad = reader("idNacionalidad")
                End If

                If IsDBNull(reader("CodigoNacionalidad")) = False Then
                    obj.CodigoNacionalidad = reader("CodigoNacionalidad")
                End If

                If IsDBNull(reader("DescripcionNacionalidad")) = False Then
                    obj.DescripcionNacionalidad = reader("DescripcionNacionalidad")
                End If
            Loop
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
        Return obj
    End Function

    Public Function Save(obj As Nacionalidad) As Boolean
        Dim persistencia As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(EntornoConstantes.Conexion)
        Dim com As SqlCommand = New SqlCommand(PA_INSERTARNACIONALIDAD, conn)
        Try
            com.Parameters.Add("@CodigoNacionalidad", SqlDbType.VarChar).Value = obj.CodigoNacionalidad
            com.Parameters.Add("@DescripcionNacionalidad", SqlDbType.VarChar).Value = obj.DescripcionNacionalidad
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
