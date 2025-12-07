using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto.InnovaStock
{
    public partial class frmProovedoresAdmin : Form
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        private int indiceEditar = -1;

        public frmProovedoresAdmin()
        {
            InitializeComponent();

            grpProveedor.Visible = false;
            lblEditar.Visible = false;

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
        {
            if (sender == cbxAñadir && cbxAñadir.Checked)
            {
                cbxEditar.Checked = false;
                cbxEliminar.Checked = false;
            }
            else if (sender == cbxEditar && cbxEditar.Checked)
            {
                cbxAñadir.Checked = false;
                cbxEliminar.Checked = false;
            }
            else if (sender == cbxEliminar && cbxEliminar.Checked)
            {
                cbxAñadir.Checked = false;
                cbxEditar.Checked = false;
            }

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
            }
            else if (cbxEditar.Checked)
            {
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

        }
    }
}
