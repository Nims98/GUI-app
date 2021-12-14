namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPrisoner : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prisoners",
                c => new
                    {
                        PrisonerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        NIC = c.String(),
                        Mobile = c.Int(nullable: false),
                        HomePhone = c.Int(nullable: false),
                        Crime = c.String(),
                        MoreInfo = c.String(),
                    })
                .PrimaryKey(t => t.PrisonerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prisoners");
        }
    }
}
