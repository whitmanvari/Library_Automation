namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
