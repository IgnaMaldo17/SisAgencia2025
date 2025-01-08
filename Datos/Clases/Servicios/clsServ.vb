#Region "Imports"
Imports Entidades
Imports System.Data
Imports Microsoft.Data.SqlClient
#End Region

Public Class clsServ

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetTpServicios() As DataTable
        Return ProcedimientoDatatable("MosTpServ")
    End Function

    Public Function GetServicios() As DataTable
        Dim dt As DataTable = ProcedimientoDatatable("MosServ")
        For Each row As DataRow In dt.Rows
            Dim monto As Double
            If Double.TryParse(row("Monto").ToString(), monto) Then
                row("Monto") = Math.Round(monto, 2)
            Else
                row("Monto") = 0
            End If
        Next
        Return dt
    End Function

    Public Function GetServiciosShrt() As DataTable
        Dim dt As DataTable = ProcedimientoDatatable("MosServShrt")
        For Each row As DataRow In dt.Rows
            Dim monto As Double
            If Double.TryParse(row("Monto").ToString(), monto) Then
                row("Monto") = Math.Round(monto, 2)
            Else
                row("Monto") = 0
            End If
        Next
        Return dt
    End Function

    Public Function GetServiciosCancel() As DataTable
        Dim dt As DataTable = ProcedimientoDatatable("MosBajServ")
        For Each row As DataRow In dt.Rows
            Dim monto As Double
            If Double.TryParse(row("Monto").ToString(), monto) Then
                row("Monto") = Math.Round(monto, 2)
            Else
                row("Monto") = 0
            End If
        Next
        Return dt
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarServicios(serv As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", serv)
    }
        Dim dt As DataTable = ProcedimientoDatatable("BusServ", parametros)
        For Each row As DataRow In dt.Rows
            Dim monto As Double
            If Double.TryParse(row("Monto").ToString(), monto) Then
                row("Monto") = Math.Round(monto, 2)
            Else
                row("Monto") = 0
            End If
        Next
        Return dt
    End Function

    Public Function BuscarServiciosShrt(serv As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", serv)
    }
        Dim dt As DataTable = ProcedimientoDatatable("BusServShrt", parametros)
        For Each row As DataRow In dt.Rows
            Dim monto As Double
            If Double.TryParse(row("Monto").ToString(), monto) Then
                row("Monto") = Math.Round(monto, 2)
            Else
                row("Monto") = 0
            End If
        Next
        Return dt
    End Function

    Public Function BuscarServiciosBaja(serv As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", serv)
    }
        Dim dt As DataTable = ProcedimientoDatatable("BusServBaj", parametros)
        For Each row As DataRow In dt.Rows
            Dim monto As Double
            If Double.TryParse(row("Monto").ToString(), monto) Then
                row("Monto") = Math.Round(monto, 2)
            Else
                row("Monto") = 0
            End If
        Next
        Return dt
    End Function

    Public Function BuscarServicioDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusServDateDes", parametros)
    End Function

    Public Function BuscarServicioDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusServDateHastaDes", parametros)
    End Function

    Public Function BuscarServicioFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusServDate", parametros)
    End Function

    Public Function BuscarServicioFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusServDateHasta", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarProvServ(serv As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodServ", serv)
    }
        Return ProcedimientoDatatable("VerProvModServ", parametros)
    End Function

    Public Function VerificarCombo(usu As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodTpServ", usu)
    }
        Return ProcedimientoDatatable("VerCmbTpServ", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function BajaServicios(id As Integer, id_eliminador As Integer, servicio As eServ) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodServ", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", servicio.MotivoDes)
    }
        Return ProcedimientoBoolean("BajServ", parametros)
    End Function

    Public Function RecServicios(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodServ", id)
    }
        Return ProcedimientoBoolean("RecServ", parametros)
    End Function


    Public Function InsTpServ(servicios As eServ) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Nombre", servicios.NombreTp),
        New SqlParameter("@IdAlta", servicios.IdAltaTp)
    }
        Return ProcedimientoBoolean("InsTpServ", parametros)
    End Function

    Public Function ModTpServ(servicio As eServ) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodTpServ", servicio.CodTpServ),
       New SqlParameter("@Nombre", servicio.NombreTp)
    }
        Return ProcedimientoBoolean("ModTpServ", parametros)
    End Function

    Public Function InsServ(servicios As eServ) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodProv", servicios.CodProv),
        New SqlParameter("@NomServ", servicios.NomServ),
        New SqlParameter("@Monto", servicios.Monto),
        New SqlParameter("@Descrip", servicios.Descripcion),
        New SqlParameter("@CodTpServ", servicios.CodTpServ),
        New SqlParameter("@IdAlta", servicios.IdAlta)
    }
        Return ProcedimientoBoolean("InsServ", parametros)
    End Function

    Public Function ModServ(servicio As eServ) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodServ", servicio.CodServ),
        New SqlParameter("@CodProv", servicio.CodProv),
        New SqlParameter("@NomServ", servicio.NomServ),
        New SqlParameter("@Monto", servicio.Monto),
        New SqlParameter("@Descrip", servicio.Descripcion),
        New SqlParameter("@CodTpServ", servicio.CodTpServ)
    }
        Return ProcedimientoBoolean("ModServ", parametros)
    End Function
#End Region

End Class
