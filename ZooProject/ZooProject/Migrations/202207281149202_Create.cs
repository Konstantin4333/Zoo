namespace ZooProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        IdAnimal = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        AnimalCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAnimal)
                .ForeignKey("dbo.CategoryOfAnimals", t => t.AnimalCategoryID, cascadeDelete: true)
                .Index(t => t.AnimalCategoryID);
            
            CreateTable(
                "dbo.CategoryOfAnimals",
                c => new
                    {
                        IdOfCategory = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdOfCategory);
            
            CreateTable(
                "dbo.CategoryOfTickets",
                c => new
                    {
                        IdOfCategoryTicket = c.Int(nullable: false, identity: true),
                        TicketType = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdOfCategoryTicket);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        IdOfEvent = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        IdTypeOfEvent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOfEvent)
                .ForeignKey("dbo.EventTypes", t => t.IdTypeOfEvent, cascadeDelete: true)
                .Index(t => t.IdTypeOfEvent);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        IdTypeOfEvent = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.IdTypeOfEvent);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        IdOfTicket = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumOfTickets = c.Int(nullable: false),
                        IdOfCategoryTicket = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOfTicket)
                .ForeignKey("dbo.CategoryOfTickets", t => t.IdOfCategoryTicket, cascadeDelete: true)
                .Index(t => t.IdOfCategoryTicket);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdUser);
            
            CreateTable(
                "dbo.UserOrders",
                c => new
                    {
                        IdOrder = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdOfTicket = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOrder)
                .ForeignKey("dbo.Tickets", t => t.IdOfTicket, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdOfTicket);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserOrders", "IdUser", "dbo.Users");
            DropForeignKey("dbo.UserOrders", "IdOfTicket", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "IdOfCategoryTicket", "dbo.CategoryOfTickets");
            DropForeignKey("dbo.Events", "IdTypeOfEvent", "dbo.EventTypes");
            DropForeignKey("dbo.Animals", "AnimalCategoryID", "dbo.CategoryOfAnimals");
            DropIndex("dbo.UserOrders", new[] { "IdOfTicket" });
            DropIndex("dbo.UserOrders", new[] { "IdUser" });
            DropIndex("dbo.Tickets", new[] { "IdOfCategoryTicket" });
            DropIndex("dbo.Events", new[] { "IdTypeOfEvent" });
            DropIndex("dbo.Animals", new[] { "AnimalCategoryID" });
            DropTable("dbo.UserOrders");
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.CategoryOfTickets");
            DropTable("dbo.CategoryOfAnimals");
            DropTable("dbo.Animals");
        }
    }
}
