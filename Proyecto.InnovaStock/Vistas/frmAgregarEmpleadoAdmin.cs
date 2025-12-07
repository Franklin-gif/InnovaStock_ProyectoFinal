using Newtonsoft.Json;
using Proyecto.InnovaStock.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.InnovaStock
{
    public partial class frmAgregarEmpleadoAdmin : Form
    {
        private readonly HttpClient cliente = new HttpClient();
        public frmAgregarEmpleadoAdmin()
        {
            InitializeComponent();
            cliente.BaseAddress = new Uri("https://localhost:7032/api/");
            cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarEmpleadoAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnRegistarLider_Click(object sender, EventArgs e)
        {
            LogEventos.Info($"Iniciando registro de nuevo empleado. Usuario: {txtUsuario.Text}");

            var nuevoEmpleado = new Usuario
            {
                idEmpleado = 0,
                nombre = txtNombre.Text,
                usuario = txtUsuario.Text,
                contrasena = txtContrasena.Text,
                cargo = "Empleado",
                estado = "Activo"
            };

            try
            {
                var json = JsonConvert.SerializeObject(nuevoEmpleado);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                LogEventos.Debug($"Enviando Petición POST a la URL: Empleado con JSON: {json}");

                var response = await cliente.PostAsync("Empleado", content);

                if (response.IsSuccessStatusCode)
                {
                    LogEventos.Info($"Empleado '{txtUsuario.Text}' registrado correctamente. Estado HTTP: {response.StatusCode}");

                    MessageBox.Show("Empleado registrado correctamente", "Éxito",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    txtCorreo.Clear();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    LogEventos.Error(null, $"❌ Error al registrar empleado '{txtUsuario.Text}'. Estado HTTP: {response.StatusCode}. Respuesta: {error}");

                    MessageBox.Show("Error al registrar: " + error, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                LogEventos.Fatal(ex, $"Error FATAL de Cliente/Red al intentar registrar empleado '{txtUsuario.Text}'.");

                MessageBox.Show("Ocurrió un error inesperado de red o serialización.", "Error Crítico",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtContrasena.UseSystemPasswordChar)
            {
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
    }
}
