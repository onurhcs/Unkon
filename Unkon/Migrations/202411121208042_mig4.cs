﻿namespace Unkon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hizmets", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hizmets", "Color");
        }
    }
}
