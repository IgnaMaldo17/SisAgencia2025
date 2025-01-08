#Region "Imports"
Imports Entidades
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Azure

#End Region

Public Class clsOp

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetOperaciones() As DataTable
        Return ProcedimientoDatatable("MosOp")
    End Function

    Public Function GetOperacionesCD() As DataTable
        Return ProcedimientoDatatable("MosOpCD")
    End Function

    Public Function GetOperacionesCDPanel() As DataTable
        Return ProcedimientoDatatable("MosOpCDPnl")
    End Function

    Public Function GetDetVentNoOp() As DataTable
        Return ProcedimientoDatatable("MosDetVentNoOp")
    End Function

    Public Function GetOperacionesCancel() As DataTable
        Return ProcedimientoDatatable("MosBajOp")
    End Function

    Public Function GetOperacionesCancelCD() As DataTable
        Return ProcedimientoDatatable("MosBajOpCD")
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarDetVentNoOp(op As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", op)
    }
        Return ProcedimientoDatatable("BusDetVentNoOp", parametros)
    End Function

    Public Function BuscarOpBaja(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusOpBaj", parametros)
    End Function

    Public Function BuscarOp(op As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", op)
    }
        Return ProcedimientoDatatable("BusOp", parametros)
    End Function

    Public Function BuscarOperacionDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusOpDateDes", parametros)
    End Function

    Public Function BuscarOperacionDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusOpDateHastaDes", parametros)
    End Function

    Public Function BuscarOperacionServDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusOpServDateDes", parametros)
    End Function

    Public Function BuscarOperacionServDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusOpServDateHastaDes", parametros)
    End Function

    Public Function BuscarOperacionFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusOpDate", parametros)
    End Function

    Public Function BuscarOperacionFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusOpDateHasta", parametros)
    End Function

    Public Function BuscarOperacionServFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusOpServDate", parametros)
    End Function

    Public Function BuscarOperacionServFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusOpServDateHasta", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarOpDetVent(op As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodOp", op)
    }
        Return ProcedimientoDatatable("VerDetVentModOp", parametros)
    End Function

    Public Function VerificarTotalOperacionesSiguienteSemana() As Integer
        Dim resultado As Object = ProcedimientoInteger("CountOperationsNextWeek")
        If resultado IsNot Nothing Then
            Return Convert.ToInt32(resultado)
        Else
            Return 0
        End If
    End Function
#End Region

#Region "ABM"
    Public Function InsOp(operacion As eOp) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodDetVenta", operacion.CodDetVenta),
        New SqlParameter("@Aclaracion", operacion.Aclaracion),
        New SqlParameter("@Valor", operacion.Valor),
        New SqlParameter("@FechaOp", operacion.FechaOp),
        New SqlParameter("@HoraOp", operacion.HoraOp),
        New SqlParameter("@Pasajeros", operacion.Pasajeros),
        New SqlParameter("@IdAlta", operacion.IdAlta)
    }
        Return ProcedimientoBoolean("InsOp", parametros)
    End Function

    Public Function InsOp2(operacion As eOp) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodDetVenta", operacion.CodDetVenta),
        New SqlParameter("@Aclaracion", operacion.Aclaracion),
        New SqlParameter("@Valor", operacion.Valor),
        New SqlParameter("@FechaOp", operacion.FechaOp),
        New SqlParameter("@HoraOp", operacion.HoraOp),
        New SqlParameter("@Pasajeros", operacion.Pasajeros),
        New SqlParameter("@IdAlta", operacion.IdAlta),
        New SqlParameter("@CodChof", operacion.CodChof),
        New SqlParameter("@CodVehiculo", operacion.CodVehiculo)
    }
        Return ProcedimientoBoolean("InsOp2", parametros)
    End Function

    Public Function BajaOperaciones(id As Integer, id_eliminador As Integer, operacion As eOp) As Boolean 'IMPORTANTE
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodOp", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", operacion.MotivoDes)
    }
        Return ProcedimientoBoolean("BajOp", parametros)
    End Function

    Public Function RecOperaciones(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodOp", id)
    }
        Return ProcedimientoBoolean("RecOp", parametros)
    End Function

    Public Function ModOp(op As eOp) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodOp", op.CodOp),
        New SqlParameter("@CodDetVenta", op.CodDetVenta),
        New SqlParameter("@Aclaracion", op.Aclaracion),
        New SqlParameter("@Valor", op.Valor),
        New SqlParameter("@FechaOp", op.FechaOp),
        New SqlParameter("@HoraOp", op.HoraOp),
        New SqlParameter("@Pasajeros", op.Pasajeros),
        New SqlParameter("@CodChof", op.CodChof),
        New SqlParameter("@CodVehiculo", op.CodVehiculo)
    }
        Return ProcedimientoBoolean("ModOp", parametros)
    End Function
#End Region

End Class
