'Author: Travis Kozlowski
'Date: 9/15/2022
'Purpose: Manage Transaction Objects

Option Strict On
Option Explicit On

Public Class ClsTransaction

    'Define Class Level Fields
    Private mintTransactionID As Integer
    Private mlstProducts As Dictionary(Of ClsProduct, Integer)
    Private mdblSubTotal As Double
    Private mdblTax As Double
    Private mdblTotal As Double
    Private mdteTime As Date

    Public Property TransactionID As Integer
        Get
            Return mintTransactionID
        End Get
        Set(value As Integer)
            mintTransactionID = value
        End Set
    End Property

    'Define Class Properties
    Public Property Products As Dictionary(Of ClsProduct, Integer)
        Get
            Return mlstProducts
        End Get
        Set(value As Dictionary(Of ClsProduct, Integer))
            mlstProducts = value
        End Set
    End Property

    Public Property SubTotal As Double
        Get
            Return mdblSubTotal
        End Get
        Set(value As Double)
            mdblSubTotal = value
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

    Public Property Time As Date
        Get
            Return mdteTime
        End Get
        Set(value As Date)
            mdteTime = value
        End Set
    End Property

    Private Function CalculateSubTotal() As Double
        Dim result As Double

        For Each pair As KeyValuePair(Of ClsProduct, Integer) In mlstProducts
            Dim product As ClsProduct = pair.Key
            Dim qty As Integer = pair.Value

            result += product.ProductPrice * qty

        Next

        Return result
    End Function

    Private Function CalculateTax() As Double
        Return CalculateSubTotal() * 0.05
    End Function
End Class
