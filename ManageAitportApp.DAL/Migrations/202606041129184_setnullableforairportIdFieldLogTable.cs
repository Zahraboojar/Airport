namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setnullableforairportIdFieldLogTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Logs", new[] { "AirportId" });
            AlterColumn("dbo.Logs", "AirportId", c => c.Int());
            CreateIndex("dbo.Logs", "AirportId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Logs", new[] { "AirportId" });
            AlterColumn("dbo.Logs", "AirportId", c => c.Int(nullable: false));
            CreateIndex("dbo.Logs", "AirportId");
        }
    }
}
