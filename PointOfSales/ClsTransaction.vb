'Author: Travis Kozlowski
'Date: 9/15/2022
'Purpose: Manage Transaction Objects

Option Strict On
Option Explicit On

Public Class ClsTransaction

    'Define Class Level Fields
    Private mintTransactionID As Integer
    Private mlstProducts As Dictionary(Of ClsProduct, Integer)
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

    Public Property Time As Date
        Get
            Return mdteTime
        End Get
        Set(value As Date)
            mdteTime = value
        End Set
    End Property

    'Public Function CalculateSubTotal(dblDiscount As Double) As Double
    'Dim result As Double

    'For Each pair As KeyValuePair(Of ClsProduct, Integer) In mlstProducts
    'Dim product As ClsProduct = pair.Key
    'Dim qty As Integer = pair.Value

    ' result += product.ProductPrice * qty

    '   Next

    '    Return result * dblDiscount
    'End Function
    Public Function CalculateSubTotal() As Double
        Dim result As Double

        For Each pair As KeyValuePair(Of ClsProduct, Integer) In mlstProducts
            Dim product As ClsProduct = pair.Key
            Dim qty As Integer = pair.Value

            result += product.ProductPrice * qty

        Next

        Return result
    End Function

    Public Function CalculateTax() As Double
        Return CalculateSubTotal() * 0.05
    End Function

    Public Function CalculateTotal() As Double
        Return CalculateSubTotal() + CalculateTax()
    End Function
End Class
