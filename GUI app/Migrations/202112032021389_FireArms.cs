namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FireArms : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FireArms",
                c => new
                    {
                        SerialNo = c.String(nullable: false, maxLength: 128),
                        Model = c.String(),
                        LastUsed = c.DateTime(nullable: false),
                        LastServiced = c.DateTime(nullable: false),
                        NewBullets = c.Int(nullable: false),
                        FiredBullets = c.Int(nullable: false),
                        BalanceBullets = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.SerialNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FireArms");
        }
    }
}
