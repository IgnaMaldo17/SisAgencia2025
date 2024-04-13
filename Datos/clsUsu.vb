Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class clsUsu
    Inherits clsConexion
    Dim cmd As New SqlCommand

    Public Function GetLogin(usu As String, pas As String) As DataTable

        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("Login")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@NomUsu", usu)
            cmd.Parameters.AddWithValue("@Password", pas)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            'cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function GetUsuarios() As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("MosUsu")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function


    Public Function VerificarUsuario(usu As String) As DataTable


        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("VerificarUsu")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@NomUsu", usu)



            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function InsUsu(usuario As eUsu) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("InsUsu")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@CodEmp", usuario.CodEmp)
            cmd.Parameters.AddWithValue("@NomUsu", usuario.NomUsu)
            cmd.Parameters.AddWithValue("@Password", usuario.Password)
            cmd.Parameters.AddWithValue("@IdAlta", usuario.IdAlta)



            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function

End Class
