#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
#End Region

Public Class clsProv

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetProveedoresShrt() As DataTable
        Return ProcedimientoDatatable("MosProvShrt")
    End Function

    Public Function GetProveedores() As DataTable
        Return ProcedimientoDatatable("MosProv")
    End Function

    Public Function GetProveedoresCancel() As DataTable
        Return ProcedimientoDatatable("MosBajProv")
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarProveedoresShrt(prov As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", prov)
    }
        Return ProcedimientoDatatable("BusProvShrt", parametros)
    End Function

    Public Function BuscarProveedores(prov As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", prov)
    }
        Return ProcedimientoDatatable("BusProv", parametros)
    End Function

    Public Function BuscarProveedoresBaja(prov As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", prov)
    }
        Return ProcedimientoDatatable("BusProvBaj", parametros)
    End Function

    Public Function BuscarProveedorDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusProvDateDes", parametros)
    End Function

    Public Function BuscarProveedorDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusProvDateHastaDes", parametros)
    End Function

    Public Function BuscarProveedorFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusProvDate", parametros)
    End Function

    Public Function BuscarProveedorFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusProvDateHasta", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarCUITProvNuevo(provcuit As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CUIT", provcuit)
    }
        Return ProcedimientoDatatable("VerCUITProv", parametros)
    End Function

    Public Function VerificarCUITProvMod(provcuit As String, proveedor As eProv) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CUIT", provcuit),
        New SqlParameter("@CodProv", proveedor.CodProv)
    }
        Return ProcedimientoDatatable("VerDNIProvMod", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function BajaProveedores(id As Integer, id_eliminador As Integer, proveedor As eProv) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodProv", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", proveedor.MotivoDes)
    }
        Return ProcedimientoBoolean("BajProvServ", parametros)
    End Function

    Public Function RecProveedores(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodProv", id)
    }
        Return ProcedimientoBoolean("RecProv", parametros)
    End Function

    Public Function InsProv(proveedor As eProv) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CUIT", proveedor.CUIT),
        New SqlParameter("@RazonSocial", proveedor.RazonSocial),
        New SqlParameter("@NickName", proveedor.Nick),
        New SqlParameter("@Email", proveedor.Correo),
        New SqlParameter("@Telefono", proveedor.Telefono),
        New SqlParameter("@IdAlta", proveedor.IdAlta)
    }
        Return ProcedimientoBoolean("InsProv", parametros)
    End Function

    Public Function ModProv(proveedores As eProv) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodProv", proveedores.CodProv),
        New SqlParameter("@CUIT", proveedores.CUIT),
        New SqlParameter("@RazonSocial", proveedores.RazonSocial),
        New SqlParameter("@Nick", proveedores.Nick),
        New SqlParameter("@Email", proveedores.Correo),
        New SqlParameter("@Telefono", proveedores.Telefono)
    }
        Return ProcedimientoBoolean("ModProv", parametros)
    End Function
#End Region

End Class
