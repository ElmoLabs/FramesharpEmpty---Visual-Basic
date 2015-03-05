Imports Framesharp.Repository
Imports FramesharpEmpty.Domain

Namespace Interfaces

    Public Interface IDemonstrationRepository
        Inherits IRepository(Of Demonstration)

        ''' <summary>
        ''' Gets a demonstration by database identification number
        ''' </summary>
        ''' <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        ''' <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        Function GetDemonstration(ByVal demonstrationId As Integer) As Demonstration

    End Interface

End Namespace