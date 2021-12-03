namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FireArms", "LastUsed", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.FireArms", "LastServiced", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FireArms", "LastServiced", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FireArms", "LastUsed", c => c.DateTime(nullable: false));
        }
    }
}
