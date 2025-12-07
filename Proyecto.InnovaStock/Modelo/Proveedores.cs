namespace Proyecto.InnovaStock.Modelo
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }

        public Proveedor() { }

        public Proveedor(int idProveedor, string nombre, string correo, string telefono, string estado)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Estado = estado;
        }
    }
}
