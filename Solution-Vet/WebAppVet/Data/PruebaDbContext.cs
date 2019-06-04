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

        public DbSet<Pieza> Piezas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Suministra> Suministrados { get; set; }
        
    }
}