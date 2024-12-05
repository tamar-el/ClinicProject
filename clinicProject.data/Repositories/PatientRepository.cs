using clinicProject.core.Entities;
using clinicProject.core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.data.Repositories
{
    public class PatientRepository:Ipatient
    {
        private DataContext _context;
        public PatientRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<ClassPatient> Get()
        {
            return _context.patients;
        }
        public ClassPatient Add(ClassPatient patient)
        {
            _context.patients.Add(patient);
            _context.SaveChanges();
            return patient;
        }
    }
}
