using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            LogTransacciones = new HashSet<LogTransacciones>();
        }

        public int IdPedido { get; set; }
        public DateTime? FechaPedido { get; set; }
        public string EstadoEntrega { get; set; }
        public string EstadoFacturado { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public decimal? Total { get; set; }
        public string CodigoRespuesta { get; set; }

        public ICollection<LogTransacciones> LogTransacciones { get; set; }
    }
}
