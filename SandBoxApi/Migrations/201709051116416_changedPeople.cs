namespace SandBoxApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedPeople : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "RfId", c => c.String());
            DropColumn("dbo.People", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.People", "RfId");
        }
    }
}
