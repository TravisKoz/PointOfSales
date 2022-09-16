'Author Brandon Werlein

Option Strict On
Option Explicit On

Public Class ClsProduct

    'Define class fields
    Private mintCodeUPC As Integer
    Private mstrProductName As String
    Private mdblProductPrice As Double
    Private mstrProductDescription As String
    Private mstrProductCategory As String

    'Define class properties
    Public Property CodeUPC As Integer
        Get
            Return mintCodeUPC
        End Get
        Set(value As Integer)
            mintCodeUPC = value
        End Set
    End Property

    Public Property ProductName As String
        Get
            Return mstrProductName
        End Get
        Set(value As String)
            mstrProductName = value
        End Set
    End Property

    Public Property ProductPrice As Double
        Get
            Return mdblProductPrice
        End Get
        Set(value As Double)
            mdblProductPrice = value
        End Set
    End Property

    Public Property ProductDescription As String
        Get
            Return mstrProductDescription
        End Get
        Set(value As String)
            mstrProductDescription = value
        End Set
    End Property

    Public Property ProductCategory As String
        Get
            Return mstrProductCategory
        End Get
        Set(value As String)
            mstrProductCategory = value
        End Set
    End Property
End Class
