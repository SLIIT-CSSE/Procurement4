namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStafffk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Company_Staff_Status", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Company_Staff_Status", "OrderId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Company_Staff_Status", "OrderId");
            CreateIndex("dbo.Company_Staff_Status", "UserId");
            AddForeignKey("dbo.Company_Staff_Status", "OrderId", "dbo.Orders", "OrderId");
            AddForeignKey("dbo.Company_Staff_Status", "UserId", "dbo.Users", "UserId");
            DropColumn("dbo.Company_Staff_Status", "Company_Staff_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Company_Staff_Status", "Company_Staff_Id", c => c.String());
            DropForeignKey("dbo.Company_Staff_Status", "UserId", "dbo.Users");
            DropForeignKey("dbo.Company_Staff_Status", "OrderId", "dbo.Orders");
            DropIndex("dbo.Company_Staff_Status", new[] { "UserId" });
            DropIndex("dbo.Company_Staff_Status", new[] { "OrderId" });
            AlterColumn("dbo.Company_Staff_Status", "OrderId", c => c.String());
            DropColumn("dbo.Company_Staff_Status", "UserId");
        }
    }
}
