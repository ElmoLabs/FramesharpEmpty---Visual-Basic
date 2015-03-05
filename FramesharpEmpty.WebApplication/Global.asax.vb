Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Optimization
Imports System.Web.Routing
Imports FramesharpEmpty.Configuration

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()

        AreaRegistration.RegisterAllAreas()

        Framesharp.DependencyInjection.DependencyResolver.ConfigureApplication(New RootApplicationSettings())

        WebApiConfig.Register(GlobalConfiguration.Configuration)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

    End Sub

End Class