using clinicProject.core.Entities;
using clinicProject.core.Repositories;
using Microsoft.EntityFrameworkCore;
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
            return _context.doctors.Include(o=>o.Routes);
        }
        public ClassDoctor Add(ClassDoctor doctor)
        {
            _context.doctors.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }
        public void Delete(ClassDoctor doctor)
        {
            _context?.doctors.Remove(doctor);

        }
        public void DeleteId(int id)
        {
            var doctors = _context.doctors.FirstOrDefault(x => x.id == id);
            if (doctors != null)
            {
                _context.doctors.Remove(doctors);
                _context.SaveChanges();

            }
        }
        
    }
}
