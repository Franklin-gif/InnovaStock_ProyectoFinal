using Newtonsoft.Json;

namespace Proyecto.InnovaStock.Modelo
{
    public class Empleado
    {
        [JsonProperty("idEmpleado")]
        public int IdEmpleado { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("usuario")]
        public string Usuario { get; set; }

        [JsonProperty("cargo")]
        public string Cargo { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }
    }
}
