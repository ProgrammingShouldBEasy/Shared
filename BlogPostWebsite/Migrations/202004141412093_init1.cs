namespace BlogPostWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "AuthorId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "AuthorId", c => c.Int(nullable: false));
        }
    }
}
