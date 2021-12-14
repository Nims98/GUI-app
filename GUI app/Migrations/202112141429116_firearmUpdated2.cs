namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firearmUpdated2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FireArms", "LastUpdatedByid", c => c.String());
            AddColumn("dbo.FireArms", "LastUpdatedByname", c => c.String());
            DropColumn("dbo.FireArms", "LastUpdatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FireArms", "LastUpdatedBy", c => c.String());
            DropColumn("dbo.FireArms", "LastUpdatedByname");
            DropColumn("dbo.FireArms", "LastUpdatedByid");
        }
    }
}
