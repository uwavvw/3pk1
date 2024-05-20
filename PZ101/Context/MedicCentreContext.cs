using Microsoft.EntityFrameworkCore;

namespace PZ101.Context
{
    public class MedicCentreContext : DbContext
    {
        public MedicCentreContext() { Database.EnsureCreated(); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.147.54; Initial Catalog=MedicCentre;User id = is; Password =1; TrustServerCertificate=True; MultipleActiveResultSets = True;");
        }

        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
    }
}
