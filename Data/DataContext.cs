using Microsoft.EntityFrameworkCore;
using SupplierRegistrationContext.Models;

namespace SupplierRegistrationContext.Data;

public class DataContext : DbContext
{
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Specialty> Specialtys { get; set; }
    public DataContext(DbContextOptions options) : base(options)
    {
    }
}
