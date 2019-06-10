using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppVet.Models;

namespace WebAppVet.Data
{
    public class PruebaDbContext : DbContext
    {
        public PruebaDbContext() :base("PruebaDbContext")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Flor> Flores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}