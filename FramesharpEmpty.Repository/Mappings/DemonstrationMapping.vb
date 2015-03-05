Imports FluentNHibernate.Mapping
Imports FramesharpEmpty.Domain

Namespace Mappings

    Public Class DemonstrationMapping
        Inherits ClassMap(Of Demonstration)

        Public Sub New()

            Id(Function(c) c.DemonstrationId).Column("DemonstrationId").GeneratedBy.Native()

            Map(Function(c) c.SomeDescription)
            Map(Function(c) c.SomeNumber)
            Map(Function(c) c.SomeFlag)
            Map(Function(c) c.CreationDate).ReadOnly()
            Map(Function(c) c.EditionDate).Nullable()

        End Sub

    End Class

End Namespace