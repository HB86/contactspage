namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameContact : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Table", newName: "Contact");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Contact", newName: "Table");
        }
    }
}
