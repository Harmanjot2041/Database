using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseEntities.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Student = new HashSet<Student>();
        }

        public long TeacherId { get; set; }
        public long CollegeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeacherAge { get; set; }
        public string Email { get; set; }
        public string SubjectTeaches { get; set; }
        public string TeacherCity { get; set; }
        public int YearOfExperience { get; set; }
        public bool Gender { get; set; }

        public virtual College College { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
