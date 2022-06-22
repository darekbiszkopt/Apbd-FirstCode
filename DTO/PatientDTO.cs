namespace Entity6._0Solution.DTO
{
    public class PatientDTO
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthday { get; set; }

        public PatientDTO(String FirstName, String LastName, DateTime Birthday)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
        }

        public PatientDTO()
        {
        }
    }
}