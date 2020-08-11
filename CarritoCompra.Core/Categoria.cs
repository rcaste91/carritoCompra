using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string Categoria1 { get; set; }
        public string Estado { get; set; }

        public ICollection<Producto> Producto { get; set; }
    }
}
