namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class payment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.String(nullable: false, maxLength: 128),
                        OrderId = c.String(),
                        TotalAmount = c.Single(nullable: false),
                        AccountNo = c.String(),
                    })
                .PrimaryKey(t => t.PaymentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payments");
        }
    }
}
