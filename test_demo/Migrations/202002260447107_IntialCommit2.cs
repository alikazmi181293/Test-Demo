namespace test_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCommit2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.AspNetUsers", "Course_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Course_ID");
            AddForeignKey("dbo.AspNetUsers", "Course_ID", "dbo.Courses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Course_ID", "dbo.Courses");
            DropIndex("dbo.AspNetUsers", new[] { "Course_ID" });
            DropColumn("dbo.AspNetUsers", "Course_ID");
            DropTable("dbo.Courses");
        }
    }
}
