namespace Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Lecturer = c.String(nullable: false),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        CategoryID = c.Byte(nullable: false),
                        lecturer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.lecturer_Id)
                .Index(t => t.CategoryID)
                .Index(t => t.lecturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "lecturer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.courses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.courses", new[] { "lecturer_Id" });
            DropIndex("dbo.courses", new[] { "CategoryID" });
            DropTable("dbo.courses");
            DropTable("dbo.Categories");
        }
    }
}
