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
        public IEnumerable<ClassDoctor> Get();
        public ClassDoctor Add(ClassDoctor doctor);
        public void Delete(ClassDoctor doctor);
        public void DeleteId(int id);
    }
}
