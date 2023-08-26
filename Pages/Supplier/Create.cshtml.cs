using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupplierRegistrationContext.Data;
using SupplierRegistrationContext.Models;
using SupplierRegistrationContext.ViewModels;

namespace SupplierRegistrationContext.Pages.Supplier
{
    public class CreateModel : PageModel
    {
        private readonly SupplierRegistrationContext.Data.DataContext _context;

        public CreateModel(SupplierRegistrationContext.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegisterSupplierViewModel SupplierViewModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var specialty = await _context
                .Specialtys
                .FirstOrDefaultAsync(x => x.Name == SupplierViewModel.Specialty);

           
            Regex regexObj = new Regex(@"[^\d]");
            var cnpj = regexObj.Replace(SupplierViewModel.CNPJ, "");
            var cep = regexObj.Replace(SupplierViewModel.CEP, "");

            var supplier = new Models.Supplier
            {
                Name = SupplierViewModel.Name,
                CEP = int.Parse(cep),
                CNPJ = (long)Convert.ToInt64(cnpj),
                Address = SupplierViewModel.Address,
                Specialty = specialty
            };
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}
