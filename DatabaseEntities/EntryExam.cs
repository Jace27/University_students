using System;
using System.Collections.Generic;

namespace UniversityStudents.DatabaseEntities
{
    public class EntryExam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Auditory { get; set; }
        public DateTime ConsultationDate { get; set; }
        public int ConsultationAuditory { get; set; }

        public ICollection<DepartmentExam> Departments { get; set; }
        public ICollection<Examination> ExaminationSheet { get; set; }
    }
}
