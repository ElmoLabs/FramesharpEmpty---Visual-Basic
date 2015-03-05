Imports Framesharp.DomainService
Imports Framesharp.ServiceModel
Imports FramesharpEmpty.Service.DataContracts
Imports FramesharpEmpty.DomainService.Interfaces
Imports FramesharpEmpty.Service.Transcriptors

Namespace Implementations

    Public Class DemonstrationServiceImplementation
        Inherits ServiceBase

        Private ReadOnly _demonstrationDomainService As IDemonstrationDomainService

        Public Sub New()

            _demonstrationDomainService = DomainServiceFactory.Get(Of IDemonstrationDomainService)(OperationCallContext)

        End Sub

        ''' <summary>
        ''' Gets a demonstration by database identification number
        ''' </summary>
        ''' <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        ''' <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        Public Function GetDemonstration(ByVal demonstrationId As Integer) As Demonstration

            Dim demonstrationDomain As Domain.Demonstration = _demonstrationDomainService.GetDemonstration(demonstrationId)

            Return DemonstrationTranscriptor.ConvertToDataContractFromDomain(demonstrationDomain)

        End Function

    End Class

End Namespace