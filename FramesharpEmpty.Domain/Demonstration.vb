Imports System
Imports Framesharp.Domain

Public Class Demonstration
    Implements IDomainObject

    Public Overridable Property DemonstrationId As Integer

    Public Overridable Property SomeDescription As String

    Public Overridable Property SomeNumber As Integer

    Public Overridable Property SomeFlag As Boolean

    Public Overridable Property CreationDate As DateTime?

    Public Overridable Property EditionDate As DateTime?

    ''' <summary>
    ''' Class constructor
    ''' </summary>
    Public Sub New()

        InitializeObject()

    End Sub

    Private Sub InitializeObject()

        '' Virtual properties initialization instructions

    End Sub

    Public Overrides Function Equals(ByVal obj As Object) As Boolean

        Return Not CType(obj, Demonstration) Is Nothing AndAlso DemonstrationId = CType(obj, Demonstration).DemonstrationId

    End Function

    Public Overrides Function GetHashCode() As Integer

        Return String.Concat(DemonstrationId).GetHashCode()

    End Function

End Class