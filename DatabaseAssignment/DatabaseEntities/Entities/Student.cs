using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseEntities.Entities
{
    public partial class Student
    {
        public long StudentId { get; set; }
        public long CollegeId { get; set; }
        public long TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentAge { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string StudentCity { get; set; }
        public string StudentState { get; set; }
        public bool Gender { get; set; }

        public virtual College College { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
