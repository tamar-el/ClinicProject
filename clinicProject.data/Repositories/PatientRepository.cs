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
    public class PatientRepository:Ipatient
    {
        private DataContext _context;
        public PatientRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<ClassPatient>> GetAsync()
        {
            return await _context.patients.Include(o=>o.doctors).ToListAsync();
        }
        public async Task<ClassPatient> AddAsync(ClassPatient patient)
        {
            _context.patients.Add(patient);
           await _context.SaveChangesAsync();
            return patient;
        }
        public void Delete(ClassPatient patient)
        {
            _context.patients.Remove(patient);

        }
        public void DeleteId(int id)
        {
            var patients = _context.patients.FirstOrDefault(x => x.id == id);
            if (patients != null)
            {
                _context.patients.Remove(patients);
                _context.SaveChanges();

            }
        }
    }
}
