using System;
using System.Collections.Generic;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents.DatabaseEntities
{
    public class Group
    {
        public int Id { get; set; }
        public int ThreadId { get; set; }

        public Thread Thread { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
