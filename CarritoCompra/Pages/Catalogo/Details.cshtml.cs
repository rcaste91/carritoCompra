﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarritoCompra;

namespace CarritoCompra.Pages.Catalogo
{
    public class DetailsModel : PageModel
    {
        private readonly CarritoCompra.ShoppingCartContext _context;

        public DetailsModel(CarritoCompra.ShoppingCartContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Cliente
                .Include(c => c.IdUsuarioNavigation).FirstOrDefaultAsync(m => m.IdCliente == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
