using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarritoCompra;

namespace CarritoCompra.Pages.Catalogo
{
    public class IndexModel : PageModel
    {
        private readonly CarritoCompra.ShoppingCartContext _context;

        public IndexModel(CarritoCompra.ShoppingCartContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; }

        public async Task OnGetAsync()
        {
            Cliente = await _context.Cliente
                .Include(c => c.IdUsuarioNavigation).ToListAsync();
        }
    }
}
