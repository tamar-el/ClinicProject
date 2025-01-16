

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
   
    public class RouteRepository:Iroutes
    {
        private DataContext _context;
        public RouteRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<ClassRoute>> GetAsync()
        {
            return await _context.routes.ToListAsync();
        }
        public async Task<ClassRoute> AddAsync(ClassRoute routes)
        {
            _context.routes.Add(routes);
            await _context.SaveChangesAsync();
            return routes;
        }
    }
}
