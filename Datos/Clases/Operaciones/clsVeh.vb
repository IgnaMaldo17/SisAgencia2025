#Region "Imports"
Imports Entidades
Imports System.Data
Imports Microsoft.Data.SqlClient
#End Region

Public Class clsVeh

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetVehiculos() As DataTable
        Return ProcedimientoDatatable("MosVeh")
    End Function

    Public Function GetVehiculosCancel() As DataTable
        Return ProcedimientoDatatable("MosBajVeh")
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarVehiculos(veh As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", veh)
    }
        Return ProcedimientoDatatable("BusVeh", parametros)
    End Function

    Public Function BuscarVehiculosBaja(veh As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", veh)
    }
        Return ProcedimientoDatatable("BusVehBaj", parametros)
    End Function

    Public Function BuscarVehiculoFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusVehDate", parametros)
    End Function

    Public Function BuscarVehiculoFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusVehDateHasta", parametros)
    End Function

    Public Function BuscarVehiculoDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusVehDateDes", parametros)
    End Function

    Public Function BuscarVehiculoDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusVehDateHastaDes", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarChofVeh(veh As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVeh", veh)
    }
        Return ProcedimientoDatatable("VerChofModVeh", parametros)
    End Function

    Public Function VerificarMatriculaNuevo(veh As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Matricula", veh)
    }
        Return ProcedimientoDatatable("VerMatricula", parametros)
    End Function

    Public Function VerificarMatriculaMod(veh As String, vehiculo As eVeh) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Matricula", veh),
        New SqlParameter("@CodVeh", vehiculo.CodVeh)
    }
        Return ProcedimientoDatatable("VerMatriculaMod", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function BajaVehiculos(id As Integer, id_eliminador As Integer, vehiculo As eVeh) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVehiculo", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", vehiculo.MotivoDes)
    }
        Return ProcedimientoBoolean("BajVeh", parametros)
    End Function

    Public Function RecVehiculos(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVeh", id)
    }
        Return ProcedimientoBoolean("RecVeh", parametros)
    End Function

    Public Function InsVeh(vehiculo As eVeh) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodChof", vehiculo.CodChof),
        New SqlParameter("@Modelo", vehiculo.Modelo),
        New SqlParameter("@Matricula", vehiculo.Matricula),
        New SqlParameter("@Capacidad", vehiculo.Capacidad),
        New SqlParameter("@IdAlta", vehiculo.IdAlta)
    }
        Return ProcedimientoBoolean("InsVeh", parametros)
    End Function

    Public Function ModVeh(vehiculo As eVeh) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodVeh", vehiculo.CodVeh),
        New SqlParameter("@CodChof", vehiculo.CodChof),
        New SqlParameter("@Modelo", vehiculo.Modelo),
        New SqlParameter("@Matricula", vehiculo.Matricula),
        New SqlParameter("@Capacidad", vehiculo.Capacidad)
    }
        Return ProcedimientoBoolean("ModVeh", parametros)
    End Function
#End Region

End Class
