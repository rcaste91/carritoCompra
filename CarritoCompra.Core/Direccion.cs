using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class Direccion
    {
        public int IdDireccion { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Direccion1 { get; set; }
        public string Estado { get; set; }
        public int IdCliente { get; set; }

        public Cliente IdClienteNavigation { get; set; }
    }
}
