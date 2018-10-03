namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFkOrderItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "ConstructionItemId", c => c.String());
            AddColumn("dbo.OrderItems", "ConstructionItem_ItemId", c => c.String(maxLength: 128));
            AlterColumn("dbo.OrderItems", "OrderId", c => c.String(maxLength: 128));
            CreateIndex("dbo.OrderItems", "OrderId");
            CreateIndex("dbo.OrderItems", "ConstructionItem_ItemId");
            AddForeignKey("dbo.OrderItems", "ConstructionItem_ItemId", "dbo.ConstructionItems", "ItemId");
            AddForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders", "OrderId");
            DropColumn("dbo.OrderItems", "ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "ItemId", c => c.String());
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "ConstructionItem_ItemId", "dbo.ConstructionItems");
            DropIndex("dbo.OrderItems", new[] { "ConstructionItem_ItemId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            AlterColumn("dbo.OrderItems", "OrderId", c => c.String());
            DropColumn("dbo.OrderItems", "ConstructionItem_ItemId");
            DropColumn("dbo.OrderItems", "ConstructionItemId");
        }
    }
}
