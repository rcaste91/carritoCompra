using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Cliente = new HashSet<Cliente>();
            Inventario = new HashSet<Inventario>();
        }

        public int IdUsuario { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Inventario> Inventario { get; set; }
    }
}
