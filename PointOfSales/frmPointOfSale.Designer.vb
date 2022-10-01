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
        Me.gbxSelectedProduct.SuspendLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbxProducts
        '
        Me.lbxProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxProducts.FormattingEnabled = True
        Me.lbxProducts.ItemHeight = 29
        Me.lbxProducts.Location = New System.Drawing.Point(18, 68)
        Me.lbxProducts.Margin = New System.Windows.Forms.Padding(2)
        Me.lbxProducts.Name = "lbxProducts"
        Me.lbxProducts.Size = New System.Drawing.Size(413, 787)
        Me.lbxProducts.TabIndex = 0
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Location = New System.Drawing.Point(466, 186)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(242, 78)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProduct.Location = New System.Drawing.Point(466, 299)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(242, 78)
        Me.btnRemoveProduct.TabIndex = 2
        Me.btnRemoveProduct.Text = "Remove"
        Me.btnRemoveProduct.UseVisualStyleBackColor = True
        '
        'btnVoidTransaction
        '
        Me.btnVoidTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidTransaction.Location = New System.Drawing.Point(466, 412)
        Me.btnVoidTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVoidTransaction.Name = "btnVoidTransaction"
        Me.btnVoidTransaction.Size = New System.Drawing.Size(242, 78)
        Me.btnVoidTransaction.TabIndex = 3
        Me.btnVoidTransaction.Text = "Void"
        Me.btnVoidTransaction.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1142, 1082)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(242, 78)
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
        Me.gbxSelectedProduct.Location = New System.Drawing.Point(776, 17)
        Me.gbxSelectedProduct.Margin = New System.Windows.Forms.Padding(6)
        Me.gbxSelectedProduct.Name = "gbxSelectedProduct"
        Me.gbxSelectedProduct.Padding = New System.Windows.Forms.Padding(6)
        Me.gbxSelectedProduct.Size = New System.Drawing.Size(651, 886)
        Me.gbxSelectedProduct.TabIndex = 8
        Me.gbxSelectedProduct.TabStop = False
        Me.gbxSelectedProduct.Text = "Product"
        '
        'lblSelectedCategory
        '
        Me.lblSelectedCategory.AutoSize = True
        Me.lblSelectedCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedCategory.Location = New System.Drawing.Point(44, 534)
        Me.lblSelectedCategory.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSelectedCategory.Name = "lblSelectedCategory"
        Me.lblSelectedCategory.Size = New System.Drawing.Size(139, 35)
        Me.lblSelectedCategory.TabIndex = 4
        Me.lblSelectedCategory.Text = "Category"
        '
        'lblSelectedPrice
        '
        Me.lblSelectedPrice.AutoSize = True
        Me.lblSelectedPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPrice.Location = New System.Drawing.Point(38, 120)
        Me.lblSelectedPrice.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSelectedPrice.Name = "lblSelectedPrice"
        Me.lblSelectedPrice.Size = New System.Drawing.Size(86, 35)
        Me.lblSelectedPrice.TabIndex = 3
        Me.lblSelectedPrice.Text = "Price"
        '
        'lblSelectedDescription
        '
        Me.lblSelectedDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDescription.Location = New System.Drawing.Point(40, 574)
        Me.lblSelectedDescription.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSelectedDescription.Name = "lblSelectedDescription"
        Me.lblSelectedDescription.Size = New System.Drawing.Size(600, 288)
        Me.lblSelectedDescription.TabIndex = 2
        Me.lblSelectedDescription.Text = "Description"
        '
        'lblSelectedProduct
        '
        Me.lblSelectedProduct.AutoSize = True
        Me.lblSelectedProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedProduct.Location = New System.Drawing.Point(38, 57)
        Me.lblSelectedProduct.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSelectedProduct.Name = "lblSelectedProduct"
        Me.lblSelectedProduct.Size = New System.Drawing.Size(122, 35)
        Me.lblSelectedProduct.TabIndex = 1
        Me.lblSelectedProduct.Text = "Product"
        '
        'picProduct
        '
        Me.picProduct.Location = New System.Drawing.Point(51, 185)
        Me.picProduct.Margin = New System.Windows.Forms.Padding(6)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.Size = New System.Drawing.Size(588, 343)
        Me.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProduct.TabIndex = 0
        Me.picProduct.TabStop = False
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(411, 1060)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(405, 100)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(11, 919)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(156, 35)
        Me.lblSubTotal.TabIndex = 10
        Me.lblSubTotal.Text = "Sub Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(11, 1102)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(93, 35)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(11, 1006)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(75, 35)
        Me.lblTax.TabIndex = 12
        Me.lblTax.Text = "Tax:"
        '
        'lblSubTotalAmount
        '
        Me.lblSubTotalAmount.AutoSize = True
        Me.lblSubTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalAmount.Location = New System.Drawing.Point(178, 919)
        Me.lblSubTotalAmount.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSubTotalAmount.Name = "lblSubTotalAmount"
        Me.lblSubTotalAmount.Size = New System.Drawing.Size(92, 35)
        Me.lblSubTotalAmount.TabIndex = 13
        Me.lblSubTotalAmount.Text = "$0.00"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.Location = New System.Drawing.Point(178, 1006)
        Me.lblTaxAmount.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(92, 35)
        Me.lblTaxAmount.TabIndex = 14
        Me.lblTaxAmount.Text = "$0.00"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(178, 1102)
        Me.lblTotalAmount.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(92, 35)
        Me.lblTotalAmount.TabIndex = 15
        Me.lblTotalAmount.Text = "$0.00"
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(411, 953)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCash.Multiline = True
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(402, 91)
        Me.txtCash.TabIndex = 16
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(557, 906)
        Me.lblCash.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(96, 35)
        Me.lblCash.TabIndex = 17
        Me.lblCash.Text = "Cash:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(867, 978)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(131, 35)
        Me.lblChange.TabIndex = 18
        Me.lblChange.Text = "Change:"
        '
        'lblChangeAmount
        '
        Me.lblChangeAmount.AutoSize = True
        Me.lblChangeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeAmount.Location = New System.Drawing.Point(1021, 978)
        Me.lblChangeAmount.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblChangeAmount.Name = "lblChangeAmount"
        Me.lblChangeAmount.Size = New System.Drawing.Size(92, 35)
        Me.lblChangeAmount.TabIndex = 19
        Me.lblChangeAmount.Text = "$0.00"
        '
        'txtUPC
        '
        Me.txtUPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPC.Location = New System.Drawing.Point(466, 68)
        Me.txtUPC.Margin = New System.Windows.Forms.Padding(6)
        Me.txtUPC.Multiline = True
        Me.txtUPC.Name = "txtUPC"
        Me.txtUPC.Size = New System.Drawing.Size(239, 70)
        Me.txtUPC.TabIndex = 20
        '
        'lblUPC
        '
        Me.lblUPC.AutoSize = True
        Me.lblUPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPC.Location = New System.Drawing.Point(539, 22)
        Me.lblUPC.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblUPC.Name = "lblUPC"
        Me.lblUPC.Size = New System.Drawing.Size(89, 35)
        Me.lblUPC.TabIndex = 21
        Me.lblUPC.Text = "UPC:"
        '
        'lblCart
        '
        Me.lblCart.AutoSize = True
        Me.lblCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCart.Location = New System.Drawing.Point(178, 22)
        Me.lblCart.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(73, 35)
        Me.lblCart.TabIndex = 22
        Me.lblCart.Text = "Cart"
        '
        'frmPointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1468, 1279)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
End Class
