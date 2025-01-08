#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
#End Region

Public Class clsCli

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetPaises() As DataTable
        Return ProcedimientoDatatable("MosPais")
    End Function

    Public Function GetClientesShrt() As DataTable
        Return ProcedimientoDatatable("MosCliShrt")
    End Function

    Public Function GetClientes() As DataTable
        Return ProcedimientoDatatable("MosCli")
    End Function

    Public Function GetClientesCancel() As DataTable
        Return ProcedimientoDatatable("MosBajCli")
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarCliente(cli As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", cli)
    }
        Return ProcedimientoDatatable("BusCli", parametros)
    End Function

    Public Function BuscarClientesShrt(cli As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", cli)
    }
        Return ProcedimientoDatatable("BusCliShrt", parametros)
    End Function

    Public Function BuscarClienteBaja(cli As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", cli)
    }
        Return ProcedimientoDatatable("BusCliBaj", parametros)
    End Function

    Public Function BuscarClienteDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusCliDateDes", parametros)
    End Function

    Public Function BuscarClienteDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusCliDateHastaDes", parametros)
    End Function

    Public Function BuscarClienteFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusCliDate", parametros)
    End Function

    Public Function BuscarClienteFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusCliDateHasta", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarCombo(usu As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodPais", usu)
    }
        Return ProcedimientoDatatable("VerCmb", parametros)
    End Function

    Public Function VerificarDNINuevo(usu As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", usu)
    }
        Return ProcedimientoDatatable("VerDNI", parametros)
    End Function

    Public Function VerificarDNIMod(usu As Integer, cliente As eCli) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", usu),
        New SqlParameter("@CodCli", cliente.CodCli)
    }
        Return ProcedimientoDatatable("VerDNIMod", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function BajaClientes(id As Integer, id_eliminador As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodCli", id),
        New SqlParameter("@IdBaja", id_eliminador)
    }
        Return ProcedimientoBoolean("BajCliTel", parametros)
    End Function

    Public Function RecClientes(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodCli", id)
    }
        Return ProcedimientoBoolean("RecCli", parametros)
    End Function

    Public Function InsCli(cliente As eCli) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", cliente.DNI),
        New SqlParameter("@Nombre", cliente.Nombre),
        New SqlParameter("@Apellido", cliente.Apellido),
        New SqlParameter("@CodPais", cliente.CodPais),
        New SqlParameter("@Correo", cliente.Correo),
        New SqlParameter("@Telefono", cliente.Telefono),
        New SqlParameter("@IdAlta", cliente.IdAlta)
    }
        Return ProcedimientoBoolean("InsCli", parametros)
    End Function

    Public Function ModCli(cliente As eCli) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodCli", cliente.CodCli),
        New SqlParameter("@DNI", cliente.DNI),
        New SqlParameter("@Nombre", cliente.Nombre),
        New SqlParameter("@Apellido", cliente.Apellido),
        New SqlParameter("@CodPais", cliente.CodPais),
        New SqlParameter("@Correo", cliente.Correo)
    }
        Return ProcedimientoBoolean("ModCli", parametros)
    End Function
#End Region

End Class
