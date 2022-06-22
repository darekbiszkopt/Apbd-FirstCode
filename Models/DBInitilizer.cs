using Entity6._0Solution.Models;
using Microsoft.EntityFrameworkCore;

public static class DBInitilizer
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor() { IdDoctor=1, FirstName = "First Standard", LastName = "X@", Email = "DS" },
            new Doctor() { IdDoctor = 2, FirstName = "Second Standard", LastName = "X", Email = "FG" },
            new Doctor() { IdDoctor = 3, FirstName = "Third Standard", LastName = "XX", Email = "WS" });

        modelBuilder.Entity<Patient>().HasData(
            new Patient() {IdPatient = 1, FirstName = "First Standard", LastName = "X@", Birthday = new DateTime(1995, 04, 22) },
            new Patient() {IdPatient = 2, FirstName = "Second Standard", LastName = "X", Birthday = new DateTime(1995, 11, 21) },
            new Patient() {IdPatient = 3, FirstName = "Third Standard", LastName = "XX", Birthday = new DateTime(1995, 12, 12) });

        modelBuilder.Entity<Medicament>().HasData(
           new Medicament() {IdMedicament=1 ,Name = "Apap", Description = "xxxsas sdssX@", Type = "X@" },
           new Medicament() { IdMedicament=2 , Name = "Ibuprom", Description = "lorem ipsum", Type = "X@" });

        modelBuilder.Entity<Prescription>().HasData(
          new Prescription() { IdPresciption = 1, Date = new DateTime(1895, 04, 22), DueDate = new DateTime(1895, 11, 22), IdPatient = 1, IdDoctor = 2 },
          new Prescription() { IdPresciption = 2, Date = new DateTime(2005, 04, 22), DueDate = new DateTime(1295, 04, 22), IdPatient = 1, IdDoctor = 1 });

        modelBuilder.Entity<Prescription_Medicament>().HasData(
        new Prescription_Medicament() { IdMedicament = 1, IdPrescription = 1, Dose = 1, Details = "Str" },
        new Prescription_Medicament() { IdMedicament = 2, IdPrescription = 2, Dose = 2, Details = "Txr" });



    }


}