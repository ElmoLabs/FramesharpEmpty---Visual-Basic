Imports System
Imports Framesharp.DomainService
Imports Framesharp.Persistence.Transaction
Imports FramesharpEmpty.Configuration
Imports FramesharpEmpty.Domain
Imports FramesharpEmpty.DomainService.Interfaces
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class DemonstrationDomainServiceTest
    Inherits Framesharp.Test.TestClassBase

    Private ReadOnly _demonstrationDomainService As IDemonstrationDomainService

    Public Sub New()
        MyBase.New(New RootApplicationSettings())

        _demonstrationDomainService = DomainServiceFactory.Get(Of IDemonstrationDomainService)(OperationCallContext)

    End Sub

    ''' <summary>
    ''' Creates a new Demonstration record
    ''' </summary>
    <TestMethod()>
    <TransactionScope(DefaultRollback:=True)>
    Public Sub CreateDemonstrationTest()

        Dim demonstration As New Demonstration() With
            {
                .SomeDescription = String.Format("Test description {0}", DateTime.Now.Ticks),
                .SomeNumber = CInt(Date.Now.Ticks Mod 10),
                .SomeFlag = True
            }

        _demonstrationDomainService.CreateDemonstration(
            demonstration.SomeDescription,
            demonstration.SomeNumber,
            demonstration.SomeFlag)

    End Sub

    ''' <summary>
    ''' Gets a demonstration by database identification number
    ''' </summary>
    <TestMethod()>
    Public Sub GetDemonstrationTest()

        Dim demonstration As Demonstration = EquivalencePartition.GetRandom(Of Demonstration)()

        If demonstration Is Nothing Then Assert.Inconclusive("Demonstration table is empty")

        _demonstrationDomainService.GetDemonstration(demonstration.DemonstrationId)

    End Sub

End Class
