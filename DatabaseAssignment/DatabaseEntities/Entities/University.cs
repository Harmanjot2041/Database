﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseEntities.Entities
{
    public partial class University
    {
        public University()
        {
            College = new HashSet<College>();
        }

        public long UniversityId { get; set; }
        public string UniversityName { get; set; }
        public string UniversityType { get; set; }
        public bool IsInternational { get; set; }

        public virtual ICollection<College> College { get; set; }
    }
}
