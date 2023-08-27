using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupplierRegistrationContext.Data;
using SupplierRegistrationContext.Models;

namespace SupplierRegistrationContext.Pages.Supplier
{
    public class EditModel : PageModel
    {
        private readonly SupplierRegistrationContext.Data.DataContext _context;

        public EditModel(SupplierRegistrationContext.Data.DataContext context)
        {
            _context = context;
            Specialties = _context.Specialtys.ToList();
        }

        [BindProperty]
        public Models.Supplier Supplier { get; set; } = default!;

        [BindProperty]
        public List<Specialty> Specialties { get; set; } = default!;

        [BindProperty]
        public int SelectedSpecialtyId { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier =  await _context.Suppliers.FirstOrDefaultAsync(m => m.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }
            Supplier = supplier;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var speciality = await _context.Specialtys.FirstOrDefaultAsync(x => x.Id == SelectedSpecialtyId);
            Supplier.Specialty = speciality;
            _context.Attach(Supplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(Supplier.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./List");
        }

        private bool SupplierExists(int id)
        {
          return (_context.Suppliers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
