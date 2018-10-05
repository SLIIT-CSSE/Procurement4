namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Supplier", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Supplier");
        }
    }
}
