using System;
using System.Collections.Generic;

namespace UniversityStudents.DatabaseEntities
{
    public class DepartmentExam
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int ExamId { get; set; }

        public Department Department { get; set; }
        public EntryExam Exam { get; set; }
    }
}
