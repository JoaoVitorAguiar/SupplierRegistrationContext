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
    public class DetailsModel : PageModel
    {
        private readonly SupplierRegistrationContext.Data.DataContext _context;

        public DetailsModel(SupplierRegistrationContext.Data.DataContext context)
        {
            _context = context;
        }

      public Models.Supplier Supplier { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await _context.Suppliers.FirstOrDefaultAsync(m => m.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }
            else 
            {
                Supplier = supplier;
            }
            return Page();
        }
    }
}
