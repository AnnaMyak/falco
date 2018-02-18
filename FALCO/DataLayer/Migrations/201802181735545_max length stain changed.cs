namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maxlengthstainchanged : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.OrderModels", newName: "Orders");
            RenameColumn(table: "dbo.Orders", name: "OrderModel_Id", newName: "Order_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_OrderModel_Id", newName: "IX_Order_Id");
            AddColumn("dbo.Orders", "Creation", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "Organ", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Orders", "Tissue", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Orders", "Stain", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Stain", c => c.String());
            AlterColumn("dbo.Orders", "Tissue", c => c.String());
            AlterColumn("dbo.Orders", "Organ", c => c.String());
            DropColumn("dbo.Orders", "Creation");
            RenameIndex(table: "dbo.Orders", name: "IX_Order_Id", newName: "IX_OrderModel_Id");
            RenameColumn(table: "dbo.Orders", name: "Order_Id", newName: "OrderModel_Id");
            RenameTable(name: "dbo.Orders", newName: "OrderModels");
        }
    }
}
