using SupplierRegistrationContext.Models;
using System.ComponentModel.DataAnnotations;

namespace SupplierRegistrationContext.ViewModels;

public class RegisterSupplierViewModel
{
    [Required]
    [MaxLength(100)]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public string CNPJ { get; set; }

    [Required]
    public string CEP { get; set; }

    [Required]
    [StringLength(255)]
    public string Address { get; set; }

    [Required]
    public string Specialty { get; set; }
}
