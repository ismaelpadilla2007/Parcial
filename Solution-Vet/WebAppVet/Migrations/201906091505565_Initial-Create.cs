namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Piezas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Suministra_CodigoPieza = c.Int(),
                        Suministra_IdProveedor = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suministras", t => new { t.Suministra_CodigoPieza, t.Suministra_IdProveedor })
                .Index(t => new { t.Suministra_CodigoPieza, t.Suministra_IdProveedor });
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Suministra_CodigoPieza = c.Int(),
                        Suministra_IdProveedor = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suministras", t => new { t.Suministra_CodigoPieza, t.Suministra_IdProveedor })
                .Index(t => new { t.Suministra_CodigoPieza, t.Suministra_IdProveedor });
            
            CreateTable(
                "dbo.Suministras",
                c => new
                    {
                        CodigoPieza = c.Int(nullable: false),
                        IdProveedor = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CodigoPieza, t.IdProveedor });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proveedors", new[] { "Suministra_CodigoPieza", "Suministra_IdProveedor" }, "dbo.Suministras");
            DropForeignKey("dbo.Piezas", new[] { "Suministra_CodigoPieza", "Suministra_IdProveedor" }, "dbo.Suministras");
            DropIndex("dbo.Proveedors", new[] { "Suministra_CodigoPieza", "Suministra_IdProveedor" });
            DropIndex("dbo.Piezas", new[] { "Suministra_CodigoPieza", "Suministra_IdProveedor" });
            DropTable("dbo.Suministras");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Piezas");
        }
    }
}
