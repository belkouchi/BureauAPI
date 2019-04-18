namespace BureauAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKcategorie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "CategorieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategorieId");
            AddForeignKey("dbo.Products", "CategorieId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategorieId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategorieId" });
            DropColumn("dbo.Products", "CategorieId");
            DropTable("dbo.Categories");
        }
    }
}
