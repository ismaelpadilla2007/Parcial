namespace WebAppVet.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
            context.Clientes.AddOrUpdate(x => x.IdCliente,
            new Cliente() { IdCliente = 1, Nombre = "Jorge", Apellido = "Padilla", Email = "xp@gmail.com", Telefono = 1111111 },
            new Cliente() { IdCliente = 2, Nombre = "Ramon", Apellido = "Perez", Email = "cp@gmail.com", Telefono = 1112222 }
            );

            context.Especies.AddOrUpdate(x => x.Id,
                new Especie { Id = 1, Nombre = "Especie1" },
                new Especie { Id = 2, Nombre = "Especie2" },
                new Especie { Id = 3, Nombre = "Especie3" },
                new Especie { Id = 4, Nombre = "Especie4" }
            );

            context.Flores.AddOrUpdate(x => x.Codigo,
                new Flor { Codigo = 1, IdEspecie = 1, Precio = 10, Nombre = "lala" },
                new Flor { Codigo = 2, IdEspecie = 2, Precio = 20, Nombre = "lele" },
                new Flor { Codigo = 3, IdEspecie = 3, Precio = 40, Nombre = "lili" },
                new Flor { Codigo = 4, IdEspecie = 4, Precio = 150, Nombre = "lolo" }
            );

            context.Pedidos.AddOrUpdate(x => x.NroPedido,
                new Pedido { NroPedido = 1, IdCliente = 3, FecVenta = DateTime.Now },
                new Pedido { NroPedido = 2, IdCliente = 2, FecVenta = DateTime.Now },
                new Pedido { NroPedido = 3, IdCliente = 1, FecVenta = DateTime.Now },
                new Pedido { NroPedido = 4, IdCliente = 4, FecVenta = DateTime.Now }
            );

            context.Ventas.AddOrUpdate(x => x.NroPedido,
                new Venta { NroPedido = 1, CodFlores = 1, Cantidad = 3 },
                new Venta { NroPedido = 2, CodFlores = 2, Cantidad = 5 },
                new Venta { NroPedido = 1, CodFlores = 2, Cantidad = 2 },
                new Venta { NroPedido = 2, CodFlores = 3, Cantidad = 1 },
                new Venta { NroPedido = 3, CodFlores = 2, Cantidad = 3 },
                new Venta { NroPedido = 2, CodFlores = 2, Cantidad = 6 }
            );
            
        }
    }
}
