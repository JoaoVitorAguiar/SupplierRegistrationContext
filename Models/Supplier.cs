namespace SupplierRegistrationContext.Models;

public class Supplier
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int CNPJ { get; set; }
    public int CEP { get; set; }
    public string Address { get; set; }

    public Specialty Specialty { get; set; }
}
