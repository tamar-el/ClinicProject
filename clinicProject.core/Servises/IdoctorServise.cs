﻿using clinicProject.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.core.Servises
{
    public interface IdoctorServise
    {
        public List<ClassDoctor> GetClassDoctors();
        public ClassDoctor AddDoctor(ClassDoctor doctor);
    }
}