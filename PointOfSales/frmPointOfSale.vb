'Authors: Travis Kozlowski
'Date: 09/15/2022
'Code Behind for the Point Of Sales Form

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class frmPointOfSale

#Region "Global Variables and Constants"
    'Define the form's global variables
    'Creates lists for our available products and the selected products.
    Dim mlstAvailableProducts As New List(Of ClsProduct)
    Dim mlstCart As New BindingList(Of ClsProduct)
    Dim mobjCurrentTransaction As New ClsTransaction

#End Region

#Region "On Load"
    Private Sub frmPointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Loads the Products from the Database
        LoadProducts()

        'Binds our list of selected Products to its repective list box.
        lbxProducts.DataSource = mlstCart
        lbxProducts.DisplayMember = "ProductName"

        'Don't think we need anymore
        'Sets the current transaction SubTotal, Tax, and Total to 0.00.
        'ResetTransaction()

        'Starts a list of products for our current transaction.
        mobjCurrentTransaction.Products = New Dictionary(Of ClsProduct, Integer)

        RemoveProductDescription()

        'Disables the Remove, Void, and Pay buttons on load.
        ToggleButtonUse(False)


        'Enables the Transaction button if the user is admin
        If frmLogin.objEnteredUser.IsAdmin = True Then
            btnTransactions.Enabled = True
        End If

        'Starts the form out focused on the UPC text box.
        txtUPC.Focus()
    End Sub
#End Region

#Region "Selected Index Changed"
    Private Sub lbxProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxProducts.SelectedIndexChanged
        Dim objSelectedProduct As ClsProduct = CType(lbxProducts.SelectedItem, ClsProduct)

        'Updates the descrition when a product in the cart is selected.
        If lbxProducts.SelectedIndex > -1 Then
            lblSelectedProduct.Text = objSelectedProduct.ProductName.ToString() & vbCrLf & "Qty " & mobjCurrentTransaction.Products(objSelectedProduct).ToString()
            lblSelectedPrice.Text = "Price per Unit " & objSelectedProduct.ProductPrice.ToString("C")
            lblSelectedCategory.Text = objSelectedProduct.ProductCategory.ToString()
            lblSelectedDescription.Text = objSelectedProduct.ProductDescription.ToString()

            If File.Exists("../../Images/" & objSelectedProduct.ProductName.ToString() & “.png") Then
                picProduct.Image = Image.FromFile("../../Images/" & objSelectedProduct.ProductName.ToString() & “.png")
            Else
                picProduct.Image = Image.FromFile("../../Images/No image.png")

            End If
        End If
    End Sub

#End Region

#Region "Click Handlers"
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim intEnteredUPC As Integer
        Dim objSelectedProduct As New ClsProduct
        Dim blnIsValidWeight As Boolean = True
        Dim blnIsUnderAge As Boolean = False


        Dim intEnteredQty As Integer


        Dim blnIsValidIdInteger = Integer.TryParse(txtUPC.Text, intEnteredUPC)
        Dim blnIsValidIdIntegerQty = Integer.TryParse(QuantityTextBox.Text, intEnteredQty)


        If blnIsValidIdIntegerQty Then
            If intEnteredQty > 0 Then  'And intEnteredQty IsNot vbEmpty

                If blnIsValidIdInteger Then
                    'UPC entered was an Integer
                    If intEnteredUPC > 0 And intEnteredUPC <= mlstAvailableProducts.Count Then
                        'Entered UPC was in the range of valid UPC's.

                        'Finds the product in the list of available Products with the entered UPC and stores it as the selected product.
                        objSelectedProduct = mlstAvailableProducts.Find(Function(value As ClsProduct)
                                                                            Return intEnteredUPC = value.CodeUPC
                                                                        End Function)

                        objSelectedProduct.ProductPrice = objSelectedProduct.ProductPrice



                        If objSelectedProduct.PayByWeight = True Then
                            Dim dblEnteredWeight As Double = 0.00


                            blnIsValidWeight = Double.TryParse(InputBox("Enter the product's weight?", "lbs:"), dblEnteredWeight)

                            If blnIsValidWeight = False Then
                                MessageBox.Show("Please enter a valid weight for this product")

                            Else
                                objSelectedProduct.ProductPrice = dblEnteredWeight * objSelectedProduct.PricePerPound


                            End If

                        End If

                        If objSelectedProduct.IsRestricted = True Then
                            Dim dteDateOfBirth As Date = dtDoB.Value
                            Dim TwentyFirstBirthday As Date = dteDateOfBirth.AddYears(21)

                            If Date.Now < TwentyFirstBirthday Then
                                blnIsUnderAge = True
                                MessageBox.Show("Customer is underage.")
                            End If
                        End If

                        If blnIsValidWeight = True And blnIsUnderAge = False Then


                            If mobjCurrentTransaction.Products.ContainsKey(objSelectedProduct) Then
                                mobjCurrentTransaction.Products.Item(objSelectedProduct) += intEnteredQty

                            Else

                                'Adds the Selected product to our list of selected products.
                                mlstCart.Add(objSelectedProduct)

                                'Update the current transaction based on the newly added product.
                                mobjCurrentTransaction.Products.Add(objSelectedProduct, intEnteredQty)

                            End If


                            'Allows the selected index to update when the first Product is added to the cart.
                            lbxProducts.SelectedIndex = -1

                            'Changes the product selected in the list box to the newly added product.
                            lbxProducts.SelectedIndex = mlstCart.Count - 1

                            'Updates displayed SubTotal, Tax, and Total
                            UpdateDisplayedTotals()

                            'Enables the remove, void, and pay buttons.
                            ToggleButtonUse(True)

                            'Changes the change label back to zero if starting a new transaction.
                            lblChangeAmount.Text = ("$0.00")

                        End If


                        ResetBoxes()

                    Else


                        'Entered UPC wasn't in the range of valid UPC's.
                        MessageBox.Show("Invalid UPC please enter in a valid UPC in the range of 1 - " & mlstAvailableProducts.Count.ToString())

                    End If

                    'After an item is added put focus and empty the UPC text box
                    txtUPC.Text = String.Empty

                    txtUPC.Focus()


                Else
                    'UPC entered wasn't an integer.
                    MessageBox.Show("UPC must be an integer value. Please try again.")

                End If


            Else

                'Quantity entered is not greater than 0

                MsgBox("Please enter a possitive number for Quantity of items", MsgBoxStyle.OkOnly, "Quantity Incorrect!")

            End If

        Else
            'Quantity entered wasn't an integer.
            MsgBox("Please enter correct quantity of items", MsgBoxStyle.OkOnly, "Quantity Incorrect!")


        End If


    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        Dim intCurrentSelectedProduct As Integer = lbxProducts.SelectedIndex
        Dim objSelectedProduct As ClsProduct = CType(lbxProducts.SelectedItem, ClsProduct)
        Dim strCurrentSelectedProductName As String = mlstCart.Item(intCurrentSelectedProduct).ProductName
        Dim intNewSelectedProduct As Integer = intCurrentSelectedProduct - 1
        Dim dblCurrentSelectedPrice As Double = mlstCart.ElementAt(intCurrentSelectedProduct).ProductPrice

        'Update the current transaction based on the newly added product.
        mobjCurrentTransaction.Products.Remove(objSelectedProduct)

        'Removes the item from the cart
        mlstCart.RemoveAt(intCurrentSelectedProduct)

        If intNewSelectedProduct = -1 Then
            'The first product in the cart was removed

            'Allows the selected index to updated after the first item was removed
            lbxProducts.SelectedIndex = -1
        Else
            'Changes the selected item in the cart
            lbxProducts.SelectedIndex = intNewSelectedProduct
        End If

        'If the cart is empty reset the product description
        'to nothing and disable buttons.
        If mlstCart.Count <= 0 Then
            RemoveProductDescription()

            ToggleButtonUse(False)

        End If

        'Updates displayed SubTotal, Tax, and tax
        UpdateDisplayedTotals()

        MessageBox.Show(strCurrentSelectedProductName & " has been removed from your cart.")
    End Sub

    Private Sub btnVoidTransaction_Click(sender As Object, e As EventArgs) Handles btnVoidTransaction.Click

        'Voids the entire cart
        mlstCart.Clear()

        'Don't Think we need anymore
        'Sets the current transaction SubTotal, Tax, and Total to 0.00.
        'ResetTransaction()

        'Clears all products out of the current transaction
        mobjCurrentTransaction.Products.Clear()

        'Updates displayed SubTotal, Tax, and tax
        UpdateDisplayedTotals()

        'Resets Displayed Product Desription to Nothing
        RemoveProductDescription()

        'Disables the remove, void, and pay buttons
        ToggleButtonUse(False)

        'Displays a message letting the user know that
        'the transaction has been void.
        MessageBox.Show("Your transaction has been voided.")
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        'Cash given variables
        Dim dblPayedCash As Double
        'Dim dblDiscount As Double
        Dim blnIsValidIdDouble = Double.TryParse(txtCash.Text, dblPayedCash)

        If blnIsValidIdDouble Then
            Dim decDiscount As Decimal = ClsDiscount.Discount(InputBox("Do you have a coupon code?", "Discount Code:"))
            'The entered cash value is a double.
            If dblPayedCash >= mobjCurrentTransaction.CalculateTotal(decDiscount) Then

                ' mobjDiscount.DiscountCode = mobjDiscount.CouponCode()


                ' Coupon code is  promted then saved as a discount
                'dblDiscount = CouponCode()

                ' Dicount is applied
                'mobjCurrentTransaction.Total = mobjCurrentTransaction.Total * dblDiscount
                ' mobjCurrentTransaction.SubTotal = mobjCurrentTransaction.SubTotal * dblDiscount
                'mobjCurrentTransaction.Tax = mobjCurrentTransaction.Tax * dblDiscount

                Dim dbConnection As SqlConnection = OpenDBConnection()

                'Create a Command Object
                Dim cmdInsertTransaction As New SqlCommand("INSERT INTO Transactions(Time) values('" & Date.Now & "');", dbConnection)


                cmdInsertTransaction.ExecuteReader()

                dbConnection.Close()
                dbConnection.Open()

                ' Returns the newly created transaction ID
                Dim cmdGetTransactionID As New SqlCommand("SELECT * FROM Transactions WHERE TransactionID=(SELECT max(TransactionID) FROM Transactions);", dbConnection)

                mobjCurrentTransaction.TransactionID = CInt(cmdGetTransactionID.ExecuteScalar())

                dbConnection.Close()

                ' Loops through each product purchased and adds the quantity to the transaction_product intersection table.
                For Each pair As KeyValuePair(Of ClsProduct, Integer) In mobjCurrentTransaction.Products

                    dbConnection.Open()

                    Dim product As ClsProduct = pair.Key
                    Dim qty As Integer = pair.Value

                    'Dim cmdInsertTransProd As New SqlCommand("INSERT INTO Transaction_Product(TransactionID, UPC, Quantity, Discount) values('" & mobjCurrentTransaction.TransactionID & "', '" & product.CodeUPC & "', '" & qty & "', '" & dblDiscount & "');", dbConnection)
                    Dim cmdInsertTransProd As New SqlCommand("INSERT INTO Transaction_Product(TransactionID, UPC, Quantity) values('" & mobjCurrentTransaction.TransactionID & "', '" & product.CodeUPC & "', '" & qty & "');", dbConnection)

                    cmdInsertTransProd.ExecuteReader()

                    dbConnection.Close()


                Next

                dbConnection.Dispose()

                'Change the displayed change.
                lblChangeAmount.Text = (dblPayedCash - (mobjCurrentTransaction.CalculateTotal(decDiscount))).ToString("C")

                'Start a new transaction
                RemoveProductDescription()
                UpdateDisplayedTotals()
                mobjCurrentTransaction.Products.Clear()
                mlstCart.Clear()
                ResetAmounts()

                txtCash.Text = ""
            Else

                MessageBox.Show("Insufficient Funds")
            End If

        Else
            MessageBox.Show("Please enter a valid cash amount.")
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        'Closes the Point Of Sale Form.
        Me.Close()

        'Shows the Login Form
        frmLogin.Show()

        'Clears the previous username and password
        'used to login.
        frmLogin.txtUserName.Clear()
        frmLogin.txtPassword.Clear()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        'Creates a message Box giving a statement
        MessageBox.Show("Currently under development")
    End Sub
#End Region

#Region "Database Functions"
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
                objStoredProduct.ProductCategory = rdrProduct.Item("Department").ToString()
                objStoredProduct.PayByWeight = CType(rdrProduct.Item("PayByWeight"), Boolean)
                objStoredProduct.PricePerPound = CDbl(rdrProduct.Item("PricePerPound"))
                objStoredProduct.IsRestricted = CType(rdrProduct.Item("IsRestricted"), Boolean)


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
#End Region

#Region "Helper Functions"


    Private Sub ResetAmounts()
        'Sets the current transaction SubTotal, Tax, and Total to 0.00.
        lblSubTotalAmount.Text = "$0.00"
        lblTaxAmount.Text = "$0.00"
        lblTotalAmount.Text = "$0.00"

    End Sub

    Private Sub UpdateDisplayedTotals()
        'Updates displayed SubTotal, Tax, and Total
        'lblSubTotalAmount.Text = mobjCurrentTransaction.CalculateSubTotal(dblDiscountAmount).ToString("C")
        lblSubTotalAmount.Text = mobjCurrentTransaction.CalculateSubTotal().ToString("C")
        lblTaxAmount.Text = mobjCurrentTransaction.CalculateTax.ToString("C")
        lblTotalAmount.Text = mobjCurrentTransaction.CalculateTotal(0.0D).ToString("C")
    End Sub

    Private Sub RemoveProductDescription()
        'Resets Displayed Product Desription to Nothing
        lblSelectedProduct.Text = String.Empty
        lblSelectedPrice.Text = String.Empty
        lblSelectedCategory.Text = String.Empty
        lblSelectedDescription.Text = String.Empty
        picProduct.Image = Nothing
    End Sub


    ' Reset boxes
    Private Sub ResetBoxes()
        QuantityTextBox.Text = "1"

    End Sub


    Private Sub ToggleButtonUse(ByVal blnEnabled As Boolean)
        'Toggles buttons based on passed in boolean value
        btnRemoveProduct.Enabled = blnEnabled
        btnVoidTransaction.Enabled = blnEnabled
        btnPay.Enabled = blnEnabled
    End Sub


    ' Funtion the adds products by presing the return/enter key
    Private Sub txtUPC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUPC.KeyDown

        If e.KeyCode = Keys.Enter Then
            QuantityTextBox.Select()

        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub


    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuantityTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddProduct_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPay_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub




#End Region
End Class


