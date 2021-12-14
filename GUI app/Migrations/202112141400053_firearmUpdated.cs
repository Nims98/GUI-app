namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firearmUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FireArms", "LastUpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FireArms", "LastUpdatedBy");
        }
    }
}
