namespace Procurment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConstructionItems", "CategoryId", c => c.String(maxLength: 128));
            CreateIndex("dbo.ConstructionItems", "CategoryId");
            AddForeignKey("dbo.ConstructionItems", "CategoryId", "dbo.Categories", "CategoryId");
            DropColumn("dbo.ConstructionItems", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ConstructionItems", "Category", c => c.String());
            DropForeignKey("dbo.ConstructionItems", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ConstructionItems", new[] { "CategoryId" });
            DropColumn("dbo.ConstructionItems", "CategoryId");
        }
    }
}
