using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupplierRegistrationContext.Data;
using SupplierRegistrationContext.Models;

namespace SupplierRegistrationContext.Pages.Supplier
{
    public class ListModel : PageModel
    {
        private readonly SupplierRegistrationContext.Data.DataContext _context;

        public ListModel(SupplierRegistrationContext.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Models.Supplier> Supplier { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Suppliers != null)
            {
                Supplier = await _context.Suppliers.Include(x => x.Specialty).ToListAsync();
            }
        }
    }
}
