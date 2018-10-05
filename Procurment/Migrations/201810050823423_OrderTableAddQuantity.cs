namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderTableAddQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ItemName", c => c.String());
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Quantity");
            DropColumn("dbo.Orders", "ItemName");
        }
    }
}
