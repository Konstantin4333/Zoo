namespace DataBaseServicee.Migrations
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
                        AnimalImage = c.Binary(),
                        IsDeleted = c.Int(nullable: false),
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
                        IsDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOfCategory);
            
            CreateTable(
                "dbo.CategoryOfTickets",
                c => new
                    {
                        IdOfCategoryTicket = c.Int(nullable: false, identity: true),
                        TicketType = c.String(),
                        NumOfTickets = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        IsDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOfCategoryTicket);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        IdOfEvent = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOfEvent)
                .ForeignKey("dbo.EventTypes", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        IsDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        IsDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser);
            
            CreateTable(
                "dbo.UserOrders",
                c => new
                    {
                        IdOrder = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        TypeOfTicket = c.String(),
                        price = c.Int(nullable: false),
                        IsDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOrder)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserOrders", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Events", "Id", "dbo.EventTypes");
            DropForeignKey("dbo.Animals", "AnimalCategoryID", "dbo.CategoryOfAnimals");
            DropIndex("dbo.UserOrders", new[] { "IdUser" });
            DropIndex("dbo.Events", new[] { "Id" });
            DropIndex("dbo.Animals", new[] { "AnimalCategoryID" });
            DropTable("dbo.UserOrders");
            DropTable("dbo.Users");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.CategoryOfTickets");
            DropTable("dbo.CategoryOfAnimals");
            DropTable("dbo.Animals");
        }
    }
}
