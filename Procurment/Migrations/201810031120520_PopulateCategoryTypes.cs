namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (CategoryId,CategoryName) values ('001','Bags')");
            Sql("INSERT INTO Categories (CategoryId,CategoryName) values ('002','Meters')");
            Sql("INSERT INTO Categories (CategoryId,CategoryName) values ('003','Cubes')");
            Sql("INSERT INTO Categories (CategoryId,CategoryName) values ('004','Kilos')");

        }

        public override void Down()
        {
        }
    }
}
