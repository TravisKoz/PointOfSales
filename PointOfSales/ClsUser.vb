'Authors: Travis Kozlowski
'Date: 09/15/2022
'Class Used for the creation of User Objects

Option Strict On
Option Explicit On

Public Class ClsUser

    'Define class fields
    Private mstrUsername As String
    Private mstrPassword As String

    'Define class properties
    Public Property Username As String
        Get
            Return mstrUsername
        End Get
        Set(value As String)
            mstrUsername = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return mstrPassword
        End Get
        Set(value As String)
            mstrPassword = value
        End Set
    End Property

End Class

