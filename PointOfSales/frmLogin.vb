Imports System.Data.SqlClient

Public Class frmLogin

    Dim mListAvailableUsers As New List(Of ClsUser)

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmSalesWindow As New frmPointOfSale

        'Hides the Login Form
        Me.Hide()

        'Navigates to the Point of Sale Form
        frmSalesWindow.ShowDialog()

    End Sub

    Private Sub LoadUsers()

        'Open the Products Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a Command Object
        Dim cmdSelect As New SqlCommand("Select * from Users;", dbConnection)

        'Execute Command into a DataReader
        Dim rdrUser As SqlDataReader = cmdSelect.ExecuteReader()

        'Reads each record of Products.
        If rdrUser.HasRows Then
            While rdrUser.Read()
                Dim objStoredUser As New ClsUser()

                'Storing a User's info.
                objStoredUser.Username = rdrUser.Item("Username").ToString()
                objStoredUser.Password = rdrUser.Item("Password").ToString()

                'Adds the stored product to the list of available products.
                mListAvailableUsers.Add(objStoredUser)
            End While
        End If

        'Close and dipose the database connection.
        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Function OpenDBConnection() As SqlConnection
        'Create a connection string
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)

        Dim strConnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFileName=" + strPath + "dboProducts.mdf"

        'Create a Connection Object
        Dim dbConnection As New SqlConnection(strConnection)

        Try
            'Open Database
            dbConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return dbConnection
    End Function

End Class
