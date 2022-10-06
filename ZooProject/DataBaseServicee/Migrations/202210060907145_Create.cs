namespace DataBaseServicee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserOrders", "TypeOfEvent", c => c.String());
            AddColumn("dbo.UserOrders", "NameOfEvent", c => c.String());
            AddColumn("dbo.UserOrders", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserOrders", "TypeOfTicket", c => c.String());
            AddColumn("dbo.UserOrders", "price", c => c.Int(nullable: false));
            AddColumn("dbo.UserOrders", "CategoryOfTickets_IdOfCategoryTicket", c => c.Int());
            AddColumn("dbo.UserOrders", "Events_IdOfEvent", c => c.Int());
            AddColumn("dbo.UserOrders", "EventType_Id", c => c.Int());
            CreateIndex("dbo.UserOrders", "CategoryOfTickets_IdOfCategoryTicket");
            CreateIndex("dbo.UserOrders", "Events_IdOfEvent");
            CreateIndex("dbo.UserOrders", "EventType_Id");
            AddForeignKey("dbo.UserOrders", "CategoryOfTickets_IdOfCategoryTicket", "dbo.CategoryOfTickets", "IdOfCategoryTicket");
            AddForeignKey("dbo.UserOrders", "Events_IdOfEvent", "dbo.Events", "IdOfEvent");
            AddForeignKey("dbo.UserOrders", "EventType_Id", "dbo.EventTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserOrders", "EventType_Id", "dbo.EventTypes");
            DropForeignKey("dbo.UserOrders", "Events_IdOfEvent", "dbo.Events");
            DropForeignKey("dbo.UserOrders", "CategoryOfTickets_IdOfCategoryTicket", "dbo.CategoryOfTickets");
            DropIndex("dbo.UserOrders", new[] { "EventType_Id" });
            DropIndex("dbo.UserOrders", new[] { "Events_IdOfEvent" });
            DropIndex("dbo.UserOrders", new[] { "CategoryOfTickets_IdOfCategoryTicket" });
            DropColumn("dbo.UserOrders", "EventType_Id");
            DropColumn("dbo.UserOrders", "Events_IdOfEvent");
            DropColumn("dbo.UserOrders", "CategoryOfTickets_IdOfCategoryTicket");
            DropColumn("dbo.UserOrders", "price");
            DropColumn("dbo.UserOrders", "TypeOfTicket");
            DropColumn("dbo.UserOrders", "Date");
            DropColumn("dbo.UserOrders", "NameOfEvent");
            DropColumn("dbo.UserOrders", "TypeOfEvent");
        }
    }
}
