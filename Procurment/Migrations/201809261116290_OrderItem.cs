namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItem : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.OrderItems");
            AddColumn("dbo.OrderItems", "OrderItemId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.OrderItems", "OrderId", c => c.String());
            AddPrimaryKey("dbo.OrderItems", "OrderItemId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.OrderItems");
            AlterColumn("dbo.OrderItems", "OrderId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.OrderItems", "OrderItemId");
            AddPrimaryKey("dbo.OrderItems", "OrderId");
        }
    }
}
