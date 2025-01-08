#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Configuration
#End Region

Public Class clsConexion

#Region "Declaraciones"
    Public con As Microsoft.Data.SqlClient.SqlConnection
#End Region

#Region "Subrutinas"
    ' Constructor que inicializa la conexión
    Public Sub New()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("SisAgencia").ConnectionString
        con = New Microsoft.Data.SqlClient.SqlConnection(connectionString)
    End Sub
#End Region

#Region "Funciones"

    Public ReadOnly Property GetConnectionString() As String
        Get
            Return con.ConnectionString
        End Get
    End Property



    ' Función para establecer la conexión
    Public Function Conectado() As Boolean
        Try
            ' Abrimos la conexión
            con.Open()
            ' Retornamos el valor true para informar el éxito de la conexión
            Return True
        Catch ex As SqlException
            ' Si sucede algún error, informamos por mensaje de pantalla el detalle
            MsgBox("Error de SQL: " & ex.Message)
            Return False
        Catch ex As Exception
            ' Manejo de otros errores
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' Función para cerrar la conexión
    Public Function Desconectado() As Boolean
        Try
            ' Preguntamos si la conexión está abierta
            If con.State = ConnectionState.Open Then
                ' Si esto es así, cerramos la conexión
                con.Close()
            End If
            ' Devolvemos el valor true para informar que la conexión se encuentra cerrada
            Return True
        Catch ex As Exception
            ' Si sucede algún error, informamos por mensaje de pantalla el detalle
            MsgBox("Error al cerrar la conexión: " & ex.Message)
            Return False
        End Try
    End Function

    ' Método para obtener la conexión (en caso de que necesites acceder a ella)
    Public Function GetConnection() As SqlConnection
        Return con
    End Function
#End Region

End Class
