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
        public async Task<List<ClassRoute>> GetClassRoutesAsync()
        {
            return await _routesRepository.GetAsync();

        }
        public async Task<ClassRoute> AddRoutesAsync(ClassRoute doctor)
        {
            return await _routesRepository.AddAsync(doctor);
        }
    }
}
