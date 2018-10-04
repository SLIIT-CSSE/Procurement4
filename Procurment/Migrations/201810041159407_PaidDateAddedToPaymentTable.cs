namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaidDateAddedToPaymentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "PaidDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "PaidDate");
        }
    }
}
