﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lblSelectedPrice = New System.Windows.Forms.Label()
        Me.lblSelectedDescription = New System.Windows.Forms.Label()
        Me.lblSelectedProduct = New System.Windows.Forms.Label()
        Me.picProduct = New System.Windows.Forms.PictureBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblPriceAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblChangeAmount = New System.Windows.Forms.Label()
        Me.gbxSelectedProduct.SuspendLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbxProducts
        '
        Me.lbxProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxProducts.FormattingEnabled = True
        Me.lbxProducts.ItemHeight = 16
        Me.lbxProducts.Location = New System.Drawing.Point(10, 10)
        Me.lbxProducts.Margin = New System.Windows.Forms.Padding(1)
        Me.lbxProducts.Name = "lbxProducts"
        Me.lbxProducts.Size = New System.Drawing.Size(227, 484)
        Me.lbxProducts.TabIndex = 0
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Location = New System.Drawing.Point(254, 21)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(132, 42)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProduct.Location = New System.Drawing.Point(254, 225)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(132, 42)
        Me.btnRemoveProduct.TabIndex = 2
        Me.btnRemoveProduct.Text = "Remove"
        Me.btnRemoveProduct.UseVisualStyleBackColor = True
        '
        'btnVoidTransaction
        '
        Me.btnVoidTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidTransaction.Location = New System.Drawing.Point(254, 448)
        Me.btnVoidTransaction.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVoidTransaction.Name = "btnVoidTransaction"
        Me.btnVoidTransaction.Size = New System.Drawing.Size(132, 42)
        Me.btnVoidTransaction.TabIndex = 3
        Me.btnVoidTransaction.Text = "Void"
        Me.btnVoidTransaction.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(623, 606)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(132, 42)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'gbxSelectedProduct
        '
        Me.gbxSelectedProduct.Controls.Add(Me.lblSelectedPrice)
        Me.gbxSelectedProduct.Controls.Add(Me.lblSelectedDescription)
        Me.gbxSelectedProduct.Controls.Add(Me.lblSelectedProduct)
        Me.gbxSelectedProduct.Controls.Add(Me.picProduct)
        Me.gbxSelectedProduct.Location = New System.Drawing.Point(419, 10)
        Me.gbxSelectedProduct.Name = "gbxSelectedProduct"
        Me.gbxSelectedProduct.Size = New System.Drawing.Size(355, 480)
        Me.gbxSelectedProduct.TabIndex = 8
        Me.gbxSelectedProduct.TabStop = False
        Me.gbxSelectedProduct.Text = "Product"
        '
        'lblSelectedPrice
        '
        Me.lblSelectedPrice.AutoSize = True
        Me.lblSelectedPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPrice.Location = New System.Drawing.Point(21, 65)
        Me.lblSelectedPrice.Name = "lblSelectedPrice"
        Me.lblSelectedPrice.Size = New System.Drawing.Size(51, 22)
        Me.lblSelectedPrice.TabIndex = 3
        Me.lblSelectedPrice.Text = "Price"
        '
        'lblSelectedDescription
        '
        Me.lblSelectedDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDescription.Location = New System.Drawing.Point(22, 263)
        Me.lblSelectedDescription.Name = "lblSelectedDescription"
        Me.lblSelectedDescription.Size = New System.Drawing.Size(327, 196)
        Me.lblSelectedDescription.TabIndex = 2
        Me.lblSelectedDescription.Text = "Description"
        '
        'lblSelectedProduct
        '
        Me.lblSelectedProduct.AutoSize = True
        Me.lblSelectedProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedProduct.Location = New System.Drawing.Point(21, 31)
        Me.lblSelectedProduct.Name = "lblSelectedProduct"
        Me.lblSelectedProduct.Size = New System.Drawing.Size(72, 22)
        Me.lblSelectedProduct.TabIndex = 1
        Me.lblSelectedProduct.Text = "Product"
        '
        'picProduct
        '
        Me.picProduct.Location = New System.Drawing.Point(28, 100)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.Size = New System.Drawing.Size(321, 145)
        Me.picProduct.TabIndex = 0
        Me.picProduct.TabStop = False
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(224, 594)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(221, 54)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(6, 518)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(56, 22)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "Price:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(6, 617)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 22)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(6, 565)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(46, 22)
        Me.lblTax.TabIndex = 12
        Me.lblTax.Text = "Tax:"
        '
        'lblPriceAmount
        '
        Me.lblPriceAmount.AutoSize = True
        Me.lblPriceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceAmount.Location = New System.Drawing.Point(97, 518)
        Me.lblPriceAmount.Name = "lblPriceAmount"
        Me.lblPriceAmount.Size = New System.Drawing.Size(55, 22)
        Me.lblPriceAmount.TabIndex = 13
        Me.lblPriceAmount.Text = "$0.00"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.Location = New System.Drawing.Point(97, 565)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(55, 22)
        Me.lblTaxAmount.TabIndex = 14
        Me.lblTaxAmount.Text = "$0.00"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(97, 617)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalAmount.TabIndex = 15
        Me.lblTotalAmount.Text = "$0.00"
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(224, 536)
        Me.txtCash.Multiline = True
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(221, 51)
        Me.txtCash.TabIndex = 16
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(304, 511)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(57, 22)
        Me.lblCash.TabIndex = 17
        Me.lblCash.Text = "Cash:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(473, 550)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(78, 22)
        Me.lblChange.TabIndex = 18
        Me.lblChange.Text = "Change:"
        '
        'lblChangeAmount
        '
        Me.lblChangeAmount.AutoSize = True
        Me.lblChangeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeAmount.Location = New System.Drawing.Point(557, 550)
        Me.lblChangeAmount.Name = "lblChangeAmount"
        Me.lblChangeAmount.Size = New System.Drawing.Size(55, 22)
        Me.lblChangeAmount.TabIndex = 19
        Me.lblChangeAmount.Text = "$0.00"
        '
        'frmPointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 654)
        Me.Controls.Add(Me.lblChangeAmount)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.lblPriceAmount)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.gbxSelectedProduct)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnVoidTransaction)
        Me.Controls.Add(Me.btnRemoveProduct)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.lbxProducts)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "frmPointOfSale"
        Me.ShowInTaskbar = False
        Me.Text = "frmPointOfSale"
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
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblPriceAmount As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblCash As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblChangeAmount As Label
End Class
