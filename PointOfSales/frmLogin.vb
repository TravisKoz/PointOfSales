Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmSalesWindow As New frmPointOfSale

        'After the valid login is made add this, so the first form goes away.
        Me.Hide()

        'Navigates to the Point of Sale Form
        frmSalesWindow.ShowDialog()
    End Sub
End Class
