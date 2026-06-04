namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setoptional : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employees", new[] { "AirportId" });
            AlterColumn("dbo.Employees", "AirportId", c => c.Int());
            CreateIndex("dbo.Employees", "AirportId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "AirportId" });
            AlterColumn("dbo.Employees", "AirportId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "AirportId");
        }
    }
}
