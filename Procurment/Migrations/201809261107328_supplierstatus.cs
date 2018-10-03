namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supplierstatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupplierStatus",
                c => new
                    {
                        SuplierStatusId = c.String(nullable: false, maxLength: 128),
                        OrderId = c.String(),
                        SupplierId = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.SuplierStatusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SupplierStatus");
        }
    }
}
