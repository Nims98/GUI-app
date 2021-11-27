namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class schemaChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Officers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Officers", "Password");
        }
    }
}
