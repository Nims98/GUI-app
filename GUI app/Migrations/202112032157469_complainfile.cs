namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class complainfile : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ComplainFiles", "Telephone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ComplainFiles", "Telephone", c => c.String());
        }
    }
}
