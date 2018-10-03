namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpaymentfk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Payments", "OrderId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Payments", "OrderId");
            AddForeignKey("dbo.Payments", "OrderId", "dbo.Orders", "OrderId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "OrderId", "dbo.Orders");
            DropIndex("dbo.Payments", new[] { "OrderId" });
            AlterColumn("dbo.Payments", "OrderId", c => c.String());
        }
    }
}
