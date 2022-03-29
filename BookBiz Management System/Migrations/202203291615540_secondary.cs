namespace BookBiz_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Role_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Role_Id");
            AddForeignKey("dbo.Employees", "Role_Id", "dbo.Roles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "Role_Id" });
            DropColumn("dbo.Employees", "Role_Id");
        }
    }
}
