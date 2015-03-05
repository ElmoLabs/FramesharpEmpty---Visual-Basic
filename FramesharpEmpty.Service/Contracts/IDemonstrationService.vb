Imports System.ServiceModel
Imports FramesharpEmpty.Service.DataContracts

Namespace Contracts

    <ServiceContract()>
    Public Interface IDemonstrationService

        <OperationContract()>
        Function GetDemonstration(ByVal demonstrationId As Integer) As Demonstration

    End Interface

End Namespace
