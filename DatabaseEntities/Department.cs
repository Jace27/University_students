using System;
using System.Collections.Generic;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents.DatabaseEntities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FacultyId { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<DepartmentExam> Exams { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
