namespace CoffeCf.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDetailsFieldInProductTypesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductTypes", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductTypes", "Details");
        }
    }
}
