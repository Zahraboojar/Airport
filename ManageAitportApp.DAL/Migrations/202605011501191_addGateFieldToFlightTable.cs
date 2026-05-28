namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGateFieldToFlightTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Flights", "GateID");
            AddForeignKey("dbo.Flights", "GateID", "dbo.Gates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flights", "GateID", "dbo.Gates");
            DropIndex("dbo.Flights", new[] { "GateID" });
        }
    }
}
