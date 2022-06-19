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
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor() { FirstName = "First Standard", LastName = "X@", Email = "DS" },
                new Doctor() { FirstName = "Second Standard", LastName = "X", Email = "FG" },
                new Doctor() { FirstName = "Third Standard", LastName = "XX", Email = "WS" });

            modelBuilder.Entity<Patient>().HasData(
                new Patient() { FirstName = "First Standard", LastName = "X@", Birthday = new DateTime(1995, 04, 22) },
                new Patient() { FirstName = "Second Standard", LastName = "X", Birthday = new DateTime(1995, 11, 21) },
                new Patient() { FirstName = "Third Standard", LastName = "XX", Birthday = new DateTime(1995, 12, 12) });

            modelBuilder.Entity<Medicament>().HasData(
               new Medicament() { Name = "Apap", Description = "xxxsas sdssX@", Type = "X@" },
               new Medicament() { Name = "Ibuprom", Description = "lorem ipsum", Type = "X@" });

            modelBuilder.Entity<Prescription>().HasData(
              new Prescription() { IdPresciption = 1, Date = new DateTime(1895, 04, 22), DueDate = new DateTime(1895, 24, 22), IdPatient = 1, IdDoctor = 2 },
              new Prescription() { IdPresciption = 2, Date = new DateTime(2005, 04, 22), DueDate = new DateTime(1295, 04, 22), IdPatient = 1, IdDoctor = 1 });

            modelBuilder.Entity<Prescription_Medicament>().HasData(
            new Prescription_Medicament() { IdMedicament = 1, IdPrescription = 1, Dose = 1, Details = "Str"},
            new Prescription_Medicament() { IdMedicament = 2, IdPrescription = 2, Dose = 2, Details = "Txr"}
            );

        }
    }
}
