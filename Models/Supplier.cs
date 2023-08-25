namespace SupplierRegistrationContext.Models;

public class Supplier
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public string CNPJ { get; set; }
    public string CEP { get; set; }

    public Specialty Specialty { get; set; }
}
