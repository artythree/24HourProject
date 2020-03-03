namespace TwentyFourHourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondTry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "PostId", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "Post_PostId", c => c.Int());
            AddColumn("dbo.Comments", "Post_PostId1", c => c.Int());
            CreateIndex("dbo.Comments", "Post_PostId");
            CreateIndex("dbo.Comments", "Post_PostId1");
            AddForeignKey("dbo.Comments", "Post_PostId", "dbo.Posts", "PostId");
            AddForeignKey("dbo.Comments", "Post_PostId1", "dbo.Posts", "PostId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Post_PostId1", "dbo.Posts");
            DropForeignKey("dbo.Comments", "Post_PostId", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "Post_PostId1" });
            DropIndex("dbo.Comments", new[] { "Post_PostId" });
            DropColumn("dbo.Comments", "Post_PostId1");
            DropColumn("dbo.Comments", "Post_PostId");
            DropColumn("dbo.Comments", "PostId");
        }
    }
}
