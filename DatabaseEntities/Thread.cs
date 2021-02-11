using System;
using System.Collections.Generic;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents.DatabaseEntities
{
    public class Thread
    {
        public int Id { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
