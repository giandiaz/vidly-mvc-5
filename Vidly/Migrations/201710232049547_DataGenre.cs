namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Horror')");
            Sql("INSERT INTO Genres VALUES ('Comedy')");
            Sql("INSERT INTO Genres VALUES ('Action')");
        }
        
        public override void Down()
        {
        }
    }
}
