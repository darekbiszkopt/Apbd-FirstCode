namespace Entity6._0Solution.DTO
{
    public class PrescriptionDTO
    {
        public DateTime DueDate { get; set; }
        public DateTime Date { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }

        public PrescriptionDTO(DateTime dueDate, DateTime date, int idPatient, int idDoctor)
        {
            DueDate = dueDate;
            Date = date;
            IdPatient = idPatient;
            IdDoctor = idDoctor;
        }

        public PrescriptionDTO()
        {
        }
    }
}
