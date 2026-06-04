namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixdatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.CheckIns", "DeletedById", "dbo.Employees");
            DropForeignKey("dbo.CheckIns", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.CheckIns", "UpdatedById", "dbo.Employees");
            DropIndex("dbo.CheckIns", new[] { "TicketId" });
            DropIndex("dbo.CheckIns", new[] { "UpdatedById" });
            DropIndex("dbo.CheckIns", new[] { "CreatedById" });
            DropIndex("dbo.CheckIns", new[] { "DeletedById" });
            DropTable("dbo.CheckIns");
        }
        
        public override void Down()
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
                        UpdatedById = c.Int(),
                        CreatedById = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedById = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.CheckIns", "DeletedById");
            CreateIndex("dbo.CheckIns", "CreatedById");
            CreateIndex("dbo.CheckIns", "UpdatedById");
            CreateIndex("dbo.CheckIns", "TicketId");
            AddForeignKey("dbo.CheckIns", "UpdatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.CheckIns", "TicketId", "dbo.Tickets", "Id");
            AddForeignKey("dbo.CheckIns", "DeletedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees", "Id");
        }
    }
}
