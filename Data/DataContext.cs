using Microsoft.EntityFrameworkCore;

namespace SupplierRegistrationContext.Data;

public class DataContext : DbContext
{

    public DataContext(DbContextOptions options) : base(options)
    {
    }
}
