﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseEntities.Entities
{
    public partial class College
    {
        public College()
        {
            Student = new HashSet<Student>();
            Teacher = new HashSet<Teacher>();
        }

        public long CollegeId { get; set; }
        public long UniversityId { get; set; }
        public string CollegeName { get; set; }
        public string CollegeCity { get; set; }
        public string CollegeState { get; set; }
        public bool IsWorking { get; set; }

        public virtual University University { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
