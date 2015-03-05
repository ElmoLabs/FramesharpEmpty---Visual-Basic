Imports System

Namespace Transcriptors

    Public Module DemonstrationTranscriptor

        ''' <summary>
        ''' Converts a domain object into a model instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="source">An instance of the domain object to be transcripted from</param>
        ''' <returns>An instance of a transcripted model</returns>
        Public Function ConvertToModelFromDomain(ByVal source As Domain.Demonstration) As Models.Demonstration

            Return ConvertToModelFromDomain(Nothing, source)

        End Function

        ''' <summary>
        ''' Converts a domain object into a model instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="result">An instance of the model to be transcripted to</param>
        ''' <param name="source">An instance of the domain object to be transcripted from</param>
        ''' <returns>An instance of a transcripted model</returns>
        Public Function ConvertToModelFromDomain(ByVal result As Models.Demonstration, ByVal source As Domain.Demonstration) As Models.Demonstration

            If source Is Nothing Then Return Nothing

            If result Is Nothing Then result = New Models.Demonstration()

            result.DemonstrationId = source.DemonstrationId
            result.SomeDescription = source.SomeDescription
            result.SomeFlag = source.SomeFlag
            result.SomeNumber = source.SomeNumber
            result.CreationDate = If(source.CreationDate, New DateTime())
            result.EditionDate = If(source.EditionDate, New DateTime())

            Return result

        End Function

        ''' <summary>
        ''' Converts a model into a domain object instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="source">An instance of the domain object to be transcripted to</param>
        ''' <returns>An instance of a transcripted domain object</returns>
        Public Function ConvertFromModelToDomain(ByVal source As Models.Demonstration) As Domain.Demonstration

            Return ConvertFromModelToDomain(source, Nothing)

        End Function

        ''' <summary>
        ''' Converts a model into a domain object instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="result">An instance of the model to be transcripted from</param>
        ''' <param name="source">An instance of the domain object to be transcripted to</param>
        ''' <returns>An instance of a transcripted domain object</returns>
        Public Function ConvertFromModelToDomain(ByVal source As Models.Demonstration, ByVal result As Domain.Demonstration) As Domain.Demonstration

            If source Is Nothing Then Return Nothing

            If result Is Nothing Then result = New Domain.Demonstration()

            result.DemonstrationId = source.DemonstrationId
            result.SomeDescription = source.SomeDescription
            result.SomeFlag = source.SomeFlag
            result.SomeNumber = source.SomeNumber
            result.CreationDate = source.CreationDate
            result.EditionDate = source.EditionDate

            Return result

        End Function

    End Module

End Namespace