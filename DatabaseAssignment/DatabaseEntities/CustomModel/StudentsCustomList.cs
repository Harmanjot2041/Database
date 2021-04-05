using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseEntities.CustomModel
{
    public class StudentsCustomList
    {
        public List<String> CollegeNames { get; set; }
        public List<String> TeachersName { get; set; }
        public StudentCustom StudentsData { get; set; }

    }
}
