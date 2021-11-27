namespace GUI_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Officers",
                c => new
                    {
                        NIC = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Policeid = c.String(),
                        Address = c.String(),
                        Mobile = c.Int(nullable: false),
                        HomePhone = c.Int(nullable: false),
                        PoliceDivision = c.String(),
                    })
                .PrimaryKey(t => t.NIC);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Officers");
        }
    }
}
