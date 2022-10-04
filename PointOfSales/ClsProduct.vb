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
    Private mblnPayByWeight As Boolean
    Private mdblPricePerPound As Double
    Private mblnIsRestricted As Boolean


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

    Public Property PayByWeight As Boolean
        Get
            Return mblnPayByWeight
        End Get
        Set(value As Boolean)
            mblnPayByWeight = value
        End Set
    End Property

    Public Property PricePerPound As Double
        Get
            Return mdblPricePerPound
        End Get
        Set(value As Double)
            mdblPricePerPound = value
        End Set
    End Property

    Public Property IsRestricted As Boolean
        Get
            Return mblnIsRestricted
        End Get
        Set(value As Boolean)
            mblnIsRestricted = value
        End Set
    End Property

End Class
