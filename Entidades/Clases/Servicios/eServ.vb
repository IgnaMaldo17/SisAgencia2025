#Region "Imports"
Imports System.Data.SqlTypes
#End Region

Public Class eServ

#Region "Propiedades"
    Public Property CodServ As Integer
    Public Property CodProv As Integer
    Public Property NombreTp As String
    Public Property NomServ As String
    Public Property Monto As SqlMoney
    Public Property Descripcion As String
    Public Property FechaAlta As Date
    Public Property FechaBaja As Date
    Public Property IdBaja As Integer
    Public Property IdAltaTp As Integer
    Public Property IdAlta As Integer
    Public Property CodTpServ As Integer
    Public Property RSProveedor As String
    Public Property MotivoDes As String
#End Region

End Class
