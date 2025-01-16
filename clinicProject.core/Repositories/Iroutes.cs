using clinicProject.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.core.Repositories
{
    public interface Iroutes
    {
        public Task<List<ClassRoute>> GetAsync();
        public Task<ClassRoute> AddAsync(ClassRoute routes);
    }
}
