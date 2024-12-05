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
        public List<ClassPatient> GetClassdPatient()
        {
            return _patientRepository.Get();

        }
        public ClassPatient AddPatient(ClassPatient doctor)
        {
            return _patientRepository.Add(doctor);
        }
    }
}
