namespace Unkon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Paragraf1 = c.String(),
                        Paragraf2 = c.String(),
                        Madde1 = c.String(),
                        Madde2 = c.String(),
                        Madde3 = c.String(),
                        ButonMetni = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
