namespace DataEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attributes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AttributesName = c.String(nullable: false, maxLength: 20),
                        ProductId = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        ProductDescription = c.String(),
                        Image = c.String(),
                        Substance = c.String(),
                        Cost = c.Double(nullable: false),
                        CategeryId = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CategoryName = c.String(nullable: false, maxLength: 20),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CustomerName = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        City = c.String(nullable: false),
                        District = c.String(nullable: false),
                        Commune = c.String(nullable: false),
                        DetailAddress = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoodsReceivedNote",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SupplierId = c.String(maxLength: 128),
                        TotalBeforeVAT = c.Double(nullable: false),
                        TotalAfterVAT = c.Double(nullable: false),
                        VAT = c.Double(nullable: false),
                        StatusOfPay = c.Boolean(nullable: false),
                        Payment = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.supplier", t => t.SupplierId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.supplier",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SupplierName = c.String(),
                        TaxCode = c.Int(nullable: false),
                        City = c.String(),
                        District = c.String(),
                        Commune = c.String(),
                        DetailAddress = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InVoice",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TotalBeforeVAT = c.Double(nullable: false),
                        TotalAfterVAT = c.Double(nullable: false),
                        VAT = c.Double(nullable: false),
                        DeliveryFee = c.Double(nullable: false),
                        Status = c.String(nullable: false),
                        CustomerId = c.String(nullable: false, maxLength: 128),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.ProductsOnInvoice",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        POAId = c.String(maxLength: 128),
                        Sale = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        InvoiceId = c.String(maxLength: 128),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InVoice", t => t.InvoiceId)
                .ForeignKey("dbo.PropertyOfAttributes", t => t.POAId)
                .Index(t => t.POAId)
                .Index(t => t.InvoiceId);
            
            CreateTable(
                "dbo.PropertyOfAttributes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AttributesId = c.String(maxLength: 128),
                        POAName = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Attributes", t => t.AttributesId)
                .Index(t => t.AttributesId);
            
            CreateTable(
                "dbo.ProductsOnNote",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        POAId = c.String(maxLength: 128),
                        UnitPrice = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice1 = c.Double(nullable: false),
                        DiscountType = c.Boolean(nullable: false),
                        DiscountValue = c.Double(nullable: false),
                        TotalPrice2 = c.Double(nullable: false),
                        GoodsReceivedNoteId = c.String(maxLength: 128),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GoodsReceivedNote", t => t.GoodsReceivedNoteId)
                .ForeignKey("dbo.PropertyOfAttributes", t => t.POAId)
                .Index(t => t.POAId)
                .Index(t => t.GoodsReceivedNoteId);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        LogId = c.String(nullable: false, maxLength: 128),
                        AttributesId = c.String(maxLength: 128),
                        NoteOrInvoiceId = c.String(),
                        QuantityOfVeriation = c.Int(nullable: false),
                        QuantityCurrent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LogId)
                .ForeignKey("dbo.Attributes", t => t.AttributesId)
                .Index(t => t.AttributesId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        PassWord = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.String(),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedUserId = c.DateTime(),
                        DeletionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductAttributes",
                c => new
                    {
                        Product_Id = c.String(nullable: false, maxLength: 128),
                        Attributes_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Attributes_Id })
                .ForeignKey("dbo.Product", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Attributes", t => t.Attributes_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Attributes_Id);
            
            CreateTable(
                "dbo.CategoryProducts",
                c => new
                    {
                        Category_Id = c.String(nullable: false, maxLength: 128),
                        Product_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.Product_Id })
                .ForeignKey("dbo.Category", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stock", "AttributesId", "dbo.Attributes");
            DropForeignKey("dbo.ProductsOnNote", "POAId", "dbo.PropertyOfAttributes");
            DropForeignKey("dbo.ProductsOnNote", "GoodsReceivedNoteId", "dbo.GoodsReceivedNote");
            DropForeignKey("dbo.ProductsOnInvoice", "POAId", "dbo.PropertyOfAttributes");
            DropForeignKey("dbo.PropertyOfAttributes", "AttributesId", "dbo.Attributes");
            DropForeignKey("dbo.ProductsOnInvoice", "InvoiceId", "dbo.InVoice");
            DropForeignKey("dbo.InVoice", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.GoodsReceivedNote", "SupplierId", "dbo.supplier");
            DropForeignKey("dbo.CategoryProducts", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.CategoryProducts", "Category_Id", "dbo.Category");
            DropForeignKey("dbo.ProductAttributes", "Attributes_Id", "dbo.Attributes");
            DropForeignKey("dbo.ProductAttributes", "Product_Id", "dbo.Product");
            DropIndex("dbo.CategoryProducts", new[] { "Product_Id" });
            DropIndex("dbo.CategoryProducts", new[] { "Category_Id" });
            DropIndex("dbo.ProductAttributes", new[] { "Attributes_Id" });
            DropIndex("dbo.ProductAttributes", new[] { "Product_Id" });
            DropIndex("dbo.Stock", new[] { "AttributesId" });
            DropIndex("dbo.ProductsOnNote", new[] { "GoodsReceivedNoteId" });
            DropIndex("dbo.ProductsOnNote", new[] { "POAId" });
            DropIndex("dbo.PropertyOfAttributes", new[] { "AttributesId" });
            DropIndex("dbo.ProductsOnInvoice", new[] { "InvoiceId" });
            DropIndex("dbo.ProductsOnInvoice", new[] { "POAId" });
            DropIndex("dbo.InVoice", new[] { "CustomerId" });
            DropIndex("dbo.GoodsReceivedNote", new[] { "SupplierId" });
            DropTable("dbo.CategoryProducts");
            DropTable("dbo.ProductAttributes");
            DropTable("dbo.User");
            DropTable("dbo.Stock");
            DropTable("dbo.ProductsOnNote");
            DropTable("dbo.PropertyOfAttributes");
            DropTable("dbo.ProductsOnInvoice");
            DropTable("dbo.InVoice");
            DropTable("dbo.supplier");
            DropTable("dbo.GoodsReceivedNote");
            DropTable("dbo.Customer");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.Attributes");
        }
    }
}
