namespace BookBiz_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rolesupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Role", c => c.Int(nullable: false));
        }
    }
}
