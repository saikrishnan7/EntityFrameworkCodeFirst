﻿namespace CodeFirstVidzy.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddClassificationTableAndClassificationColumnToVideo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classification");
        }
    }
}
