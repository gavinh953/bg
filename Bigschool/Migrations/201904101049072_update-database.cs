namespace Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {


        public override void Up()
        {


            DropForeignKey("dbo.courses", "lecturer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.courses", new[] { "lecturer_Id" });
            RenameColumn(table: "dbo.courses", name: "lecturer_Id", newName: "LecturerId");
            AlterColumn("dbo.courses", "LecturerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.courses", "LecturerId");
            AddForeignKey("dbo.courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.courses", "Lecturer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.courses", "Lecturer", c => c.String(nullable: false));
            DropForeignKey("dbo.courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.courses", new[] { "LecturerId" });
            AlterColumn("dbo.courses", "LecturerId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.courses", name: "LecturerId", newName: "lecturer_Id");
            CreateIndex("dbo.courses", "lecturer_Id");
            AddForeignKey("dbo.courses", "lecturer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
