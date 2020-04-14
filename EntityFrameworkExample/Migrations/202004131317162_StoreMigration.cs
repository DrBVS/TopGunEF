namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoreMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Phones", "StoreId", c => c.Int());
            AddColumn("dbo.Phones", "Store_Id", c => c.Int());
            CreateIndex("dbo.Phones", "StoreId");
            CreateIndex("dbo.Phones", "Store_Id");
            AddForeignKey("dbo.Phones", "StoreId", "dbo.Stores", "Id");
            AddForeignKey("dbo.Phones", "Store_Id", "dbo.Stores", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Phones", "StoreId", "dbo.Stores");
            DropIndex("dbo.Phones", new[] { "Store_Id" });
            DropIndex("dbo.Phones", new[] { "StoreId" });
            DropColumn("dbo.Phones", "Store_Id");
            DropColumn("dbo.Phones", "StoreId");
            DropTable("dbo.Stores");
        }
    }
}
