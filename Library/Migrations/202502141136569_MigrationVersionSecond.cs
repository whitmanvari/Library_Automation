namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationVersionSecond : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Admins", "RoleId", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "RoleId", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "Role", c => c.Int(nullable: false));
            AlterColumn("dbo.Admins", "Role", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "Role", c => c.String());
            DropColumn("dbo.Members", "Role");
            DropColumn("dbo.Members", "RoleId");
            DropColumn("dbo.Admins", "RoleId");
            DropTable("dbo.Roles");
        }
    }
}
