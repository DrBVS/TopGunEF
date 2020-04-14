namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VendorMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Phones", "Vendor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Phones", "Vendor");
        }
    }
}
