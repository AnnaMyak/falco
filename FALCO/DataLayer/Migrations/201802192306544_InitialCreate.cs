namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Criteria",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Criteria_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.Criteria_Id)
                .Index(t => t.Criteria_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Organ = c.String(nullable: false, maxLength: 40),
                        Tissue = c.String(nullable: false, maxLength: 40),
                        Stain = c.String(nullable: false, maxLength: 20),
                        Value = c.Int(nullable: false),
                        Acceptance = c.Double(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Order_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Criteria", "Criteria_Id", "dbo.Criteria");
            DropIndex("dbo.Orders", new[] { "Order_Id" });
            DropIndex("dbo.Criteria", new[] { "Criteria_Id" });
            DropTable("dbo.Orders");
            DropTable("dbo.Criteria");
        }
    }
}
