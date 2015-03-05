Imports System
Imports System.Configuration
Imports System.Reflection
Imports FluentNHibernate.Cfg
Imports FluentNHibernate.Cfg.Db
Imports NHibernate

''' <summary>
''' This class is responsible for building the NHibernate Session Factory configuration
''' </summary>
''' <remarks></remarks>
Public Class DatabaseSettings

    ''' <summary>
    ''' Builds the NHibernate Configuration class according
    '''  to the specifications for this application
    ''' </summary>
    ''' <returns>A <see cref="NHibernate.Cfg.Configuration"/> instance</returns>
    Public Shared Function BuildSessionFactory() As ISessionFactory

        Return Fluently.Configure().Database(
            MsSqlConfiguration.MsSql2012.ConnectionString(
                ConfigurationManager.ConnectionStrings("conexao").ToString()
                )
            ).Mappings(Sub(m) m.FluentMappings.AddFromAssembly(Assembly.Load("FramesharpEmpty.Repository"))).BuildSessionFactory()

    End Function

End Class