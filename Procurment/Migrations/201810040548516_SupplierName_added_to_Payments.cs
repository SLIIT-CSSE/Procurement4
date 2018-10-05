namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierName_added_to_Payments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "SupplierName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "SupplierName");
        }
    }
}
