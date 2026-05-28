namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Aircrafts", newName: "Aircraft");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Aircraft", newName: "Aircrafts");
        }
    }
}
