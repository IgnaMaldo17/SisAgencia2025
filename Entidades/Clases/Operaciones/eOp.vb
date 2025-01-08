#Region "Imports"
Imports System.Data.SqlTypes
#End Region

Public Class eOp

#Region "Propiedades"
    Public Property CodOp As Integer
    Public Property CodVehiculo As Integer
    Public Property CodChof As Integer
    Public Property Aclaracion As String
    Public Property Valor As SqlMoney
    Public Property FechaAlta As Date
    Public Property FechaBaja As Date
    Public Property IdBaja As Integer
    Public Property IdAlta As Integer
    Public Property FechaOp As String
    Public Property HoraOp As String
    Public Property FechaOpFrmOp As Date
    Public Property HoraOpFrmOp As Date
    Public Property Pasajeros As Integer
    Public Property CodDetVenta As Integer
    Public Property MotivoDes As String
#End Region

End Class
