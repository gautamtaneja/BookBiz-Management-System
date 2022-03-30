namespace BookBiz_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.AuthorID)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ISBN = c.Int(nullable: false),
                        Title = c.String(),
                        UnitPrice = c.Int(nullable: false),
                        YearOfPublish = c.DateTime(nullable: false),
                        QOH = c.Int(nullable: false),
                        Category = c.Int(nullable: false),
                        Publisher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .Index(t => t.Publisher_Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        FaxNumber = c.Int(nullable: false),
                        CreditLimit = c.Int(nullable: false),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Books", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.Authors", "Book_Id", "dbo.Books");
            DropIndex("dbo.Clients", new[] { "Role_Id" });
            DropIndex("dbo.Books", new[] { "Publisher_Id" });
            DropIndex("dbo.Authors", new[] { "Book_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Roles");
            DropTable("dbo.Clients");
            DropTable("dbo.Categories");
            DropTable("dbo.Publishers");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
