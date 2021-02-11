using System;
using System.Collections.Generic;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents.DatabaseEntities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
#pragma warning disable CS8632 // Аннотацию для ссылочных типов, допускающих значения NULL, следует использовать в коде только в контексте аннотаций "#nullable".
        public string? Password { get; set; }
#pragma warning restore CS8632 // Аннотацию для ссылочных типов, допускающих значения NULL, следует использовать в коде только в контексте аннотаций "#nullable".
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportIssued { get; set; }
        public string SchoolName { get; set; }
        public string SchoolCity { get; set; }
        public string SchoolEndDate { get; set; }
        public bool? Medal { get; set; }
        public int? DepartmentId { get; set; }
        public int? FacultyId { get; set; }
        public int? GroupId { get; set; }

        public UserRole Role { get; set; }
        public Department Department { get; set; }
        public Faculty Faculty { get; set; }
        public Group Group { get; set; }
        public ICollection<Examination> ExaminationSheet { get; set; }
    }
}
