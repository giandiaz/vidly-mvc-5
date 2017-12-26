namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDataMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES ('Shrek 2', 'Comedy', CAST('2009-05-25' AS DATETIME), CAST('2009-05-25' AS DATETIME), 5)");
            Sql("INSERT INTO Movies VALUES ('The Fog', 'Terror', CAST('2012-05-25' AS DATETIME), CAST('2012-05-25' AS DATETIME), 10)");
        }
        
        public override void Down()
        {
        }
    }
}
