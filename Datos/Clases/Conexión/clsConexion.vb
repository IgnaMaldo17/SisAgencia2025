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
    ' Constructor que inicializa la conexi�n
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



    ' Funci�n para establecer la conexi�n
    Public Function Conectado() As Boolean
        Try
            ' Abrimos la conexi�n
            con.Open()
            ' Retornamos el valor true para informar el �xito de la conexi�n
            Return True
        Catch ex As SqlException
            ' Si sucede alg�n error, informamos por mensaje de pantalla el detalle
            MsgBox("Error de SQL: " & ex.Message)
            Return False
        Catch ex As Exception
            ' Manejo de otros errores
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' Funci�n para cerrar la conexi�n
    Public Function Desconectado() As Boolean
        Try
            ' Preguntamos si la conexi�n est� abierta
            If con.State = ConnectionState.Open Then
                ' Si esto es as�, cerramos la conexi�n
                con.Close()
            End If
            ' Devolvemos el valor true para informar que la conexi�n se encuentra cerrada
            Return True
        Catch ex As Exception
            ' Si sucede alg�n error, informamos por mensaje de pantalla el detalle
            MsgBox("Error al cerrar la conexi�n: " & ex.Message)
            Return False
        End Try
    End Function

    ' M�todo para obtener la conexi�n (en caso de que necesites acceder a ella)
    Public Function GetConnection() As SqlConnection
        Return con
    End Function
#End Region

End Class
