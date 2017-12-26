namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdayCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = CAST('2009-05-25' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
