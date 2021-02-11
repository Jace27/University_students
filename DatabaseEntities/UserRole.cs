using System;
using System.Collections.Generic;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents.DatabaseEntities
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
