using Entity6._0Solution.DTO;
using Entity6._0Solution.Models;
using Microsoft.AspNetCore.Mvc;

namespace Entity6._0Solution.Services
{
    public class PrescriptionService : IPrescriptionService
    {

        private readonly MainContext mainContext;

        public PrescriptionService(MainContext mainC)
        {
            this.mainContext = mainC;
        }
        public FullDataDTO GetPrescription(int idPrescription)
        {
            var fullData = new FullDataDTO();
            var prescription1 = new PrescriptionDTO();
            var doctor1 = new DoctorDTO();
            var patient1 = new PatientDTO();
            using (var context = this.mainContext)
            {
                /// get prescription
                var prescription = context.Prescription.Where(x => x.IdPresciption == idPrescription).First();
                prescription1 = new PrescriptionDTO(prescription.DueDate, prescription.Date, prescription.IdPatient, prescription.IdDoctor);

                /// get doctor
                var doctor = context.Doctor.Where(x => x.IdDoctor == prescription1.IdDoctor).First();
                doctor1 = new DoctorDTO(doctor.FirstName, doctor.LastName, doctor.Email);

                /// get patient
                var patient = context.Patient.Where(x => x.IdPatient == prescription1.IdPatient).First();
                patient1 = new PatientDTO(patient.FirstName, patient.LastName, patient.Birthday);
            };

            fullData.Prescription = prescription1;
            fullData.Doctor = doctor1;
            fullData.Patient = patient1;

            return fullData;

        }
    }
}
