#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
Imports Microsoft.Identity
#End Region

Public Class clsTel

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function MostrarTelefono(tel As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", tel)
    }
        Return ProcedimientoDatatable("MosTel", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function InsTel(cliente As eCli) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodCli", cliente.CodCli),
        New SqlParameter("@Telefono", cliente.Telefono),
        New SqlParameter("@IdAlta", cliente.IdAlta)
    }
        Return ProcedimientoBoolean("InsTel", parametros)
    End Function

    Public Function ModTel(cliente As eCli) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodCli", cliente.CodCli),
        New SqlParameter("@Telefono", cliente.Telefono),
        New SqlParameter("@CodNum", cliente.CodNum)
    }
        Return ProcedimientoBoolean("ModTel", parametros)
    End Function

    Public Function BajaTelefono(id As Integer, id_eliminador As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodNum", id),
        New SqlParameter("@IdBaja", id_eliminador)
    }
        Return ProcedimientoBoolean("BajTel", parametros)
    End Function

    Public Function AltaTelefono(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodNum", id)
    }
        Return ProcedimientoBoolean("RecTel", parametros)
    End Function
#End Region

End Class
