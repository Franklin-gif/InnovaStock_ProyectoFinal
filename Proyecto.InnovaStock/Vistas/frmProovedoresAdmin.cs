<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
=======
﻿using Newtonsoft.Json;
using Proyecto.InnovaStock.Modelo;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
>>>>>>> 5011455 (Agregando CRUD AMEN GLORIA A DIOS)

namespace Proyecto.InnovaStock
{
    public partial class frmProovedoresAdmin : Form
    {
<<<<<<< HEAD
        private List<Proveedor> listaProveedores = new List<Proveedor>();

=======
        private readonly HttpClient http = new HttpClient();
        private List<Proveedor> lista = new List<Proveedor>();
>>>>>>> 5011455 (Agregando CRUD AMEN GLORIA A DIOS)
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
            btmCon.Click += btnConfirmar_Click;

            grpProveedor.Visible = false;
            lblEditar.Visible = false;

<<<<<<< HEAD
            dgvProveedores.ColumnCount = 4;
            dgvProveedores.Columns[0].Name = "Nombre";
            dgvProveedores.Columns[1].Name = "Correo";
            dgvProveedores.Columns[2].Name = "Telefono";
            dgvProveedores.Columns[3].Name = "Estado";
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbxAñadir.CheckedChanged += CheckBoxes_CheckedChanged;
            cbxEditar.CheckedChanged += CheckBoxes_CheckedChanged;
            cbxEliminar.CheckedChanged += CheckBoxes_CheckedChanged;

            dgvProveedores.CellDoubleClick += dgvProveedores_CellDoubleClick;

            btnConfirmar.Click += btnConfirmar_Click;
        }

        public class Proveedor
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Estado { get; set; }
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
=======
            // ESTADOS VALIDOS PARA LA API
            cnbEstado.Items.Clear();
            cnbEstado.Items.Add("Activo");
            cnbEstado.Items.Add("Suspendido");
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
>>>>>>> 5011455 (Agregando CRUD AMEN GLORIA A DIOS)
        {
            if (sender == cbxAñadir && cbxAñadir.Checked)
            {
                cbxEditar.Checked = false;
                cbxEliminar.Checked = false;

                grpProveedor.Visible = true;
                lblEditar.Visible = false;
                btmCon.Text = "Guardar";
                Limpiar();
            }
            else if (sender == cbxEditar && cbxEditar.Checked)
            {
                cbxAñadir.Checked = false;
                cbxEliminar.Checked = false;

                grpProveedor.Visible = true;
                lblEditar.Visible = true;
                btmCon.Text = "Actualizar";
            }
            else if (sender == cbxEliminar && cbxEliminar.Checked)
            {
                cbxAñadir.Checked = false;
                cbxEditar.Checked = false;

                grpProveedor.Visible = false;
                lblEditar.Visible = false;
                btmCon.Text = "Eliminar (Doble click)";
            }
<<<<<<< HEAD

            ActualizarVista();
        }

        private void ActualizarVista()
        {
            if (cbxAñadir.Checked)
            {
                grpProveedor.Visible = true;
                lblEditar.Visible = false;
                btnConfirmar.Text = "Guardar";
                LimpiarCampos();
=======
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            // 🔹 VALIDAR CAMPOS
            if (string.IsNullOrWhiteSpace(txtProv.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) ||
                string.IsNullOrWhiteSpace(cnbEstado.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            // 🔹 VALIDAR CORREO ANTES DE ENVIAR A LA API
            try
            {
                var email = new System.Net.Mail.MailAddress(txtCorreo.Text);
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
                    Nombre = txtProv.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTel.Text,
                    Estado = cnbEstado.Text
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
>>>>>>> 5011455 (Agregando CRUD AMEN GLORIA A DIOS)
            }

            if (cbxEditar.Checked)
            {
<<<<<<< HEAD
                grpProveedor.Visible = true;
                lblEditar.Visible = true;
                btnConfirmar.Text = "Actualizar";
            }
            else if (cbxEliminar.Checked)
            {
                grpProveedor.Visible = false;
                lblEditar.Visible = false;
                btnConfirmar.Text = "Eliminar (Doble click)";
            }
            else
            {
                grpProveedor.Visible = false;
                lblEditar.Visible = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cbxAñadir.Checked)
            {
                Proveedor nuevo = new Proveedor
                {
                    Nombre = txtNombrePro.Text,
                    Correo = txtCorreoPro.Text,
                    Telefono = txtTelefonoPro.Text,
                    Estado = cbEstadoPro.Text
                };

                listaProveedores.Add(nuevo);
                CargarTabla();
                LimpiarCampos();

                MessageBox.Show("Proveedor agregado correctamente");
            }

            else if (cbxEditar.Checked)
            {
                if (indiceEditar == -1)
                {
                    MessageBox.Show("Seleccione un proveedor dando doble clic en la tabla.");
                    return;
                }

                listaProveedores[indiceEditar].Nombre = txtNombrePro.Text;
                listaProveedores[indiceEditar].Correo = txtCorreoPro.Text;
                listaProveedores[indiceEditar].Telefono = txtTelefonoPro.Text;
                listaProveedores[indiceEditar].Estado = cbEstadoPro.Text;

                CargarTabla();
                LimpiarCampos();
                indiceEditar = -1;

                MessageBox.Show("Proveedor actualizado");
            }
        }

        private void CargarTabla()
        {
            dgvProveedores.Rows.Clear();

            foreach (var p in listaProveedores)
            {
                dgvProveedores.Rows.Add(p.Nombre, p.Correo, p.Telefono, p.Estado);
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (cbxEditar.Checked)
            {
                indiceEditar = e.RowIndex;

                txtNombrePro.Text = listaProveedores[indiceEditar].Nombre;
                txtCorreoPro.Text = listaProveedores[indiceEditar].Correo;
                txtTelefonoPro.Text = listaProveedores[indiceEditar].Telefono;
                cbEstadoPro.Text = listaProveedores[indiceEditar].Estado;
            }

            else if (cbxEliminar.Checked)
            {
                DialogResult r = MessageBox.Show("¿Seguro que deseas eliminar este proveedor?",
                    "Confirmar", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    listaProveedores.RemoveAt(e.RowIndex);
                    CargarTabla();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombrePro.Text = "";
            txtCorreoPro.Text = "";
            txtTelefonoPro.Text = "";
            cbEstadoPro.SelectedIndex = -1;
        }
 
private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void grpProveedor_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void grpAñadirProve_Enter(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void cbxEliminar_CheckedChanged(object sender, EventArgs e) { }
        private void cbxEditar_CheckedChanged(object sender, EventArgs e) { }
        private void cbxAñadir_CheckedChanged(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void frmProovedoresAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

=======
                if (indiceEditar == -1)
                {
                    MessageBox.Show("Seleccione un proveedor con doble click.");
                    return;
                }

                var proveedor = lista[indiceEditar];

                proveedor.Nombre = txtProv.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.Telefono = txtTel.Text;
                proveedor.Estado = cnbEstado.Text;

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

                txtProv.Text = p.Nombre;
                txtCorreo.Text = p.Correo;
                txtTel.Text = p.Telefono;
                cnbEstado.Text = p.Estado;
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
            txtProv.Text = "";
            txtCorreo.Text = "";
            txtTel.Text = "";
            cnbEstado.SelectedIndex = -1;
>>>>>>> 5011455 (Agregando CRUD AMEN GLORIA A DIOS)
        }
    }
}
