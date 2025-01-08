#Region "Imports"
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Entidades
Imports System.Data.SqlTypes
#End Region

Public Class clsUsu

#Region "Inherits"
    Inherits clsConexion
#End Region

#Region "Mostrar"
    Public Function GetLogin(usu As String, pas As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@NomUsu", usu),
        New SqlParameter("@Password", pas)
    }
        Return ProcedimientoDatatable("Login", parametros)
    End Function

    Public Function GetUsuarios() As DataTable
        Return ProcedimientoDatatable("MosUsu")
    End Function

    Public Function GetCotizacion() As DataTable
        Return ProcedimientoDatatable("MosCot")
    End Function

    Public Function GetTpUsuarios() As DataTable
        Return ProcedimientoDatatable("MosTpUsu")
    End Function

    Public Function GetUsuariosCancel() As DataTable
        Return ProcedimientoDatatable("MosBajUsu")
    End Function

    Public Function GetFav(id As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodUsu", id)
    }
        Return ProcedimientoDatatable("MosFav", parametros)
    End Function
#End Region

#Region "Buscar"
    Public Function BuscarUsuarios(usu As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", usu)
    }
        Return ProcedimientoDatatable("BusUsu", parametros)
    End Function

    Public Function BuscarUsuarioBaja(usu As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", usu)
    }
        Return ProcedimientoDatatable("BusUsuBaj", parametros)
    End Function

    Public Function BuscarUsuarioDesFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusUsuDateDes", parametros)
    End Function

    Public Function BuscarUsuarioDesFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusUsuDateHastaDes", parametros)
    End Function

    Public Function BuscarUsuarioFecha(vent As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Busqueda", vent)
    }
        Return ProcedimientoDatatable("BusUsuDate", parametros)
    End Function

    Public Function BuscarUsuarioFechaHasta(desde As String, hasta As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@BusquedaDesde", desde),
        New SqlParameter("@BusquedaHasta", hasta)
    }
        Return ProcedimientoDatatable("BusUsuDateHasta", parametros)
    End Function
#End Region

#Region "Verificar"
    Public Function VerificarEmpUsu(usu As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodUsu", usu)
    }
        Return ProcedimientoDatatable("VerEmpModUsu", parametros)
    End Function

    Public Function VerificarUsuario(usu As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@NomUsu", usu)
    }
        Return ProcedimientoDatatable("VerificarUsu", parametros)
    End Function

    Public Function VerificarContraseña(usu As String, pas As String) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@NomUsu", usu),
        New SqlParameter("@Password", pas)
    }
        Return ProcedimientoDatatable("VerConMod", parametros)
    End Function

    Public Function VerificarComboTpUsu(usu As Integer) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodTpUsu", usu)
    }
        Return ProcedimientoDatatable("VerCmbTpUsu", parametros)
    End Function

    Public Function VerificarUsuMod(usu As String, usuario As eUsu) As DataTable
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@NomUsu", usu),
        New SqlParameter("@CodUsu", usuario.CodUsu)
    }
        Return ProcedimientoDatatable("VerUsuMod", parametros)
    End Function
#End Region

#Region "ABM"
    Public Function BajaUsuario(id As Integer, id_eliminador As Integer, usuario As eUsu) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodUsu", id),
        New SqlParameter("@IdBaja", id_eliminador),
        New SqlParameter("@MotivoDes", usuario.MotivoDes)
    }
        Return ProcedimientoBoolean("BajUsu", parametros)
    End Function

    Public Function RecUsuarios(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodUsu", id)
    }
        Return ProcedimientoBoolean("RecUsu", parametros)
    End Function

    Public Function ModUsu(usuario As eUsu) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodUsu", usuario.CodUsu),
        New SqlParameter("@NomUsu", usuario.NomUsu),
        New SqlParameter("@CodTpUsu", usuario.CodTpUsu)
    }
        Return ProcedimientoBoolean("ModUsu", parametros)
    End Function

    Public Function ModCotizacion(id As Integer, val As SqlMoney) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodMoneda", id),
        New SqlParameter("@Valor", val)
    }
        Return ProcedimientoBoolean("ModCot", parametros)
    End Function

    Public Function FavoritosModIns(id As Integer, cform As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodForm", cform),
        New SqlParameter("@CodUsu", id)
    }
        Return ProcedimientoBoolean("FavoritosModIns", parametros)
    End Function

    Public Function FavoritosDel(id As Integer) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodUsu", id)
    }
        Return ProcedimientoBoolean("FavoritosDel", parametros)
    End Function

    Public Function ModConADMIN(usuario As eUsu) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@NomUsu", usuario.NomUsu),
        New SqlParameter("@Password", usuario.Password)
    }
        Return ProcedimientoBoolean("CambiarPassADMIN", parametros)
    End Function

    Public Function ModCon(usuario As eUsu, usu As String) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@NomUsu", usuario.NomUsu),
        New SqlParameter("@Password2", usuario.Password),
        New SqlParameter("@Password", usu)
    }
        Return ProcedimientoBoolean("CambiarPass", parametros)
    End Function

    Public Function InsUsu(usuario As eUsu) As Boolean
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@CodEmp", usuario.CodEmp),
        New SqlParameter("@NomUsu", usuario.NomUsu),
        New SqlParameter("@Password", usuario.Password),
        New SqlParameter("@CodTpUsu", usuario.CodTpUsu),
        New SqlParameter("@IdAlta", usuario.IdAlta)
    }
        Return ProcedimientoBoolean("InsUsu", parametros)
    End Function
#End Region

End Class
