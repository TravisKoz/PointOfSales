﻿'Authors: Travis Kozlowski
'Date: 09/15/2022
'Code Behind for the Point Of Sales Form

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class frmPointOfSale

    'Define the form's global variables
    'Creates lists for our available products and the selected products.
    Dim mlstAvailableProducts As New List(Of ClsProduct)
    Dim mlstSelectedProducts As New BindingList(Of ClsProduct)


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        'Closes the Point Of Sale Form.
        Me.Close()
    End Sub

    Private Sub frmPointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Loads the Products from the Database
        LoadProducts()

        'Binds our list of selected Products to its repective list box.
        lbxProducts.DataSource = mlstSelectedProducts
        lbxProducts.DisplayMember = "ProductName"

        'Starts the form out focused on the UPC text box.
        txtUPC.Focus()

    End Sub



    Private Sub LoadProducts()

        'Open the Products Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a Command Object
        Dim cmdSelect As New SqlCommand("Select * from Products;", dbConnection)

        'Execute Command into a DataReader
        Dim rdrProduct As SqlDataReader = cmdSelect.ExecuteReader()

        'Reads each record of Products.
        If rdrProduct.HasRows Then
            While rdrProduct.Read()
                Dim objStoredProduct As New ClsProduct()

                'Storing a Product's info.
                objStoredProduct.CodeUPC = CInt(rdrProduct.Item("UPC"))
                objStoredProduct.ProductName = rdrProduct.Item("Name").ToString()
                objStoredProduct.ProductPrice = CDbl(rdrProduct.Item("Price"))
                objStoredProduct.ProductDescription = rdrProduct.Item("Description").ToString()
                objStoredProduct.ProductCategory = rdrProduct.Item("Department").ToString

                'Adds the stored product to the list of available products.
                mlstAvailableProducts.Add(objStoredProduct)

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

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim intEnteredUPC As Integer = CInt(txtUPC.Text)
        Dim objSelectedProduct As New ClsProduct

        'Finds the product in the list of available Products with the entered UPC and stores it as the selected product.
        objSelectedProduct = mlstAvailableProducts.Find(Function(value As ClsProduct)
                                                            Return intEnteredUPC = value.CodeUPC
                                                        End Function)

        'Adds the Selected product to our list of selected products.
        mlstSelectedProducts.Add(objSelectedProduct)

        'Changes the product selected in the list box to the newly added product.
        lbxProducts.SelectedIndex = mlstSelectedProducts.Count - 1

    End Sub

    Private Sub lbxProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxProducts.SelectedIndexChanged
        Dim objSelectedProduct As ClsProduct = CType(lbxProducts.SelectedItem, ClsProduct)
        lblSelectedProduct.Text = objSelectedProduct.ProductName.ToString()
        lblSelectedPrice.Text = "$" & objSelectedProduct.ProductPrice.ToString()
        lblSelectedDescription.Text = objSelectedProduct.ProductDescription.ToString()

    End Sub
End Class
