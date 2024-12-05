using clinicProject.core.Entities;
using Microsoft.EntityFrameworkCore;



namespace clinicProject
{
    public class DataContext :DbContext
    {

        public DbSet<ClassDoctor> doctors { get; set; }
        public DbSet<ClassRoute> routes { get; set; }
        public DbSet<ClassPatient> patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=clinic");
        }
        
    }

}
