namespace CodeFirstExistingDB.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CopyDataIntoTempTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo._Categories",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO _Categories (Name) SELECT Name FROM Categories");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                    "dbo._Categories",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO _Categories (Name) SELECT Name FROM Categories");
            DropTable("dbo.Categories");
        }
    }
}
