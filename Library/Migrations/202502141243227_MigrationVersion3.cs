namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationVersion3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Admins", newName: "Users");
            AddColumn("dbo.Users", "CreatedDate", c => c.DateTime(nullable: false));
            DropTable("dbo.Members");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        Role = c.Int(nullable: false),
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
            
            DropColumn("dbo.Users", "CreatedDate");
            RenameTable(name: "dbo.Users", newName: "Admins");
        }
    }
}
