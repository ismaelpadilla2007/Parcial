namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Apellido = c.String(maxLength: 100),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(maxLength: 100),
                        Pedido_NroPedido = c.Int(),
                        Pedido_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdCliente)
                .ForeignKey("dbo.Pedidoes", t => new { t.Pedido_NroPedido, t.Pedido_IdCliente })
                .Index(t => new { t.Pedido_NroPedido, t.Pedido_IdCliente });
            
            CreateTable(
                "dbo.Especies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Flor_Codigo = c.Int(),
                        Flor_IdEspecie = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flors", t => new { t.Flor_Codigo, t.Flor_IdEspecie })
                .Index(t => new { t.Flor_Codigo, t.Flor_IdEspecie });
            
            CreateTable(
                "dbo.Flors",
                c => new
                    {
                        Codigo = c.Int(nullable: false),
                        IdEspecie = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 100),
                        Precio = c.Int(nullable: false),
                        Venta_NroPedido = c.Int(),
                        Venta_CodFlores = c.Int(),
                    })
                .PrimaryKey(t => new { t.Codigo, t.IdEspecie })
                .ForeignKey("dbo.Ventas", t => new { t.Venta_NroPedido, t.Venta_CodFlores })
                .Index(t => new { t.Venta_NroPedido, t.Venta_CodFlores });
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        NroPedido = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        FecVenta = c.DateTime(nullable: false),
                        Venta_NroPedido = c.Int(),
                        Venta_CodFlores = c.Int(),
                    })
                .PrimaryKey(t => new { t.NroPedido, t.IdCliente })
                .ForeignKey("dbo.Ventas", t => new { t.Venta_NroPedido, t.Venta_CodFlores })
                .Index(t => new { t.Venta_NroPedido, t.Venta_CodFlores });
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        NroPedido = c.Int(nullable: false),
                        CodFlores = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NroPedido, t.CodFlores });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", new[] { "Venta_NroPedido", "Venta_CodFlores" }, "dbo.Ventas");
            DropForeignKey("dbo.Flors", new[] { "Venta_NroPedido", "Venta_CodFlores" }, "dbo.Ventas");
            DropForeignKey("dbo.Clientes", new[] { "Pedido_NroPedido", "Pedido_IdCliente" }, "dbo.Pedidoes");
            DropForeignKey("dbo.Especies", new[] { "Flor_Codigo", "Flor_IdEspecie" }, "dbo.Flors");
            DropIndex("dbo.Pedidoes", new[] { "Venta_NroPedido", "Venta_CodFlores" });
            DropIndex("dbo.Flors", new[] { "Venta_NroPedido", "Venta_CodFlores" });
            DropIndex("dbo.Especies", new[] { "Flor_Codigo", "Flor_IdEspecie" });
            DropIndex("dbo.Clientes", new[] { "Pedido_NroPedido", "Pedido_IdCliente" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Flors");
            DropTable("dbo.Especies");
            DropTable("dbo.Clientes");
        }
    }
}
