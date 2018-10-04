namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKeyToPayments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "BankAccount_AccountId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Payments", "BankAccount_AccountId");
            AddForeignKey("dbo.Payments", "BankAccount_AccountId", "dbo.BankAccounts", "AccountId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "BankAccount_AccountId", "dbo.BankAccounts");
            DropIndex("dbo.Payments", new[] { "BankAccount_AccountId" });
            DropColumn("dbo.Payments", "BankAccount_AccountId");
        }
    }
}
