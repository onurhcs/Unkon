namespace Unkon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hakkimizdas", "AltBaslik1", c => c.String());
            AddColumn("dbo.Hakkimizdas", "AltBaslik2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hakkimizdas", "AltBaslik2");
            DropColumn("dbo.Hakkimizdas", "AltBaslik1");
        }
    }
}
