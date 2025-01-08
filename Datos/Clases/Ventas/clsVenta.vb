#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
Imports Microsoft.Identity.Client.TelemetryCore.Internal

#End Region

Public Class clsVenta

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetVentas() As DataTable
        Return ProcedimientoDatatable("MosVent")
    End Function

    Public Function GetDetVentas() As DataTable
        Return ProcedimientoDatatable("MosDetVent")
    End Function

    Public Function GetDetVentasCD() As DataTable
        Return ProcedimientoDatatable("MosDetVentCD")
    End Function

    Public Function GetVentasCD() As DataTable
        Return ProcedimientoDatatable("MosVentCD")
    End Function

    Public Function GetVentasCancel() As DataTable
        Return ProcedimientoDatatable("MosBajVent")
    End Function

    Public Function GetDetVentasCancelCD() As DataTable
        Return ProcedimientoDatatable("MosBajDetVentCD")
    End Function

    Public Function GetVentasCancelCD() As DataTable
        Return ProcedimientoDatatable("MosBajVentCD")
    End Function

    Public Function GetDetVentasCancel() As DataTable
        Return ProcedimientoDatatable("MosBajDetVent")
    End Function

    Public Function CantidadDetVent(vent As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVenta", vent)
    }
        Return ProcedimientoDatatable("CantidadDetVent", parametros)
    End Function

    Public Function Comprobante(vent As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVenta", vent)
    }
        Return ProcedimientoDatatable("MosComprobante", parametros)
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarDetVentaBaja(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusDetVentBaj", parametros)
    End Function

    Public Function BuscarVenta(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusVent", parametros)
    End Function

    Public Function BuscarVentaDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusVentDateDes", parametros)
    End Function

    Public Function BuscarDetVentaDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusDetVentDateDes", parametros)
    End Function

    Public Function BuscarDetVentaDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusDetVentDateHastaDes", parametros)
    End Function

    Public Function BuscarDetVentaServDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusDetVentServDateDes", parametros)
    End Function

    Public Function BuscarDetVentaServDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusDetVentServDateHastaDes", parametros)
    End Function

    Public Function BuscarVentaDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusVentDateHastaDes", parametros)
    End Function

    Public Function BuscarVentaFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusVentDate", parametros)
    End Function

    Public Function BuscarDetVentaFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusDetVentDate", parametros)
    End Function

    Public Function BuscarDetVentaFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusDetVentDateHasta", parametros)
    End Function

    Public Function BuscarDetVentaServFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusDetVentServDate", parametros)
    End Function

    Public Function BuscarDetVentaServFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusDetVentServDateHasta", parametros)
    End Function

    Public Function BuscarVentaFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusVentDateHasta", parametros)
    End Function

    Public Function BuscarDetVenta(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusDetVent", parametros)
    End Function

    Public Function BuscarVentaBaja(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusVentBaj", parametros)
    End Function

    Public Function BuscarCodVentaBaja(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusxDetVentBaj", parametros)
    End Function

    Public Function BuscarCodVenta(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusxDetVent", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarVentDetVent(vent As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodDetVent", vent)
    }
        Return ProcedimientoDatatable("VerVentModDetVent", parametros)
    End Function

    Public Function VerificarVenta(cli As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodCli", cli)
    }
        Return ProcedimientoDatatable("VerificarUltimas5Ventas", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function InsVenta(venta As eVenta) As DataTable
        Dim dt As New DataTable()
        Try
            If Not Conectado() Then
                Return dt
            End If
            Using cmd As New SqlCommand("InsVent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodCli", venta.CodCli)
                cmd.Parameters.AddWithValue("@IdAlta", venta.IdAlta)
                cmd.Parameters.AddWithValue("@CodMoneda", venta.CodMoneda)
                cmd.Parameters.AddWithValue("@CodMedPago", venta.CodMedPago)
                cmd.Parameters.AddWithValue("@NumTransferencia", venta.CodTrans)
                Dim paramCodVenta As New SqlParameter("@CodVenta", SqlDbType.Int)
                paramCodVenta.Direction = ParameterDirection.Output
                cmd.Parameters.Add(paramCodVenta)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        Catch ex As SqlException
            MsgBox("Error de SQL: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Desconectado()
        End Try
        Return dt
    End Function


    Public Function InsDetVent2(venta As eVenta) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVenta", venta.CodVenta),
        New SqlParameter("@CodServ", venta.CodServ),
        New SqlParameter("@FechaServ", venta.FechaServ),
        New SqlParameter("@Observaciones", venta.Observaciones),
        New SqlParameter("@IdAlta", venta.IdAlta),
        New SqlParameter("@Hora", venta.Hora),
        New SqlParameter("@CanPersonas", venta.CanPersonas)
    }
        Return ProcedimientoBoolean("InsDetVent2", parametros)
    End Function

    Public Function InsDetVent(venta As eVenta) As DataTable
        Dim dt As New DataTable()
        Try
            If Not Conectado() Then
                Return dt
            End If
            Using cmd As New SqlCommand("InsDetVent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodVenta", venta.CodVenta)
                cmd.Parameters.AddWithValue("@CodServ", venta.CodServ)
                cmd.Parameters.AddWithValue("@FechaServ", venta.FechaServ)
                cmd.Parameters.AddWithValue("@Observaciones", venta.Observaciones)
                cmd.Parameters.AddWithValue("@IdAlta", venta.IdAlta)
                cmd.Parameters.AddWithValue("@Hora", venta.Hora)
                cmd.Parameters.AddWithValue("@CanPersonas", venta.CanPersonas)
                Dim paramCodVenta As New SqlParameter("@CodDetVenta", SqlDbType.Int)
                paramCodVenta.Direction = ParameterDirection.Output
                cmd.Parameters.Add(paramCodVenta)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        Catch ex As SqlException
            MsgBox("Error de SQL: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Desconectado()
        End Try
        Return dt
    End Function

    Public Function BajaVentas(id As Integer, id_eliminador As Integer, venta As eVenta) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVenta", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", venta.MotivoDes)
    }
        Return ProcedimientoBoolean("BajVentDetVent", parametros)
    End Function

    Public Function RecVentas(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVent", id)
    }
        Return ProcedimientoBoolean("RecVent", parametros)
    End Function

    Public Function BajaDetVentas(id As Integer, id_eliminador As Integer, venta As eVenta) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodDetVent", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", venta.MotivoDes)
    }
        Return ProcedimientoBoolean("BajDetVent", parametros)
    End Function

    Public Function RecDetVentas(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodDetVent", id)
    }
        Return ProcedimientoBoolean("RecDetVent", parametros)
    End Function

    Public Function ModDetVent(venta As eVenta) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodDetVent", venta.CodDetVent),
        New SqlParameter("@CodVenta", venta.CodVenta),
        New SqlParameter("@CodServ", venta.CodServ),
        New SqlParameter("@FechaServ", venta.FechaServ),
        New SqlParameter("@Observaciones", venta.Observaciones),
        New SqlParameter("@Hora", venta.Hora),
        New SqlParameter("@CanPersonas", venta.CanPersonas)
    }
        Return ProcedimientoBoolean("ModDetVent", parametros)
    End Function
#End Region

End Class
