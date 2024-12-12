using clinicProject.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.core.Servises
{
    public interface IroutesSrevise
    {
        public IEnumerable<ClassRoute> GetClassRoutes();
        public ClassRoute AddRoutes(ClassRoute doctor);
    }
}
