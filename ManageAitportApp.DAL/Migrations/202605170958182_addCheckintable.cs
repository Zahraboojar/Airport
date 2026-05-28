namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCheckintable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketId = c.Int(nullable: false),
                        CheckInTime = c.DateTime(nullable: false),
                        GateNumber = c.String(),
                        LuggageWeight = c.Decimal(precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        Remarks = c.String(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedBy = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.TicketId)
                .Index(t => t.TicketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckIns", "TicketId", "dbo.Tickets");
            DropIndex("dbo.CheckIns", new[] { "TicketId" });
            DropTable("dbo.CheckIns");
        }
    }
}
