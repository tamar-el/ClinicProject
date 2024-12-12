using clinicProject.core.Servises;
using clinicProject.core.Repositories;
using clinicProject.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.service
{
    public class DoctorServise: IdoctorServise
    {
        private Idoctor _doctorRepository;
        public DoctorServise(Idoctor doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public IEnumerable<ClassDoctor> GetClassDoctors() {
            return _doctorRepository.Get();
             
        }
        public ClassDoctor AddDoctor(ClassDoctor doctor)
        {
            return _doctorRepository.Add(doctor);
        }
        }
}
