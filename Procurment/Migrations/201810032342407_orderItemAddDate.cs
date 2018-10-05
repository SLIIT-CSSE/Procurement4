namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderItemAddDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItems", "Date");
        }
    }
}
