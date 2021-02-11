using System;

namespace UniversityStudents.DatabaseEntities
{
    public class Examination
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ExamId { get; set; }
        public int Grade { get; set; }

        public User User { get; set; }
        public EntryExam Exam { get; set; }
    }
}
