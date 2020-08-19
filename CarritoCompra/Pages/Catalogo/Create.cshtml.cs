using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarritoCompra;

namespace CarritoCompra.Pages.Catalogo
{
    public class CreateModel : PageModel
    {
        private readonly CarritoCompra.ShoppingCartContext _context;

        public CreateModel(CarritoCompra.ShoppingCartContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario");
            return Page();
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cliente.Add(Cliente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}