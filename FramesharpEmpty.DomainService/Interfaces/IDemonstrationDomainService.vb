Imports Framesharp.DomainService.Interfaces
Imports FramesharpEmpty.Domain

Namespace Interfaces

    Public Interface IDemonstrationDomainService
        Inherits ICrudDomainService(Of Demonstration)

        ''' <summary>
        ''' Creates a new demonstration record
        ''' </summary>
        ''' <param name="someDescription">Some random description</param>
        ''' <param name="someNumber">Some random number</param>
        ''' <param name="someFlag">Some random flag</param>
        ''' <returns></returns>
        Function CreateDemonstration(ByVal someDescription As String, ByVal someNumber As Integer, ByVal someFlag As Boolean) As Demonstration

        ''' <summary>
        ''' Gets a demonstration by database identification number
        ''' </summary>
        ''' <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        ''' <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        Function GetDemonstration(ByVal demonstrationId As Integer) As Demonstration

    End Interface

End Namespace