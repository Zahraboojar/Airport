namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editgatetable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Gates", new[] { "TerminalId" });
            AlterColumn("dbo.Gates", "GateNumber", c => c.String(nullable: false, maxLength: 2));
            CreateIndex("dbo.Gates", new[] { "TerminalId", "GateNumber" }, unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Gates", new[] { "TerminalId", "GateNumber" });
            AlterColumn("dbo.Gates", "GateNumber", c => c.String());
            CreateIndex("dbo.Gates", "TerminalId");
        }
    }
}
