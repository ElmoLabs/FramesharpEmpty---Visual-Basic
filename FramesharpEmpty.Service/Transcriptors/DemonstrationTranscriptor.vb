Imports System

Namespace Transcriptors

    Public Module DemonstrationTranscriptor

        ''' <summary>
        ''' Converts a domain object into a data contract instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="source">An instance of the domain object to be transcripted from</param>
        ''' <returns>An instance of a transcripted data contract</returns>
        Public Function ConvertToDataContractFromDomain(ByVal source As Domain.Demonstration) As DataContracts.Demonstration

            Return ConvertToDataContractFromDomain(Nothing, source)

        End Function

        ''' <summary>
        ''' Converts a domain object into a data contract instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="result">An instance of the data contract to be transcripted to</param>
        ''' <param name="source">An instance of the domain object to be transcripted from</param>
        ''' <returns>An instance of a transcripted data contract</returns>
        Public Function ConvertToDataContractFromDomain(ByVal result As DataContracts.Demonstration, ByVal source As Domain.Demonstration) As DataContracts.Demonstration

            If source Is Nothing Then Return Nothing

            If result Is Nothing Then result = New DataContracts.Demonstration()

            result.DemonstrationId = source.DemonstrationId
            result.SomeDescription = source.SomeDescription
            result.SomeFlag = source.SomeFlag
            result.SomeNumber = source.SomeNumber
            result.CreationDate = source.CreationDate
            result.EditionDate = If(source.EditionDate, New DateTime())

            Return result

        End Function

        ''' <summary>
        ''' Converts a data contract into a domain object instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="source">An instance of the domain object to be transcripted to</param>
        ''' <returns>An instance of a transcripted domain object</returns>
        Public Function ConvertFromDataContractToDomain(ByVal source As DataContracts.Demonstration) As Domain.Demonstration

            Return ConvertFromDataContractToDomain(source, Nothing)

        End Function

        ''' <summary>
        ''' Converts a data contract into a domain object instance transfering all information from the source
        '''  object to the resulting instance. Transcription should only be applied to properties
        '''  whose values are not lazy loaded or readonly.
        ''' </summary>
        ''' <param name="result">An instance of the data contract to be transcripted from</param>
        ''' <param name="source">An instance of the domain object to be transcripted to</param>
        ''' <returns>An instance of a transcripted domain object</returns>
        Public Function ConvertFromDataContractToDomain(ByVal source As DataContracts.Demonstration, ByVal result As Domain.Demonstration) As Domain.Demonstration

            If source Is Nothing Then Return Nothing

            If result Is Nothing Then result = New Domain.Demonstration()

            result.DemonstrationId = source.DemonstrationId
            result.SomeDescription = source.SomeDescription
            result.SomeFlag = source.SomeFlag
            result.SomeNumber = source.SomeNumber
            result.EditionDate = source.EditionDate

            Return result

        End Function

    End Module

End Namespace