using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplierRegistrationContext.Models;

[Table("Suppliers")]
public class Supplier
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public long CNPJ { get; set; }

    [Required]
    public int CEP { get; set; }

    [Required]
    [StringLength(255)]
    public string Address { get; set; }

    [Required]
    public Specialty Specialty { get; set; }
}
