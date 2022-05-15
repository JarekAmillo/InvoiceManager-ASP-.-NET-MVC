namespace InvoiceManager_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AJAX : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.InvoicePositions", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InvoicePositions", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
