namespace ZooProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Description");
        }
    }
}
