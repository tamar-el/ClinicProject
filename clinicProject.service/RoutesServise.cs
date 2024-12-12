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
    public class RoutesServise: IroutesSrevise
    {
        private Iroutes _routesRepository;
        public RoutesServise(Iroutes routesRepository)
        {
            _routesRepository = routesRepository;
        }
        public IEnumerable<ClassRoute> GetClassRoutes()
        {
            return _routesRepository.Get();

        }
        public ClassRoute AddRoutes(ClassRoute doctor)
        {
            return _routesRepository.Add(doctor);
        }
    }
}
