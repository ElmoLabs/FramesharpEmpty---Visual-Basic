Imports System
Imports System.Runtime.Serialization

Namespace DataContracts

    <DataContract()>
    Public Class Demonstration

        <DataMember()>
        Public Property DemonstrationId As Integer

        <DataMember()>
        Public Property SomeDescription As String

        <DataMember()>
        Public Property SomeNumber As Integer

        <DataMember()>
        Public Property SomeFlag As Boolean

        <DataMember()>
        Public Property CreationDate As DateTime?

        <DataMember()>
        Public Property EditionDate As DateTime?

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

End Namespace