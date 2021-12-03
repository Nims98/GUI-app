namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipModels",
                c => new
                    {
                        TipModelID = c.Int(nullable: false, identity: true),
                        TipText = c.String(),
                    })
                .PrimaryKey(t => t.TipModelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipModels");
        }
    }
}
