using clinicProject.core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.core.Repositories
{
    public interface Idoctor
    {
        public Task<List<ClassDoctor>> GetAsync();
        public Task<ClassDoctor> AddAsync(ClassDoctor doctor);
        public void Delete(ClassDoctor doctor);
        public Task DeleteIdAsync(int id);
        public Task SaveChangesAsync();
        
    }
}
