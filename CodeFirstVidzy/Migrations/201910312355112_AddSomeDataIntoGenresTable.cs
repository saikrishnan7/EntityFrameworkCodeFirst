namespace CodeFirstVidzy.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeDataIntoGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(Id, Name) Values(1, 'Horror')");
            Sql("Insert into Genres(Id, Name) Values(2, 'Thriller')");
            Sql("Insert into Genres(Id, Name) Values(3, 'Romance')");
            Sql("Insert into Genres(Id, Name) Values(4, 'Comedy')");
            Sql("Insert into Genres(Id, Name) Values(5, 'Drama')"); 
            Sql("Insert into Genres(Id, Name) Values(6, 'Action')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres");
        }
    }
}
