namespace ZooProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class animal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AnimalImage", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "AnimalImage");
        }
    }
}
