using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto.InnovaStock
{
    public partial class frmProovedoresAdmin : Form
    {
        public frmProovedoresAdmin()
        {
            InitializeComponent();

            grpProveedor.Visible = false;
            lblEditar.Visible = false;
            dgvProveedores.Visible = true;

            // Crear columna si no existe NINGUNA
            if (dgvProveedores.ColumnCount == 0)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "MensajeSistema";
                col.HeaderText = "";
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns.Add(col);
            }

            // Eventos
            cbxAñadir.CheckedChanged += CheckBoxes_CheckedChanged;
            cbxEditar.CheckedChanged += CheckBoxes_CheckedChanged;
            cbxEliminar.CheckedChanged += CheckBoxes_CheckedChanged;
        }

        // -----------------------------------------------------
        //                 CONTROL DE CHECKBOXES
        // -----------------------------------------------------
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

            ActualizarVisibilidadElementos();
        }

        // -----------------------------------------------------
        //           MENSAJE ROJO "ELIMINAR"
        // -----------------------------------------------------
        private void MostrarMensajeEliminar()
        {
            // Si ya está el mensaje → NO duplicar
            if (dgvProveedores.Rows.Count > 0 &&
                dgvProveedores.Rows[0].Tag?.ToString() == "AlertaEliminar")
                return;

            DataGridViewRow alerta = new DataGridViewRow();
            alerta.CreateCells(dgvProveedores);

            alerta.Cells[0].Value = "⚠ Doble Click Para Eliminar Proveedor";
            alerta.DefaultCellStyle.ForeColor = Color.Red;
            alerta.DefaultCellStyle.Font = new Font(dgvProveedores.Font, FontStyle.Bold);

            alerta.Tag = "AlertaEliminar";

            dgvProveedores.Rows.Insert(0, alerta);
        }

        private void OcultarMensajeEliminar()
        {
            // Eliminar SOLO si es el mensaje
            if (dgvProveedores.Rows.Count > 0 &&
                dgvProveedores.Rows[0].Tag?.ToString() == "AlertaEliminar")
            {
                dgvProveedores.Rows.RemoveAt(0);
            }
        }

        // -----------------------------------------------------
        //       VISIBILIDAD SEGÚN OPCIÓN SELECCIONADA
        // -----------------------------------------------------
        private void ActualizarVisibilidadElementos()
        {
            if (cbxAñadir.Checked)
            {
                grpProveedor.Visible = true;
                lblEditar.Visible = false;
                OcultarMensajeEliminar();
            }
            else if (cbxEditar.Checked)
            {
                grpProveedor.Visible = true;
                lblEditar.Visible = true;
                OcultarMensajeEliminar();
            }
            else if (cbxEliminar.Checked)
            {
                grpProveedor.Visible = false;
                lblEditar.Visible = false;
                MostrarMensajeEliminar();
            }
            else
            {
                grpProveedor.Visible = false;
                lblEditar.Visible = false;
                OcultarMensajeEliminar();
            }
        }

        // -----------------------------------------------------
        // EVENTOS AUTOMÁTICOS DEL FORM (NO USAR)
        // -----------------------------------------------------
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
    }
}
