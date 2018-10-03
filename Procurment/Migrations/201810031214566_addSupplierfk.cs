namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSupplierfk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupplierStatus", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.SupplierStatus", "OrderId", c => c.String(maxLength: 128));
            CreateIndex("dbo.SupplierStatus", "OrderId");
            CreateIndex("dbo.SupplierStatus", "UserId");
            AddForeignKey("dbo.SupplierStatus", "OrderId", "dbo.Orders", "OrderId");
            AddForeignKey("dbo.SupplierStatus", "UserId", "dbo.Users", "UserId");
            DropColumn("dbo.SupplierStatus", "SupplierId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupplierStatus", "SupplierId", c => c.String());
            DropForeignKey("dbo.SupplierStatus", "UserId", "dbo.Users");
            DropForeignKey("dbo.SupplierStatus", "OrderId", "dbo.Orders");
            DropIndex("dbo.SupplierStatus", new[] { "UserId" });
            DropIndex("dbo.SupplierStatus", new[] { "OrderId" });
            AlterColumn("dbo.SupplierStatus", "OrderId", c => c.String());
            DropColumn("dbo.SupplierStatus", "UserId");
        }
    }
}
