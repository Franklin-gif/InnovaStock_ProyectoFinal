using Newtonsoft.Json;
using Proyecto.InnovaStock.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.InnovaStock
{
    public partial class frmProovedoresAdmin : Form
    {
        private readonly HttpClient http = new HttpClient();
        private List<Proveedor> lista = new List<Proveedor>();
        private int indiceEditar = -1;

        public frmProovedoresAdmin()
        {
            InitializeComponent();

            http.BaseAddress = new Uri("https://localhost:7032/api/");
            http.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            ConfigurarGrid();

            cbxAñadir.CheckedChanged += Cbx_Checked;
            cbxEditar.CheckedChanged += Cbx_Checked;
            cbxEliminar.CheckedChanged += Cbx_Checked;

            dgvProveedores.CellDoubleClick += dgvProveedores_CellDoubleClick;
            btnConfirmar.Click += btnConfirmar_Click;

            grpProveedor.Visible = false;
            lblSub.Visible = false;

            // ESTADOS VALIDOS PARA LA API
            cbEstadoPro.Items.Clear();
            cbEstadoPro.Items.Add("Activo");
            cbEstadoPro.Items.Add("Suspendido");
        }

        private void ConfigurarGrid()
        {
            dgvProveedores.Rows.Clear();
            dgvProveedores.Columns.Clear();

            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProveedores.Columns.Add("IdProveedor", "ID");
            dgvProveedores.Columns.Add("Nombre", "Nombre");
            dgvProveedores.Columns.Add("Correo", "Correo");
            dgvProveedores.Columns.Add("Telefono", "Teléfono");
            dgvProveedores.Columns.Add("Estado", "Estado");
        }

        private async void frmProovedoresAdmin_Load(object sender, EventArgs e)
        {
            await CargarProveedores();
        }

        private async Task CargarProveedores()
        {
            try
            {
                var resp = await http.GetAsync("Proveedor");

                if (!resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al conectar con la API.");
                    return;
                }

                string json = await resp.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Proveedor>>(json) ?? new List<Proveedor>();

                dgvProveedores.Rows.Clear();

                foreach (var p in lista)
                {
                    dgvProveedores.Rows.Add(
                        p.IdProveedor,
                        p.Nombre,
                        p.Correo,
                        p.Telefono,
                        p.Estado
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void Cbx_Checked(object sender, EventArgs e)
        {
            if (sender == cbxAñadir && cbxAñadir.Checked)
            {

                lblSub.Text = "Llene los campos";
                cbxEditar.Checked = false;
                cbxEliminar.Checked = false;

                grpProveedor.Visible = true;
                lblSub.Visible = false;
                btnConfirmar.Text = "Guardar";
                Limpiar();
            }
            else if (sender == cbxEditar && cbxEditar.Checked)
            {
                cbxAñadir.Checked = false;
                cbxEliminar.Checked = false;

                grpProveedor.Visible = true;
                lblSub.Visible = true;
                btnConfirmar.Text = "Actualizar";
            }
            else if (sender == cbxEliminar && cbxEliminar.Checked)
            {
                cbxAñadir.Checked = false;
                cbxEditar.Checked = false;

                grpProveedor.Visible = true;

                btnConfirmar.Visible = false;

                lblSub.Text = "Haga doble click para eliminar";

                label4.Visible = false;
                label1.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

                cbEstadoPro.Visible = false;

                txtCorreoPro.Visible = false;
                txtNombrePro.Visible = false;
                txtTelefonoPro.Visible = false;


            }
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombrePro.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoPro.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoPro.Text) ||
                string.IsNullOrWhiteSpace(cbEstadoPro.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            // Validar formato de correo
            try
            {
                var email = new System.Net.Mail.MailAddress(txtCorreoPro.Text);
            }
            catch
            {
                MessageBox.Show("El correo no es válido.");
                return;
            }

            if (cbxAñadir.Checked)
            {
                var nuevo = new Proveedor
                {
                    Nombre = txtNombrePro.Text,
                    Correo = txtCorreoPro.Text,
                    Telefono = txtTelefonoPro.Text,
                    Estado = cbEstadoPro.Text
                };

                string json = JsonConvert.SerializeObject(nuevo);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await http.PostAsync("Proveedor", content);

                if (resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Proveedor agregado correctamente.");
                    await CargarProveedores();
                    Limpiar();
                }
                else
                {
                    string err = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al agregar proveedor: " + err);
                }
            }
            else if (cbxEditar.Checked)
            {
                if (indiceEditar == -1)
                {
                    MessageBox.Show("Seleccione un proveedor con doble click.");
                    return;
                }

                var proveedor = lista[indiceEditar];

                proveedor.Nombre = txtNombrePro.Text;
                proveedor.Correo = txtCorreoPro.Text;
                proveedor.Telefono = txtTelefonoPro.Text;
                proveedor.Estado = cbEstadoPro.Text;

                string json = JsonConvert.SerializeObject(proveedor);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await http.PutAsync($"Proveedor/{proveedor.IdProveedor}", content);

                if (resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Proveedor actualizado.");
                    await CargarProveedores();
                    Limpiar();
                    indiceEditar = -1;
                }
                else
                {
                    string err = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al actualizar: " + err);
                }
            }
        }

        private async void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (cbxEditar.Checked)
            {
                indiceEditar = e.RowIndex;
                var p = lista[indiceEditar];

                txtNombrePro.Text = p.Nombre;
                txtCorreoPro.Text = p.Correo;
                txtTelefonoPro.Text = p.Telefono;
                cbEstadoPro.Text = p.Estado;
            }
            else if (cbxEliminar.Checked)
            {
                var p = lista[e.RowIndex];

                var confirm = MessageBox.Show("¿Desea eliminar este proveedor?",
                    "Confirmar", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    var resp = await http.DeleteAsync($"Proveedor/{p.IdProveedor}");

                    if (resp.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Proveedor eliminado.");
                        await CargarProveedores();
                    }
                    else
                    {
                        string err = await resp.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al eliminar: " + err);
                    }
                }
            }
        }

        private void Limpiar()
        {
            txtNombrePro.Text = "";
            txtCorreoPro.Text = "";
            txtTelefonoPro.Text = "";
            cbEstadoPro.SelectedIndex = -1;
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            // No usado
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No usado
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No usado
        }
    }
}
