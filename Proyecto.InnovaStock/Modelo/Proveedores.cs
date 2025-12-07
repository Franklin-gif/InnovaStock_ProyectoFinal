using System;

namespace Proyecto.InnovaStock.Modelo
{
    public class Proveedores
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }

        public Proveedores() { }

        public Proveedores(string nombre, string correo, string telefono, string estado)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Estado = estado;
        }
    }
}
