'Author: Travis Kozlowski
'Date: 9/15/2022
'Purpose: Manage Transaction Objects

Option Strict On
Option Explicit On

Public Class ClsTransaction

    'Define Class Level Fields
    Private mlstProducts As List(Of ClsProduct)
    Private mdblPrice As Double
    Private mdblTax As Double
    Private mdblTotal As Double

    'Define Class Properties
    Public Property Products As List(Of ClsProduct)
        Get
            Return mlstProducts
        End Get
        Set(value As List(Of ClsProduct))
            mlstProducts = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return mdblPrice
        End Get
        Set(value As Double)
            mdblPrice = value
        End Set
    End Property

    Public Property Tax As Double
        Get
            Return mdblTax
        End Get
        Set(value As Double)
            mdblTax = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return mdblTotal
        End Get
        Set(value As Double)
            mdblTotal = value
        End Set
    End Property
End Class
