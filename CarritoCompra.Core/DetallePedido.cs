using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class DetallePedido
    {
        public int IdDetallePedido { get; set; }
        public int IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public int IdPedido { get; set; }
    }
}
