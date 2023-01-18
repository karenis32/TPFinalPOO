namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avión",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominación = c.String(),
                        lineaAerea_IdLinea = c.Int(),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineaAereas", t => t.lineaAerea_IdLinea)
                .Index(t => t.lineaAerea_IdLinea);
            
            CreateTable(
                "dbo.LineaAereas",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avión", "lineaAerea_IdLinea", "dbo.LineaAereas");
            DropIndex("dbo.Avión", new[] { "lineaAerea_IdLinea" });
            DropTable("dbo.LineaAereas");
            DropTable("dbo.Avión");
        }
    }
}
