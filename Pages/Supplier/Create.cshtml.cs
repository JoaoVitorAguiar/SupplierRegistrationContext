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
using SupplierRegistrationContext.Services;
using SupplierRegistrationContext.ViewModels;

namespace SupplierRegistrationContext.Pages.Supplier
{
    public class CreateModel : PageModel
    {
        private readonly SupplierRegistrationContext.Data.DataContext _context;

        public CreateModel(SupplierRegistrationContext.Data.DataContext context)
        {
            _context = context;
            Specialties = _context.Specialtys.ToList();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegisterSupplierViewModel SupplierViewModel { get; set; } = default!;

        [BindProperty]
        public IEnumerable<Specialty> Specialties { get; set; } = default!;

        [BindProperty]
        public int SelectedSpecialtyId { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var specialty = await _context
                .Specialtys
                .FirstOrDefaultAsync(x => x.Id == SelectedSpecialtyId);

            Regex regexObj = new Regex(@"[^\d]");
            var cnpj = regexObj.Replace(SupplierViewModel.CNPJ, "");
            var cep = regexObj.Replace(SupplierViewModel.CEP, "");

            var address = await AddressFromCep.GetJson(cep);

            var supplier = new Models.Supplier
            {
                Name = SupplierViewModel.Name,
                CEP = int.Parse(cep),
                CNPJ = (long)Convert.ToInt64(cnpj),
                Specialty = specialty,
                Address = address
            };
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();

            return RedirectToPage("./List");
        }
    }
}
