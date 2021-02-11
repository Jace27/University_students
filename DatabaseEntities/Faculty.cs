using System;
using System.Collections.Generic;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents.DatabaseEntities
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentsNumber { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
