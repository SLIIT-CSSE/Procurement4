namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Staffstatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company_Staff_Status",
                c => new
                    {
                        Company_Staff_StatusId = c.String(nullable: false, maxLength: 128),
                        OrderId = c.String(),
                        Company_Staff_Id = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Company_Staff_StatusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Company_Staff_Status");
        }
    }
}
