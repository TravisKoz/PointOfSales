
Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class frmLogin

    Dim mListAvailableUsers As New List(Of ClsUser)
    Public objEnteredUser As New ClsUser

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmSalesWindow As New frmPointOfSale

        Dim strEnteredUsername As String = txtUserName.Text.ToString()
        Dim strEnteredPassword As String = txtPassword.Text.ToString()

        Try
            'Finds the user in the list of available users with the entered username and stores it as the selected User.
            objEnteredUser = mListAvailableUsers.Find(Function(value As ClsUser)
                                                          Return strEnteredUsername = value.Username
                                                      End Function)


            If objEnteredUser.Password = strEnteredPassword Then
                ' The entered password matches the password for the entered user

                'Hides the Login Form
                Me.Hide()

                'Navigates to the Point of Sale Form
                frmSalesWindow.ShowDialog()

            Else
                'The entered password doesn't match the password for the entered user
                'Display Invalid Entry Message
                MessageBox.Show("Invalid Username or Password! Please Try Again")

            End If

            ' A Null Reference or another exception was thrown.
        Catch ex As NullReferenceException
            'Display Invalid Entry Message
            MessageBox.Show("Invalid Username or Password! Please Try Again")
        End Try
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
                objStoredUser.IsAdmin = CBool(rdrUser.Item("IsAdmin").ToString())

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


    Private Sub txtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Select()
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub


    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub
End Class