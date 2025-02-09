using clinicProject.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace clinicProject
{
    public class DataContext :DbContext
    {
        private readonly IConfiguration _configuration;
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
            
        }

        public DbSet<ClassDoctor> doctors { get; set; }
        public DbSet<ClassRoute> routes { get; set; }
        public DbSet<ClassPatient> patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);
        }
        
    }

}
