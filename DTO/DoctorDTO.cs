namespace Entity6._0Solution.DTO
{
    public class DoctorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public DoctorDTO(String FirstName, String LastName, String Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
        }

        public DoctorDTO()
        {
        }
    }
}
