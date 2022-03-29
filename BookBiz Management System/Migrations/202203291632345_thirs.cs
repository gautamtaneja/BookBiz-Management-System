namespace BookBiz_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "Role_Id" });
            AddColumn("dbo.Employees", "Role", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Role_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Role_Id", c => c.Int());
            DropColumn("dbo.Employees", "Role");
            CreateIndex("dbo.Employees", "Role_Id");
            AddForeignKey("dbo.Employees", "Role_Id", "dbo.Roles", "Id");
        }
    }
}
