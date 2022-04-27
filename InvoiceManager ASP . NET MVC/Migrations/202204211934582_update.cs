namespace InvoiceManager_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Clients", new[] { "Address_Id" });
            RenameColumn(table: "dbo.Clients", name: "Address_Id", newName: "AddressId");
            AlterColumn("dbo.Clients", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "AddressId");
            AddForeignKey("dbo.Clients", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
            DropColumn("dbo.Clients", "AddresId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "AddresId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Clients", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Clients", new[] { "AddressId" });
            AlterColumn("dbo.Clients", "AddressId", c => c.Int());
            RenameColumn(table: "dbo.Clients", name: "AddressId", newName: "Address_Id");
            CreateIndex("dbo.Clients", "Address_Id");
            AddForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}
