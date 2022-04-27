namespace InvoiceManager_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class whiteText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Invoices", "CreatetDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "CreatetDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Invoices", "CreatedDate");
        }
    }
}
