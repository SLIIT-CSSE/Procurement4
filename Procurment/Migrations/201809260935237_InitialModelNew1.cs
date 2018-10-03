namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModelNew1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.String(nullable: false, maxLength: 128),
                        Sequential_Reference = c.String(),
                        CompanyStatus = c.String(),
                        SupplierStatus = c.String(),
                        TotalAmount = c.Single(nullable: false),
                        SiteManagerId = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
