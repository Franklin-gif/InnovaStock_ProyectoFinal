using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.InnovaStock.Modelo
{
    internal class Usuario
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string cargo { get; set; }
        public string estado { get; set; }
    }
}
