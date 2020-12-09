namespace CaseStudy2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        menuItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItems", t => t.menuItemId, cascadeDelete: true)
                .Index(t => t.menuItemId);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        freeDelivery = c.Boolean(nullable: false),
                        Price = c.Double(nullable: false),
                        dateOfLaunch = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        categoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.categoryId, cascadeDelete: true)
                .Index(t => t.categoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "menuItemId", "dbo.MenuItems");
            DropForeignKey("dbo.MenuItems", "categoryId", "dbo.Categories");
            DropIndex("dbo.MenuItems", new[] { "categoryId" });
            DropIndex("dbo.Carts", new[] { "menuItemId" });
            DropTable("dbo.Categories");
            DropTable("dbo.MenuItems");
            DropTable("dbo.Carts");
        }
    }
}
