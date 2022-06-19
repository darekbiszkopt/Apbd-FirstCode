using System.ComponentModel.DataAnnotations;

namespace Entity6._0Solution.Models
{
    public class Medicament
    {
        [Key]
        public int IdMedicament { get; set; }
        [Required]
        [MaxLength(100)]
        public String Name { get; set; }
        [Required]
        [MaxLength(100)]
        public String Description { get; set; }
        [Required]
        [MaxLength(100)]
        public String Type { get; set; }

        public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
    }

}
