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
    public class DoctorServise : IdoctorServise
    {
        private Idoctor _doctorRepository;
        public DoctorServise(Idoctor doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public async Task<List<ClassDoctor>> GetClassDoctorsAsync()
        {
            return await _doctorRepository.GetAsync();

        }
        public async Task<ClassDoctor> AddDoctorAsync(ClassDoctor doctor)
        {
            return await _doctorRepository.AddAsync(doctor);
        }

        public ClassDoctor Get(int id)
        {
            throw new NotImplementedException();
        }
        //public ClassDoctor Get(int id)
        //{
        //    return _doctorRepository.Get(id);
        //}
    }
}
