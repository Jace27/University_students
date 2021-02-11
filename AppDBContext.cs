using System;
using System.Data.Entity;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DBConn")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<EntryExam> EntryExams { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<DepartmentExam> DepartmentExams { get; set; }
    }
}
