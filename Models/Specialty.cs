using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplierRegistrationContext.Models;

[Table("Specialties")]
public class Specialty
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(2)]
    public string Name { get; set; }

    public IList<Supplier> Suppliers { get; set; }
}
