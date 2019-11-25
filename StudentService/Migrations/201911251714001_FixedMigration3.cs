namespace StudentService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedMigration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        label = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        label = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        tel = c.Int(nullable: false),
                        cpf = c.Int(nullable: false),
                        courseID = c.Int(nullable: false),
                        genderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Courses", t => t.courseID, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.genderID, cascadeDelete: true)
                .Index(t => t.courseID)
                .Index(t => t.genderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "genderID", "dbo.Genders");
            DropForeignKey("dbo.Students", "courseID", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "genderID" });
            DropIndex("dbo.Students", new[] { "courseID" });
            DropTable("dbo.Students");
            DropTable("dbo.Genders");
            DropTable("dbo.Courses");
        }
    }
}
