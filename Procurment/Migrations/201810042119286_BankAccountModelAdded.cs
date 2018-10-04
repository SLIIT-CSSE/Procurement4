namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BankAccountModelAdded : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BankAccounts");
        }
    }
}
