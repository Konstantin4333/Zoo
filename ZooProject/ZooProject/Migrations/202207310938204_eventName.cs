namespace ZooProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Name");
        }
    }
}
