namespace AppInventarioWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventario",
                c => new
                    {
                        NegocioId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        InventarioId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaMod = c.DateTime(),
                        Producto_NegocioId = c.Int(),
                        Producto_ProveedorId = c.Int(),
                        Producto_ProductoId = c.Int(),
                    })
                .PrimaryKey(t => new { t.NegocioId, t.ProductoId, t.InventarioId })
                .ForeignKey("dbo.Productos", t => new { t.Producto_NegocioId, t.Producto_ProveedorId, t.Producto_ProductoId })
                .Index(t => new { t.Producto_NegocioId, t.Producto_ProveedorId, t.Producto_ProductoId });
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        NegocioId = c.Int(nullable: false),
                        ProveedorId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 64),
                        Costo = c.Double(nullable: false),
                        Precio = c.Double(nullable: false),
                        Contenido = c.Int(nullable: false),
                        Unidad = c.String(nullable: false, maxLength: 8),
                        Activo = c.Boolean(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaMod = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.NegocioId, t.ProveedorId, t.ProductoId })
                .ForeignKey("dbo.Proveedores", t => new { t.NegocioId, t.ProveedorId }, cascadeDelete: true)
                .Index(t => new { t.NegocioId, t.ProveedorId });
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        NegocioId = c.Int(nullable: false),
                        ProveedorId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 64),
                        Activo = c.Boolean(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaMod = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.NegocioId, t.ProveedorId });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventario", new[] { "Producto_NegocioId", "Producto_ProveedorId", "Producto_ProductoId" }, "dbo.Productos");
            DropForeignKey("dbo.Productos", new[] { "NegocioId", "ProveedorId" }, "dbo.Proveedores");
            DropIndex("dbo.Productos", new[] { "NegocioId", "ProveedorId" });
            DropIndex("dbo.Inventario", new[] { "Producto_NegocioId", "Producto_ProveedorId", "Producto_ProductoId" });
            DropTable("dbo.Proveedores");
            DropTable("dbo.Productos");
            DropTable("dbo.Inventario");
        }
    }
}
