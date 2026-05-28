namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameField : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Flights", new[] { "GateID" });
            CreateIndex("dbo.Flights", "GateId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Flights", new[] { "GateId" });
            CreateIndex("dbo.Flights", "GateID");
        }
    }
}
