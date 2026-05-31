namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteSettingTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Settings", "AirportId", "dbo.Airports");
            DropForeignKey("dbo.Settings", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Settings", "DeletedById", "dbo.Employees");
            DropIndex("dbo.Settings", new[] { "AirportId" });
            DropIndex("dbo.Settings", new[] { "CreatedById" });
            DropIndex("dbo.Settings", new[] { "DeletedById" });
            AddColumn("dbo.Airports", "Logo", c => c.String());
            DropTable("dbo.Settings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AirportId = c.Int(nullable: false),
                        Description = c.String(),
                        Email = c.String(),
                        Logo = c.String(),
                        Link = c.String(),
                        CreatedById = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedById = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Airports", "Logo");
            CreateIndex("dbo.Settings", "DeletedById");
            CreateIndex("dbo.Settings", "CreatedById");
            CreateIndex("dbo.Settings", "AirportId");
            AddForeignKey("dbo.Settings", "DeletedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Settings", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Settings", "AirportId", "dbo.Airports", "Id");
        }
    }
}
