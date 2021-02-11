namespace UniversityStudents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Main : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        ExamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.EntryExams", t => t.ExamId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.ExamId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FacultyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StudentsNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SecondName = c.String(),
                        PassportSeries = c.String(),
                        PassportNumber = c.String(),
                        PassportIssued = c.String(),
                        SchoolName = c.String(),
                        SchoolCity = c.String(),
                        SchoolEndDate = c.String(),
                        Medal = c.Boolean(),
                        DepartmentId = c.Int(),
                        FacultyId = c.Int(),
                        GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.Faculties", t => t.FacultyId)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .ForeignKey("dbo.UserRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.DepartmentId)
                .Index(t => t.FacultyId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Examinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ExamId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EntryExams", t => t.ExamId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ExamId);
            
            CreateTable(
                "dbo.EntryExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Auditory = c.Int(nullable: false),
                        ConsultationDate = c.DateTime(nullable: false),
                        ConsultationAuditory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThreadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Threads", t => t.ThreadId, cascadeDelete: true)
                .Index(t => t.ThreadId);
            
            CreateTable(
                "dbo.Threads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.UserRoles");
            DropForeignKey("dbo.Users", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Groups", "ThreadId", "dbo.Threads");
            DropForeignKey("dbo.Users", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.Examinations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Examinations", "ExamId", "dbo.EntryExams");
            DropForeignKey("dbo.DepartmentExams", "ExamId", "dbo.EntryExams");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.DepartmentExams", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Groups", new[] { "ThreadId" });
            DropIndex("dbo.Examinations", new[] { "ExamId" });
            DropIndex("dbo.Examinations", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "GroupId" });
            DropIndex("dbo.Users", new[] { "FacultyId" });
            DropIndex("dbo.Users", new[] { "DepartmentId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Departments", new[] { "FacultyId" });
            DropIndex("dbo.DepartmentExams", new[] { "ExamId" });
            DropIndex("dbo.DepartmentExams", new[] { "DepartmentId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Threads");
            DropTable("dbo.Groups");
            DropTable("dbo.EntryExams");
            DropTable("dbo.Examinations");
            DropTable("dbo.Users");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
            DropTable("dbo.DepartmentExams");
        }
    }
}
