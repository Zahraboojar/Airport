namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditTableNameCulomnLogTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logs", "TableName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logs", "TableName", c => c.Int(nullable: false));
        }
    }
}
