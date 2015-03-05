Imports Framesharp.DomainService
Imports Framesharp.DomainService.Interfaces
Imports Framesharp.Repository
Imports StructureMap.Configuration.DSL

''' <summary>
''' This class is responsible for registering all other IoC registries
'''  for scanning the application assembly for repository classes and domain services
'''  classes.
''' </summary>
''' <remarks></remarks>
Public Class DependencyInjectionRegistry
    Inherits Registry

    Public Sub New()

        Scan(Sub(x)

                 x.WithDefaultConventions()
                 x.Assembly("FramesharpEmpty.DomainService")
                 x.AddAllTypesOf(GetType(CrudDomainService(Of )))
                 x.ConnectImplementationsToTypesClosing(GetType(ICrudDomainService(Of )))
                 x.Assembly("FramesharpEmpty.Repository")
                 x.AddAllTypesOf(GetType(RepositoryBase(Of )))
                 x.ConnectImplementationsToTypesClosing(GetType(IRepository(Of )))
                 
             End Sub)

    End Sub

End Class
