namespace SandBoxApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "LocationId", c => c.Int(nullable: false));
            DropColumn("dbo.People", "PersonId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "PersonId", c => c.Int(nullable: false));
            DropColumn("dbo.People", "LocationId");
        }
    }
}
