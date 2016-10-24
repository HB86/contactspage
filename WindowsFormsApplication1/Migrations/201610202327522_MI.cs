namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Table", "MiddleInitial", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Table", "MiddleInitial");
        }
    }
}
