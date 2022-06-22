using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity6._0Solution.Models
{
    public class Prescription_Medicament
    {
    [Key]
    [Required]
    public int IdMedicament { get; set; }
    [Key]
    [Required]
    public int IdPrescription { get; set; }
    public int? Dose { get; set; }
    [Required]
    [MaxLength(100)]
    public string Details { get; set; }

    [ForeignKey("IdMedicament")]
    public virtual Medicament Medicament { get; set; }
    [ForeignKey("IdPrescription")]
    public virtual Prescription Presciption { get; set; }
    }

}
