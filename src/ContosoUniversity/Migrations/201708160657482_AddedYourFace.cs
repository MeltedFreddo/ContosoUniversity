namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedYourFace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "YourFace", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Course", "YourFace");
        }
    }
}
