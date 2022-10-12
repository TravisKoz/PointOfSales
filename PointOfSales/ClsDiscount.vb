' Author Brandon Werlein

Option Strict On
Option Explicit On

Public Class ClsDiscount
    Public Shared Function Discount(couponCodeForm As String) As Decimal
        Dim decDiscount As Decimal

        Select Case couponCodeForm
            Case "fiddyCent"
                decDiscount = 0.5D
            Case "April20th"
                decDiscount = 0.42D
            Case "4u25"
                decDiscount = 0.25D
            Case "employeeDiscount"
                decDiscount = 0.17D
            Case Else
                decDiscount = 0.0D
        End Select

        Return decDiscount
    End Function
End Class
