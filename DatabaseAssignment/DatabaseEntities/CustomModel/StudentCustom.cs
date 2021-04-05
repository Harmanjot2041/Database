using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseEntities.CustomModel
{
    public  class StudentCustom
    {
        public long StudentId { get; set; }
        public string CollegeName { get; set; }
        public string TeacherName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentAge { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string StudentCity { get; set; }
        public string StudentState { get; set; }
        public bool Gender { get; set; }

    }
}
