Imports System
Imports Framesharp.Presentation.Web.Mvc.Models

Namespace Models

    Public Class Demonstration
        Inherits ModelBase

        Public Shared Widening Operator CType(ByVal model As Models.Demonstration) As Domain.Demonstration

            Return Transcriptors.DemonstrationTranscriptor.ConvertFromModelToDomain(model, New Domain.Demonstration())

        End Operator

        Public Shared Widening Operator CType(ByVal domain As Domain.Demonstration) As Models.Demonstration

            Return Transcriptors.DemonstrationTranscriptor.ConvertToModelFromDomain(New Models.Demonstration(), domain)

        End Operator

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

        ''' <summary>
        ''' Initilizes class properties with default values
        ''' </summary>
        Private Sub InitializeObject()

            ' Virtual properties initilization instructions

        End Sub

        Public Overrides Function Equals(ByVal obj As Object) As Boolean

            Return Not CType(obj, Models.Demonstration) Is Nothing AndAlso
                DemonstrationId = CType(obj, Models.Demonstration).DemonstrationId

        End Function

        Public Overrides Function GetHashCode() As Integer

            Return String.Concat(DemonstrationId).GetHashCode()

        End Function

    End Class

End Namespace