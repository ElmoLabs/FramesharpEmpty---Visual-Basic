Imports Framesharp.Core
Imports Framesharp.DomainService
Imports FramesharpEmpty.DomainService
Imports FramesharpEmpty.DomainService.Interfaces

Namespace Controllers

    Public Class DemonstrationController
        Inherits Controller

        Private ReadOnly _demonstrationDomainService As IDemonstrationDomainService

        Public Sub New()

            _demonstrationDomainService = DomainServiceFactory.Get(Of IDemonstrationDomainService)(OperationCallContext.Current)

        End Sub

        <HttpGet()>
        Function Index() As ActionResult

            Return View()

        End Function

    End Class

End Namespace