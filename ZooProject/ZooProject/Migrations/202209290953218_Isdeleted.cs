namespace ZooProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Isdeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CategoryOfAnimals", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CategoryOfTickets", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Events", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.EventTypes", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserOrders", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserOrders", "IsDeleted");
            DropColumn("dbo.Users", "IsDeleted");
            DropColumn("dbo.EventTypes", "IsDeleted");
            DropColumn("dbo.Events", "IsDeleted");
            DropColumn("dbo.CategoryOfTickets", "IsDeleted");
            DropColumn("dbo.CategoryOfAnimals", "IsDeleted");
            DropColumn("dbo.Animals", "IsDeleted");
        }
    }
}
