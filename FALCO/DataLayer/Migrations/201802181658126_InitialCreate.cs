namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderModels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Organ = c.String(),
                        Tissue = c.String(),
                        Stain = c.String(),
                        Value = c.Int(nullable: false),
                        Acceptance = c.Double(nullable: false),
                        OrderModel_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderModels", t => t.OrderModel_Id)
                .Index(t => t.OrderModel_Id);
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderModels", "Creation", c => c.DateTime());
            DropForeignKey("dbo.OrderModels", "OrderModel_Id", "dbo.OrderModels");
            DropIndex("dbo.OrderModels", new[] { "OrderModel_Id" });
            DropTable("dbo.OrderModels");
        }
    }
}
