using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class Producto
    {
        public Producto()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? CantMaxima { get; set; }
        public int IdCategoria { get; set; }
        public string Estado { get; set; }
        public int? Existencia { get; set; }

        public Categoria IdCategoriaNavigation { get; set; }
        public ICollection<Inventario> Inventario { get; set; }
    }
}
