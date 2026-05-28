namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gates", "Capacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gates", "Capacity", c => c.Int());
        }
    }
}
