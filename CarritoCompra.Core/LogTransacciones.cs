using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class LogTransacciones
    {
        public int IdLog { get; set; }
        public int IdPedido { get; set; }
        public DateTime? FechaTransaccion { get; set; }
        public string Respuesta { get; set; }
        public string CodigoRespuesta { get; set; }

        public Pedidos IdPedidoNavigation { get; set; }
    }
}
