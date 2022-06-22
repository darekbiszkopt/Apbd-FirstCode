namespace Entity6._0Solution.DTO
{
    public class FullDataDTO
    {
        public DoctorDTO Doctor { get; set; }
        public MedicamentDTO Medicament { get; set; }
        public PatientDTO Patient { get; set; }
        public PrescriptionDTO Prescription { get; set; }

        public FullDataDTO(DoctorDTO doctor, MedicamentDTO medicament, PatientDTO patient, PrescriptionDTO prescription)
        {
            Doctor = doctor;
            Medicament = medicament;
            Patient = patient;
            Prescription = prescription;
        }

        public FullDataDTO()
        {
        }
    }
}
