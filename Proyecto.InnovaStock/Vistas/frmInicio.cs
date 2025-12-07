using Newtonsoft.Json;
using Proyecto.InnovaStock.Modelo;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace Proyecto.InnovaStock
{
    public partial class frmInicio : Form
    {
        private readonly HttpClient cliente = new HttpClient();

        public frmInicio()
        {
            InitializeComponent();

            // Configuración del cliente HTTP
            cliente.BaseAddress = new Uri("http://localhost:5286/api/");
            cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void btmInicio_Click(object sender, EventArgs e)
        {
            var credenciales = new
            {
                Usuario = txtUsuario.Text,
                Contrasena = txtContra.Text
            };

            string json = JsonConvert.SerializeObject(credenciales);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("Empleado/login", content);
            string jsonResponse = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            var empleadoLogueado = JsonConvert.DeserializeObject<Empleado>(jsonResponse);

            MessageBox.Show("Bienvenido " + empleadoLogueado.Nombre);

            if (empleadoLogueado.IdEmpleado == 1)
            {
                frmSesionAdmin admin = new frmSesionAdmin();
                admin.Show();
                this.Hide();
            }
            else
            {
                frmSesionEmple lider = new frmSesionEmple();
                lider.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar u ocultar contraseña
            txtContra.UseSystemPasswordChar = !txtContra.UseSystemPasswordChar;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            // Maximizar ventana al iniciar
            this.WindowState = FormWindowState.Maximized;
        }

        private void btmIcon_Paint(object sender, PaintEventArgs e)
        {
            // No se está usando actualmente
        }
    }
}
