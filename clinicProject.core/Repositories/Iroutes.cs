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
        public IEnumerable<ClassRoute> Get();
        public ClassRoute Add(ClassRoute doctor);
    }
}
