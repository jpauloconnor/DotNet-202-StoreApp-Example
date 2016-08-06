namespace SuperSupremeMegaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        LastPurchase = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Purchase",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UPC = c.Long(nullable: false),
                        SectionID = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inventory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchase", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Purchase", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Purchase", new[] { "CustomerID" });
            DropIndex("dbo.Purchase", new[] { "ProductID" });
            DropTable("dbo.Product");
            DropTable("dbo.Purchase");
            DropTable("dbo.Customer");
        }
    }
}
