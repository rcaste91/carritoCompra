using System;
using System.Collections.Generic;

namespace CarritoCompra
{
    public partial class Cliente
    {
        public Cliente()
        {
            Direccion = new HashSet<Direccion>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int? Telefono { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }

        public Usuarios IdUsuarioNavigation { get; set; }
        public ICollection<Direccion> Direccion { get; set; }
    }
}
