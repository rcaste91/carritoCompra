using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompra.Data
{
    public class CarritoCompraDbContext : DbContext
    {

        public CarritoCompraDbContext(DbContextOptions<CarritoCompraDbContext>options)
            :base(options)
        {

        }

    }
}
