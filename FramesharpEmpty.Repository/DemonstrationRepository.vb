Imports Framesharp.Core.Interfaces
Imports Framesharp.Repository
Imports FramesharpEmpty.Domain
Imports FramesharpEmpty.Repository.Interfaces

Public Class DemonstrationRepository
    Inherits RepositoryBase(Of Demonstration)
    Implements IDemonstrationRepository

    Public Sub New(ByVal context As IOperationCallContext)
        MyBase.New(context)
    End Sub


    ''' <summary>
    ''' Gets a demonstration by database identification number
    ''' </summary>
    ''' <param name="demonstrationId">Database identification number of the Demonstration instance</param>
    ''' <returns>An instance of <see cref="Domain.Demonstration"/></returns>
    Public Function GetDemonstration(ByVal demonstrationId As Integer) As Demonstration _
    Implements IDemonstrationRepository.GetDemonstration

        Return Me.Get(demonstrationId)

    End Function

End Class