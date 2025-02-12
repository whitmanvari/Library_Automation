namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        BookAuthor = c.String(),
                        BookPublisher = c.String(),
                        BookPage = c.Int(nullable: false),
                        BookYear = c.Int(nullable: false),
                        BookLanguage = c.String(),
                        BookGenre = c.String(),
                        BookDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        MembershipDate = c.DateTime(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
            DropTable("dbo.Books");
            DropTable("dbo.Admins");
        }
    }
}
