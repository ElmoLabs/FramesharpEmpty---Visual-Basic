Imports System

Namespace Models

    Public Class Demonstration

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

        Public Overridable Property CreationDate As DateTime

        Public Overridable Property EditionDate As DateTime?

        ''' <summary>
        ''' Class constructor
        ''' </summary>
        Public Sub New()

            InitializeObject()

        End Sub

        ''' <summary>
        ''' Class initialization method
        ''' </summary>
        Private Sub InitializeObject()

            ' Virtual properties initialization instructions

        End Sub

        ''' <summary>
        ''' Overrides equality comparison between business domain objects
        '''  so that business information is used instead of comparing 
        '''  object instances
        ''' </summary>
        ''' <param name="obj">Instance of the object to compare</param>
        ''' <returns>True if it is the same object business-wise</returns>
        Public Overrides Function Equals(ByVal obj As Object) As Boolean

            Return Not CType(obj, Demonstration) Is Nothing AndAlso DemonstrationId = CType(obj, Demonstration).DemonstrationId

        End Function

        ''' <summary>
        ''' Gets the hash code using business identification values
        ''' </summary>
        ''' <returns>A hash code that represents this instance</returns>
        Public Overrides Function GetHashCode() As Integer

            Return String.Concat(DemonstrationId).GetHashCode()

        End Function

    End Class

End Namespace