using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity6._0Solution.Models
{
    public class Prescription
    {
        [Key]
        public int IdPresciption { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public int IdPatient { get; set; }
        [Required]
        public int IdDoctor { get; set; }

        [ForeignKey("IdDoctor")]
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }

        public virtual ICollection<Prescription_Medicament> Medicaments { get; set; }
    }

}

