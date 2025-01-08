#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
#End Region

Public Class clsEmp

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetEmpleados() As DataTable
        Return ProcedimientoDatatable("MosEmp")
    End Function

    Public Function GetEmpleadosCancel() As DataTable
        Return ProcedimientoDatatable("MosBajEmp")
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarEmpleados(emp As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", emp)
    }
        Return ProcedimientoDatatable("BusEmp", parametros)
    End Function

    Public Function BuscarEmpleadoBaja(emp As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", emp)
    }
        Return ProcedimientoDatatable("BusEmpBaj", parametros)
    End Function

    Public Function BuscarEmpleadoFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusEmpDate", parametros)
    End Function

    Public Function BuscarEmpleadoFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusEmpDateHasta", parametros)
    End Function

    Public Function BuscarEmpleadoDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusEmpDateDes", parametros)
    End Function

    Public Function BuscarEmpleadoDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusEmpDateHastaDes", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarDNIEmpNuevo(usu As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", usu)
    }
        Return ProcedimientoDatatable("VerDNIEmp", parametros)
    End Function

    Public Function VerificarDNIEmpMod(usu As Integer, empleado As eEmp) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", usu),
        New SqlParameter("@CodEmp", empleado.CodEmp)
    }
        Return ProcedimientoDatatable("VerDNIModEmp", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function BajaEmpleados(id As Integer, id_eliminador As Integer, empleado As eEmp) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodEmp", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", empleado.MotivoDes)
    }
        Return ProcedimientoBoolean("BajEmpUsu", parametros)
    End Function

    Public Function RecEmpleados(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodEmp", id)
    }
        Return ProcedimientoBoolean("RecEmp", parametros)
    End Function

    Public Function InsEmp(empleado As eEmp) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@DNI", empleado.DNI),
        New SqlParameter("@Nombre", empleado.Nombre),
        New SqlParameter("@Apellido", empleado.Apellido),
        New SqlParameter("@Telefono", empleado.Telefono),
        New SqlParameter("@CodPais", empleado.CodPais),
        New SqlParameter("@Email", empleado.Correo),
        New SqlParameter("@Domicilio", empleado.Domicilio),
        New SqlParameter("@IdAlta", empleado.IdAlta)
    }
        Return ProcedimientoBoolean("InsEmp", parametros)
    End Function

    Public Function ModEmp(empleado As eEmp) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodEmp", empleado.CodEmp),
        New SqlParameter("@DNI", empleado.DNI),
        New SqlParameter("@Nombre", empleado.Nombre),
        New SqlParameter("@Apellido", empleado.Apellido),
        New SqlParameter("@Telefono", empleado.Telefono),
        New SqlParameter("@CodPais", empleado.CodPais),
        New SqlParameter("@Email", empleado.Correo),
        New SqlParameter("@Domicilio", empleado.Domicilio)
    }
        Return ProcedimientoBoolean("ModEmp", parametros)
    End Function
#End Region

End Class
