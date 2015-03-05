Imports Framesharp.Core.Interfaces
Imports Framesharp.DomainService
Imports Framesharp.Persistence.Transaction
Imports Framesharp.Repository
Imports FramesharpEmpty.Domain
Imports FramesharpEmpty.DomainService.Interfaces
Imports FramesharpEmpty.Repository.Interfaces

Public Class DemonstrationDomainService
    Inherits CrudDomainService(Of Demonstration, IDemonstrationRepository)
    Implements IDemonstrationDomainService

    Private ReadOnly _demonstrationRepository As IDemonstrationRepository

    Public Sub New(ByVal context As IOperationCallContext)
        MyBase.New(context)

        _demonstrationRepository = RepositoryFactory.Get(Of IDemonstrationRepository)(context)
    End Sub
    
    ''' <summary>
    ''' Creates a new demonstration record
    ''' </summary>
    ''' <param name="someDescription">Some random description</param>
    ''' <param name="someNumber">Some random number</param>
    ''' <param name="someFlag">Some random flag</param>
    ''' <returns>A new instance of <see cref="Domain.Demonstration"/></returns>
    <TransactionScope()>
    Public Function CreateDemonstration(ByVal someDescription As String, ByVal someNumber As Integer, ByVal someFlag As Boolean) As Demonstration _
        Implements IDemonstrationDomainService.CreateDemonstration

        Dim demonstration As Demonstration = New Demonstration() With
        {
            .SomeDescription = someDescription,
            .SomeNumber = someNumber,
            .SomeFlag = someFlag
        }

        Repository.Save(demonstration)

        Return demonstration

    End Function

    ''' <summary>
    ''' Gets a demonstration by database identification number
    ''' </summary>
    ''' <param name="demonstrationId">Database identification number of the Demonstration instance</param>
    ''' <returns>An instance of <see cref="Domain.Demonstration"/></returns>
    Public Function GetDemonstration(ByVal demonstrationId As Integer) As Demonstration _
        Implements IDemonstrationDomainService.GetDemonstration

        Return _demonstrationRepository.Get(demonstrationId)

    End Function

End Class