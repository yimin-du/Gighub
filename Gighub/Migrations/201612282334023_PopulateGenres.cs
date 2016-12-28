namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES('1', 'JAZZ')");
            Sql("INSERT INTO Genres(Id, Name) VALUES('2', 'BLUES')");
            Sql("INSERT INTO Genres(Id, Name) VALUES('3', 'ROCK')");
            Sql("INSERT INTO Genres(Id, Name) VALUES('4', 'COUNTRY')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
