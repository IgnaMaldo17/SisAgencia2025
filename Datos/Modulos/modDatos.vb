#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
Imports Datos
Imports System.Reflection.Metadata.Ecma335
Imports Microsoft.Identity.Client.ApiConfig
#End Region

Module modDatos
    Private conexion As New clsConexion()

    Public Function ProcedimientoDatatable(spName As String, Optional parametros As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            If Not conexion.Conectado() Then
                Return dt
            End If
            Using cmd As New SqlCommand(spName, conexion.con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 9999
                ' Agregar los parámetros si existen
                If parametros IsNot Nothing Then
                    cmd.Parameters.AddRange(parametros.ToArray())
                End If
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("Error de SQL: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conexion.Desconectado()
        End Try
        Return dt
    End Function

    Public Function ProcedimientoBoolean(spName As String, parametros As List(Of SqlParameter)) As Boolean
        Try
            ' Intentamos abrir la conexión
            If Not conexion.Conectado() Then
                Return False
            End If
            ' Usamos Using para manejar el comando y la conexión
            Using cmd As New SqlCommand(spName, conexion.con)
                cmd.CommandType = CommandType.StoredProcedure
                ' Agregamos los parámetros
                If parametros IsNot Nothing Then
                    cmd.Parameters.AddRange(parametros.ToArray())
                End If
                ' Ejecutamos el comando y verificamos si afectó filas
                If cmd.ExecuteNonQuery() Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As SqlException
            MsgBox("Error de SQL: " & ex.Message)
            Return False
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            conexion.Desconectado() ' Cerramos la conexión
        End Try
    End Function

    Public Function ProcedimientoInteger(spName As String, Optional parametros As List(Of SqlParameter) = Nothing) As Object
        Try
            ' Intentamos abrir la conexión
            If Not conexion.Conectado() Then
                Return Nothing
            End If
            ' Usamos Using para manejar el comando y la conexión
            Using cmd As New SqlCommand(spName, conexion.con)
                cmd.CommandType = CommandType.StoredProcedure
                ' Agregamos los parámetros si existen
                If parametros IsNot Nothing Then
                    cmd.Parameters.AddRange(parametros.ToArray())
                End If
                cmd.CommandTimeout = 9999
                ' Ejecutamos el comando y devolvemos el valor escalar
                Return cmd.ExecuteScalar()
            End Using
        Catch ex As SqlException
            MsgBox("Error de SQL: " & ex.Message)
            Return Nothing
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return Nothing
        Finally
            conexion.Desconectado() ' Cerramos la conexión
        End Try
    End Function
End Module
