<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPointOfSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbxProducts = New System.Windows.Forms.ListBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.btnVoidTransaction = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.gbxSelectedProduct = New System.Windows.Forms.GroupBox()
        Me.lblSelectedCategory = New System.Windows.Forms.Label()
        Me.lblSelectedPrice = New System.Windows.Forms.Label()
        Me.lblSelectedDescription = New System.Windows.Forms.Label()
        Me.lblSelectedProduct = New System.Windows.Forms.Label()
        Me.picProduct = New System.Windows.Forms.PictureBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotalAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblChangeAmount = New System.Windows.Forms.Label()
        Me.txtUPC = New System.Windows.Forms.TextBox()
        Me.lblUPC = New System.Windows.Forms.Label()
        Me.lblCart = New System.Windows.Forms.Label()
        Me.txtProductWeight = New System.Windows.Forms.TextBox()
        Me.dtDoB = New System.Windows.Forms.DateTimePicker()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.gbxSelectedProduct.SuspendLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbxProducts
        '
        Me.lbxProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxProducts.FormattingEnabled = True
        Me.lbxProducts.ItemHeight = 36
        Me.lbxProducts.Location = New System.Drawing.Point(23, 83)
        Me.lbxProducts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbxProducts.Name = "lbxProducts"
        Me.lbxProducts.Size = New System.Drawing.Size(524, 868)
        Me.lbxProducts.TabIndex = 0
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Location = New System.Drawing.Point(593, 225)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(308, 94)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProduct.Location = New System.Drawing.Point(593, 361)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(308, 94)
        Me.btnRemoveProduct.TabIndex = 2
        Me.btnRemoveProduct.Text = "Remove"
        Me.btnRemoveProduct.UseVisualStyleBackColor = True
        '
        'btnVoidTransaction
        '
        Me.btnVoidTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidTransaction.Location = New System.Drawing.Point(593, 497)
        Me.btnVoidTransaction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVoidTransaction.Name = "btnVoidTransaction"
        Me.btnVoidTransaction.Size = New System.Drawing.Size(308, 94)
        Me.btnVoidTransaction.TabIndex = 3
        Me.btnVoidTransaction.Text = "Void"
        Me.btnVoidTransaction.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1454, 1307)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(308, 94)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'gbxSelectedProduct
        '
        Me.gbxSelectedProduct.Controls.Add(Me.lblSelectedCategory)
        Me.gbxSelectedProduct.Controls.Add(Me.lblSelectedPrice)
        Me.gbxSelectedProduct.Controls.Add(Me.lblSelectedDescription)
        Me.gbxSelectedProduct.Controls.Add(Me.lblSelectedProduct)
        Me.gbxSelectedProduct.Controls.Add(Me.picProduct)
        Me.gbxSelectedProduct.Location = New System.Drawing.Point(987, 20)
        Me.gbxSelectedProduct.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.gbxSelectedProduct.Name = "gbxSelectedProduct"
        Me.gbxSelectedProduct.Padding = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.gbxSelectedProduct.Size = New System.Drawing.Size(828, 1071)
        Me.gbxSelectedProduct.TabIndex = 8
        Me.gbxSelectedProduct.TabStop = False
        Me.gbxSelectedProduct.Text = "Product"
        '
        'lblSelectedCategory
        '
        Me.lblSelectedCategory.AutoSize = True
        Me.lblSelectedCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedCategory.Location = New System.Drawing.Point(56, 645)
        Me.lblSelectedCategory.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblSelectedCategory.Name = "lblSelectedCategory"
        Me.lblSelectedCategory.Size = New System.Drawing.Size(179, 44)
        Me.lblSelectedCategory.TabIndex = 4
        Me.lblSelectedCategory.Text = "Category"
        '
        'lblSelectedPrice
        '
        Me.lblSelectedPrice.AutoSize = True
        Me.lblSelectedPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPrice.Location = New System.Drawing.Point(49, 145)
        Me.lblSelectedPrice.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblSelectedPrice.Name = "lblSelectedPrice"
        Me.lblSelectedPrice.Size = New System.Drawing.Size(109, 44)
        Me.lblSelectedPrice.TabIndex = 3
        Me.lblSelectedPrice.Text = "Price"
        '
        'lblSelectedDescription
        '
        Me.lblSelectedDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDescription.Location = New System.Drawing.Point(51, 694)
        Me.lblSelectedDescription.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblSelectedDescription.Name = "lblSelectedDescription"
        Me.lblSelectedDescription.Size = New System.Drawing.Size(763, 348)
        Me.lblSelectedDescription.TabIndex = 2
        Me.lblSelectedDescription.Text = "Description"
        '
        'lblSelectedProduct
        '
        Me.lblSelectedProduct.AutoSize = True
        Me.lblSelectedProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedProduct.Location = New System.Drawing.Point(49, 69)
        Me.lblSelectedProduct.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblSelectedProduct.Name = "lblSelectedProduct"
        Me.lblSelectedProduct.Size = New System.Drawing.Size(155, 44)
        Me.lblSelectedProduct.TabIndex = 1
        Me.lblSelectedProduct.Text = "Product"
        '
        'picProduct
        '
        Me.picProduct.Location = New System.Drawing.Point(65, 223)
        Me.picProduct.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.Size = New System.Drawing.Size(749, 415)
        Me.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProduct.TabIndex = 0
        Me.picProduct.TabStop = False
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(523, 1280)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(516, 120)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(14, 1111)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(198, 44)
        Me.lblSubTotal.TabIndex = 10
        Me.lblSubTotal.Text = "Sub Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(14, 1332)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(118, 44)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(14, 1216)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(96, 44)
        Me.lblTax.TabIndex = 12
        Me.lblTax.Text = "Tax:"
        '
        'lblSubTotalAmount
        '
        Me.lblSubTotalAmount.AutoSize = True
        Me.lblSubTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalAmount.Location = New System.Drawing.Point(226, 1111)
        Me.lblSubTotalAmount.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblSubTotalAmount.Name = "lblSubTotalAmount"
        Me.lblSubTotalAmount.Size = New System.Drawing.Size(118, 44)
        Me.lblSubTotalAmount.TabIndex = 13
        Me.lblSubTotalAmount.Text = "$0.00"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.Location = New System.Drawing.Point(226, 1216)
        Me.lblTaxAmount.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(118, 44)
        Me.lblTaxAmount.TabIndex = 14
        Me.lblTaxAmount.Text = "$0.00"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(226, 1332)
        Me.lblTotalAmount.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(118, 44)
        Me.lblTotalAmount.TabIndex = 15
        Me.lblTotalAmount.Text = "$0.00"
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(523, 1151)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtCash.Multiline = True
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(510, 109)
        Me.txtCash.TabIndex = 16
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(709, 1095)
        Me.lblCash.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(122, 44)
        Me.lblCash.TabIndex = 17
        Me.lblCash.Text = "Cash:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(1104, 1182)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(168, 44)
        Me.lblChange.TabIndex = 18
        Me.lblChange.Text = "Change:"
        '
        'lblChangeAmount
        '
        Me.lblChangeAmount.AutoSize = True
        Me.lblChangeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeAmount.Location = New System.Drawing.Point(1300, 1182)
        Me.lblChangeAmount.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblChangeAmount.Name = "lblChangeAmount"
        Me.lblChangeAmount.Size = New System.Drawing.Size(118, 44)
        Me.lblChangeAmount.TabIndex = 19
        Me.lblChangeAmount.Text = "$0.00"
        '
        'txtUPC
        '
        Me.txtUPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPC.Location = New System.Drawing.Point(593, 83)
        Me.txtUPC.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtUPC.Multiline = True
        Me.txtUPC.Name = "txtUPC"
        Me.txtUPC.Size = New System.Drawing.Size(303, 84)
        Me.txtUPC.TabIndex = 20
        '
        'lblUPC
        '
        Me.lblUPC.AutoSize = True
        Me.lblUPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPC.Location = New System.Drawing.Point(686, 27)
        Me.lblUPC.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblUPC.Name = "lblUPC"
        Me.lblUPC.Size = New System.Drawing.Size(112, 44)
        Me.lblUPC.TabIndex = 21
        Me.lblUPC.Text = "UPC:"
        '
        'lblCart
        '
        Me.lblCart.AutoSize = True
        Me.lblCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCart.Location = New System.Drawing.Point(226, 27)
        Me.lblCart.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(93, 44)
        Me.lblCart.TabIndex = 22
        Me.lblCart.Text = "Cart"
        '
        'txtProductWeight
        '
        Me.txtProductWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductWeight.Location = New System.Drawing.Point(593, 714)
        Me.txtProductWeight.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtProductWeight.Multiline = True
        Me.txtProductWeight.Name = "txtProductWeight"
        Me.txtProductWeight.Size = New System.Drawing.Size(303, 84)
        Me.txtProductWeight.TabIndex = 23
        '
        'dtDoB
        '
        Me.dtDoB.Location = New System.Drawing.Point(432, 1017)
        Me.dtDoB.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.dtDoB.Name = "dtDoB"
        Me.dtDoB.Size = New System.Drawing.Size(464, 35)
        Me.dtDoB.TabIndex = 24
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(686, 658)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(94, 44)
        Me.lblWeight.TabIndex = 25
        Me.lblWeight.Text = "Lbs:"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.Location = New System.Drawing.Point(686, 961)
        Me.lblDateOfBirth.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(106, 44)
        Me.lblDateOfBirth.TabIndex = 26
        Me.lblDateOfBirth.Text = "DoB:"
        '
        'frmPointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1890, 1487)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.dtDoB)
        Me.Controls.Add(Me.txtProductWeight)
        Me.Controls.Add(Me.lblCart)
        Me.Controls.Add(Me.lblUPC)
        Me.Controls.Add(Me.txtUPC)
        Me.Controls.Add(Me.lblChangeAmount)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.lblSubTotalAmount)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.gbxSelectedProduct)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnVoidTransaction)
        Me.Controls.Add(Me.btnRemoveProduct)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.lbxProducts)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPointOfSale"
        Me.ShowInTaskbar = False
        Me.Text = "Point of Sale"
        Me.gbxSelectedProduct.ResumeLayout(False)
        Me.gbxSelectedProduct.PerformLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxProducts As ListBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents btnVoidTransaction As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents gbxSelectedProduct As GroupBox
    Friend WithEvents lblSelectedPrice As Label
    Friend WithEvents lblSelectedDescription As Label
    Friend WithEvents lblSelectedProduct As Label
    Friend WithEvents picProduct As PictureBox
    Friend WithEvents btnPay As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotalAmount As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblCash As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblChangeAmount As Label
    Friend WithEvents txtUPC As TextBox
    Friend WithEvents lblUPC As Label
    Friend WithEvents lblSelectedCategory As Label
    Friend WithEvents lblCart As Label
    Friend WithEvents txtProductWeight As TextBox
    Friend WithEvents dtDoB As DateTimePicker
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblDateOfBirth As Label
End Class
