namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppVet.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppVet.Data.PruebaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppVet.Data.PruebaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Piezas.AddOrUpdate(x => x.Id,
                new Pieza() { Id = 1, Nombre = "Pieza1" },
                new Pieza() { Id = 2, Nombre = "Pieza2" }
            );

            context.Proveedores.AddOrUpdate(x => x.Id,
                new Proveedor { Id = 1, Nombre = "Proveedor1" },
                new Proveedor { Id = 2, Nombre = "Proveedor2" }
            );

            context.Suministrados.AddOrUpdate(x => x.IdProveedor,
                new Suministra { IdProveedor = 1, CodigoPieza = 1, Precio = 10 },
                new Suministra { IdProveedor = 2, CodigoPieza = 2, Precio = 20 }
            );
        }
    }
}
