namespace CoffeCf.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ProductTypes VALUES ('Cakes')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM ProductTypes WHERE Description='Cakes'");

        }
    }
}
