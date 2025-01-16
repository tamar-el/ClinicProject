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
    public class PatientServise: IpatientSrevise
    {
        private Ipatient _patientRepository;
        public PatientServise(Ipatient patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public async Task<List<ClassPatient>> GetClassdPatientAsync()
        {
            return await _patientRepository.GetAsync();

        }
        public async Task<ClassPatient> AddPatientAsync(ClassPatient doctor)
        {
            return await _patientRepository.AddAsync(doctor);
        }
    }
}
