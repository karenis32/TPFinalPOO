namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arregloTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.LineaAereas", newName: "Linea Aérea");
            AlterColumn("dbo.Avión", "Denominación", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Linea Aérea", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Linea Aérea", "Nombre", c => c.String());
            AlterColumn("dbo.Avión", "Denominación", c => c.String());
            RenameTable(name: "dbo.Linea Aérea", newName: "LineaAereas");
        }
    }
}
