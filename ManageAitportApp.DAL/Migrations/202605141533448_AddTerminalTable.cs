namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTerminalTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gates", "AirportId", "dbo.Airports");
            DropIndex("dbo.Gates", new[] { "AirportId" });
            CreateTable(
                "dbo.Terminals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AirportId = c.Int(nullable: false),
                        Name = c.String(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedBy = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.AirportId)
                .Index(t => t.AirportId);
            
            AddColumn("dbo.Gates", "TerminalId", c => c.Int(nullable: false));
            CreateIndex("dbo.Gates", "TerminalId");
            AddForeignKey("dbo.Gates", "TerminalId", "dbo.Terminals", "Id");
            DropColumn("dbo.Gates", "Terminal");
            DropColumn("dbo.Gates", "AirportId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gates", "AirportId", c => c.Int(nullable: false));
            AddColumn("dbo.Gates", "Terminal", c => c.String());
            DropForeignKey("dbo.Gates", "TerminalId", "dbo.Terminals");
            DropForeignKey("dbo.Terminals", "AirportId", "dbo.Airports");
            DropIndex("dbo.Terminals", new[] { "AirportId" });
            DropIndex("dbo.Gates", new[] { "TerminalId" });
            DropColumn("dbo.Gates", "TerminalId");
            DropTable("dbo.Terminals");
            CreateIndex("dbo.Gates", "AirportId");
            AddForeignKey("dbo.Gates", "AirportId", "dbo.Airports", "Id");
        }
    }
}
