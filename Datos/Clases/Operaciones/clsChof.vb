#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
Imports System.Reflection.Metadata.Ecma335
Imports Microsoft.Identity.Client.ApiConfig
#End Region

Public Class clsChof

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetChoferes() As DataTable
        Return ProcedimientoDatatable("MosChof")
    End Function

    Public Function GetChoferesShrt()
        Return ProcedimientoDatatable("MosChofShrt")
    End Function

    Public Function GetChoferesCancel() As DataTable
        Return ProcedimientoDatatable("MosBajChof")
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarChoferes(chof As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", chof)
    }
        Return ProcedimientoDatatable("BusChof", parametros)
    End Function

    Public Function BuscarChoferesShrt(chof As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", chof)
    }
        Return ProcedimientoDatatable("BusChofShrt", parametros)
    End Function

    Public Function BuscarChoferesBaja(chof As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", chof)
    }
        Return ProcedimientoDatatable("BusChofBaj", parametros)
    End Function

    Public Function BuscarChoferDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusChofDateDes", parametros)
    End Function

    Public Function BuscarChoferDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusChofDateHastaDes", parametros)
    End Function

    Public Function BuscarChoferFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusChofDate", parametros)
    End Function

    Public Function BuscarChoferFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusChofDateHasta", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarDNIChofNuevo(chof As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", chof)
    }
        Return ProcedimientoDatatable("VerDNIChof", parametros)
    End Function

    Public Function VerificarDNIChofMod(chof As Integer, chofer As eChof) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", chof),
        New SqlParameter("@CodChof", chofer.CodChof)
    }
        Return ProcedimientoDatatable("VerDNIModChof", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function BajaChoferes(id As Integer, id_eliminador As Integer, chofer As eChof) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodChof", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", chofer.MotivoDes)
    }
        Return ProcedimientoBoolean("BajChofVeh", parametros)
    End Function

    Public Function RecChoferes(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodChof", id)
    }
        Return ProcedimientoBoolean("RecChof", parametros)
    End Function

    Public Function InsChof(chofer As eChof) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", chofer.DNI),
        New SqlParameter("@Nombre", chofer.Nombre),
        New SqlParameter("@Apellido", chofer.Apellido),
        New SqlParameter("@Correo", chofer.Correo),
        New SqlParameter("@Telefono", chofer.Telefono),
        New SqlParameter("@IdAlta", chofer.IdAlta)
    }
        Return ProcedimientoBoolean("InsChof", parametros)
    End Function

    Public Function ModChof(chofer As eChof) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodChof", chofer.CodChof),
        New SqlParameter("@DNI", chofer.DNI),
        New SqlParameter("@Nombre", chofer.Nombre),
        New SqlParameter("@Apellido", chofer.Apellido),
        New SqlParameter("@Correo", chofer.Correo),
        New SqlParameter("@Telefono", chofer.Telefono)
    }
        Return ProcedimientoBoolean("ModChof", parametros)
    End Function
#End Region

End Class
