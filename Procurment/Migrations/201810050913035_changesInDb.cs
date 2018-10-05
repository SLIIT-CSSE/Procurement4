namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "BankAccount_AccountId", "dbo.BankAccounts");
            DropIndex("dbo.Payments", new[] { "BankAccount_AccountId" });
            DropColumn("dbo.Orders", "Supplier");
            DropColumn("dbo.Payments", "SupplierName");
            DropColumn("dbo.Payments", "PaidDate");
            DropColumn("dbo.Payments", "BankAccount_AccountId");
            DropTable("dbo.BankAccounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        AccountId = c.String(nullable: false, maxLength: 128),
                        Bank = c.String(),
                        AccountNo = c.String(),
                    })
                .PrimaryKey(t => t.AccountId);
            
            AddColumn("dbo.Payments", "BankAccount_AccountId", c => c.String(maxLength: 128));
            AddColumn("dbo.Payments", "PaidDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payments", "SupplierName", c => c.String());
            AddColumn("dbo.Orders", "Supplier", c => c.String());
            CreateIndex("dbo.Payments", "BankAccount_AccountId");
            AddForeignKey("dbo.Payments", "BankAccount_AccountId", "dbo.BankAccounts", "AccountId");
        }
    }
}
