

using clinicProject.core.Entities;
using clinicProject.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.data.Repositories
{
    public class RouteRepository:Iroutes
    {
        private DataContext _context;
        public RouteRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<ClassRoute> Get()
        {
            return _context.routes;
        }
        public ClassRoute Add(ClassRoute routes)
        {
            _context.routes.Add(routes);
            _context.SaveChanges();
            return routes;
        }
    }
}
