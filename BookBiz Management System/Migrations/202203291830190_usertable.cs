namespace BookBiz_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Clients", new[] { "Role_Id" });
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.Clients", "Role", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "Role_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Role_Id", c => c.Int());
            DropColumn("dbo.Clients", "Role");
            DropTable("dbo.Users");
            CreateIndex("dbo.Clients", "Role_Id");
            AddForeignKey("dbo.Clients", "Role_Id", "dbo.Roles", "Id");
        }
    }
}
