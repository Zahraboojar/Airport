namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserStatusToEmploeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Status");
        }
    }
}
