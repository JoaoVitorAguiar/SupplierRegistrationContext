namespace SupplierRegistrationContext.Models;

public class Specialty
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IList<Supplier> Suppliers { get; set; }
}
