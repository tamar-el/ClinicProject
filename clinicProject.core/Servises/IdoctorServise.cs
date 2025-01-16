using clinicProject.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.core.Servises
{
    public interface IdoctorServise
    {
        public Task<List<ClassDoctor>> GetClassDoctorsAsync();
        public Task<ClassDoctor> AddDoctorAsync(ClassDoctor doctor);
        public ClassDoctor Get(int id);
    }
}
