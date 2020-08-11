using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public int? CantAgregada { get; set; }
        public int? CantInicial { get; set; }
        public int? CantFinal { get; set; }
        public DateTime? Fecha { get; set; }
        public int IdUsuario { get; set; }

        public Producto IdProductoNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
    }
}
