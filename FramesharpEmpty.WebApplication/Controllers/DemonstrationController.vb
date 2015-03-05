Imports Framesharp.DomainService
Imports FramesharpEmpty.DomainService
Imports FramesharpEmpty.DomainService.Interfaces

Namespace Controllers

    Public Class DemonstrationController
        Inherits Framesharp.Presentation.Web.Mvc.BaseController

        Private ReadOnly _demonstrationDomainService As IDemonstrationDomainService

        Public Sub New()

            _demonstrationDomainService = DomainServiceFactory.Get(Of IDemonstrationDomainService)(OperationCallContext)

        End Sub

        <HttpGet()>
        Function Index() As ActionResult

            Return View()

        End Function

    End Class

End Namespace