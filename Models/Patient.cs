using System.ComponentModel.DataAnnotations;

namespace Entity6._0Solution.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public DateTime Birthday { get; set; }

        public ICollection<Prescription> presciptions { get; set; }
    }
}

