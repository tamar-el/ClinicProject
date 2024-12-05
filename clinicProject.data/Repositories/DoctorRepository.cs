using clinicProject.core.Entities;
using clinicProject.core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.data.Repositories
{
    public class DoctorRepository : Idoctor
    {
        private DataContext _context;
        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<ClassDoctor> Get()
        {
            return _context.doctors;
        }
        public ClassDoctor Add(ClassDoctor doctor)
        {
            _context.doctors.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }
        //public void Delete()
        //{
        //    _context.doctors.Clear();
        //}
    }
}
