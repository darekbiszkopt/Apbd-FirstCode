using Microsoft.EntityFrameworkCore;

namespace Entity6._0Solution.Models
{
    public class MainContext : DbContext
    {
       
        public MainContext()
        {
        }

        public MainContext(DbContextOptions dbContextOptionBuilder): base(dbContextOptionBuilder)
        {
        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s21522;Integrated Security=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prescription_Medicament>().HasKey(x => new { x.IdPrescription, x.IdMedicament });
            modelBuilder.Seed();
        }
    }
}
