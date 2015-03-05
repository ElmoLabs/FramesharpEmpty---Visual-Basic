Imports FramesharpEmpty.Service.Contracts
Imports FramesharpEmpty.Service.DataContracts
Imports FramesharpEmpty.Service.Implementations

Public Class DemonstrationService
    Implements IDemonstrationService

    Private ReadOnly _serviceImplementation As DemonstrationServiceImplementation

    Public Sub New()

        _serviceImplementation = New DemonstrationServiceImplementation()

    End Sub

    Public Function GetDemonstration(ByVal demonstrationId As Integer) As Demonstration _
        Implements IDemonstrationService.GetDemonstration

        Return _serviceImplementation.GetDemonstration(demonstrationId)

    End Function

End Class
